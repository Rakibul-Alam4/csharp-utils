using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_between_each_characte
{
    internal class Program
    {
        static void Main(string[] args)
        /*
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string output = string.Join(" ", input.ToCharArray());

        Console.WriteLine("Output: " + output);
    }
        */
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
                if (i < input.Length - 1) // Avoid adding a trailing space
                    output += " ";
            }

            Console.WriteLine("Output: " + output);
        }
    }
}
