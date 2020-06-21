using System;
using System.Linq;
using Ginder.Domain.Commands.LoginCommands;
using Ginder.Domain.Entities;
using Ginder.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ginder.Domain.CommandHandlers.LoginCommandHandlers
{
    public class LoginCommandHandler : CommandHandler<LoginCommand, Player>
    {
        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(IUserRepository userRepository) 
            => _userRepository = userRepository;

        public override Player Handle(LoginCommand command)
        {
            var user = _userRepository
                .GetAll()
                .Include(x => x.Player)
                .ThenInclude(x => x.Games)
                .ThenInclude(x => x.Game)
                .FirstOrDefault(x => x.Login == command.Login);
            
            if (user.IsNull())
                throw new Exception("Usuário não encontrado.");
            
            if (user.Password != command.Password)
                throw new Exception("Senha inválida.");
            
            return user.Player;
        }
    }

    public static class ObjectExtensions
    {
        public static bool IsNull(this Object value)
            => value == null;
    }
}