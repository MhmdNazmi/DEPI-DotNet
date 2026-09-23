using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DEPI_Session08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            #region 2.
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P);
            #endregion

            #region 3.
            int x, y, z;

            Console.Write("Enter point 1: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Invalid input, try again: ");
            }
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Invalid input, try again: ");
            }
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.Write("Invalid input, try again: ");
            }
            Point3D P1 = new Point3D(x, y, z);


            Console.Write("Enter point 2: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Invalid input, try again: ");
            }
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Invalid input, try again: ");
            }
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.Write("Invalid input, try again: ");
            }
            Point3D P2 = new Point3D(x, y, z);

            Console.WriteLine(P1);
            Console.WriteLine(P2);
            #endregion

            #region 4.
            if (P1 == P2)
            {
                Console.WriteLine("Two points are equal");
            }
            else
            {
                Console.WriteLine("Two points are not equal");
            }
            #endregion

            #region 5.
            Point3D[] points =
            {
                new Point3D(5,2,1),
                new Point3D(1,8,3),
                new Point3D(1,2,7),
                new Point3D(4,1,9)
            };

            Array.Sort(points);

            Console.WriteLine("Sorted points:");
            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            #endregion

            #region 6.
            Point3D clonedPoint = (Point3D)P1.Clone();
            Console.WriteLine($"Cloned point: {clonedPoint}");
            #endregion
            #endregion

            #region Second Project
            Console.WriteLine($"Add: {Maths.Add(10, 5)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(10, 5)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(10, 5)}");
            Console.WriteLine($"Divide: {Maths.Divide(10, 5)}");
            #endregion

            #region Third Project
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2);

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            Console.WriteLine(D4);
            #endregion
        }
    }
}
