using System;
using System.Linq;
using Ginder.Domain.Entities;

namespace Ginder.Domain.Commands.PlayersGameCommands
{
    public class PlayersGameCommand : ICommand<IQueryable<PlayerGame>>
    {
        public Guid PlayerId { get; set; }
        public Guid GameId { get; set; }
        public double Distance { get; set; } 
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}