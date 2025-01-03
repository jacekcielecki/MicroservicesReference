using MicroservicesReference.Products.Core.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroservicesReference.Products.Core.Adapters.EntityConfig;

public class UserConfig : IEntityTypeConfiguration<Product>
{
	public void Configure(EntityTypeBuilder<Product> builder)
	{
		builder
			.HasKey(x => x.Id);

		builder
			.Property(x => x.Name)
			.HasMaxLength(1000)
			.IsRequired();

		builder.HasData(GenerateDefaults());
	}

	public IEnumerable<Product> GenerateDefaults()
	{
		return new List<Product>
		{
			new Product
			{
				Id = Guid.Parse("6E6369C3-E7DC-4CB2-8C34-EB40E8D51DA2"),
				Name = "Orange",
				Price = 1.99m
			},
			new Product
			{
				Id = Guid.Parse("D00464C5-950D-45AD-999E-83D947077F37"),
				Name = "Apple",
				Price = 2.50m
			}
		};
	}
}