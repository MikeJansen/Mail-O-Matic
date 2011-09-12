using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using Castle.Core.Logging;
using CrowSoftware.Common.Log;

namespace MailOMatic.Lib
{
    public class SendMail : MailOMatic.Lib.ISendMail
    {
        private SmtpServer _server;
        private SmtpClient _client;

        public ILogger Logger { get; set; }
        public ILogManager Log { get; set; }

        public SmtpServer Server
        {
            get { return _server; }
            set 
            { 
                _server = value;
                _client = new SmtpClient
                {
                    Host = _server.Host,
                    Port = _server.Port,
                    EnableSsl = _server.EnableSsl,
                    Credentials = new NetworkCredential(_server.User, _server.Password)
                };
            }
        }


        public bool Send(string from, string to, string subject, string body)
        {
            _client.Send(from, to, subject, body);
            return true;
        }
    }
}
