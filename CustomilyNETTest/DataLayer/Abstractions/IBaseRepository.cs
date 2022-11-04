using System.Threading;
using System.Threading.Tasks;

namespace CustomilyNETTest.DataLayer.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> TryAddAsync(T entity, CancellationToken ct);
        
        //TODO Otros métodos crud
    }
}