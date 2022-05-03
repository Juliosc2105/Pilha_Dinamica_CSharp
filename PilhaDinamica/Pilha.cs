using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Pilha
    {
        Noh topo = null;
        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public void Empilhar(string Valor)
        {
            Noh nn = new Noh();

            nn.Valores = Valor;
            nn.Anterior = topo;

            topo = nn;
            Quantidade++;
        }



    }
}
