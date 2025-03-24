using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDupla
{
    internal class NoLista
    {
        public string? valor;
        public NoLista? prox, ant;
        public NoLista(string valor)
        {
            this.valor = valor;
            prox = null;
            ant = null;
        }
    }       
}
