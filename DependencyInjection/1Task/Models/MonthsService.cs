namespace _1Task.Models
{
    public class MonthsService : IStringService
    {
        private readonly List<string> _months = new()
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        public IEnumerable<string> GetValues()
        {
            return _months;
        }
    }
}
