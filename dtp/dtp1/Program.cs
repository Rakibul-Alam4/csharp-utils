using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace dtp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the number: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);

            string reverse = new string(charArray);
            Console.WriteLine("Reversed : " + reverse);
            */

            Console.Write("Enter the message: ");
            string input = Console.ReadLine();

           string Output = " ";
            for (int i = 0; i < input.Length; i++)
            {
                Output += input[i];
                if (i < input.Length - 1)
                    Output += " ";
            }
            Console.WriteLine("Output: "+Output);

        }
    }
}
