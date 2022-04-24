namespace ZENBEAR.Data.Models
{
    using ZENBEAR.Data.Common.Models;

    public class IssueReport : BaseModel<int>
    {
        public int IssueId { get; set; }

        public Issue Issue { get; set; }

        public int IssueTicketsCount { get; set; }
    }
}
