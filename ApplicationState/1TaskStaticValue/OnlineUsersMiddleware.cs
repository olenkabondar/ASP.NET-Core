using System.Collections.Concurrent;

namespace _1TaskStaticValue
{
    public class OnlineUsersMiddleware
    {
        private readonly RequestDelegate _next;
        private static ConcurrentDictionary<string, bool> _onlineUsers = new();

        public OnlineUsersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // кожному користувачу – унікальний sessionId
            if (context.Session.IsAvailable)
            {
                var sessionId = context.Session.Id;
                _onlineUsers.TryAdd(sessionId, true);
            }

            // покласти кількість користувачів у Items (щоб забрати в контролері)
            context.Items["OnlineUsersCount"] = _onlineUsers.Count;

            await _next(context);
        }

        public static int GetOnlineUsers() => _onlineUsers.Count;
    }
}
