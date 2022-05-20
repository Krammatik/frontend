namespace Application_Layer.Common.Interfaces
{
    public interface IKrammatikService
    {
        Task<string> AuthenticateByPasswordAsync(string username, string password,
            CancellationToken cancellationToken = default);
    }
}