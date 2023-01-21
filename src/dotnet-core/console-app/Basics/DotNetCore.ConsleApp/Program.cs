using ArithmaticOperation1;
using System;

namespace ArithmaticOperations // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int option = -1;
            //MathOperation mathOp = new MathOperation();
            //Console.WriteLine("Select Option");
            //Console.WriteLine("1.Add");
            //Console.WriteLine("2.Subtract");
            //Console.WriteLine("3.Multiplication");
            //Console.WriteLine("4.Division");
            //Console.Write("Enter your option:");
            //string optionText = Console.ReadLine();
            //Console.WriteLine("Enter First Number:");
            //int firstNumber = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number:");
            //int secondNumber = Int32.Parse(Console.ReadLine());
            //int result = 0;

            //if (optionText == "1")
            //{               
            //    result = mathOp.Add(firstNumber, secondNumber);
            //}
            //else if (optionText == "2")
            //{
            //    result = mathOp.Subtract(firstNumber, secondNumber);
            //}
            //else if(optionText == "3")
            //{
            //    result = mathOp.Multiply(firstNumber, secondNumber);                
            //}
            //else if (optionText == "4")
            //{
            //    result = mathOp.Division(firstNumber, secondNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Please select a correct operation.....");
            //}            

            //Console.WriteLine($"Result={result}");

            // End of calculator code


            // Usage of if statement with AND operator

            //int b = 10;
            //if (b >= 10 && b <= 20)
            //{
            //    Console.WriteLine("Value is in the range");
            //}
            //else
            //{
            //    Console.WriteLine("Value is not in the range");
            //}

            //String concatenation
            //if (args.Count() > 1)
            //{
            //    string firstName = args[0];
            //    string LastName = args[1];

            //    Console.WriteLine("Hello " + firstName + " " + LastName);
            //}

            // Usage of While Loop
            int index = 1;
            Console.WriteLine("Enter a Number:");
            int numberToDisplayTable = Int32.Parse(Console.ReadLine());

            while (index <= 10)
            {
                Console.WriteLine(numberToDisplayTable * index);
                index++;

            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numberToDisplayTable * i);
            }


            do
            {

            } while (true);
        }

    }
}