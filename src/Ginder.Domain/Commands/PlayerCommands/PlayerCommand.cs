using System;
using Ginder.Domain.Entities;
using Ginder.Domain.ValueObjects;

namespace Ginder.Domain.Commands.PlayerCommands
{
    public class PlayerCommand : ICommand<Player>
    {
        public Guid PlayerId { get; set; }
    }
}