using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    class CSequence
    {
        public static double getNextValue(String table, String connexionString)
        {

            OracleConnection connex = SingleConnexion.getInstance(connexionString);
            OracleCommand req = new OracleCommand("select S_ID_" + table + ".nextval from dual", connex);
            OracleDataReader res = req.ExecuteReader();

            double value = -1;

            if(res.HasRows)
            {
                res.Read();
                value = double.Parse(res.GetValue(0).ToString());
            }

            connex.Close();
            return value;
        }

    }
}
