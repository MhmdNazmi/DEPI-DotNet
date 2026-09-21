using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Car : IMoveable
    {
        public void MoveForward() 
            => Console.WriteLine("Car moves forward on the road.");

        public void MoveBackward()
            => Console.WriteLine("Car moves backward on the road.");
    }
}
