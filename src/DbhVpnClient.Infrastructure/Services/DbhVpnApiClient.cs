using DbhVpnClient.Contracts.Orchestrators;

namespace DbhVpnClient.Infrastructure.Services
{
    public class DbhVpnApiClientService : IDbhVpnApiClientService
    {
        private HttpClient _client;

        public DbhVpnApiClientService(HttpClient client
           /*  IEnumerable<IMyDependency> myDependencies */ )
        {
            ArgumentNullException.ThrowIfNull(client, nameof(client));
            
            _client = client;
        }

        public async Task<string> GetIpAdressAsync()
        {
            return string.Empty;
        }
    }
}
