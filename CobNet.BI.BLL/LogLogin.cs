using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.BLL
{
    public class LogLogin
    {
        public void Inserir(int UsuarioId) 
        {
            new DAL.LogLogin().Inserir(UsuarioId);
        }
    }
}
