using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Vehicle : IVehicle
    {
        public virtual void MoveForward() 
            => Console.WriteLine("Forward");

        public virtual void MoveBackward() 
            => Console.WriteLine("Backward");

        public virtual void MoveUp() 
            => Console.WriteLine("Up");

        public virtual void MoveDown() 
            => Console.WriteLine("Down");
    }
}
