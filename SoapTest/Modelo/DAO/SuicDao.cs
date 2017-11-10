using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DAO
{
    public class SuicDao
    {
        public static List<suic> ConsultarActivos()
        {
            using (CapacitacionEntities modelo = new CapacitacionEntities())
            {
                List<suic> listado = modelo
                                    .suics
                                    .Where(x => x.habilitado && x.fecha_proxima_revision >= DateTime.Now)
                                    .ToList();
                return listado;
            }
            
        }

        public static bool EscribirRom(string _rom, int cara)
        {
            using (CapacitacionEntities modelo = new CapacitacionEntities())
            {
                suic _suic = new suic();
                _suic.rom = _rom;
                _suic.fecha_proxima_revision = DateTime.Now;
                _suic.habilitado = true;

                modelo.suics.Add(_suic);
                modelo.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
