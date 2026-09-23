using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session08
{
    internal class Point3D :IComparable<Point3D>, ICloneable
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        

        public override string ToString()
            => $"Point Coordinates: ({X}, {Y}, {Z})";


        public static bool operator ==(Point3D? left, Point3D? right)
        {
            //if (ReferenceEquals(left, right)) return true;
            if (left == right) return true;

            if (left is null || right is null) return false;
            return left.Equals(right) ;
        }

        public static bool operator !=(Point3D? left, Point3D? right) 
            => !(left == right);


        public int CompareTo(Point3D? other)
        {
            if (other is null) return 1;

            int xComparison = X.CompareTo(other.X);
            if (xComparison != 0) return xComparison;

            return Y.CompareTo(other.Y);
        }

        public object Clone() 
            => new Point3D(X, Y, Z);
        
    }
}
