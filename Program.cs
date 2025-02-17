namespace multiMatriz
{
    internal class Program
    {
        static double[,] multiplicaMatriz(double[,] m1, double[,] m2)
        {
            int numeroLinhas = m1.GetLength(0);
            int numeroColunas = m2.GetLength(1);
            double[,] resultado = new double[numeroLinhas, numeroColunas];

            for(int i = 0; i < numeroLinhas; i++) 
            {
                for (int j = 0; j < numeroColunas; j++)
                {
                    double valor = 0;
                    for (int k = 0; k < numeroColunas; k++)
                    {
                        valor = valor + m1[i,k] * m2[k,j];
                    }
                    resultado[i,j] = valor;
                }
            
            }
            return resultado;
        }


        static void Main(string[] args)
        {
            double[,] m1 = new double[2, 2];
            double[,] m2 = new double[2, 2];
            //preenche matriz 1
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            //preenche matriz 2
            m2[0, 0] = 5;
            m2[0, 1] = 6;
            m2[1, 0] = 7;
            m2[1, 1] = 8;

            double[,] resultado = multiplicaMatriz(m1,m2);

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(resultado[i, j] + "  ");

                }
                Console.WriteLine();
            }
        }
    }
}
