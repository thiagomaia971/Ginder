using Ginder.Common.Interfaces;

namespace Ginder.Blazor.Repositories
{
    public class LoginRepository : Repository, ILoginRepository
    {
        public override string Action => "api/Users/login";
    }
}