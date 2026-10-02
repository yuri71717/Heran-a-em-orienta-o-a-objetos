using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInstrumentos
{
    public class Violino : Instrumento
    {
        public int QuantidadeCordas = 4;

        public void ExibirCordas()
        {
            Console.WriteLine("Quantidade de cordas: " + QuantidadeCordas);
        }
    }
}