// Download the twilio-csharp library from www.twilio.com/docs/libraries/csharp#installation
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Notify.V1.Service;

public class Example
{
    public static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        const string serviceSid = "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        TwilioClient.Init(accountSid, authToken);

        var binding = BindingResource.Create(
            serviceSid,
            endpoint: "endpoint_id",
            identity: "00000001",
            bindingType: BindingResource.BindingTypeEnum.FacebookMessenger,
            address: "fcm_device_token",
            tag: new List<string> { "preferred user", "new user" });

        Console.WriteLine(binding.Sid);
    }
}
