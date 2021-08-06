using System;

namespace console_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Operand1: ");
            string input1 = Console.ReadLine();
            double operand1 = Convert.ToDouble(input1);
            Console.Write("Input Operand2: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Sign: ");
            string sign = Console.ReadLine();
            switch(sign)
            {
                case "+":
                    Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                    break;
                case "-":
                    Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                    break;
                case "*":
                    Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                    break;
                case "/":
                    if(operand2 == 0)
                    {
                        Console.WriteLine("You can't divide by zero");
                        break;
                    }
                    Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }
        }
    }
}
