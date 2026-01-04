using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class MetaDiaria : Base
    {
        [AtributoBind(ChavePrimaria = true
            , ProcedureAlterar = "SPUMetaDiaria"
            , ProcedureInserir = "SPIMetaDiaria"
            , ProcedureRemover = "SPDMetaDiaria"
            , ProcedureListarTodos = "SPSMetaDiaria"
            , ProcedureSelecionar = "SPSMetaDiariaPelaPK")]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Meta { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataLimite { get; set; }
    }
}
