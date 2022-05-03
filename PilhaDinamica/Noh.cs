using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Noh
    {
        string valores;
        Noh anterior;
    
        public string Valores
        {
            get { return valores; }
            set { valores = value; }
        }

        public Noh Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
    }
}
