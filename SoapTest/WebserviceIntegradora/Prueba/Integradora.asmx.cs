using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebserviceIntegradora.Prueba
{
    /// <summary>
    /// Summary description for Integradora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Integradora : System.Web.Services.WebService
    {
            

        [WebMethod(Description = "Lee el rom en la cara especificada")]
        public string LeerRom(int cara)
        {
            return Logica.MasterLogica.LeerRom(cara);
        }

        [WebMethod(Description = "Escribe rom en la cara especificada")]
        public bool EscribirRom(string rom, int cara)
        {
            return Logica.MasterLogica.EscribirRom(rom, cara);
        }

        [WebMethod(Description = "Imprime un texto")]
        public bool Imprimir(string texto, string ip)
        {
            return Logica.MasterLogica.Imprimir(texto, ip);
        }
    }
}
