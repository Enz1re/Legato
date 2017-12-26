using System;
using Ninject;
using System.Threading;
using System.ComponentModel;
using Legato.ServiceDAL.Interfaces;


namespace Legato.Service.Workers
{
    public class TokenMonitorWorker : IDisposable
    {
        private readonly BackgroundWorker _tokenMonitorWorker = new BackgroundWorker();

        [Inject]
        public IUserRepository UserWorker { get; set; }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            UserWorker.RemoveExpiredTokens();
            Thread.Sleep(1000 * 60);
        }

        public void Start()
        {
            _tokenMonitorWorker.RunWorkerAsync();
        }

        public void Stop()
        {
            if (_tokenMonitorWorker.IsBusy)
            {
                _tokenMonitorWorker.CancelAsync();
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }
}