using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Day3
    {
        static void Main(string[] args)
        {
            // Input binary string
            Console.Write("Enter a binary number: ");
            string binaryInput = Console.ReadLine();

            // Calculate the complement
            string complement = GetBinaryComplement(binaryInput);

            // Output the result
            Console.WriteLine("Complement: " + complement);
        }

        static string GetBinaryComplement(string binary)
        {
            char[] complementArray = new char[binary.Length];

            for (int i = 0; i < binary.Length; i++)
            {
                // Flip each bit
                complementArray[i] = (binary[i] == '0') ? '1' : '0';

            }

            return new string(complementArray);

        }

    }
}
    

