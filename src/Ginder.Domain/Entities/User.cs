using System;

namespace Ginder.Domain.Entities
{
    public class User : Entity
    {
        public Guid PlayerId { get; set; }
        
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual Player Player { get; set; }

        public User(Guid playerId, string login, string password)
        {
            PlayerId = playerId;
            Login = login;
            Password = password;
        }
        
        public User(Guid id, Guid playerId, string login, string password) : this(playerId, login, password) 
            => Id = id;
    }
}