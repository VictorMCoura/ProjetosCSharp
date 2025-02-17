using System.Net.Http.Headers;

namespace revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números ");
            int tamanhoLista  = Convert.ToInt32(Console.ReadLine());
            int[] lista = new int[tamanhoLista];


            for (int i = 0; i < tamanhoLista; i++)
            {
                Console.WriteLine($"Digite um número: ");
                lista[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = (tamanhoLista - 1); i >= 0; i--)
            {   
                Console.Write("Sua Lista de Números é: ");
                Console.WriteLine(lista[i]);
            }



        }
    }

}



