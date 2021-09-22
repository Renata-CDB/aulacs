using System;

namespace calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            string numero = "", numero2  = "";
            double soma, subtracao, divisao, multiplicacao, exponenciacao, restoDivisaoInt;

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
                case "*":
                    multiplicacao = Double.Parse(numero) * Double.Parse(numero2);
                    Console.WriteLine($"multiplicacao: {multiplicacao}");
                    break;
                case "%":
                    restoDivisaoInt = Double.Parse(numero) % Double.Parse(numero2);
                    Console.WriteLine($"resto da divisão inteira: {restoDivisaoInt}");
                    break;
                case "^":
                    //exponenciacao = Double.Parse(numero) ^ Double.Parse(numero2);
                    exponenciacao = Math.Pow(Double.Parse(numero) , Double.Parse(numero2));
                    Console.WriteLine($"exponenciacao: {exponenciacao}");
                    break;         

            }


        }
    }
}
