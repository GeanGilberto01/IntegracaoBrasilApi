using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.Models
{
    public class CorretoraModel
    {
        [JsonPropertyName("bairro")]
        public string? Bairro;

        [JsonPropertyName("cep")]
        public string? Cep;

        [JsonPropertyName("cnpj")]
        public string? Cnpj;

        [JsonPropertyName("codigo_cvm")]
        public string? CodigoCvm;

        [JsonPropertyName("complemento")]
        public string? Complemento;

        [JsonPropertyName("data_inicio_situacao")]
        public string? DataInicioSituacao;

        [JsonPropertyName("data_patrimonio_liquido")]
        public string? DataPatrimonioLiquido;

        [JsonPropertyName("data_registro")]
        public string? DataRegistro;

        [JsonPropertyName("email")]
        public string? Email;

        [JsonPropertyName("logradouro")]
        public string? Logradouro;

        [JsonPropertyName("municipio")]
        public string? Municipio;

        [JsonPropertyName("nome_social")]
        public string? NomeSocial;

        [JsonPropertyName("nome_comercial")]
        public string? NomeComercial;

        [JsonPropertyName("pais")]
        public string? Pais;

        [JsonPropertyName("status")]
        public string? Status;

        [JsonPropertyName("telefone")]
        public string? Telefone;

        [JsonPropertyName("type")]
        public string? Tipo;

        [JsonPropertyName("uf")]
        public string? Uf;

        [JsonPropertyName("valor_patrimonio_liquido")]
        public string? ValorPatrimonioLiquido;
    }
}
