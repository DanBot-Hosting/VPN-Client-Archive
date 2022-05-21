

namespace DbhVpnClient.Contracts.Orchestrators
{
     public interface IDbhVpnApiClientService
    {
        Task<string> GetIpAdressAsync();
    }
}
