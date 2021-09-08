using System;

namespace calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            string numero = "", numero2  = "";
            double soma, subtracao, divisao;

            Console.WriteLine("Digite um numero");
            numero = Console.ReadLine();
            Console.WriteLine("Digite outro numero");
            numero2 = Console.ReadLine();

            Console.WriteLine("Digite um operador\n + - / * % ^");
            string operador = Console.ReadLine();
            switch(operador)
            {
                case "+":
                    soma = Double.Parse(numero) + Double.Parse(numero2);
                    Console.WriteLine($"soma: {soma}");
                    break;
                case "-":
                    subtracao = Double.Parse(numero) - Double.Parse(numero2);
                    Console.WriteLine($"subtração: {subtracao}");
                    break;
                case "/":
                    divisao = Double.Parse(numero) / Double.Parse(numero2);
                    Console.WriteLine($"divisão: {divisao}");
                    break;
            }


        }
    }
}
