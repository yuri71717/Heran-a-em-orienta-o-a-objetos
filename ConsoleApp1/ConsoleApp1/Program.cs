using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaInstrumentos;


Violino violino = new Violino();

violino.Nome = "Violino 4/4";
violino.Marca = "Eagle";
violino.Preco = 1200;

violino.ExibirInformacoes();
violino.ExibirCordas();
violino.Tocar();

Console.WriteLine("-------------------------");

ViolaDeArco viola = new ViolaDeArco();

viola.Nome = "Viola de Arco";
viola.Marca = "Rolim";
viola.Preco = 1800;
viola.Tamanho = "40 cm";

viola.ExibirInformacoes();
viola.ExibirTamanho();
viola.Tocar();

Console.WriteLine("-------------------------");

Violoncelo violoncelo = new Violoncelo();

violoncelo.Nome = "Violoncelo 4/4";
violoncelo.Marca = "Eagle";
violoncelo.Preco = 4500;

violoncelo.ExibirInformacoes();
violoncelo.ExibirEspigao();
violoncelo.Tocar();

Console.WriteLine("-------------------------");

Contrabaixo contrabaixo = new Contrabaixo();

contrabaixo.Nome = "Contrabaixo Acústico";
contrabaixo.Marca = "Michael";
contrabaixo.Preco = 7500;
contrabaixo.Altura = 1.80;

contrabaixo.ExibirInformacoes();
contrabaixo.ExibirAltura();
contrabaixo.Tocar();