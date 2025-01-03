using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;

namespace MicroservicesReference.Azure.Functions.Queries;

public class GetUsers
{
    [Function(nameof(GetUsers))]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}
