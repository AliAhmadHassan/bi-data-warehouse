using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class Metas:Base
    {
        public int UsuarioId { get; set; }
        public int Alo { get; set; }
        public int PercLocalizado  { get; set; }
        public int PercContato { get; set; }
        public int PercAcordo { get; set; }
        public int PercQuebra { get; set; }
        public decimal MetaDiaria { get; set; }
        public decimal MetaMensal { get; set; }
        public decimal MetaRefin { get; set; }
        public decimal MetaRefinMensal { get; set; }
    }
}
