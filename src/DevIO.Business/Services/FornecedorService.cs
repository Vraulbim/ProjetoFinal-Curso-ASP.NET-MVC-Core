using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Business.Models.Validations;
using DevIO.Business.Models.Validations.Documentos;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {

        private readonly IFornecedorRepository _repository;
        private readonly IEnderecoRepository _repositoryEndereco;

        public FornecedorService(IFornecedorRepository repository, IEnderecoRepository repositoryEndereco, 
            INotificador notificador) : base(notificador)
        {
            _repository = repository;
            _repositoryEndereco = repositoryEndereco;
        }


        public async Task Adicionar(Fornecedor fornecedor)
        {

            if (!ExecValidation(new FornecedorValidation(), fornecedor) 
                && !ExecValidation(new EnderecoValidation(), fornecedor.Endereco)) return;

            if(_repository.Search(f=> f.Documento == fornecedor.Documento).Result.Any())
            {
                Notificar("Já existe um fornecedor cadastrado com este documento!");
                return;
            }

            await _repository.Add(fornecedor);
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecValidation(new FornecedorValidation(), fornecedor)) return;

            if (_repository.Search(f => f.Documento == fornecedor.Documento && f.Id != fornecedor.Id).Result.Any())
            {
                Notificar("Já existe um fornecedor cadastrado com este documento!");
                return;
            }

            await _repository.Update(fornecedor);
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecValidation(new EnderecoValidation(), endereco)) return;

            await _repositoryEndereco.Update(endereco);
        }

        public async Task Remover(Guid id)
        {
            if (_repository.ObterFornecedorProdutosEndereco(id).Result.Produtos.Any())
            {
                Notificar("O fornecedor possui produtos cadastrado");
                return;
            }

            await _repository.Remove(id);
        }

        public void Dispose()
        {
            _repository?.Dispose();
            _repositoryEndereco?.Dispose();
        }
    }
}
