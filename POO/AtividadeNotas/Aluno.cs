using System;
using System.Globalization;

namespace AtividadeNotas
{
    internal class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double notaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public string resultado()
        {
            if(notaFinal() >= 60)
            {
                return "Aprovado";
            }
            else
            {
                Console.WriteLine("Reprovado");
                return $"Faltaram {60 - notaFinal():F2} pontos.";
            }
        }

        public override string ToString()
        {
            return $"Nota Final = {notaFinal():F2}";
        }
    }
}
