using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public Shape()
        {
            Width = 0;
            Height = 0;
        }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area() 
            => Width * Height;

        public override string ToString() 
            => $"Width = {Width}, Height = {Height}";
    }
}
