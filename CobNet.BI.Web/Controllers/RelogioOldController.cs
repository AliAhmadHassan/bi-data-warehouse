using CobNet.BI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CobNet.BI.Web.Controllers
{
    public class RelogioOldController : Controller
    {
        public ActionResult Details(int UsuarioID)
        {
            List<UsuarioModel> usuarios = new UsuarioModel().getModels(new BLL.Usuario().Subordinados(UsuarioID));
            //List<UsuarioModel> usuarios = new List<UsuarioModel>();
            //usuarios.Add(new UsuarioModel().getModels(new BLL.Usuario().Obter(10536)));

            return View(usuarios);
        }

        public ActionResult Alo(int IdUsuario, DateTime data)
        {
            List<HistoricoModel> historicos = new HistoricoModel().getModels(new BLL.Historico().SelectParaRelogio(IdUsuario, data));
            MetaRelogioModel metaRelogio = new MetaRelogioModel().getModels(new BLL.MetaRelogio().ObterPeloUsuario(IdUsuario));
            
            
            RelogioOldModel relogio = new RelogioOldModel();
            relogio.IdUsuario = IdUsuario;
            relogio.Valor = historicos.Sum(c => c.Qtd);
            relogio.Min = 0;
            relogio.Max = metaRelogio.Alo;

            return PartialView(relogio);
        }

        public ActionResult Localizado(int IdUsuario, DateTime data)
        {
            List<HistoricoModel> historicos = new HistoricoModel().getModels(new BLL.Historico().SelectParaRelogio(IdUsuario, data));
            MetaRelogioModel metaRelogio = new MetaRelogioModel().getModels(new BLL.MetaRelogio().ObterPeloUsuario(IdUsuario));


            RelogioOldModel relogio = new RelogioOldModel();
            relogio.IdUsuario = IdUsuario;
            relogio.Valor = historicos.Where(w=>w.Localizado.Equals(1)).Sum(c => c.Qtd);
            relogio.Min = 0;
            relogio.Max = Convert.ToInt32((metaRelogio.Alo * (metaRelogio.PercLocalizado / 100)));

            return PartialView(relogio);
        }

        public ActionResult Contato(int IdUsuario, DateTime data)
        {
            List<HistoricoModel> historicos = new HistoricoModel().getModels(new BLL.Historico().SelectParaRelogio(IdUsuario, data));
            MetaRelogioModel metaRelogio = new MetaRelogioModel().getModels(new BLL.MetaRelogio().ObterPeloUsuario(IdUsuario));


            RelogioOldModel relogio = new RelogioOldModel();
            relogio.IdUsuario = IdUsuario;
            relogio.Valor = historicos.Where(w => w.Positivo.Equals(1)).Sum(c => c.Qtd);
            relogio.Min = 0;
            relogio.Max = Convert.ToInt32((metaRelogio.Alo * (metaRelogio.PercLocalizado / 100)));
            relogio.Max = Convert.ToInt32((relogio.Max * (metaRelogio.PercContato / 100)));

            return PartialView(relogio);
        }
    }
}
