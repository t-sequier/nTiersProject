using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2.DAO
{
    public class SingleConnexion
    {
        private static OracleConnection _connexion;
        private static String _connexionString;
        
        //Constructeur privé
        private SingleConnexion()
        {
            _connexion = new OracleConnection(_connexionString);
        }

        public static OracleConnection getInstance(String connexionString)
        {
            if (_connexion == null)
            {
                _connexionString = connexionString;
                new SingleConnexion();
            }
            return _connexion;   
        }
    }
    
}
