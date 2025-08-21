using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double sum;
            sum= num1 + num2;
            Console.WriteLine(sum);
            */

            Console.Write("Enter num1: ");
            int num1  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is the biggest number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is the biggest number");

            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("num3 is the biggest number ");
            }


        }
    }
}
