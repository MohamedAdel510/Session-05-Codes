using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    internal struct Person
    {
        public int Age;
        public string? Name;

        public Person()
        {
            Age = 0;
            Name = null;
        }

        public Person(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
            Console.WriteLine("--------");
        }
    }
}
