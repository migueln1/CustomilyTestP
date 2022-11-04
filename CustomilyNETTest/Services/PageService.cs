using CustomilyNETTest.DataLayer.Repositories;
using CustomilyNETTest.Models;
using System.Data.SqlTypes;
using System.Threading;
using System.Threading.Tasks;

namespace CustomilyNETTest.Services
{
    public class PageService
    {
        //TODO usar dto
        //TODO usar OneOf
        public async Task<int> TryAddPage(Page entity, CancellationToken ct)
        {
            try
            {
                var pageRepo = new PageRepository();
                var result = await pageRepo.TryAddAsync(entity, ct);
                return result.Id;

            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}