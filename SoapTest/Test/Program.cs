using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            WebserviceIntegradora.Prueba.Integradora _integradora = new WebserviceIntegradora.Prueba.Integradora();

            _integradora.EscribirRom("AKSKAKAKAA", 1);
        }
    }
}
