using eWebShop.Clients.Contracts;

using Microsoft.Extensions.DependencyInjection;

namespace eWebShop.Clients.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection RegisterServiceClients
            (this IServiceCollection services, string baseUri)
        {
            services.AddHttpClient<IEWebShopClient, EWebShopClient>(client =>
            {
                client.BaseAddress = new Uri(baseUri);
            });

            return services;
        }
    }
}
