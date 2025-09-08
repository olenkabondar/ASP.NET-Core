using System.ComponentModel.DataAnnotations;

namespace RegistrationForm1Task.Models
{
    public class ConsultationFormModel
    {
        [Required(ErrorMessage = "Ім'я обов'язкове")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Прізвище обов'язкове")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email обов'язковий")]
        [EmailAddress(ErrorMessage = "Неправильний формат Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Дата консультації обов'язкова")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Дата має бути в майбутньому і не на вихідні")]
        public DateTime ConsultationDate { get; set; }
    }
    // Користувацька валідація для дати
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            var date = (DateTime)value;

            // Має бути в майбутньому
            if (date.Date <= DateTime.Today)
                return false;

            // Не на вихідні
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                return false;

            return true;
        }
    }
}
