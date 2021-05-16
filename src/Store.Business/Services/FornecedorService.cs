﻿using Store.Business.Interfaces;
using Store.Business.Models;
using Store.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace Store.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public FornecedorService(INotificador notificador) : base(notificador) { }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            // Validar o estado da entidade
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor) && !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
