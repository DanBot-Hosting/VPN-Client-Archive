using Newtonsoft.Json;

namespace DbhVpnClient.Infrastructure.Dtos
{
    public class IpDto
    {
        [JsonProperty("ip")]
        public string Ip { get; set; } = string.Empty;
    }
}
