using System;
using Ginder.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginder.Infra.EntityTypeConfigurations
{
    public class PlayerGameEntityTypeConfiguration : EntityTypeConfigurationBase<PlayerGame>
    {
        public override void Configure(EntityTypeBuilder<PlayerGame> builder)
        {
            builder.HasData(
                new PlayerGame
                {
                    Id = Guid.Parse("fee6b24d-a74d-4391-ab0e-091d48762b6f"),
                    PlayerId = Guid.Parse("c8413c17-63e7-491a-9eae-0489737e19ff"),
                    GameId = Guid.Parse("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"), Description = "Jogo pra me divertir",
                    PeriodTime = "Jogo aos finais de semanas", Role = "Jogo na posição de ADC",
                    CreatedAt = DateTimeOffset.Now
                }
            );
        }
    }
}