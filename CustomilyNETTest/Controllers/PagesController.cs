using CustomilyNETTest.Models;
using CustomilyNETTest.Services;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace CustomilyNETTest.Controllers
{
    public class PagesController : ApiController
    {
        // POST: Pages
        public async Task<int> Post([FromBody] Page entity, CancellationToken ct)
        {
            var pageService = new PageService();
            return await pageService.TryAddPage(entity, ct);
        }
    }
}