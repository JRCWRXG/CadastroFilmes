using CadastroFilmes.Domain.Contracts;
using CadastroFilmes.infrastructure.Repositories;
using CadastroFilmes.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFilmes.IoC
{
    public static class Startup
    {
        public static void Configure(IConfiguration configuration, IServiceCollection serviceCollection)
        {
            ConfigureServices(serviceCollection);
            ConfigureRepository(serviceCollection);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IFilmeService, FilmeService>();
        }

        private static void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<IFilmeRepository, FilmeRepository>();
        }
    }
}
