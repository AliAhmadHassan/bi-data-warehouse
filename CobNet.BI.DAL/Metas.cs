using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class Metas
    {
        public List<DTO.Metas> ObterPeloUsuario(int UsuarioId, DateTime Data)
        {
            return AuxConsultas<DTO.Metas>.Lista("SPSMetas", Conexao.strConnDW,
                new SqlParameter[]{
                    new SqlParameter("@ID", UsuarioId),
                    new SqlParameter("@Data", Data)
                });
        }
    }
}
