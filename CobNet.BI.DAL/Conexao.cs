#define RELEASE
//#define ITAU

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobNet.BI.DAL
{
    public static class Conexao
    {




#if (RELEASE)
        
        private static string ConnectionStringPonto = "Data Source = 192.168.20.168; Initial Catalog=ControleAcesso; User Id=Select ; Password=20140429";
        private static string ConnectionStringCobNet = "Data Source = 192.168.20.168; Initial Catalog=CobNetDB; User Id=Select ; Password=20140429";
        private static string ConnectionStringDW = "Data Source=localhost;Initial Catalog=CobNetDW;Persist Security Info=True;User ID=sa;Password=Admin357/";
        private static string ConnectionStringCubo = "Data Source=http://192.168.22.191/olap/msmdpump.dll;Initial Catalog=Cubo_Orcozol;Persist Security Info=True;User ID=sa;Password=Admin357/";
        
#elif (ITAU)
    
        private static string ConnectionStringPonto = "Data Source = 192.168.20.168; Initial Catalog=ControleAcesso; User Id=Select ; Password=20140429";
        private static string ConnectionStringCobNet = "Data Source = 192.168.20.44; Initial Catalog=CobNetitauDB; User Id=sa ; Password=sistema123*";
        private static string ConnectionStringDW = "Data Source=localhost;Initial Catalog=CobNetItauDW;Persist Security Info=True;User ID=sa;Password=Admin357/";
        private static string ConnectionStringCubo = "Data Source=http://192.168.22.191/olap/msmdpump.dll;Initial Catalog=Cubo_Orcozol;Persist Security Info=True;User ID=sa;Password=Admin357/";
#endif

        public static string strConnDW
        {
            get { return ConnectionStringDW; }
        }

        public static string strConnPonto
        {
            get { return ConnectionStringPonto; }
        }

        public static string strConnCobNet
        {
            get { return ConnectionStringCobNet; }
        }

        public static string strConnCubo
        {
            get { return ConnectionStringCubo; }
        }
    }
}
