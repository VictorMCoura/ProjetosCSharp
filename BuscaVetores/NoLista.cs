using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaVetores
{
    internal class NoLista
    {
        public int valor;
        public NoLista? prox;
        public NoLista(int valor)
        {
            this.valor = valor;
            prox = null;
        }
    }
}
