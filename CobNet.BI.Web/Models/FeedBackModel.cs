using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class FeedBackModel:DTO.FeedBack
    {
        public string Usuario { get; set; }

        public List<FeedBackModel> getModels(List<DTO.FeedBack> Campanhas)
        {
            List<FeedBackModel> CampanhasModels = new List<FeedBackModel>();

            foreach (DTO.FeedBack campanha in Campanhas)
                CampanhasModels.Add(getModels(campanha));

            return CampanhasModels;
        }

        public FeedBackModel getModels(DTO.FeedBack Campanhas)
        {
            FeedBackModel feedBackModel = Campanhas.GetModels<FeedBackModel, DTO.FeedBack>(Campanhas);
            feedBackModel.Usuario = new BLL.Usuario().Obter(feedBackModel.UsuarioID).Nome;
            return feedBackModel;
        }
    }
}