using System;
using System.Globalization;

namespace ExercicioUm
{
    class ConversorDeMoeda
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public static double Cotacao;
        public static double TotalEmDolar;

        public static double Conversor()
        {
            return ((TotalEmDolar*6.0)/100+TotalEmDolar)*Cotacao;
        }
    }
}
