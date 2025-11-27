using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Rest;
using IntegracaoBrasilApi.Services;

namespace IntegracaoBrasilApi.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IBrasilApi, BrasilApiRest>();
            services.AddSingleton<IBancoService, BancoService>();
            services.AddSingleton<ICambioService, CambioService>();
            services.AddSingleton<ICepService, CepService>();
            services.AddSingleton<ICnpjService, CnpjService>();
            services.AddSingleton<ICorretoraService, CorretoraService>();
            services.AddSingleton<ICptecService, CptecService>();
            services.AddSingleton<IDddService, DddService>();
            services.AddSingleton<IFeriadoService, FeriadoService>();
            services.AddSingleton<IFipeService, FipeService>();
            services.AddSingleton<IIbgeService, IbgeService>();
            services.AddSingleton<IIsbnService, IsbnService>();
            services.AddSingleton<INcmService, NcmService>();
            services.AddSingleton<IPixService, PixService>();
            services.AddSingleton<IRegistroBrService, RegistroBrService>();
            services.AddSingleton<ITaxaService, TaxaService>();

            services.AddHttpClient<HttpService>();

            return services;
        }
    }
}
