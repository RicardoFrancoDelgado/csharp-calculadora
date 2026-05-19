using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Iniciando calculadora...");
            Console.WriteLine("Escolha uma das operações a seguir");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("--------------------");
            Console.Write("Escolha uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 0: Sair(); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default:
                    Console.WriteLine("Operação não reconhecida");
                    Menu();
                    break;
            }
        }

        static void Sair()
        {
            Console.WriteLine("Encerrando calculadora...");
            System.Environment.Exit(0);
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro número:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double v2 = double.Parse(Console.ReadLine());

            double res = v1 + v2;
            Console.WriteLine($"Resultado da soma: {res}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro número:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double v2 = double.Parse(Console.ReadLine());

            double res = v1 - v2;
            Console.WriteLine($"Resultado da subtração: {res}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro número:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double v2 = double.Parse(Console.ReadLine());

            double res = v1 / v2;
            Console.WriteLine($"Resultado da divisão: {res}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Informe o primeiro número:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double v2 = double.Parse(Console.ReadLine());

            double res = v1 * v2;
            Console.WriteLine($"Resultado da multiplicação: {res}");

            Console.ReadKey();
            Menu();
        }
    }
}
