using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public class DAOFactory
    {
        protected static String _connexionString = "SERVER=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=tcp)(HOST = 10.5.0.41)(PORT=1521)))(CONNECT_DATA=(SID=XE)));uid=mms06;pwd=mms06;";


        public static _CPaysDAO getCPaysDAO()
        {
            return new _CPaysDAO(_connexionString);
        }
    }
}
