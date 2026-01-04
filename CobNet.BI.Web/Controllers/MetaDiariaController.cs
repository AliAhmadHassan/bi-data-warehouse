using CobNet.BI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CobNet.BI.Web.Controllers
{
    public class MetaDiariaController : Controller
    {
        //
        // GET: /MetaDiaria/

        public ActionResult Index()
        {
            List<UsuarioModel> usuarios = new UsuarioModel().getModels(new BLL.Usuario().Subordinados(1));

            return View(usuarios);
        }

        //
        // GET: /MetaDiaria/Details/5

        public ActionResult Details(int id)
        {
            UsuarioModel usuario = new UsuarioModel().getModels(new BLL.Usuario().Obter(id));
            return PartialView(usuario);
        }


        //
        // GET: /MetaDiaria/Edit/5

        public ActionResult Edit(int id)
        {
            MetaDiariaModel metaDiaria = new MetaDiariaModel().getModels(new BLL.MetaDiaria().Obter(id));

            return View(metaDiaria);
        }

        //
        // POST: /MetaDiaria/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, MetaDiariaModel metaDiaria)
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

        //
        // GET: /MetaDiaria/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /MetaDiaria/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
