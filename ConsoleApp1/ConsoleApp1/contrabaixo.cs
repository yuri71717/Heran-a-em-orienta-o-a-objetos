using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos
{
    public class Contrabaixo : Instrumento
    {
        public double Altura;

        public void ExibirAltura()
        {
            Console.WriteLine("Altura: " + Altura + " metros");
        }
    }
}