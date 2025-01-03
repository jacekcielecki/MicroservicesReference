using MicroservicesReference.Products.Core.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MicroservicesReference.Products.Core.Adapters;

public class ProductsDbContext : DbContext
{
	public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
	}

	public required DbSet<Product> Products { get; set; }
}