using System;

namespace Resto2_URI1075
{
    class Program
    {
        static void Main(string[] args)
        {
            //Efetua a leitura do número informado
            int n = int.Parse(Console.ReadLine());
                        
            for (int i = 0; i <= 10000; i++)
            {
                int resto = 0;
                
                //Identifica os valores dos restos que são iguais a "2".
                resto = i % n;

                //Imprime apenas os números que na divisão, são iguais a zero.
                if (resto ==2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
