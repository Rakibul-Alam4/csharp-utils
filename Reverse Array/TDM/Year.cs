using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM
{
    internal class Year
    {
        static void Main(string[] args)
        /*
    {
        string input = "1100";
        string output = new string(input.Reverse().ToArray());

        Console.WriteLine("Input: " + input);
        Console.WriteLine("Output: " + output);
    }
        */

        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine(); // Read user input

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray); // Reverse the array
            string reversed = new string(charArray);

            Console.WriteLine("Reversed: " + reversed);
        }
    }
}
