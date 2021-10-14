using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository, INotificador notificador) : base(notificador)
        {
            _repository = repository;
        }


        public async Task Adicionar(Produto produto)
        {
            if (!ExecValidation(new ProdutoValidation(), produto)) return;

            await _repository.Add(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecValidation(new ProdutoValidation(), produto)) return;

            await _repository.Update(produto);
        }

        public async Task Remover(Guid id)
        {
            await _repository.Remove(id);
        }

        public void Dispose()
        {
            _repository?.Dispose();
        }
    }
}
