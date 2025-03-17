using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BuscaVetores;

namespace ListaSimples
{
    internal class LIstaSimplesEncad
    {
        public NoLista? inicio = null;

        public void inserirFinal(int valor)
        {
            NoLista novo = new NoLista(valor);
            if (inicio == null)
            {
                inicio = novo;
            }
            else
            {
                NoLista ultimo = inicio;
                //encontra o ultimo elemento
                while (ultimo.prox != null)
                {
                    ultimo = ultimo.prox;

                }
                //insere depois do ultimo
                ultimo.prox = novo;
            }
        }   
        public void inserirValor(int valor)
        {
            NoLista novo = new NoLista(valor);

            if (inicio == null)
            {
                inicio = novo;
            }
            else
            {
                novo.prox = inicio;
                inicio = novo;
            }

        }
        public void imprimir()
        {
            NoLista? atual = inicio;

            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.prox;
            }
        }
    } 

}
