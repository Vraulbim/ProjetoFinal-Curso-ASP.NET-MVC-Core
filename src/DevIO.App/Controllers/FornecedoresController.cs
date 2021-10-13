using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using AutoMapper;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Authorization;
using DevIO.App.Extensions;

namespace DevIO.App.Controllers
{
    [Authorize]
    public class FornecedoresController : BaseController
    {
        private readonly IFornecedorRepository _repository;
        private readonly IFornecedorService _service;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository repository, IFornecedorService service ,
            IMapper mapper, INotificador notificador) : base(notificador)
        {
            _repository = repository;
            _service = service;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [Route("listar-fornecedores")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<FornecedorViewModel>>(await _repository.GetAll()));
        }

        [AllowAnonymous]
        [Route("detalhes-fornecedor/{id:guid}")]

        public async Task<IActionResult> Details(Guid id)
        {

            var fornecedorViewModel = await ObterFornecedorEndereco(id);
           
            if (fornecedorViewModel == null)
            {
                return NotFound();
            }

            return View(fornecedorViewModel);
        }

        [ClaimsAuthorize("Fornecedores", "Adicionar")]
        [Route("novo-fornecedor")]
        public IActionResult Create()
        {
            return View();
        }

        [ClaimsAuthorize("Fornecedores", "Adicionar")]
        [Route("novo-fornecedor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FornecedorViewModel fornecedorViewModel)
        {
            if (!ModelState.IsValid) return View(fornecedorViewModel);

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _service.Adicionar(fornecedor);

            if (!OperacaoValida()) return View(fornecedorViewModel);

            return RedirectToAction("Index");
        }


        [ClaimsAuthorize("Fornecedores", "Editar")]
        [Route("editar-fornecedor/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {

            var fornecedorViewModel = await ObterFornecedorProdutosEndereco(id);
            if (fornecedorViewModel == null)
            {
                return NotFound();
            }
            return View(fornecedorViewModel);
        }

        [ClaimsAuthorize("Fornecedores", "Editar")]
        [Route("editar-fornecedor/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, FornecedorViewModel fornecedorViewModel)
        {
            if (id != fornecedorViewModel.Id) return NotFound();


            if (!ModelState.IsValid) return View(fornecedorViewModel);

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _service.Atualizar(fornecedor);

            if (!OperacaoValida()) return View(await ObterFornecedorProdutosEndereco(id));

            return RedirectToAction(nameof(Index));
        }

        [ClaimsAuthorize("Fornecedores", "Deletar")]
        [Route("apagar-fornecedor/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {

            var fornecedorViewModel = await ObterFornecedorEndereco(id);

            if (fornecedorViewModel == null)
            {
                return NotFound();
            }

            return View(fornecedorViewModel);
        }

        [ClaimsAuthorize("Fornecedores", "Deletar")]
        [Route("apagar-fornecedor/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedorEndereco(id);

            if (fornecedorViewModel == null) return NotFound();

            await _service.Remover(id);

            if (!OperacaoValida()) return View(fornecedorViewModel);

            return RedirectToAction("Index");
        }


        [Route("obter-fornecedor-endereco/{id:guid}")]
        private async Task<FornecedorViewModel> ObterFornecedorEndereco(Guid Id)
        {
            return _mapper.Map<FornecedorViewModel>(await _repository.ObterFornecedorEndereco(Id));
        }

        [AllowAnonymous]
        [Route("obter-fornecedor-produtos-endereco/{id:guid}")]
        private async Task<FornecedorViewModel> ObterFornecedorProdutosEndereco(Guid Id)
        {
            return  _mapper.Map<FornecedorViewModel>(await _repository.ObterFornecedorProdutosEndereco(Id));
        }

        [ClaimsAuthorize("Fornecedores", "Editar")]
        [Route("atualizar-endereco/{id:guid}")]
        public async Task<IActionResult> AtualizarEndereco(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if(fornecedor == null){
                return NotFound();
            }

            return PartialView("_AtualizarEndereco", new FornecedorViewModel { Endereco = fornecedor.Endereco });
        }

        [ClaimsAuthorize("Fornecedores", "Editar")]
        [Route("atualizar-endereco/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AtualizarEndereco(FornecedorViewModel fornecedor)
        {
            ModelState.Remove("Nome");
            ModelState.Remove("Documento");

            if (!ModelState.IsValid) return PartialView("_AtualizarEndereco", fornecedor);

            await _service.AtualizarEndereco(_mapper.Map<Endereco>(fornecedor));

            if (!OperacaoValida()) return PartialView("_AtualizarEndereco", fornecedor);

            var url = Url.Action("ObterEndereco", "Fornecedores", new { id = fornecedor.Endereco.FornecedorId });
            return Json(new { sucess = true, url });
        }

        [AllowAnonymous]
        [Route("obter-endereco/{id:guid}")]
        public async Task<IActionResult> ObterEndereco(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if (fornecedor == null) {
                return NotFound();
            }

            return PartialView("_DetailsEndereco", fornecedor);
        }
    }
}
