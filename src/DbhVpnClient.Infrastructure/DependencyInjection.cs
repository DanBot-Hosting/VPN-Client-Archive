using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using DbhVpnClient.Contracts.Configuration;
using DbhVpnClient.Contracts.Orchestrators;
using DbhVpnClient.Infrastructure.Services;

namespace DbhVpnClient.Inferstructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInferstructure(
            this IServiceCollection services, IConfiguration config)
            {
            services.Configure<DbhVpnApiConfig>(
                config.GetSection(DbhVpnApiConfig.SectionName)
            )

            .AddHttpClient<IDbhVpnApiClientService, DbhVpnApiClientService>(client =>
            {

            });

                return services;
            }
    }
}