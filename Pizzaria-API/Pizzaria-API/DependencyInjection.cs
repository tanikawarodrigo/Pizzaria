using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data;
using Pizzaria.Data.IRepository;
using Pizzaria.Data.Repository;
using Pizzaria.Domain.ProfileAutoMapper;
using Pizzaria.Infraestructure.Dapper;
using Pizzaria.Service.IService;
using Pizzaria.Service.Service;

namespace Pizzaria_API
{
    public static class DependencyInjection 
    {
        public static void AddConfig(this IServiceCollection service, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            service.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            service.AddScoped<DapperConnection>();


            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IProdutoRepository, ProdutoRepository>();
            service.AddScoped<IPedidoRepository, PedidoRepository>();
            service.AddScoped<IPedidoProdutoRepository, PedidoProdutoRepository>();

            service.AddScoped<IPedidoService, PedidoService>();
            service.AddScoped<IProdutoService, ProdutoService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IPedidoProdutoService, PedidoProdutoService>();


            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new PedidoProfile());
                config.AddProfile(new ProdutoProfile());
                config.AddProfile(new UserProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();

            service.AddSingleton(mapper);

            service.AddCors();
        }
    }
}
