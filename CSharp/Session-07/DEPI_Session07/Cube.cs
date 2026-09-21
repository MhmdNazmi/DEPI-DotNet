using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Cube : Shape
    {
        public double Depth { get; set; }

        public Cube() : base() 
            => Depth = 0;

        public Cube(double width, double height, double depth) : base(width, height)
            => Depth = depth;

        public new double Area()
            => base.Area() * Depth;

        public void Print()
            => Console.WriteLine($"Width = {Width}, Height = {Height}, Depth = {Depth}");
    }
}
