using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebJobChollometro.Data;
using WebJobChollometro.Repositories;

//Console.WriteLine("Bienvenido a nuestros chollos");
string connectionString = "Data Source=sqloscar13.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=adminsql;Password=Admin123;Encrypt=True;Trust Server Certificate=True";
var provider = new ServiceCollection().AddTransient<RepositoryChollometro>()
    .AddDbContext<ChollometroContext>(options => options.UseSqlServer(connectionString)).BuildServiceProvider();
RepositoryChollometro repo = provider.GetService<RepositoryChollometro>();
//Console.WriteLine("Pulse Enter para Iniciar");
//Console.ReadLine();
await repo.PopulatedChollosAzureAsync();
//Console.WriteLine("Proceso completado correctamente");
//Console.WriteLine("Enhorabuena!!!");