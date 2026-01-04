using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DTO
{
    public class Usuario:Base
    {
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public int SupervisorID { get; set; }
    }
}
