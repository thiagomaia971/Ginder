﻿using Ginder.Domain.Entities;

namespace Ginder.Domain.Commands.LoginCommands
{
    public class LoginCommand : ICommand<Player>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}