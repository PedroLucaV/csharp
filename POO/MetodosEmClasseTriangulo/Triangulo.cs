using System;
namespace trianguloEmClasse
{
    internal class Triangulo //posso a declarar dentro do Program tbm caso tenha nescessidade;
    {
        public double A;
        public double B;
        public double C;

        //para criar um metodo, fazemos uma funcao como uma variavel
        public double Area()
        {
            double p = (A + B + C) / 2;
            double areaFinal = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return areaFinal;
        }
    }
}
