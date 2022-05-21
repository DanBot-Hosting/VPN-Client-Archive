

namespace DbhVpnClient.Contracts.Orchestrators
{
     public interface IAuthenticationWebsocketService
    {
        Task CreateNewAuthWebSocketAsync(string registerCode, EventHandler AuthProcessCompleted);
    }
}
