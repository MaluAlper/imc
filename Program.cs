using System;

namespace imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular o índice de massa corporal de uma pessoa (IMC), pesando 80kg e medindo 2m.");
            int P=80;
            int A=2;
            double resultado=Math.Pow(A, 2);
            double resultado2=P / resultado;
            Console.WriteLine($"IMC: {resultado2} kg/m²");
        }
    }
}
