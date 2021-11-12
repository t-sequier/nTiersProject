using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    
    public abstract class DAO<T,V>
    {
        protected OracleConnection _connex;

        public DAO(String connexionString)
        {
            this._connex = SingleConnexion.getInstance(connexionString);
            if (_connex.State == System.Data.ConnectionState.Closed)
                _connex.Open();
        }

        public abstract V create(T obj);
        public abstract Boolean update(T obj);
        public abstract Boolean delete(T obj);
        public abstract List<T> getAll();
        public abstract T find(V critere);
    }
    
}
