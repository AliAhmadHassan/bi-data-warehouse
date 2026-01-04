using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class Acordo
    {
        public List<DTO.Acordo> SelectParaRelogio(int UsuarioID, DateTime Data)
        {
            return AuxConsultas<DTO.Acordo>.Lista("SPSAcordoParaRelogio", Conexao.strConnDW,
                new SqlParameter[]{
                    new SqlParameter("@UsuarioId", UsuarioID),
                    new SqlParameter("@Data", Data)
                });
        }

        public int QuebraPAraRelogio(int UsuarioID, DateTime Data)
        {
            int Quebra = 0;

            using (SqlConnection Conn = new SqlConnection(Conexao.strConnDW))
            {
                using (SqlCommand cmd = new SqlCommand("SPSQuebraParaRelogio", Conn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        foreach (SqlParameter parametro in new SqlParameter[]{
                    new SqlParameter("@UsuarioId", UsuarioID),
                    new SqlParameter("@Data", Data)
                })
                            cmd.Parameters.Add(parametro);

                        Conn.Open();
                        Quebra = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return Quebra;
        }
    }
}
