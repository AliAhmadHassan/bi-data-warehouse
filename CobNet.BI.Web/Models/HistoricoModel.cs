using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class HistoricoModel:DTO.Historico
    {
        public List<HistoricoModel> getModels(List<DTO.Historico> Campanhas)
        {
            List<HistoricoModel> CampanhasModels = new List<HistoricoModel>();

            foreach (DTO.Historico campanha in Campanhas)
                CampanhasModels.Add(getModels(campanha));

            return CampanhasModels;
        }

        public HistoricoModel getModels(DTO.Historico Campanhas)
        {
            HistoricoModel historicoModel = Campanhas.GetModels<HistoricoModel, DTO.Historico>(Campanhas);
            return historicoModel;
        }
    }
}