using System;
using System.Globalization;

namespace soma_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
         
            Console.Write(" Quantos numeros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++){
                Console.Write(" Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(),CI);   
            }
            Console.WriteLine();
            Console.Write("Valores = ");

          
            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CI));
                Console.Write("  ");
                
            }
           double Soma = 0;
            for (int i = 0; i < N; i++){
                Soma = Soma + vet[i];
            }
            Console.WriteLine();
            Console.Write("Soma = " + Soma.ToString("F2", CI));
            Console.WriteLine();
            double Media = (double) Soma / N;
            Console.Write("Media = "+ Media.ToString("F2",CI));
        }
    }
}
