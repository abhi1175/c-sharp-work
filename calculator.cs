using System;5

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");

        while (true)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        continue;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    continue;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine();

            Console.Write("Do you want to calculate again? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                break;

            Console.WriteLine();
        }
    }
}
