using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class ResultadoAnterior
    {
        public List<DTO.ResultadoAnterior> ObterPeloUsuario(int UsuarioId)
        {
            return AuxConsultas<DTO.ResultadoAnterior>.Lista("SPSResultado", Conexao.strConnDW,
                new SqlParameter[]{
                    new SqlParameter("@UsuarioID", UsuarioId)
                });
        }
    }
}
