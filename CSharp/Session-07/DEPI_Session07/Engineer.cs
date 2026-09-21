using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Engineer : Person
    {
        public string Field { get; set; }

        public int YearsOfExperience { get; set; }

        public Engineer() : base() 
            => Field = "Unknown";

        public Engineer(int id, string name, int age, string field) : base(id, name, age)
            => Field = field;

        public new void Greet()
            => Console.WriteLine("I am an Engineer.");

        public override void Display()
            => Console.WriteLine($"Id: {ID}, Name: {Name}, Age: {Age}, Experience Years: {YearsOfExperience}, Field: {Field}");
    }
}
