namespace ZENBEAR.Web.ViewModels.Jobtitles
{
    using System.ComponentModel.DataAnnotations;

    public class EditJobtitleViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
