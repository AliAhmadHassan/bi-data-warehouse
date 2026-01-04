using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class RelogioModel:DTO.Relogio
    {
        public List<RelogioModel> getModels(List<DTO.Relogio> relogios)
        {
            List<RelogioModel> relogiosModels = new List<RelogioModel>();

            foreach (DTO.Relogio relogio in relogios)
                relogiosModels.Add(getModels(relogio));

            return relogiosModels;
        }

        public RelogioModel getModels(DTO.Relogio relogios)
        {
            RelogioModel relogioModel = relogios.GetModels<RelogioModel, DTO.Relogio>(relogios);
            return relogioModel;
        }
    }
}