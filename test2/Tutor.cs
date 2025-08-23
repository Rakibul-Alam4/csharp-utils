using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Tutor
    {

        public int Id;
        public string Name;
        public double Salary;

        public void insert(int i, String n, double s)
        {
            Id =i;
            Name = n;
            Salary = s;

        }
        public void display()
        {
            Console.WriteLine(Id + " " + Name + " " + Salary);
        }    
        static void Main(string[] args)
        {
            Tutor t1 = new Tutor();
            Tutor t2 = new Tutor();
            Tutor t3 = new Tutor();

            t1.insert (1, "A", 25);
            t2.insert (2, "B", 26);
            t3.insert (3, "C" ,27);

            t1.display();
            t2.display();
            t3.display();
        }
    }
}
