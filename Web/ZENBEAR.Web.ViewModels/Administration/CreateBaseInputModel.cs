namespace ZENBEAR.Web.ViewModels.Administration
{
    using System.ComponentModel.DataAnnotations;

    using ZENBEAR.Common;

    public class CreateBaseInputModel
    {
        [Required]
        [StringLength(GlobalConstants.BaseNameMaxLength, MinimumLength = GlobalConstants.BaseNameMinLength, ErrorMessage = GlobalMessages.ErrorLength)]
        public string Name { get; set; }
    }
}
