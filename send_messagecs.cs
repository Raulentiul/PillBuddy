using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MedstuffPrincipal
{
    internal class send_messagecs
    {
        static void send_sms(string[] args)
        {
            var accountSid = "AC0b3cd400ca5c586a6f25538c6cdc0897";
            var authToken = "0b22918d7f06364b007e9659e9da0fd6";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
              new PhoneNumber("+40760672703"));
            messageOptions.From = new PhoneNumber("+12707180376");
            messageOptions.Body = "lui teo ii plac baietii";


            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
        }
    }
    
}


