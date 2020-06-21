using System.Linq;
using Ginder.Domain.Entities;
using Ginder.Domain.ValueObjects;

namespace Ginder.Domain.Commands.PlayerCommands
{
    public class PlayersCommand : ICommand<IQueryable<Player>>
    {
        public LocationValueObject Location { get; set; }
    }
}