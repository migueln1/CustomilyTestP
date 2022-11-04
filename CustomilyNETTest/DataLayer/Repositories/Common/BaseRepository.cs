using CustomilyNETTest.DataLayer.Abstractions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomilyNETTest.DataLayer.Repositories.Common
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public async Task<T> TryAddAsync(T entity, CancellationToken ct)
        {
            using (var context = new CustomilyDbContext())
            {
                context.Set<T>().Add(entity);
                await context.SaveChangesAsync(ct);
                return entity;
            }
        }
    }
}