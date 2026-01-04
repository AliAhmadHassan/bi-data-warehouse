using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class Acordo:Base
    {
        public int AcordoID { get; set; }
        public int CredorID { get; set; }
        public int SegmentoID { get; set; }
        public int ProdutoID { get; set; }
        public int DevedorId { get; set; }
        public int UsuarioID { get; set; }
        public int Cadastro { get; set; }
        public int Plano { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorAcordo { get; set; }
        public int Cancelamento { get; set; }
        public int Vencimento { get; set; }
        public int ReciboID { get; set; }
        public int CadastroHora { get; set; }
    }
}
