namespace IntegracaoBrasilApi.DTOs
{
    public class CnaesResponse
    {
        public int? Codigo { get; set; }

        public string? Descricao { get; set; }
    }

    public class SocioAdministradorResponse
    {
        public object? Pais { get; set; }

        public string? NomeSocio { get; set; }

        public object? CodigoPais { get; set; }

        public string? FaixaEtaria { get; set; }

        public string? CnpjCpfDoSocio { get; set; }

        public string? QualificacaoSocio { get; set; }

        public int? CodigoFaixaEtaria { get; set; }

        public string? DataEntradaSociedade { get; set; }

        public int? IdentificadorDeSocio { get; set; }

        public string? CpfRepresentanteLegal { get; set; }

        public string? NomeRepresentanteLegal { get; set; }

        public int? CodigoQualificacaoSocio { get; set; }

        public string? QualificacaoRepresentanteLegal { get; set; }

        public int? CodigoQualificacaoRepresentanteLegal { get; set; }
    }

    public class RegimeTributarioResponse
    {
        public int? Ano { get; set; }

        public object? CnpjDaScp { get; set; }

        public string? FormaDeTributacao { get; set; }

        public int? QuantidadeDeEscrituracoes { get; set; }
    }

    public class CnpjResponse
    {
        public string? Uf { get; set; }

        public string? Cep { get; set; }

        public List<SocioAdministradorResponse>? Qsa { get; set; }

        public string? Cnpj { get; set; }

        public object? Pais { get; set; }

        public object? Email { get; set; }

        public string? Porte { get; set; }

        public string? Bairro { get; set; }

        public string? Numero { get; set; }

        public string? DddFax { get; set; }

        public string? Municipio { get; set; }

        public string? Logradouro { get; set; }

        public int? CnaeFiscal { get; set; }

        public object? CodigoPais { get; set; }

        public string? Complemento { get; set; }

        public int? CodigoPorte { get; set; }

        public string? RazaoSocial { get; set; }

        public string? NomeFantasia { get; set; }

        public int? CapitalSocial { get; set; }

        public string? DddTelefone1 { get; set; }

        public string? DddTelefone2 { get; set; }

        public object? OpcaoPeloMei { get; set; }

        public string? DescricaoPorte { get; set; }

        public int? CodigoMunicipio { get; set; }

        public List<CnaesResponse>? CnaesSecundarios { get; set; }

        public string? NaturezaJuridica { get; set; }

        public List<RegimeTributarioResponse>? RegimeTributario { get; set; }

        public string? SituacaoEspecial { get; set; }

        public object? OpcaoPeloSimples { get; set; }

        public int? SituacaoCadastral { get; set; }

        public object? DataOpcaoPeloMei { get; set; }

        public object? DataExclusaoDoMei { get; set; }

        public string? CnaeFiscalDescricao { get; set; }

        public int? CodigoMunicipioIbge { get; set; }

        public string? DataInicioAtividade { get; set; }

        public object? DataSituacaoEspecial { get; set; }

        public object? DataOpcaoPeloSimples { get; set; }

        public string? DataSituacaoCadastral { get; set; }

        public string? NomeCidadeNoExterior { get; set; }

        public int? CodigoNaturezaJuridica { get; set; }

        public object? DataExclusaoDoSimples { get; set; }

        public int? MotivoSituacaoCadastral { get; set; }

        public string? EnteFederativoResponsavel { get; set; }

        public int? IdentificadorMatrizFilial { get; set; }

        public int? QualificacaoDoResponsavel { get; set; }

        public string? DescricaoSituacaoCadastral { get; set; }

        public string? DescricaoTipoDeLogradouro { get; set; }

        public string? DescricaoMotivoSituacaoCadastral { get; set; }

        public string? DescricaoIdentificadorMatrizFilial { get; set; }
    }
}
