using MicroservicesReference.Products.Core.Adapters;
using MicroservicesReference.Products.Core.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesReference.Products.Core;

public static class TypeRegister
{
	public static void RegisterProductsModule(this IServiceCollection serviceCollection)
	{
		serviceCollection.AddDbContext<ProductsDbContext>(options =>
			options.UseSqlServer(Environment.GetEnvironmentVariable("DatabaseConnectionString")));
		serviceCollection.AddTransient<GetProducts>();
	}
}