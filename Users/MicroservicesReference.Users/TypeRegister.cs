using MicroservicesReference.Users.Core.Adapters;
using MicroservicesReference.Users.Core.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesReference.Users.Core;

public static class TypeRegister
{
	public static void RegisterUsersModule(this IServiceCollection serviceCollection)
	{
		serviceCollection.AddDbContext<UsersDbContext>(options => 
			options.UseSqlServer(Environment.GetEnvironmentVariable("DatabaseConnectionString")));
        serviceCollection.AddTransient<GetUsers>();
	}
}