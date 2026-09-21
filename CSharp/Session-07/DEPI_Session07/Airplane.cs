using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_Session07
{
    internal class Airplane : IMoveable, IFlyable
    {
        void IMoveable.MoveForward() 
             => Console.WriteLine("Airplane moves forward.");
         
        void IMoveable.MoveBackward() 
             => Console.WriteLine("Airplane moves backward.");

        void IFlyable.MoveUp() 
             => Console.WriteLine("Airplane climbs.");
         
        void IFlyable.MoveDown() 
            => Console.WriteLine("Airplane descends.");




    }
}
