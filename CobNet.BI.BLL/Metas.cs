using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class Metas
    {
        public List<DTO.Metas> ObterPeloUsuario(int UsuarioId, DateTime Data)
        {
            return new DAL.Metas().ObterPeloUsuario(UsuarioId, Data);
        }
    }
}
