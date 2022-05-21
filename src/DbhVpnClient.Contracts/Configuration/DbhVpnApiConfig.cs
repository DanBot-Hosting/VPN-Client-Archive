namespace DbhVpnClient.Contracts.Configuration
{
    public class DbhVpnApiConfig
    {
        public readonly static string SectionName = "DbhVpnApi";

        public string BaseUri { get; } = string.Empty;
    }
}
