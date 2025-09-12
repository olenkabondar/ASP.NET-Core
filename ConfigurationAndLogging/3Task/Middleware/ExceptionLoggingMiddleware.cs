namespace _3Task.Middleware
{
    public class ExceptionLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _logFilePath = "logs.txt"; // файл для логів

        public ExceptionLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context); // передаємо запит далі
            }
            catch (Exception ex)
            {
                await LogExceptionAsync(ex); // логування у файл
                throw; // щоб стандартний обробник помилок міг також спрацювати
            }
        }

        private Task LogExceptionAsync(Exception ex)
        {
            var logLine = $"{DateTime.Now}: {ex.Message} {Environment.NewLine}{ex.StackTrace}{Environment.NewLine}";
            return File.AppendAllTextAsync(_logFilePath, logLine);
        }
    }
}
