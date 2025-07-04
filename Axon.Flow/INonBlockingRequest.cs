
namespace Axon.Flow
{
  public interface INonBlockingRequest: INotification, IRequest
  {
    
  }

  public interface INonBlockingRequest<out TResponse> : IRequest<TResponse>, INotification
  {
    
  }
}
