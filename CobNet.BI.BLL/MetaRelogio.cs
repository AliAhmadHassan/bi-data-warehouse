using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class MetaRelogio
    {
        public List<DTO.MetaRelogio> Listar()
        {
            return new DAL.MetaRelogio().Select();
        }

        public DTO.MetaRelogio Obter(int codigo)
        {
            return new DAL.MetaRelogio().SelectPelaPK(codigo);
        }

        public DTO.MetaRelogio ObterPeloUsuario(int UsuarioId)
        {
            return new DAL.MetaRelogio().ObterPeloUsuario(UsuarioId);
        }

        public void Cadastrar(DTO.MetaRelogio carga)
        {
            new DAL.MetaRelogio().Cadastro(carga);
        }

        public void Remover(DTO.MetaRelogio carga)
        {
            new DAL.MetaRelogio().Remover(carga);
        }
    }
}
