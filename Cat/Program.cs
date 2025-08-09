using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1= new Cat();
            c1.age = 10;
            c1.name = "ASh";
            c1.Colour = "ghm";

            Console.WriteLine("age is " +c1.age +" name is " +c1.name+ " and colour is  "+c1.Colour);
          c1.getInfo();
            c1.run();
            c1.wait();
        }
    }
}


