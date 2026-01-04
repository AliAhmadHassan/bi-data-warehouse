using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class FeedBack:Base<DTO.FeedBack>
    {
        public DTO.FeedBack Obter(int UsuarioID, DateTime Data)
        {
            return AuxConsultas<DTO.FeedBack>.Entidade("SPSFeedBackPeloUsuarioData", Conexao.strConnDW,
                new SqlParameter[]{
                    new SqlParameter("@UsuarioID", UsuarioID),
                    new SqlParameter("@Data", Data)
                });
        }
    }
}
