using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular {
    internal class NoLista
    {
        public int Valor;
        public NoLista? prox;
        public NoLista? ant;

        public NoLista(int valor)
        {
            Valor = valor;
            prox = null;
            ant = null;
        }
    }

    internal class ListaCicular
    {
        public NoLista ini, ult;
        public void inserInicio(int valor)
        {
            NoLista novo = new NoLista(valor);
            if (ini == null)
            {
                ini = novo;
                ult = novo;
                novo.prox = novo;
                novo.ant = novo;
            }
            else
            {
                novo.ant = ult;
                novo.prox = ini;
                ini.ant = novo;
                ult.prox = novo;
                ini = novo;
            }

        }

        public void inserFim(int valor)
        {
            NoLista novo = new NoLista(valor);
            if (ini == null)
            {
                ini = novo;
                ult = novo;
                novo.prox = novo;
                novo.ant = novo;
            }
            else
            {
                novo.ant = ult;
                novo.prox = ini;
                ini.ant = novo;
                ult.prox = novo;
                ult = novo;
            }

        }
        public void remover(int valor)
        {
            NoLista? atual = ini;
            while(atual != ult)
            {
                if (atual.Valor == valor)
                    break;
                atual = atual.prox;
            }
        }

        public void imprimir()
        {
            NoLista? atual = ini;
            while (atual != ult)
            {
                Console.Write(atual.Valor);
                atual = atual.prox;
            }
            Console.WriteLine(ult.Valor);

        }
    }
}
