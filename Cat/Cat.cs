using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    public class Cat
    {
        public int age;
        public string name;
        public String Colour;
        public Cat()
        {
            age = 10;
            name = "Peu";
            Colour = "White";

        }
        public Cat (int age, String name, String colour)
        {
            this.age = age;
            this.name = name;
            this.Colour = colour;
        }
        public void run()
        {
            Console.WriteLine("Running................");
        }
        public void wait()
        {
            Console.WriteLine("waiting................");
        }

        public void getInfo()
        {
            Console.WriteLine("age is {0} name is {1} and colour is{2}", age,name,Colour);
        }
    }
}

