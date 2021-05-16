using Store.Business.Interfaces;
using Store.Business.Models;
using Store.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Store.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
<<<<<<< HEAD
        public ProdutoService(INotificador notificador) : base(notificador) { }
=======
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository,
                              INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }
>>>>>>> 3610b6123b1ebaefc4318a63d6c8daa35f9a1fae

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtoRepository.Dispose();
        }
    }
}
