using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class Acordo
    {
        public List<DTO.Acordo> SelectParaRelogio(int UsuarioID, DateTime Data)
        {
            return new DAL.Acordo().SelectParaRelogio(UsuarioID, Data);
        }

        public int QuebraPAraRelogio(int UsuarioID, DateTime Data)
        {
            return new DAL.Acordo().QuebraPAraRelogio(UsuarioID, Data);
        }
    }
}
