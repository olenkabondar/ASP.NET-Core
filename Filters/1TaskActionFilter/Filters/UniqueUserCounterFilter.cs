using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Concurrent;

namespace _1TaskActionFilter.Filters
{
    public class UniqueUserCounterFilter : IActionFilter
    {
        private static readonly ConcurrentDictionary<string, bool> _uniqueUsers = new();
        private readonly string _filePath;

        public UniqueUserCounterFilter(string filePath)
        {
            _filePath = filePath;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var userId = context.HttpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown";

            _uniqueUsers.TryAdd(userId, true);

            // Записуємо у файл
            File.WriteAllText(_filePath, $"Унікальних користувачів: {_uniqueUsers.Count}");

            // Зберігаємо у HttpContext для View
            context.HttpContext.Items["UniqueUserCount"] = _uniqueUsers.Count;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Нічого не робимо після виконання дії
        }
    }
}
