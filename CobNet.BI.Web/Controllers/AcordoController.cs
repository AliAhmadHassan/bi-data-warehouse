using CobNet.BI.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CobNet.BI.Web.Controllers
{
    public class AcordoController : Controller
    {

        public ActionResult Relogio(int IdUsuario, DateTime data)
        {
            List<AcordoModel> acordos = new AcordoModel().getModels(new BLL.Acordo().SelectParaRelogio(IdUsuario, data));
            MetaRelogioModel metaRelogio = new MetaRelogioModel().getModels(new BLL.MetaRelogio().ObterPeloUsuario(IdUsuario));


            RelogioOldModel relogio = new RelogioOldModel();
            relogio.IdUsuario = IdUsuario;
            relogio.Valor = acordos.Count;
            relogio.Min = 0;
            relogio.Max = Convert.ToInt32((metaRelogio.Alo * (metaRelogio.PercLocalizado / 100)));
            relogio.Max = Convert.ToInt32((relogio.Max * (metaRelogio.PercContato / 100)));
            relogio.Max = Convert.ToInt32((relogio.Max * (metaRelogio.PercAcordo / 100)));


            return PartialView(relogio);
        }

        public ActionResult RelogioQuebra(int IdUsuario, DateTime data)
        {
            MetaRelogioModel metaRelogio = new MetaRelogioModel().getModels(new BLL.MetaRelogio().ObterPeloUsuario(IdUsuario));


            RelogioOldModel relogio = new RelogioOldModel();
            relogio.IdUsuario = IdUsuario;
            relogio.Valor = new BLL.Acordo().QuebraPAraRelogio(IdUsuario, data);
            relogio.Min = 0;
            relogio.Max = Convert.ToInt32(metaRelogio.PercQuebra);

            return PartialView(relogio);
        }

        public ActionResult MetaDiaria(int IdUsuario, DateTime data)
        {
            List<AcordoModel> acordos = new AcordoModel().getModels(new BLL.Acordo().SelectParaRelogio(IdUsuario, data));
            MetaRelogioModel metaRelogio = new MetaRelogioModel().getModels(new BLL.MetaRelogio().ObterPeloUsuario(IdUsuario));

            AcordoRealizadoModel acordoRealizado = new AcordoRealizadoModel();
            acordoRealizado.AcordoFormalizado = acordos.Sum(c => c.ValorParcela);
            acordoRealizado.MetaDiaria = 1000;
            acordoRealizado.MetaAtingida = Convert.ToInt32((Convert.ToDecimal(acordoRealizado.AcordoFormalizado) / acordoRealizado.MetaDiaria) * 100);
            if (acordoRealizado.MetaAtingida > 100)
                acordoRealizado.MetaAtingida = 100;


            return PartialView(acordoRealizado);
        }
        
    }
}
