using CobNet.BI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CobNet.BI.Web.Controllers
{
    public class FeedBackController : Controller
    {
        public ActionResult Details(int id)
        {
            FeedBackModel feedBackModel = new FeedBackModel().getModels(new BLL.FeedBack().Obter(id));
            return View(feedBackModel);
        }

        //
        // GET: /FeedBack/Create

        public ActionResult Create(int UsuarioID)
        {
            if (new BLL.FeedBack().Obter(UsuarioID, DateTime.Today).Id != 0)
            {
                return PartialView("Justificado");
            }


            FeedBackModel feedBackModel = new FeedBackModel();
            feedBackModel.UsuarioID = UsuarioID;
            feedBackModel.Data = DateTime.Today;
            return PartialView(feedBackModel);
        }

        //
        // POST: /FeedBack/Create

        [HttpPost]
        public ActionResult Create(FeedBackModel feedBackModel, int SupervisorID)
        {
            try
            {
                feedBackModel.Id = -1;
                feedBackModel.Data = DateTime.Today;
                new BLL.FeedBack().Cadastrar(feedBackModel);

                return RedirectToAction("Index", "Relogio", new { UsuarioID = SupervisorID});
            }
            catch
            {
                return PartialView();
            }
        }

        //
        // GET: /FeedBack/Edit/5

        public ActionResult Edit(int id)
        {
            FeedBackModel feedBackModel = new FeedBackModel().getModels(new BLL.FeedBack().Obter(id));
            return View(feedBackModel);
        }

        //
        // POST: /FeedBack/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FeedBackModel feedBackModel)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
