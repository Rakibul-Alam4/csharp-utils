using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Day2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is Day2");
            //Console.ReadKey();

            /*
            Console.WriteLine("Enter the number");
            Console.Write("Num1 is:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num 2 is: ");
            int num2= Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("The result is :" + result);
            */

            Console.Write("Enter your name:");
            String name= Console.ReadLine();

            Console.Write("Enter the marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            string Status;
            if (marks > 50)
            {
                Status = "Passed";
            }
            else
            {
                Status = "Failed";
            }
            Console.WriteLine("Hi " +name+  " you have "  + Status);

            Console.ReadKey();
        }
    }
}
