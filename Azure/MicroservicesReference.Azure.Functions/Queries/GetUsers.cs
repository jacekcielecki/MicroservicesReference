using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

namespace MicroservicesReference.Azure.Functions.Queries;

public static class GetUsers
{
	[FunctionName(nameof(GetUsers))]
	public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
	{
		return new OkObjectResult("test test test");
	}
}