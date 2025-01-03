using MicroservicesReference.Users.Core.Adapters;
using MicroservicesReference.Users.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesReference.Users.Core.Queries;

public class GetUsers
{
	private readonly UsersDbContext _usersDbContext;

	public GetUsers(UsersDbContext usersDbContext)
	{
		_usersDbContext = usersDbContext;
	}

	public async Task<List<User>> Get()
	{
		var users = await _usersDbContext.Users.ToListAsync();
		return users;
	}
}