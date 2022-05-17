

namespace Application_Layer.Common.Interfaces
{
    public interface IGrammatikService
    {
        Task AuthenticateByPasswordAsync(CancellationToken cancellationToken=default);

    }
}
