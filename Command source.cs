using System;

namespace ConsoleAppprogram 3 // Added a namespace to avoid conflict
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Integer Calculator! - Command source.cs:9");

            while (true)
            {
                Console.WriteLine("\nSelect an operation: - Command source.cs:13");
                Console.WriteLine("1. Add - Command source.cs:14");
                Console.WriteLine("2. Subtract - Command source.cs:15");
                Console.WriteLine("3. Multiply - Command source.cs:16");
                Console.WriteLine("4. Divide - Command source.cs:17");
                Console.WriteLine("5. Exit - Command source.cs:18");

                Console.Write("Enter your choice (15): - Command source.cs:20");
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Thank you for using the calculator. Goodbye! - Command source.cs:25");
                    break;
                }

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    try
                    {
                        Console.Write("Enter the first integer: - Command source.cs:33");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter the second integer: - Command source.cs:36");
                        int num2 = int.Parse(Console.ReadLine());

                        if (choice == "1")
                        {
                            int result = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {result} - Command source.cs:42");
                        }
                        else if (choice == "2")
                        {
                            int result = num1 - num2;
                            Console.WriteLine($"{num1}  {num2} = {result} - Command source.cs:47");
                        }
                        else if (choice == "3")
                        {
                            int result = num1 * num2;
                            Console.WriteLine($"{num1} * {num2} = {result} - Command source.cs:52");
                        }
                        else if (choice == "4")
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: Division by zero is not allowed. - Command source.cs:58");
                            }
                            else
                            {
                                double result = (double)num1 / num2;
                                Console.WriteLine($"{num1} / {num2} = {result} - Command source.cs:63");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter integer numbers. - Command source.cs:69");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 5. - Command source.cs:74");
                }
            }
        }
    }
}
