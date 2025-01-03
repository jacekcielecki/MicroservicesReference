using MicroservicesReference.Products.Core.Adapters;
using MicroservicesReference.Products.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesReference.Products.Core.Queries;

public class GetProducts
{
	private readonly ProductsDbContext _productsDbContext;

	public GetProducts(ProductsDbContext productsDbContext)
	{
		_productsDbContext = productsDbContext;
	}

	public async Task<List<Product>> Get()
	{
		var products = await _productsDbContext.Products.ToListAsync();
		return products;
	}
}