using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hunter.Email
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();

        }
        public EmailOptions Options { get; set; }
        public EmailSender(IOptions<EmailOptions> emailOptions) 
        { 
            Options = emailOptions.Value; 
        }
    }
}
