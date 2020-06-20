using System;
using Ginder.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginder.Infra.EntityTypeConfigurations
{
    public class PlayerEntityTypeConfiguration : EntityTypeConfigurationBase<Player>
    {
        public override void Configure(EntityTypeBuilder<Player> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Idade).IsRequired();
            builder.Property(x => x.Name).IsRequired();
            builder.OwnsOne(e => e.Location);
            
            builder.HasData(
                new Player
                {
                    Id = Guid.Parse("c8413c17-63e7-491a-9eae-0489737e19ff"), Name = "Admin Teste Player", Idade = 20,
                    CreatedAt = DateTimeOffset.Now
                }
            );
        }
    }
}