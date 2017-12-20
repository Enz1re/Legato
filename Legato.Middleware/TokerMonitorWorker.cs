using System;
using Ninject;
using System.Threading;
using Legato.BL.Interfaces;
using System.ComponentModel;


namespace Legato.Middleware
{
    public class TokenMonitorWorker : IDisposable
    {
        private readonly ILegatoUserBLWorker _userWorker;
        private readonly BackgroundWorker _tokenMonitorWorker = new BackgroundWorker();

        [Inject]
        public TokenMonitorWorker(ILegatoUserBLWorker userWorker)
        {
            _userWorker = userWorker;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            _userWorker.RemoveExpiredTokens();
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