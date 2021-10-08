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

namespace DevIO.App.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _repository;
        private readonly IFornecedorRepository _repositoryFornecedor;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository repository, IFornecedorRepository repositoryFornecedor, IMapper mapper)
        {
            _repository = repository;
            _repositoryFornecedor = repositoryFornecedor;
            _mapper = mapper;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _repository.ObterProdutosFornecedores()));
        }

        
        public async Task<IActionResult> Details(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);


            if (produtoViewModel == null) return NotFound();

            return View(produtoViewModel);
        }

        
        public async Task<IActionResult> Create()
        {
            var produtoViewModel = await PopularFornecedores(new ProdutoViewModel());
            return View(produtoViewModel);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {

            produtoViewModel = await PopularFornecedores(produtoViewModel);

            if (!ModelState.IsValid) return View(produtoViewModel);

            var imgPrefix = Guid.NewGuid() + "_";

            if (!await UploadArquivo(produtoViewModel.ImagemUpload, imgPrefix)) return View(produtoViewModel);

            produtoViewModel.Imagem = imgPrefix + produtoViewModel.ImagemUpload.FileName;

            await _repository.Add(_mapper.Map<Produto>(produtoViewModel));

            return RedirectToAction("Index");
        }


        
        public async Task<IActionResult> Edit(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }
            

            return View(produtoViewModel);
        }

        
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

            await _repository.Update(_mapper.Map<Produto>(produtoAtualizacao));

            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> Delete(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            await _repository.Remove(id);

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
