using System;
namespace MailOMatic.Lib
{
    public interface ISendMail
    {
        bool Send(string from, string to, string subject, string body);
        SmtpServer Server { get; set; }
    }
}
