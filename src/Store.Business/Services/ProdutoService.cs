using Store.Business.Interfaces;
using Store.Business.Models;
using Store.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Store.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public ProdutoService(INotificador notificador) : base(notificador) { }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
