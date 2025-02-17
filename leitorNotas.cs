using System.Net.Http.Headers;

namespace revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nAlunos, nNotas;
            Console.WriteLine("Digite o número de notas:");
            nNotas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número de alunos:");
            nAlunos = Convert.ToInt32(Console.ReadLine());

            
            float[][] notas_2 = new float[nNotas][];
            for (int i = 0; i < nNotas; i++)
            {
                notas_2[i] = new float[nAlunos];
            }

            for (int i = 0; i < nNotas; i++)
            {
                for (int j = 0; j < nAlunos; j++)
                {
                    Console.WriteLine("Digite a nota " + (i + 1) + " do aluno " + (j + 1));
                    float nota = float.Parse(Console.ReadLine());
                    notas_2[i][j] = nota;
                }
            }
            for(int j = 0;j < nAlunos; j++)
            {
                Console.Write("Nota do aluno" + (j +1)+ ":");
                float soma = 0;
                for (int i = 0;i < nNotas; i++)
                {
                    Console.Write(" "+notas_2[i][j]);
                    soma += notas_2[i][j];

                }
                float media = soma / nNotas;
                Console.WriteLine(" e media: "+ media);
            }
        }
    }
}
