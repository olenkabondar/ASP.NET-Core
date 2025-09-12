using Microsoft.AspNetCore.Mvc.Filters;

namespace _2TaskActionFilter.Filters
{
    public class LogActionFilter : IActionFilter
    {
        private readonly string _filePath;

        public LogActionFilter(string filePath)
        {
            _filePath = filePath;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = context.ActionDescriptor.DisplayName;
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            var log = $"{time} - Виклик методу: {actionName}{Environment.NewLine}";

            File.AppendAllText(_filePath, log);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // залишаємо порожнім
        }
    }
}
