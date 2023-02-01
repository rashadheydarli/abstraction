using System;
namespace test
{
    public class Program
    {
        static void Main()
        {
            var addition = new Addition();
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int resultaddition = addition.Operate(number1, number2);
            Console.WriteLine($"Addition: first number = {number1}, second number = {number2}, Result = {resultaddition}");


            var substraction = new Substraction();
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int resultsubstraction = substraction.Operate(number1, number2);
            Console.WriteLine($"Substraction: first number={number1}, second number={number2}, Result= {resultsubstraction}");

            var multiplication = new Multiplication();
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int resultmultiplication = multiplication.Operate(number1, number2);
            Console.WriteLine($"Multiplication : first number = {number1}, second number={number2}, Result= {resultmultiplication}");

            var division = new Division();
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int resultdivision = division.Operate(number1, number2);
            Console.WriteLine($"Addition: first number = {number1}, second number = {number2}  , Result = {resultdivision}");

        }
    }
}

    