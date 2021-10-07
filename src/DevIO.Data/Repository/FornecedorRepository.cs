using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {

        public FornecedorRepository(MyDbContext context) : base(context){ }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid Id)
        {
            return await DataBase.Fornecedores.AsNoTracking().Include(e => e.Endereco).FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid Id)
        {
            return await DataBase.Fornecedores.AsNoTracking().Include(p => p.Produtos)
                .Include(e => e.Endereco).FirstOrDefaultAsync(f => f.Id == Id);
        }
    }
}
