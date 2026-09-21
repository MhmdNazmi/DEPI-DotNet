using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Ship : IMoveable
    {
        public void MoveBackward()
        {
            Console.WriteLine("Ship moves forward on the sea.");
        }

        public void MoveForward()
        {
            Console.WriteLine("Ship moves backward on the sea.");
        }
    }
}
