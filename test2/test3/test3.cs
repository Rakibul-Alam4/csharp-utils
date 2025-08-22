using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    internal class test3
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the Redius:");
            int r =Convert.ToInt32(Console.ReadLine());
            double Circle;
            Circle = 3.1416 * r * r;
            Console.WriteLine("The Circle is: " +Circle);
            */
            /*
            Console.Write("Enter the base:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the heigt:");
            int h = Convert.ToInt32(Console.ReadLine());
            double Triangle;
            Triangle = 0.5 * b * h;
            Console.WriteLine("The Triangle is: " + Triangle);
            */
            /*
            Console.Write("Enter the Ferenhight:");
            int f = Convert.ToInt32(Console.ReadLine());
            double Celcius;
            Celcius = (f - 32) / 1.8;
            Console.WriteLine("The Circle is: " + Celcius);
            */
            Console.Write("Enter the Celcius:");
            int c = Convert.ToInt32(Console.ReadLine());
            double Fer;
            Fer = (1.8 * c) + 32;
            Console.WriteLine("The Fer is: " + Fer);
        }
    }
}
