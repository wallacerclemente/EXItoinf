using Newtonsoft.Json;

namespace EXItoinfWallace.Modelos
{
    public class EtiquetaResponse
    {
        [JsonProperty("numero")]
        public string Numero { get; set; }
        [JsonProperty("sigla")]
        public string Sigla { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("categoria")]
        public string Categoria { get; set; }
        [JsonProperty("tipo")]
        public string Tipo { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("hora")]
        public string Hora { get; set; }
        [JsonProperty("descricao")]
        public string Descricao { get; set; }
        [JsonProperty("local")]
        public string Local { get; set; }
        [JsonProperty("codigo")]
        public string Codigo { get; set; }
        [JsonProperty("cidade")]
        public string Cidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
    }
}
