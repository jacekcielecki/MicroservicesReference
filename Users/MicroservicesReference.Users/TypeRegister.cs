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
			options.UseSqlServer(Constants.DbConnectionString1));
			//options.UseSqlServer(Environment.GetEnvironmentVariable("MicroservicesReference_Users_Db")));
        serviceCollection.AddTransient<GetUsers>();
	}
}

public static class Constants
{
	//public static string DbConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MicroservicesReference_Users33;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true;";
	public static string DbConnectionString1 = "Server=localhost;Database=MyFreshDb;Trusted_Connection=True;";
	//public static string DbConnectionString2 = "Server=localhost\\SQLEXPRESS;Database=MicroservicesReference_Users2;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true;";
}