using System.ComponentModel.DataAnnotations;

namespace _2Task.Models
{
    public class EmailFormModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Одержувач")]
        public string To { get; set; }

        [Required]
        [Display(Name = "Тема")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Повідомлення")]
        public string Body { get; set; }
    }

}
