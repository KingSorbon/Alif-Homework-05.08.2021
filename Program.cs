using System;

namespace Alif_Academy_HomeWork_05._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //HomeWork 05.08.2021
            //задания 2
            int A = 10;
            int B = 11;
            if (A > B)
            {
                A = B;
            }
            else if (B > A)
            {
                A = B;
            }
            else
            {
                A = B = 0;
            }
            Console.WriteLine($"A = {A} B = {B}");
            Console.ReadKey();

            // задания 3
            Console.Write("Enter operand1 : ");
            double operand1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter operand2 : ");
            double operand2 = Double.Parse(Console.ReadLine());

            Console.Write("Enter operator + - * / :  ");
            var sign = Console.ReadLine();

            switch (sign)
            {
                case ("+"):
                    System.Console.WriteLine(operand1 + operand2);
                    break;
                case ("-"):
                    System.Console.WriteLine(operand1 - operand2);
                    break;
                case ("*"):
                    System.Console.WriteLine(operand1 * operand2);
                    break;
                default:
                    try
                    {
                        System.Console.WriteLine(operand1 / operand2);
                    }
                    catch (System.DivideByZeroException)
                    {
                        System.Console.WriteLine("Your Exception notification");
                    }
                    break;
            }
            Console.ReadKey();

            //задания 4
            Console.WriteLine("Enter any number");
            var num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 14)
            {
                Console.WriteLine("Number is between 0 and 14");
            }
            else if (num >= 15 && num <= 35)
            {
                Console.WriteLine("Number is between 15 and 35");
            }
            else if (num >= 36 && num < 50)
            {
                Console.WriteLine("Number is between 36 and 50");
            }
            else if (num >= 50 && num <= 100)
            {
                Console.WriteLine("Number is between 50 and 100");
            }
            else if (num >= 100)
            {
                Console.WriteLine("I said any number but between 0 and 100 ");
            }
            Console.ReadKey();
        }
    }
}
