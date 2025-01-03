using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Core = MicroservicesReference.Products.Core.Queries;

namespace MicroservicesReference.Azure.Functions.Queries;

public class GetProducts
{
	private readonly Core.GetProducts _getProducts;

	public GetProducts(Core.GetProducts getProducts)
	{
		_getProducts = getProducts;
	}

	[Function(nameof(GetProducts))]
	public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
	{
		var result = await _getProducts.Get();
		return new OkObjectResult(result);
	}
}