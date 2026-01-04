using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class MetaRelogio:Base
    {
        [AtributoBind(ChavePrimaria = true
            , ProcedureAlterar = "SPUMetaRelogio"
            , ProcedureInserir = "SPIMetaRelogio"
            , ProcedureRemover = "SPDMetaRelogio"
            , ProcedureListarTodos = "SPSMetaRelogio"
            , ProcedureSelecionar = "SPSMetaRelogioPelaPK")]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int Alo { get; set; }
        public Double PercLocalizado { get; set; }
        public Double PercContato { get; set; }
        public Double PercAcordo { get; set; }
        public Double PercQuebra { get; set; }
    }
}
