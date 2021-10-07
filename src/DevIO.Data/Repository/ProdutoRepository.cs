using DevIO.Business.Models;
using DevIO.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DevIO.Data.Context;

namespace DevIO.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {

        public ProdutoRepository(MyDbContext context) : base(context){ }

        public async Task<Produto> ObterProdutoFornecedor(Guid Id)
        {
            return await DataBase.Produtos.AsNoTracking().Include(f => f.Fornecedor).FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutoPorFornecedor(Guid FornecedorId)
        {
            return await Search(p => p.FornecedorId == FornecedorId);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await DataBase.Produtos.AsNoTracking().Include(f => f.Fornecedor).OrderBy(p => p.Nome).ToListAsync();
        }
    }
}
