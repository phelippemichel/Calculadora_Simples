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

            Console.WriteLine("------Calculadora Simples------");
            Console.WriteLine("--Selecione a opção desejada--");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------------");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Sair(); break;
                default: Menu(); break;
            }


        }

        static void Adicao()
        {

            Console.Clear();

            Console.WriteLine("Insira o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Insira o primeiro valor : ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado :) github.com/phelippemichel");
            System.Environment.Exit(0);
        }

    }
}
