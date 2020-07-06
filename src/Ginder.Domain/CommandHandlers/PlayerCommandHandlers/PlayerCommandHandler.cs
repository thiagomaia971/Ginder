using System.Linq;
using Ginder.Domain.Commands.PlayerCommands;
using Ginder.Domain.Entities;
using Ginder.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ginder.Domain.CommandHandlers.PlayerCommandHandlers
{
    public class PlayerCommandHandler : CommandHandler<PlayerCommand, Player>
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerCommandHandler(IPlayerRepository playerRepository) 
            => _playerRepository = playerRepository;

        public override Player Handle(PlayerCommand command) 
            => _playerRepository
                .GetAll()
                .Include(x => x.Games)
                .ThenInclude(x => x.Game)
                .FirstOrDefault(x => x.Id == command.PlayerId);
    }
}