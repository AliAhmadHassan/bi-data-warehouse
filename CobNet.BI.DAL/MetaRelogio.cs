using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public class MetaRelogio:Base<DTO.MetaRelogio>
    {
        public DTO.MetaRelogio ObterPeloUsuario(int UsuarioId)
        {
            return AuxConsultas<DTO.MetaRelogio>.Entidade("SPSUsuarioPeloUsuario", Conexao.strConnDW, new SqlParameter("@UsuarioId", UsuarioId));
        }

    }
}
