using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Store.App.Extensions;
using Store.Business.Interfaces;
using Store.Data.Context;
using Store.Data.Repository;

namespace Store.App.Configurations
{
    public static class DependencyInjectionConfig 
    {
        public static IServiceCollection ResolveDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<StoreDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            return services;
        }
    }
}
