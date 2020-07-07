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
                },
                new PlayerGame
                {
                    Id = Guid.Parse("b2768f45-4d9f-4dae-abec-a6c07cc35603"),
                    PlayerId = Guid.Parse("c8413c17-63e7-491a-9eae-0489737e19ff"),
                    GameId = Guid.Parse("885c76df-b632-496e-a87f-98a5a362bd94"), Description = "Jogo pra zuar3",
                    PeriodTime = "Todo santo dia xD4", Role = "DPS",
                    CreatedAt = DateTimeOffset.Now
                },

                new PlayerGame
                {
                    Id = Guid.Parse("488d7a32-cd07-4963-8846-61a1ff12deee"),
                    PlayerId = Guid.Parse("e19e6927-a444-489c-885c-45735f88e6ee"),
                    GameId = Guid.Parse("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"), Description = "Jogo pra zuar",
                    PeriodTime = "Todo santo dia xD", Role = "MID",
                    CreatedAt = DateTimeOffset.Now
                },

                new PlayerGame
                {
                    Id = Guid.Parse("23098ff0-1267-460f-a3f0-fbea676a4279"),
                    PlayerId = Guid.Parse("b0707b09-f1bd-44e9-928b-9277e1bf8d46"),
                    GameId = Guid.Parse("8e4275ae-b5ed-4a16-a8c7-32d4c5cbd4f4"), Description = "Jogo pra zuar2",
                    PeriodTime = "Todo santo dia xD2", Role = "ADC",
                    CreatedAt = DateTimeOffset.Now
                },
                new PlayerGame
                {
                    Id = Guid.Parse("2adcaf82-a6a7-46d2-b126-0d342cd51130"),
                    PlayerId = Guid.Parse("b0707b09-f1bd-44e9-928b-9277e1bf8d46"),
                    GameId = Guid.Parse("885c76df-b632-496e-a87f-98a5a362bd94"), Description = "Jogo pra zuar2",
                    PeriodTime = "Todo santo dia xD3", Role = "Healer",
                    CreatedAt = DateTimeOffset.Now
                }
            );
        }
    }
}