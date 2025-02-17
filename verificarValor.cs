using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        int[] lista = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Digite um valor para verificar se está na lista: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        VerificarValor(lista, valor);
    }


    static int VerificarValor(int[] lista, int valor)
    {
       
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i] == valor)  
            {
                Console.WriteLine($"Valor {lista[i]} encontrado na lista");
                return i;  
            }
        }

        
        Console.WriteLine("Valor não encontrado na lista");
        return -1; 
    }
}



