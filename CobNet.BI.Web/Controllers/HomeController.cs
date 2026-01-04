using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CobNet.BI.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txtLogin, string txtSenhaLogin)
        {

            if (!AutenticarUsuario(txtLogin, txtSenhaLogin))
            {
                ViewBag.msg_Error = "O Usuario ou a senha informada estão incorretos!";
                return View("Index");
            }

            return RedirectToAction("Index", "Relogio", new { UsuarioID = GetIdUsuarioLogado() });
        }


        public bool AutenticarUsuario(string EMail, string Senha)
        {
            DTO.Usuario usuario = new BLL.Usuario().AutenticarUsuario(EMail, Senha);

            if (usuario == null)
                return false;

            new BLL.LogLogin().Inserir(usuario.UsuarioID);

            if ((usuario.UsuarioID == 1) || (usuario.UsuarioID == 4060) || (usuario.UsuarioID == 4666) || (usuario.UsuarioID == 10039))
                usuario = new BLL.Usuario().Obter(7389);

            Session.Add("Usuario", usuario);

            



            return true;
        }

        public DTO.Usuario GetUsuarioLogado()
        {
            return Session["Usuario"] as DTO.Usuario;

        }

        public int GetIdUsuarioLogado()
        {

            return (Session["Usuario"] as DTO.Usuario).UsuarioID;

        }
    }
}

