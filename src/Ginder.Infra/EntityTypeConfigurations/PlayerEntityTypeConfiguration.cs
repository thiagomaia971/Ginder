using System;
using Ginder.Domain.Entities;
using Ginder.Domain.ValueObjects;
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
                    // Location = new LocationValueObject(-3.8255355199999999, -38.474861509999997),
                    CreatedAt = DateTimeOffset.Now
                },
                new Player
                {
                    Id = Guid.Parse("e19e6927-a444-489c-885c-45735f88e6ee"), Name = "Player 2", Idade = 23,
                    // Location = new LocationValueObject(-3.8255355199999999, -38.474861509999997),
                    CreatedAt = DateTimeOffset.Now
                },
                new Player
                {
                    Id = Guid.Parse("b0707b09-f1bd-44e9-928b-9277e1bf8d46"), Name = "Player 3", Idade = 23,
                    // Location = new LocationValueObject(-3.8255355199999999, -38.474861509999997),
                    CreatedAt = DateTimeOffset.Now
                },
                new Player
                {
                    Id = Guid.Parse("eaf6db7c-e7f3-49c8-afbe-66ed55d52af8"), Name = "Player 4", Idade = 17,
                    // Location = new LocationValueObject(-3.8255355199999999, -38.474861509999997),
                    CreatedAt = DateTimeOffset.Now
                }
            );
        }
    }
}