using Legato.Service.ReturnTypes;
using Legato.ServiceDAL.ViewModels;


namespace Legato.Service.Interfaces
{
    public interface ILegatoUserServiceWorker
    {
        bool AddToken(string token, string username, int expireMinutes);

        bool RemoveToken(string token);

        bool IsTokenActive(string token);

        bool IsTokenBanned(string token);

        void AddCompromisedAttempt(CompromisedAttemptViewModel attempt);

        CompromisedAttemptList GetCompromisedAttempts();

        void RemoveCompromisedAttempts(int[] attemptIds);

        ILegatoUserManager GetUserManager();
    }
}
