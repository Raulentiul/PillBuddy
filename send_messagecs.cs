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
        public static void send_sms()
        {
            var accountSid = "AC0b3cd400ca5c586a6f25538c6cdc0897";
            var authToken = "91dd0ced46a48f41478856b5e6fe4e2a";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
              new PhoneNumber("+40760672703"));
            messageOptions.From = new PhoneNumber("+12707180376");
            messageOptions.Body = "Reminder to take your meds";


            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
        }
    }
    
}


