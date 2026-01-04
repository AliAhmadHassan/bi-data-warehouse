using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class MetaDiaria
    {
        public List<DTO.MetaDiaria> Listar()
        {
            return new DAL.MetaDiaria().Select();
        }

        public DTO.MetaDiaria Obter(int codigo)
        {
            return new DAL.MetaDiaria().SelectPelaPK(codigo);
        }

        public void Cadastrar(DTO.MetaDiaria carga)
        {
            new DAL.MetaDiaria().Cadastro(carga);
        }

        public void Remover(DTO.MetaDiaria carga)
        {
            new DAL.MetaDiaria().Remover(carga);
        }
    }
}
