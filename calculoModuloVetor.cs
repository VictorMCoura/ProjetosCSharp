using System;

class Program
{
    static void Main()
    {
        double[] lista = new double[5] { 1, 2, 3, 4, 5 };
        double resultado = CalcularModuloVetor(lista);
        Console.WriteLine($"O módulo do vetor é: {resultado}");
    }

    static double CalcularModuloVetor(double[] lista)
    {
        double soma = 0;
        
        // Calculando a soma dos quadrados dos elementos
        for (int i = 0; i < lista.Length; i++)
        {
            soma = soma + lista[i] * lista[i];
        }

        // Retorna a raiz quadrada da soma dos quadrados
        return Math.Sqrt(soma);
    }
}
