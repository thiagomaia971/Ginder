using System;
using Ginder.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginder.Infra.EntityTypeConfigurations
{
    public class GameEntityTypeConfiguration : EntityTypeConfigurationBase<Game>
    {
        public override void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                new Game { Id = Guid.Parse("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"), Name = "League of Legends", ImagePath = "/Games/LeagueOfLegends.png", CreatedAt = DateTimeOffset.Now },
                new Game { Id = Guid.Parse("885c76df-b632-496e-a87f-98a5a362bd94"), Name = "World of Warcraft", ImagePath = "/Games/WorldOfWarcraft.png", CreatedAt = DateTimeOffset.Now },
                new Game { Id = Guid.Parse("71833138-ba80-4851-bf9d-ff01ea572d88"), Name = "Shadow Arena", ImagePath = "/Games/ShadowArena.png", CreatedAt = DateTimeOffset.Now }
            );
        }
    }
}