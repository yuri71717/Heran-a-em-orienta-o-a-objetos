using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LojaInstrumentos
{
    public class Instrumento
    {
        public string Nome;
        public string Marca;
        public double Preco;

        public void ExibirInformacoes()
        {
            Console.WriteLine("Instrumento: " + Nome);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Preço: R$ " + Preco);
        }

        public void Tocar()
        {
            Console.WriteLine("O instrumento está sendo tocado.");
        }
    }
}