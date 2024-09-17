using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            double operation = Calculation(choice);
            Console.WriteLine($"{operation}");

            Console.ReadKey();
        }
        static int Numbers(double firstNumber, double secondNumber, int choice)
        {
            Console.WriteLine("\t********************");
            Console.WriteLine("\t CONSOLE CALCULATOR");
            Console.WriteLine("\t********************");
            Console.WriteLine();
            Console.WriteLine("Please enter your: ");
            Console.Write("\t\t First number: ");
            firstNumber = double.Parse(Console.ReadLine());
            Console.Write("\t\t Second number: ");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please choose option 1,2,3 or 4 to select the operation");
            Console.WriteLine();
            Console.Write("Choice:");
            Console.WriteLine("\t1 Addition");
            Console.WriteLine("\t2 Subtraction");
            Console.WriteLine("\t3 Multiplication");
            Console.WriteLine("\t4 Divion");
            Console.Write("Choice: ");

            choice = int.Parse(Console.ReadLine());

            return choice;
        }
        static double Calculation(int choice)
        {
            double firstNumber = 0, secondNumber = 0;
            int operationChoice = Numbers(firstNumber, secondNumber, choice);

            if (choice == 1)
            {
                return firstNumber + secondNumber;
            }
            else if (choice == 2)
            {
                return firstNumber - secondNumber;
            }
            else if (choice == 3)
            {
                return firstNumber * secondNumber;
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }
    }
}
