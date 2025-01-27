using Netcore.TallerChallenge.Api.Abstractions;

namespace Netcore.TallerChallenge.Api.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetNameAsync(string name);
    }
}
