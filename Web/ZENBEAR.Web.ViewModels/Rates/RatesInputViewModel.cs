namespace ZENBEAR.Web.ViewModels.Rates
{
    using System.ComponentModel.DataAnnotations;

    public class RatesInputViewModel
    {
        public int TicketId { get; set; }

        [Range(1, 5)]
        public byte Value { get; set; }
    }
}
