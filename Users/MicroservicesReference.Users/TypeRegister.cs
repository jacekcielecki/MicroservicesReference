using MicroservicesReference.Users.Core.Adapters;
using MicroservicesReference.Users.Core.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MicroservicesReference.Users.Core;

public static class TypeRegister
{
	public static void RegisterUsersModule(this IServiceCollection serviceCollection)
	{
		var db = Environment.GetEnvironmentVariable("MicroservicesReference_Users_Db");
		serviceCollection.AddDbContext<UsersDbContext>(options =>
			options.UseSqlServer(db));
        serviceCollection.AddTransient<GetUsers>();
	}
}