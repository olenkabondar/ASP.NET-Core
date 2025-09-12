using _2Task.Models;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace _2Task.Services
{
    public class EmailService
    {
        private readonly EmailSettings _settings;

        public EmailService(IOptions<EmailSettings> options)
        {
            _settings = options.Value;
        }

        public void SendEmail(string to, string subject, string body)
        {
            using var client = new SmtpClient(_settings.SmtpHost, _settings.SmtpPort)
            {
                Credentials = new NetworkCredential(_settings.SmtpUser, _settings.SmtpPass),
                EnableSsl = _settings.EnableSsl
            };

            var mailMessage = new MailMessage(_settings.SmtpUser, to, subject, body);
            client.Send(mailMessage);
        }
    }
}
