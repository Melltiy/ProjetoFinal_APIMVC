using System;

namespace ApiOcorrenciaMvc.Models
{
    public class Ocorrencia
    {
        public int idOcorrencia { get; set; }
        public DateTime dataOcorrencia { get; set; }
        public string tipoOcorrencia { get; set; }
        public string descricaoOcorrencia { get; set; }
        public string situacao { get; set; }
    }
}