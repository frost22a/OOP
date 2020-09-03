using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Threading;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator();

            Console.WriteLine("wpisz proszę dwie liczby oddzielone enterem:");
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("wpisz proszę działanie, które chcesz wykonać");
            Console.WriteLine("dostępne działania to: + - * /");

            var operation = (Console.ReadLine());

            var result = default(int);

            switch (operation)
            {
                case "+":
                    {
                        result = calculator.Add(firstNumber, secondNumber);
                    }break;
                case "-":
                    {
                        result = calculator.Substract(firstNumber, secondNumber);
                    }
                    break;
                case "*":
                    {
                        result = calculator.Mulitply(firstNumber, secondNumber);
                    }
                    break;
                case "/":
                    {
                        result = calculator.Divide(firstNumber, secondNumber);
                    }
                    break;


            }

            Console.WriteLine(result);

        }

    }
}
