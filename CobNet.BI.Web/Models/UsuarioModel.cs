using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class UsuarioModel: DTO.Usuario
    {

        public string Supervisor { get; set; }

        public List<UsuarioModel> getModels(List<DTO.Usuario> Usuarios)
        {
            List<UsuarioModel> UsuariosModels = new List<UsuarioModel>();

            foreach (DTO.Usuario Usuario in Usuarios)
                UsuariosModels.Add(getModels(Usuario));

            return UsuariosModels;
        }

        public UsuarioModel getModels(DTO.Usuario Usuarios)
        {
            UsuarioModel usuarioModel = Usuarios.GetModels<UsuarioModel, DTO.Usuario>(Usuarios);
            usuarioModel.Supervisor = new BLL.Usuario().Obter(usuarioModel.SupervisorID).Nome;
            return usuarioModel;
        }
    }
}