using System;
using System.Globalization;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.TotalEmDolar = double.Parse(Console.ReadLine(), CI);

            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.Conversor().ToString("F2", CI));
        }
    }
}
