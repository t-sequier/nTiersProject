using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public class _CPaysDAO : CPaysDAO
    {
        public _CPaysDAO(String connexionString) : base(connexionString) { }

        /*public List<CRegion> getRegion(CPays pays)
        {
            return DAOFactory.getCPaysDAO().getRegion(pays);
        }*/
    }
}
