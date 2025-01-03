using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Core = MicroservicesReference.Users.Core.Queries;

namespace MicroservicesReference.Azure.Functions.Queries;

public class GetUsers
{
	private readonly Core.GetUsers _getUsers;

	public GetUsers(Core.GetUsers getUsers)
	{
		_getUsers = getUsers;
	}

	[Function(nameof(GetUsers))]
    public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
    {
		var result = await _getUsers.Get();
        return new OkObjectResult(result);
    }
}
