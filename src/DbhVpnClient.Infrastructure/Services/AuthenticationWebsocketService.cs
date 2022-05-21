using DbhVpnClient.Contracts.Orchestrators;
using DbhVpnClient.Infrastructure.Dtos;
using Newtonsoft.Json;
using System;
using System.Threading;
using Websocket.Client;


namespace DbhVpnClient.Infrastructure.Services
{
    public class AuthenticationWebsocketService : IAuthenticationWebsocketService
    {

        public AuthenticationWebsocketService(
           /*  IEnumerable<IMyDependency> myDependencies */ )
        {
            
        }

        public async Task CreateNewAuthWebSocketAsync(string registerCode, EventHandler AuthProcessCompleted)
        {
            try
            {
                var exitEvent = new ManualResetEvent(false);
                var url = new Uri("ws://localhost");

                using (var client = new WebsocketClient(url))
                {
                    client.ReconnectTimeout = TimeSpan.FromSeconds(30);
                    client.ReconnectionHappened.Subscribe(info =>
                    {
                        Console.WriteLine("Reconnection happened, type: " + info.Type);
                    });
                    client.MessageReceived.Subscribe(msg =>
                    {
                        Console.WriteLine("Message received: " + msg);
                        if (msg.ToString().ToLower() == "connected")
                        {
                            string data = "{\"registerCode\":\"" + registerCode + "\"}";
                            client.Send(data);
                        } else
                        {
                            AuthProcessCompleted(this, null);
                            //OnUserHasAuthnticated(msg.ToString());
                        }
                    });
                    await client.Start();
                    //Task.Run(() => client.Send("{ message }"));
                    exitEvent.WaitOne();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }

            return;

        }

    }
}
