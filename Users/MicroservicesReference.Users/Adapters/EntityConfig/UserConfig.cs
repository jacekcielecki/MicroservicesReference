using MicroservicesReference.Users.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroservicesReference.Users.Core.Adapters.EntityConfig;

public class UserConfig : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder
			.HasKey(x => x.Id);

		builder
			.Property(x => x.Email)
			.HasMaxLength(1000)
			.IsRequired();

		builder.HasData(GenerateDefaults());
	}

	public IEnumerable<User> GenerateDefaults()
	{
		return new List<User>
		{
			new User
			{
				Id = Guid.Parse("4F88C524-1738-4827-BE54-AEAF1E2F6DE4"),
				Email = "john@example.com"
            },
			new User
			{
				Id = Guid.Parse("B5E645AD-39AA-4912-8B9E-A2A2EBFA72EE"),
				Email = "mike@example.com"
            }
		};
	}
}