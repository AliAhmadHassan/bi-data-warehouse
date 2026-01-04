using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class LogLogin
    {
        public void Inserir(int UsuarioId)
        {
            using (SqlConnection conn = new SqlConnection(Conexao.strConnDW))
            {
                using (SqlCommand cmd = new SqlCommand("SPILogLogin", conn))
                {
                    conn.Open();
                    SqlParameter param = new SqlParameter("@UsuarioId", System.Data.SqlDbType.Int);
                    param.Value = UsuarioId;
                    cmd.Parameters.Add(param);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
