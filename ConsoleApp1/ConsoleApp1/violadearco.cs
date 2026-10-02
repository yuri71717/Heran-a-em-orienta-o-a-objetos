using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos
{
    public class ViolaDeArco : Instrumento
    {
        public string Tamanho;

        public void ExibirTamanho()
        {
            Console.WriteLine("Tamanho da viola: " + Tamanho);
        }
    }
}