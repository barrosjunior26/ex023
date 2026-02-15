using System;
using System.Linq;

namespace ex023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis globais
            double[] Subtracao;
            int quantidade = 0;
            double resultado = 0;

            Console.Clear();

            Console.WriteLine("Informe a quantidade de valores que deseja realizar na operação: ");
            quantidade = Convert.ToInt16(Console.ReadLine());

            Subtracao = new double[quantidade];

            for (int i = 0; i < Subtracao.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                Subtracao[i] = Convert.ToDouble(Console.ReadLine());
            }

            resultado = Subtracao.Aggregate((valor1, valor2) => valor1 - valor2);

            Console.WriteLine($"O resultado é = {Math.Round(resultado, 2)}");
        }
    }
}
