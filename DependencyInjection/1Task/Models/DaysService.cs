namespace _1Task.Models
{
    public class DaysService : IStringService
    {
        private readonly List<string> _days = new()
        {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
        };
        public IEnumerable<string> GetValues()
        {
            return _days;
        }
    }
}
