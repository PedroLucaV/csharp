using System;

namespace ExercicioDolar
{
    class ConversorDolar
    {
        public static double taxaIOF = 0.06;

        public static double ConverterDolar(double cota, double dol)
        {
            double valorReal = cota * dol;
            valorReal = valorReal + (valorReal * taxaIOF);
            return valorReal;
        }
    }
}
