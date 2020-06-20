using System.Threading.Tasks;

namespace Ginder.Common.Interfaces
{
    public interface IRepository
    {
        string BaseApi { get; }
        string Action { get; }

        Task<T> Get<T>(object parameters = null, object queryString = null);

        string BuildAction(object parameters, object queryString);
    }
}