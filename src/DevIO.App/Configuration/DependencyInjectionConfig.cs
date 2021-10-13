using DevIO.App.Extensions;
using DevIO.Business.Interfaces;
using DevIO.Business.Notifications;
using DevIO.Business.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Configuration
{
    public static class DependencyInjectionConfig 
    {

        public static IServiceCollection ResolveDependency(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>(); 

            services.AddScoped<INotificador, Notificador>();

            return services;
        }

    }
}
