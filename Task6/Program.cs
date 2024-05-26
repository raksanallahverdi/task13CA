using System;

namespace Task6
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<double> calculator = new Calculator<double>();

            while (true)
            {
                
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");
                Console.WriteLine("5. Exit");

                Console.Write("Please choose operation: ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Happy End");
                    break;
                }

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = choice switch
                    {
                        "1" => calculator.Add(num1, num2),
                        "2" => calculator.Subtract(num1, num2),
                        "3" => calculator.Multiply(num1, num2),
                        "4" => calculator.Divide(num1, num2),
                        _ => throw new InvalidOperationException("Invalid operation")
                    };

                    Console.WriteLine($"Result: {result}");
                }

                else
                {
                    Console.WriteLine("Please choose valid operation !!!");
                }
            }
        }
    }
}