using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class Usuario
    {
        public virtual DTO.Usuario Obter(int UsuarioID)
        {
            return AuxConsultas<DTO.Usuario>.Entidade("SPSUsuarioPelaPK", Conexao.strConnDW, new SqlParameter("@UsuarioID", UsuarioID));
        }

        public List<DTO.Usuario> Subordinados(int UsuarioID)
        {
            return AuxConsultas<DTO.Usuario>.Lista("SPSUsuarioPeloSupervisorID", Conexao.strConnDW, new SqlParameter("@SupervisorID", UsuarioID));

        }

        public DTO.Usuario AutenticarUsuario(string Login, string Senha)
        {
            using(SqlConnection conn = new SqlConnection(Conexao.strConnCobNet))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tb_Usuario (NOLOCK) WHERE Us_Login = '" + Login + "' AND PWDCOMPARE('" + Senha + "', Us_Nova_Senha) = 1", conn))
                {
                    conn.Open();
                    using (SqlDataReader Dr = cmd.ExecuteReader())
                    {
                        Dr.Read();
                        if (Dr.HasRows)
                        {
                            return Obter(Convert.ToInt32(Dr["Us_Id"]));
                        }
                    }
                }
            }
            return null;
        }
    }
}
