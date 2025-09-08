using System.ComponentModel.DataAnnotations;

namespace RegistrationForm3Task.Models
{
    public class ConsultationFormModel
    {
        [Required(ErrorMessage = "Ім'я обов'язкове")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Прізвище обов'язкове")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email обов'язковий")]
        [EmailAddress(ErrorMessage = "Некоректний Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Дата обов'язкова")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Дата має бути в майбутньому і не на вихідний")]
        public DateTime? ConsultationDate { get; set; }

        [Required(ErrorMessage = "Оберіть продукт")]
        public string Product { get; set; }

        /// <summary>
        /// Валідація дати (майбутнє, не вихідний, + спец правило для "Основи")
        /// </summary>
        public class FutureDateAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var model = (ConsultationFormModel)validationContext.ObjectInstance;

                if (value is DateTime date)
                {
                    if (date <= DateTime.Today)
                        return new ValidationResult("Дата має бути в майбутньому.");

                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        return new ValidationResult("Консультації не проводяться у вихідні.");

                    if (model.Product == "Основи" && date.DayOfWeek == DayOfWeek.Monday)
                        return new ValidationResult("Консультації з продукту 'Основи' не проводяться по понеділках.");
                }

                return ValidationResult.Success;
            }
        }
    }
}
