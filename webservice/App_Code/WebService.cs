using System;
using System.Collections.Generic;
using ClassLibrary2.DAO;
using ClassLibrary2.Objets;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Description résumée de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Supprimez les marques de commentaire dans la ligne suivante si vous utilisez des composants conçus 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld(String nom)
    {
        List<CPays> retour = ClassLibrary2.DAO.DAOFactory.getCPaysDAO().getAll();
        return "salut "+nom+" !";
    }

    [WebMethod]
    public float Test(float a, float b)
    {
        return a+b;
    }

    [WebMethod(Description = "Charge tous les Pays")]
    public List<CPays> GetAllPays()
    {
        List<CPays> retour = new List<CPays>();
        retour = DAOFactory.getCPaysDAO().getAll();
        return retour;
    }

}
