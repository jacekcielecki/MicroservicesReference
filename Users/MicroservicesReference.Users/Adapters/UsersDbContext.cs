using MicroservicesReference.Users.Core.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MicroservicesReference.Users.Core.Adapters;

public class UsersDbContext : DbContext
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
		//optionsBuilder.UseSqlServer(");
		//optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("MicroservicesReference_Users_Db"));
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
	}

	public DbSet<User> Users { get; set; }
}