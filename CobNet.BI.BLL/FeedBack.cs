using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class FeedBack
    {
        public List<DTO.FeedBack> Listar()
        {
            return new DAL.FeedBack().Select();
        }

        public DTO.FeedBack Obter(int codigo)
        {
            return new DAL.FeedBack().SelectPelaPK(codigo);
        }
        public DTO.FeedBack Obter(int UsuarioID, DateTime Data)
        {
            return new DAL.FeedBack().Obter(UsuarioID, Data);
        }

        public void Cadastrar(DTO.FeedBack carga)
        {
            new DAL.FeedBack().Cadastro(carga);
        }

        public void Remover(DTO.FeedBack carga)
        {
            new DAL.FeedBack().Remover(carga);
        }
    }
}
