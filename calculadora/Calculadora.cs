using System;

namespace calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            string numero = "", numero2  = "";
            double soma; 

            Console.WriteLine("Digite um numero");
            numero = Console.ReadLine();
            Console.WriteLine("Digite outro numero");
            numero2 = Console.ReadLine();

            soma = Double.Parse(numero) + Double.Parse(numero2);
            Console.WriteLine($"soma: {soma}");

        }
    }
}
