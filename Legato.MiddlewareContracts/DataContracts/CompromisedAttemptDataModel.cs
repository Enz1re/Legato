using System;


namespace Legato.MiddlewareContracts.DataContracts
{
    public class CompromisedAttemptDataModel
    {
        public string CompromisedToken { get; set; }

        public string RequestIP { get; set; }

        public string Username { get; set; }

        public DateTime RequestDateTime { get; set; }
    }
}
