using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class Relogio
    {
        public List<DTO.Relogio> ObterPeloUsuario(int UsuarioId, DateTime Data)
        {
            return AuxConsultas<DTO.Relogio>.Lista("SPSRelogio", Conexao.strConnDW,
                new SqlParameter[]{
                    new SqlParameter("@ID", UsuarioId),
                    new SqlParameter("@CadastroID", Data)
                });
        }
    }
}
