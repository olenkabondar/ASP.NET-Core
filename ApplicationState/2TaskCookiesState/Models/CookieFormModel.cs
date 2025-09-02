using System.ComponentModel.DataAnnotations;

namespace _2TaskCookiesState.Models
{
    public class CookieFormModel
    {
        [Required]
        public string Value { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ExpirationDate { get; set; }
    }
}
