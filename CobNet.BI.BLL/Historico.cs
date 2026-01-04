using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class Historico
    {
        public List<DTO.Historico> SelectParaRelogio(int UsuarioID, DateTime Data)
        {
            return new DAL.Historico().SelectParaRelogio(UsuarioID, Data);
        }
    }
}
