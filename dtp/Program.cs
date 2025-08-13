using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the year: ");

            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || (year % 400 == 0))
            {
                Console.WriteLine("It's leap year");
            }
            else
            {
                Console.WriteLine("it's not leap year");
            }

            Console.Write("Enter num1 :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2 :");
            double num2= Convert.ToDouble(Console.ReadLine());

            double sum;

            sum = num1 + num2;

            Console.WriteLine("The sum is : " + sum);
            

            Console.Write("Enter the num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2 && num1>num3)
            {
                Console.WriteLine("num 1 is the bigger" + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num 2 is the bigger" + num2);
            }

            else if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine("num 3 is the bigger" + num3);
            }
            

            Console.Write("Enter the name: ");
            String name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            String Status;

            if (marks >= 50)
            {
                Status = "Passed";
            }
            else
            {
                Status = "Failed";
            }
            Console.WriteLine("Hi" + name + "is" + Status);
            */

            

            Console.Write("Enter a string to reverse: ");
            String input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string (charArray);
            Console.Write("Reverse: "+reverse);
            

            /*

            Console.Write("Enter the message : ");
            string input = Console.ReadLine();

            string output = " ";
            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
                if (i < input.Length - 1)
                    output += " ";
            }
            Console.Write("Output: " + output);
            */

        }
    }
}
