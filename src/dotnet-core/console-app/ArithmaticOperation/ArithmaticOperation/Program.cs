using ArithmaticOperation;
using System;

namespace ArithmaticOperations // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int option = -1;
            MathOperation mathOp = new MathOperation();
            Console.WriteLine("Select Option");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.Write("Enter your option:");
            string optionText = Console.ReadLine();
            Console.WriteLine("Enter First Number:"); 
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int secondNumber = Int32.Parse(Console.ReadLine());
            int result = 0;
            if (optionText == "1") 
            {
                result = mathOp.Add(firstNumber, secondNumber);
            }
            Console.WriteLine($"Result={result}");
        }
        
    }
}