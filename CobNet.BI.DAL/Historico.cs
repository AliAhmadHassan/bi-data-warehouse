using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class Historico
    {
        public List<DTO.Historico> SelectParaRelogio(int UsuarioID, DateTime Data)
        {
            return AuxConsultas<DTO.Historico>.Lista("SPSHistoricoParaRelogio", Conexao.strConnDW, 
                new SqlParameter[]{
                    new SqlParameter("@UsuarioID", UsuarioID),
                    new SqlParameter("@CadastroID", Data)
                });
        }
    }
}
