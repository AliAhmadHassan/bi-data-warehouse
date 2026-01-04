using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class ResultadoAnterior
    {
        public List<DTO.ResultadoAnterior> ObterPeloUsuario(int UsuarioId)
        {
            return new DAL.ResultadoAnterior().ObterPeloUsuario(UsuarioId);
        }
    }
}
