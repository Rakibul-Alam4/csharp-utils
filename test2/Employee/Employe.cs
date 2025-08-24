using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employe
    {
        public int Id;
        public string Name;
        public Double Salary;

        public void insert(int i, String n, Double s)
        {
            Id = i;
            Name = n;
            Salary = s;
        }
        public void display()
        {
            Console.WriteLine(Id + " " + Name + " " + Salary);
        }

        static void Main(string[] args)
        {
            Employe e1 = new Employe();
            Employe e2 = new Employe();
            Employe e3 = new Employe();

            e1.insert(1, "A", 25);
            e2.insert(2, "B", 26);
            e3.insert(3, "C", 28);

            e1.display(); 
            e2.display();
            e3.display();

            Console.ReadKey();
        }
    }
}
