using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha nomes = new Pilha();

            // Inserindo valores na PILHA
            nomes.Empilhar("A");
            nomes.Empilhar("B");
            nomes.Empilhar("C");
            nomes.Empilhar("D");
            nomes.Empilhar("E");

            // Impressão da PILHA
            nomes.Imprimir();


        }
    }
}
