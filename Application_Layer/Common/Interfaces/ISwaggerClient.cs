

namespace Application_Layer.Common.Interfaces
{
    public interface ISwaggerClient
    {
        Task AuthenticateByPasswordAsync(CancellationToken cancellationToken=default);

    }
}
