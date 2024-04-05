using System;

namespace HomeWork1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                int result = 0;
                int num1 = int.Parse(args[0]);
                string operation = args[1];
                int num2 = int.Parse(args[2]);
                if (operation == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                }
                if (operation == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                }
                if (operation == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                }
                if (operation == "/")
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
            }
        }
    }
}