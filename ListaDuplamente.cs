using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDupla
{
    internal class ListaDuplamente
    {
        NoLista? ini=null, fim=null;
        public void inserirInicio(string valor)
        {
            NoLista novo = new NoLista(valor);
            //primeiro elemento
            if (ini == null)
            {
                ini = novo;
                fim = novo;
            }
            else 
            {
                ini.ant = novo;
                novo.prox = ini;
                ini = novo;
            }
        }
        public void inserirFim(string valor) 
        {
            NoLista novo = new NoLista(valor);
            if (fim == null) 
            {
                ini = novo;
                fim = novo;
            }
            else 
            {
                novo.ant = fim;
                fim.prox = novo;
                fim = novo;
            }
        }
        public void imprimir()
        {
            NoLista? atual = ini;
            Console.WriteLine("============");
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.prox;
            }
        }
        public void imprimirRev() 
        {
            NoLista? atual = fim;
            Console.WriteLine("============");
            while (atual != null) 
            {
                Console.WriteLine(atual.valor);
                atual = atual.ant;
            }
        }
        public void remover(string valor)
        {
            NoLista? elemento = ini;
            while (elemento != null)
            {
                if (elemento.valor == valor)
                {
                    break;
                }
                elemento = elemento.prox;
            }
            //não tem elemento
            if (elemento == null)
            {
                Console.WriteLine("Elemento não encontrado");
                return;
            }
            // apenas um elemento
            if (ini == fim)
            {
                ini = null;
                fim = null;
            }
            // removendo primeiro elemento
            else if (elemento == ini)
            {
                elemento.prox.ant = null;
                ini = elemento.prox;
            }
            // removendo ultimo elemento
            else if (elemento == fim)
            {
                elemento.ant.prox = null;
                fim = elemento.ant;
            }
            //removendo elemento do meio
            else
            {
                NoLista? ant = elemento.ant;
                NoLista? prox = elemento.prox;
                ant.prox = prox;
                prox.ant = ant;
            }

        }

    }
}
