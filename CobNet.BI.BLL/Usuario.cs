using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class Usuario
    {
        public virtual DTO.Usuario Obter(int UsuarioID)
        {
            return new DAL.Usuario().Obter(UsuarioID);
        }

        public virtual List<DTO.Usuario> Subordinados(int UsuarioID)
        {
            return new DAL.Usuario().Subordinados(UsuarioID);
        }

        public DTO.Usuario AutenticarUsuario(string Login, string Senha)
        {
            return new DAL.Usuario().AutenticarUsuario(Login, Senha);
        }
    }
}
