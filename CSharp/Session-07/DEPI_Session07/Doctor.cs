using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Doctor : Person
    {
        public string Speciality { get; set; }

        public Doctor() : base()
        {
            Speciality = "Unknown";   
        }

        public Doctor(int id, string name, int age, string speciality) : base(id, name, age)
            => Speciality = speciality;

        public new void Greet()
            => Console.WriteLine("I'm a Doctor");

        public override void Display() 
            => Console.WriteLine($"Id: {ID}, Name: {Name}, Age: {Age}, Speciality: {Speciality}");
    }
}
