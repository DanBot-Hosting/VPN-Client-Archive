using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace DbhVpnClient.Infrastructure.Services
{
    public class OpenVpnClientService
    {
        private Process OpenVpnProcess = new Process();
        private bool Stopping = false;

        private string? _vpnExePath;
        private string? _vpnConfig;
        private string? _sessionId;

        public StringBuilder ErrorLogString = new StringBuilder();
        public StringBuilder InputLogString = new StringBuilder();

        public async Task Start(
            string? VpnExePath,
            string? VpnConfig,
            string? SessionId
            )
        {
            _vpnExePath = VpnExePath ?? _vpnExePath;
            ArgumentNullException.ThrowIfNull(_vpnExePath, nameof(_vpnExePath));

            _vpnConfig = VpnConfig ?? _vpnConfig;
            ArgumentNullException.ThrowIfNull(_vpnConfig, nameof(_vpnConfig));

            _sessionId = SessionId ?? _sessionId;
            ArgumentNullException.ThrowIfNull(_sessionId, nameof(_sessionId));

            Stopping = false;

            OpenVpnProcess.StartInfo.FileName = _vpnExePath;
           // OpenVpnProcess.StartInfo.WorkingDirectory = configPath;
            OpenVpnProcess.StartInfo.Arguments = string.Format("--service {0} --config \"{1}\", \"DbhVpnClient-Manager-{_sessionId}", _vpnConfig);
            OpenVpnProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            OpenVpnProcess.StartInfo.CreateNoWindow = true;
            OpenVpnProcess.EnableRaisingEvents = true;

            OpenVpnProcess.ErrorDataReceived += delegate (object sender, DataReceivedEventArgs e)
            {
                ErrorLogString.Append(e.Data);
            };
            OpenVpnProcess.OutputDataReceived += delegate (object sender, DataReceivedEventArgs e)
            {
                InputLogString.Append(e.Data);
            };

            OpenVpnProcess.StartInfo.RedirectStandardError = true;
            OpenVpnProcess.StartInfo.RedirectStandardInput = true;

            OpenVpnProcess.Exited += new EventHandler(openVPNclient_exit);
            OpenVpnProcess.Start();

            OpenVpnProcess.BeginOutputReadLine();
            OpenVpnProcess.BeginErrorReadLine();
        }
        public void Dissconnect()
        {
            Stopping = true;
            OpenVpnProcess.Kill();
        }
        public void Dispose()
        {
            OpenVpnProcess.Dispose();
        }
        private async void openVPNclient_exit(object? sender, EventArgs e)
        {
            if (!Stopping)
            {

                // restart OpenVPN.exe becouse stop was unexpected.
                // this can happen when OpenVPN enqounters a 'unresovlable' situation (like asking for a password which needs to be aborted..)
               // await Start();
            }
        }
    }
}
