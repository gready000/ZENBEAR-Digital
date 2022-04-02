namespace ZENBEAR.Web.Controllers
{
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using ZENBEAR.Services.Data;
    using ZENBEAR.Web.ViewModels.Rates;

    [ApiController]
    [Route("api/[controller]")]
    [IgnoreAntiforgeryToken]
    public class RatesController : Controller
    {
        private readonly IRatesService ratesService;

        public RatesController(IRatesService ratesService)
        {
            this.ratesService = ratesService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ListRateViewModel>> Rate(RatesInputViewModel input)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.ratesService.RateAsync(input.TicketId, userId, input.Value);
            var value = this.ratesService.GetRateValue(input.TicketId);

            return new ListRateViewModel { Value = value };
        }
    }
}
