using MicroservicesReference.Users.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroservicesReference.Users.Core.Adapters;

public class UsersDbContext : DbContext
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}