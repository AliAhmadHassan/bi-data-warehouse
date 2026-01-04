using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CobNet.BI.Web.Models
{
    public class ResultadoAnteriorModel:DTO.ResultadoAnterior
    {
        public List<ResultadoAnteriorModel> getModels(List<DTO.ResultadoAnterior> ResultadoAnteriors)
        {
            List<ResultadoAnteriorModel> ResultadoAnteriorsModels = new List<ResultadoAnteriorModel>();

            foreach (DTO.ResultadoAnterior ResultadoAnterior in ResultadoAnteriors)
                ResultadoAnteriorsModels.Add(getModels(ResultadoAnterior));

            return ResultadoAnteriorsModels;
        }

        public ResultadoAnteriorModel getModels(DTO.ResultadoAnterior ResultadoAnteriors)
        {
            ResultadoAnteriorModel resultadoAnteriorModel = ResultadoAnteriors.GetModels<ResultadoAnteriorModel, DTO.ResultadoAnterior>(ResultadoAnteriors);
            return resultadoAnteriorModel;
        }
    }
}