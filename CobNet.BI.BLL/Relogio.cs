using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class Relogio
    {
        public List<DTO.Relogio> ObterPeloUsuario(int UsuarioId, DateTime Data)
        {
            return new DAL.Relogio().ObterPeloUsuario(UsuarioId, Data);
        }
    }
}
