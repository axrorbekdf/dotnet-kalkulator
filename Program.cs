using System;
using KALKULATOR.Classes;

internal class Program
{
    private static void Main(string[] args)
    {   
        
        Security security = new Security();
        security.CheckPasswod();

        Calculator calculator = new Calculator();

        calculator.GetInputs();

        int summary = 0;
        switch (calculator.Operation)
        {
            case "+":
                summary = calculator.FirstNumber + calculator.SecondNumber;
                break;

            case "-":
                summary = calculator.FirstNumber - calculator.SecondNumber;
                break;

            case "*":
                summary = calculator.FirstNumber * calculator.SecondNumber;
                break;

            case "/":
                if (calculator.SecondNumber == 0)
                    Console.WriteLine("Sonni 0ga bo'lib bo'lmaydi!");
                else
                    summary = calculator.FirstNumber / calculator.SecondNumber;
                break;

            case "%":
                summary = calculator.FirstNumber + calculator.SecondNumber;
                break;

            default:
                Console.WriteLine("Bunday amal mavjud emas!");
                break;
        }

        Console.WriteLine($"Natija: {summary}");
    }
}