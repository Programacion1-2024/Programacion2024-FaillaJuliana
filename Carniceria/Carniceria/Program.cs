using CDatos;
using CDatos.Contracts;
using CDatos.Repository;
using CNegocio.Contracts;
using CNegocio.Logic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Carniceria
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            _serviceProvider = host.Services;

            Application.Run(_serviceProvider.GetRequiredService<VistaUsuario>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddTransient<ICorteRepository,CorteRepository>();
                    services.AddTransient<ICorteLogic,CorteLogic>();
                    services.AddTransient<VistaUsuario>();



                    services.AddDbContext<CarniceriaContext>(options => options.UseSqlServer("Data Source=LAPTOP-MFV6MCLC\\SQLEXPRESS;Initial Catalog=CarniceriaBD;Integrated Security=True;TrustServerCertificate=true"), ServiceLifetime.Scoped);
                });
        }
    }
}