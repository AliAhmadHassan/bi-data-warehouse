using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class Relogio:Base
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public int Alo { get; set; }
        public int Localizado { get; set; }
        public int Contato { get; set; }
        public int Supervisor { get; set; }
        public int QtdAcordo { get; set; }
        public decimal Promessa { get; set; }
        public int Quebra { get; set; }
        public decimal MetaMensal { get; set; }
        public decimal Refin { get; set; }
        public decimal RefinMensal { get; set; }

    }
}
