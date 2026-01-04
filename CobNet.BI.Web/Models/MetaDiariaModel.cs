using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class MetaDiariaModel : DTO.MetaDiaria
    {
        public string Usuario { get; set; }

        public List<MetaDiariaModel> getModels(List<DTO.MetaDiaria> Campanhas)
        {
            List<MetaDiariaModel> CampanhasModels = new List<MetaDiariaModel>();

            foreach (DTO.MetaDiaria campanha in Campanhas)
                CampanhasModels.Add(getModels(campanha));

            return CampanhasModels;
        }

        public MetaDiariaModel getModels(DTO.MetaDiaria Campanhas)
        {
            MetaDiariaModel metaDiariaModel = Campanhas.GetModels<MetaDiariaModel, DTO.MetaDiaria>(Campanhas);
            metaDiariaModel.Usuario = new BLL.Usuario().Obter(metaDiariaModel.UsuarioId).Nome;
            return metaDiariaModel;
        }
    }
}