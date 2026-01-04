using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class MetaRelogioModel : DTO.MetaRelogio
    {
        public string Usuario { get; set; }

        public List<MetaRelogioModel> getModels(List<DTO.MetaRelogio> Campanhas)
        {
            List<MetaRelogioModel> CampanhasModels = new List<MetaRelogioModel>();

            foreach (DTO.MetaRelogio campanha in Campanhas)
                CampanhasModels.Add(getModels(campanha));

            return CampanhasModels;
        }

        public MetaRelogioModel getModels(DTO.MetaRelogio Campanhas)
        {
            MetaRelogioModel metaRelogioModel = Campanhas.GetModels<MetaRelogioModel, DTO.MetaRelogio>(Campanhas);
            metaRelogioModel.Usuario = new BLL.Usuario().Obter(metaRelogioModel.UsuarioId).Nome;
            return metaRelogioModel;
        }
    }
}