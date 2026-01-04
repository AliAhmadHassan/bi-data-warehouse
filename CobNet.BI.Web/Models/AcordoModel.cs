using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class AcordoModel:DTO.Acordo
    {
        public List<AcordoModel> getModels(List<DTO.Acordo> Campanhas)
        {
            List<AcordoModel> CampanhasModels = new List<AcordoModel>();

            foreach (DTO.Acordo campanha in Campanhas)
                CampanhasModels.Add(getModels(campanha));

            return CampanhasModels;
        }

        public AcordoModel getModels(DTO.Acordo Campanhas)
        {
            AcordoModel acordoModel = Campanhas.GetModels<AcordoModel, DTO.Acordo>(Campanhas);
            return acordoModel;
        }
    }
}