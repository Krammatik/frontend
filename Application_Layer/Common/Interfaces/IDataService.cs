using MediatR;
namespace Application_Layer.Common.Interfaces
{
    public interface IDataService
    {
        public ISender Sender { get; set; }
    }
}
