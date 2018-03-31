using System;

namespace AE.Net.Core.Mail.EventArguments
{
    public class WarningEventArgs : EventArgs
    {
        public string Message { get; set; }
        public MailMessage MailMessage { get; set; }
    }
}
