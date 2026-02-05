using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");


            Console.WriteLine("Input the first number: ");
            string x = Console.ReadLine();
            double num1;
            while (!double.TryParse(x, out num1))
            {
                Console.WriteLine("Enter valid number !");
                x = Console.ReadLine();
            }

            Console.WriteLine("Input the second number: ");
            string y = Console.ReadLine();
            double num2;
            while (!double.TryParse(y, out num2))
            {
                Console.WriteLine("Enter valid number !");
                y = Console.ReadLine();
            }
            bool flag = false;
            do
            {
                Console.WriteLine(" What do you want to do with those numbers? \n ");
                Console.WriteLine("[A]dd\n");
                Console.WriteLine("[S]ubtract\n");
                Console.WriteLine("[M]ultiply\n");
                Console.WriteLine("Enter your Choice ");
                char ch = Console.ReadLine()[0];
                ch = char.ToUpper(ch);
                if (ch == 'A')
                {
                    Console.WriteLine($"{x} + {y} = {num1 + num2}");
                    flag = false;
                }
                else if (ch == 'S')
                {
                    Console.WriteLine($"{x} - {y} = {num1 - num2}");
                    flag = false;
                }
                else if (ch == 'M')
                {
                    Console.WriteLine($"{x} * {y} = {num1 * num2}");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice !");
                    flag = true;
                }

            } while (flag);
        }
    }
}
