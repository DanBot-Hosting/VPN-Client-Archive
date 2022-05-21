using DbhVpnClient.Contracts.Orchestrators;
using DbhVpnClient.Infrastructure.Dtos;
using Newtonsoft.Json;

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
            var response = await _client.GetAsync("/ip");

            response.EnsureSuccessStatusCode();

            var rawJsonResponce = await response.Content.ReadAsStringAsync();

            var json = JsonConvert.DeserializeObject<IpDto>(rawJsonResponce);

            return json.Ip;
        }
    }
}
