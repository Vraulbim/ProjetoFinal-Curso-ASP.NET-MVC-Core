using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using AutoMapper;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using DevIO.App.Extensions;

namespace DevIO.App.Controllers
{
    [Authorize]
    public class ProdutosController : BaseController
    {
        private readonly IProdutoRepository _repository;
        private readonly IFornecedorRepository _repositoryFornecedor;
        private readonly IProdutoService _service;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository repository, IFornecedorRepository repositoryFornecedor, IMapper mapper,
            IProdutoService service, INotificador notificador) : base(notificador)
        {
            _repository = repository;
            _repositoryFornecedor = repositoryFornecedor;
            _service = service;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [Route("listar-produtos")]
        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _repository.ObterProdutosFornecedores()));
        }

        [AllowAnonymous]
        [Route("detalhes-produto/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);


            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produtos", "Adicionar")]
        [Route("novo-produto")]
        public async Task<IActionResult> Create()
        {
            var produtoViewModel = await PopularFornecedores(new ProdutoViewModel());
            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produtos", "Adicionar")]
        [Route("novo-produto/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {

            produtoViewModel = await PopularFornecedores(produtoViewModel);

            if (!ModelState.IsValid) return View(produtoViewModel);

            var imgPrefix = Guid.NewGuid() + "_";

            if (!await UploadArquivo(produtoViewModel.ImagemUpload, imgPrefix)) return View(produtoViewModel);

            produtoViewModel.Imagem = imgPrefix + produtoViewModel.ImagemUpload.FileName;

            await _service.Adicionar(_mapper.Map<Produto>(produtoViewModel));

            if (!OperacaoValida()) return View(produtoViewModel);

            return RedirectToAction("Index");
        }

        [ClaimsAuthorize("Produtos", "Editar")]
        [Route("editar-produto/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }
            

            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produtos", "Editar")]
        [Route("editar-produto/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            if (id != produtoViewModel.Id) return NotFound();

            var produtoAtualizacao = await ObterProduto(id);
            produtoViewModel.Fornecedor = produtoAtualizacao.Fornecedor;
            produtoViewModel.Imagem = produtoAtualizacao.Imagem;

            if (!ModelState.IsValid) return View(produtoViewModel);

            if(produtoViewModel.ImagemUpload != null)
            {
                var imgPrefix = Guid.NewGuid() + "_" ;
                if (!await UploadArquivo(produtoViewModel.ImagemUpload, imgPrefix)) return View(produtoViewModel);
                produtoAtualizacao.Imagem = imgPrefix + produtoViewModel.ImagemUpload.FileName;
            }

            produtoAtualizacao.Nome = produtoViewModel.Nome;
            produtoAtualizacao.Descricao = produtoViewModel.Descricao;
            produtoAtualizacao.Valor = produtoViewModel.Valor;
            produtoAtualizacao.Ativo = produtoAtualizacao.Ativo;

            await _service.Atualizar(_mapper.Map<Produto>(produtoAtualizacao));

            if (!OperacaoValida()) return View(produtoViewModel);

            return RedirectToAction("Index");
        }

        [ClaimsAuthorize("Produtos", "Deletar")]
        [Route("apagar-produto/{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        [ClaimsAuthorize("Produtos", "Deletar")]
        [Route("apagar-produto/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            await _service.Remover(id);

            if (!OperacaoValida()) return View(produtoViewModel);

            return RedirectToAction("Index");
        }

        private async Task<ProdutoViewModel> ObterProduto(Guid Id)
        {
            var produto = _mapper.Map<ProdutoViewModel>(await _repository.ObterProdutoFornecedor(Id));
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _repositoryFornecedor.GetAll());

            return produto;
        }
        private async Task<ProdutoViewModel> PopularFornecedores(ProdutoViewModel produto)
        {
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _repositoryFornecedor.GetAll()); 
            return produto;
        }

        private async Task<bool> UploadArquivo(IFormFile arquivo, string imgPrefix)
        {
           if(arquivo.Length <= 0) return false;

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Imagens", imgPrefix + arquivo.FileName);

            if (System.IO.File.Exists(path))
            {
                ModelState.AddModelError(string.Empty, "Já existe um arquivo com este nome!");
                return false;
            }

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await arquivo.CopyToAsync(stream);
            }

            return true;
        }
    }
}
