using CobNet.BI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CobNet.BI.Web.Controllers
{
    public class ResultadoAnteriorController : Controller
    {
        //
        // GET: /ResultadoAnterior/

        public ActionResult Details(int id)
        {
            List<ResultadoAnteriorModel> resultados = new ResultadoAnteriorModel().getModels(new BLL.ResultadoAnterior().ObterPeloUsuario(id));
            return View(resultados);
        }

    }
}
