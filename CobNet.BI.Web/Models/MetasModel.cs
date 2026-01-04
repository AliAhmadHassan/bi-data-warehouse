using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class MetasModel:DTO.Metas
    {
        public List<MetasModel> getModels(List<DTO.Metas> metas)
        {
            List<MetasModel> metasModels = new List<MetasModel>();

            foreach (DTO.Metas meta in metas)
                metasModels.Add(getModels(meta));

            return metasModels;
        }

        public MetasModel getModels(DTO.Metas metas)
        {
            MetasModel metaModel = metas.GetModels<MetasModel, DTO.Metas>(metas);
            return metaModel;
        }
    }
}