using System;


namespace Legato.ServiceDAL.ViewModels
{
    public class CompromisedAttemptViewModel
    {
        public int AttemptId { get; set; }

        public string CompromisedToken { get; set; }

        public string RequestIP { get; set; }

        public string Username { get; set; }

        public DateTime RequestDateTime { get; set; }
    }
}
