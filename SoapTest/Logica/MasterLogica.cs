using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Logica
{
    public class MasterLogica
    {
        public static string LeerRom(int cara)
        {
            suic oSuic;
            List<suic> lsuic = Modelo.DAO.SuicDao.ConsultarActivos();
            //Random random = new Random(1, cara);
            if (lsuic.Count > 1)
                oSuic = lsuic[cara];
            else
                oSuic = lsuic[0];
            return oSuic.rom;
        }

        public static bool EscribirRom(string rom, int cara)
        {
            return Modelo.DAO.SuicDao.EscribirRom(rom, cara);
        }

        public static bool Imprimir(string texto, string ip)
        {
            return false;
        }
    }
}
