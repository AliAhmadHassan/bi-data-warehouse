using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class FeedBack:Base
    {
        [AtributoBind(ChavePrimaria = true
    , ProcedureAlterar = "SPUFeedBackPelo"
    , ProcedureInserir = "SPIFeedBackPelo"
    , ProcedureRemover = "SPDFeedBackPelo"
    , ProcedureListarTodos = "SPSFeedBackPelo"
    , ProcedureSelecionar = "SPSFeedBackPeloPelaPK")]
        public int Id { get; set; }
        public int UsuarioID { get; set; }
        public DateTime Data { get; set; }
        public string Justificativa { get; set; }
    }
}
