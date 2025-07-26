using System;

namespace Lesson3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Integer Calculator!");

            while (true)
            {
                Console.WriteLine("\nSelect an operation:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Thank you for using the calculator. Goodbye!");
                    break;
                }

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    try
                    {
                        Console.Write("Enter the first integer: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter the second integer: ");
                        int num2 = int.Parse(Console.ReadLine());

                        if (choice == "1")
                        {
                            int result = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {result}");
                        }
                        else if (choice == "2")
                        {
                            int result = num1 - num2;
                            Console.WriteLine($"{num1} - {num2} = {result}");
                        }
                        else if (choice == "3")
                        {
                            int result = num1 * num2;
                            Console.WriteLine($"{num1} * {num2} = {result}");
                        }
                        else if (choice == "4")
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                            else
                            {
                                double result = (double)num1 / num2;
                                Console.WriteLine($"{num1} / {num2} = {result}");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter integer numbers.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                }
            }
        }
    }
}