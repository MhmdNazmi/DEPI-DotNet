namespace DEPI_Session07
{
    internal class Program
    {
        static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Q3
            //Shape shape = new Shape(2, 3);
            //Console.WriteLine(shape.Area()); // 6

            //Cube cube = new Cube(2, 3, 4);
            //Console.WriteLine(cube.Area()); // 24

            //Shape shapeRef =  new Cube(2, 3, 4);
            //Console.WriteLine(shapeRef.Area()); // 6
            //                                    // a reference from SHAPE points at an object from CUBE
            //                                    // Area() was hidden using keyword "new" & was not overridden
            //                                    // this is called early binding where mister compiler decides 
            //                                    // which method to call at compile time
            #endregion

            #region Q4
            //object obj = new Cube(1, 2, 3);
            //Console.WriteLine( obj.ToString()); // outputs Width = 1, Height = 2
            //                                    // calls the ToString in class Cube inherited from class Shape
            //                                    // where it was overridden only in class Shape and not in class Cube
            //                                    // this is Late/Dynamic Binding where method is selected at runtime

            #endregion

            #region Q7
            //Person doctor = new Doctor
            //{
            //    ID = 1,
            //    Name = "Ahmed",
            //    Age = 40,
            //    Speciality = "Cardiology"
            //};

            //Person engineer = new Engineer
            //{
            //    ID = 2,
            //    Name = "Ali",
            //    Age = 30,
            //    Field = "Software"
            //};

            //ProcessPerson(doctor);
            //ProcessPerson(engineer);
            // a reference from class Person points at an object from class
            // Greet() was hidden using keyword "new" & was not overridden therefore it used the base method

            // Display() is virtual in base class so it can be overridden in child classes
            // uses late/dynamic binding
            #endregion

            #region Q8
            // it'd cause compilaion error
            // 'Doctor.Display()': cannot override inherited member 'Person.Display()' because it is not marked virtual, abstract, or override
            // 'Engineer.Display()': cannot override inherited member 'Person.Display()' because it is not marked virtual, abstract, or override

            // means override can only happen when base class is marked virtual, override, or abstract
            #endregion

            #region Q9
            // The problem: not all vehicles can do all these movements
            // They'd be forced to implement methods they don't need
            #endregion

            #region Q12
            //Car car = new Car();
            //Ship ship = new Ship();
            //Airplane plane = new Airplane();

            //car.MoveForward();
            //ship.MoveForward();

            //plane.MoveForward();
            //plane.MoveUp();

            //IMoveable carRef = new Car();
            //IMoveable planeRef = new Airplane();

            //carRef.MoveForward();
            //planeRef.MoveBackward();

            //planeRef.MoveUp();
            // no, planeRef is of type IMoveable which does not contain MoveUp()
            // so to call MoveUp() we need a reference from IFlyable or Airplane 
            #endregion

            #region Q13
            // one interface can combine multiple capabilities and interfaces
            // which makes it easier to inherit from and makes it more organised
            #endregion

            #region Q14
            //Ship ship = new Ship();

            //ship.MoveForward();
            #endregion

            #region Q15
            /* 
             | Feature                     | Static Binding (new)   | Dynamic Binding (override) |
             | --------------------------- | ---------------------  | -------------------------- |
             | Keyword in base             | normal method /virtual | virtual                    |
             | Keyword in derived          | new                    | override                   |
             | Resolved at                 | Compile Time           | Runtime                    |
             | Behavior via base reference | Base version executes  | Derived version executes   |

             
           */
            #endregion

            #region Q16
            // "virtual" forces the programmer to grant permission for overriding
            // without virtual C# protects the original implementation and prevents overriding
            #endregion 
        }
    }
}
