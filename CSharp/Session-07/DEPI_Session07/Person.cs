using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }    

        public int Age { get; set; }

        public Person()
        {
            ID = 0;
            Name = "Unknown";
            Age = 0;
        }

        public Person(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public void Greet() 
            => Console.WriteLine("I am a person");

        public virtual void Display()
            => Console.WriteLine($"Id: {ID}, Name: {Name}, Age: {Age}");
    }
}
