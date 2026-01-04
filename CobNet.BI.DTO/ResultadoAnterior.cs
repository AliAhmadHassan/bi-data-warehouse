using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class ResultadoAnterior:Base
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public decimal MetaDiaria { get; set; }
        public int Alo { get; set; }
        public double PercLocalizado { get; set; }
        public double PercContato { get; set; }
        public double PercAcordo { get; set; }
        public double PercQuebra { get; set; }
        public int Localizado { get; set; }
        public int Contato { get; set; }
        public int QtdAcordo { get; set; }
        public string Justificativa { get; set; }
        public int MetaAlo { get; set; }
        public decimal ValorMensal { get; set; }
        public decimal MetaMensal { get; set; }
        public decimal Refin { get; set; }
        public decimal MetaRefin { get; set; }
        public decimal RefinMensal { get; set; }
        public decimal MetaRefinMensal { get; set; }

    }
}
