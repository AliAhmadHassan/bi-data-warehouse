using CobNet.BI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CobNet.BI.Web.Controllers
{
    public class RelogioController : Controller
    {
        public ActionResult Index(int UsuarioID)
        {
            List<RelogioModel> relogios = new RelogioModel().getModels(new BLL.Relogio().ObterPeloUsuario(UsuarioID, DateTime.Today));
            List<MetasModel> metas = new MetasModel().getModels(new BLL.Metas().ObterPeloUsuario(UsuarioID, DateTime.Today));

            ViewBag.metas = metas;

            return View(relogios);
        }

    }
}
