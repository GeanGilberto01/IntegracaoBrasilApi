using IntegracaoBrasilApi.Mapping;

namespace IntegracaoBrasilApi.Config
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<BancoMapping>();
                cfg.AddProfile<CambioMapping>();
                cfg.AddProfile<CepMapping>();
                cfg.AddProfile<CnpjMapping>();
                cfg.AddProfile<CorretoraMapping>();
                cfg.AddProfile<DddMapping>();
                cfg.AddProfile<FeriadoMapping>();
                cfg.AddProfile<IsbnMapping>();
                cfg.AddProfile<MoedaMapping>();
                cfg.AddProfile<NcmMapping>();
                cfg.AddProfile<PixParticipantesMapping>();
                cfg.AddProfile<RegistroBrMapping>();
                cfg.AddProfile<TaxaMapping>();

                //CTPEC
                cfg.AddProfile<CidadeMapping>();
                cfg.AddProfile<ClimaMapping>();
                cfg.AddProfile<OndasMapping>();
                cfg.AddProfile<PrevisaoMapping>();

                //FIPE
                cfg.AddProfile<MarcaMapping>();
                cfg.AddProfile<ModeloMapping>();
                cfg.AddProfile<PrecoMapping>();
                cfg.AddProfile<TabelaMapping>();

                //IBGE
                cfg.AddProfile<EstadoMapping>();
                cfg.AddProfile<MunicipioMapping>();
            });

            return services;
        }
    }
}
