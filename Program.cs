using System;
using KALKULATOR.Classes;

internal class Program
{
    private static void Main(string[] args)
    {   
        
        Security security = new Security();
        Calculator calculator = new Calculator();

        security.CheckPasswod();
        calculator.GetInputs();

        string messageFirst = !(calculator.IsFirstNumberPositive()) ? "1-raqam musbat emas!" : "1-raqam manfiy emas!";
        Console.WriteLine(messageFirst);

        string messageSecond = !(calculator.IsSecontNumberPositive()) ? "2-raqam musbat emas!" : "2-raqam manfiy emas!";
        Console.WriteLine(messageSecond);

        calculator.ComparisonInputs();

        string result = calculator.Calculate();
        Console.WriteLine($"Natija: {result}");


        calculator.PrintEvenNumbers();

        calculator.PrintMultiplicationTable();
    }
}