using System.Collections.Generic;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.ReturnTypes
{
    public class CompromisedAttemptList
    {
        public IEnumerable<CompromisedAttemptViewModel> CompromisedAttempts { get; set; }
    }
}