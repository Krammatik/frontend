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
    }
}