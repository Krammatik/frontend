using Application_Layer.Common.Models;

namespace Application_Layer.Common.Interfaces
{
    public interface IKrammatikService
    {
        Task<string> AuthenticateByPasswordAsync(string username, string password,
            CancellationToken cancellationToken = default);

        Task<List<KrammatikTask>> GetTasks(string token, CancellationToken cancellationToken = default);

        Task<string> SignupAsync(string username, string password,
            CancellationToken cancellationToken = default);

        Task<List<User>> GetAllUser(string token, CancellationToken cancellation = default);

        Task<bool> IsLoginValid(string token, CancellationToken cancellation = default);

        Task<User> GetUser(string token, CancellationToken cancellation = default);

        Task<User?> GetSpecificUser(string token, string userId, CancellationToken cancellation = default);
    }
}