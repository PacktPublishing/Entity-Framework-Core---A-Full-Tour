using EntityFrameworkNet5.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkNet5.Data.Configurations.Entities;

public class LeagueConfiguration : IEntityTypeConfiguration<League>
{
    public void Configure(EntityTypeBuilder<League> builder)
    {
        ////builder.Property(p => p.Name).HasMaxLength(50);
        builder.HasIndex(h => h.Name);

        builder.HasData(
                new League
                {
                    Id = 20,
                    Name = "Sample League"
                }
            );
    }
}
