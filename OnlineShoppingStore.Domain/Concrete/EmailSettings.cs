using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete 
{
    public class EmailSettings 
    {
        public string MailToAddress = "nasirzchaudhry@gmail.com";
        public string MailFromAddress = "nasirzchaudhry@gmail.com";
        public bool UseSsl = true;
        public string Username = "nasirzchaudhry@gmail.com";
        public string Password = "586Bakra";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}