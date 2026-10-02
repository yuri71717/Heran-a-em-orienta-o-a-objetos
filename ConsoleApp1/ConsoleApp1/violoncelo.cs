using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos
{
    public class Violoncelo : Instrumento
    {
        public bool PossuiEspigao = true;

        public void ExibirEspigao()
        {
            Console.WriteLine("Possui espigão: " + PossuiEspigao);
        }
    }
}