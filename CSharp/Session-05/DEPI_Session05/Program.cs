using System.Threading.Channels;

namespace DEPI_Session05
{
    internal class Program
    {
        #region Q1's function
        static void ChangeValueTo99(int x)
        {
            x = 99;
        }

        static void ChangeValueTo70(ref int k)
        {
            k = 70;
        }
        #endregion

        #region Q2's function
        static void PassArrByVal(int[] arr)
        {
            arr[0] = 0;
        }

        static void PassByRef(ref int[] arr)
        {
            arr[0] = 0;
        }
        #endregion

        #region Q3's function
        static void Calculate(int a, int b, int c, int d)
        {
            int sum = a + b;
            int sub = c - d;

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Subtraction = {sub}");
        }
        #endregion

        #region Q4's function
        static int SumDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
        #endregion

        #region Q5's function
        static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
        #endregion

        #region Q6's function
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }
        }
        #endregion

        #region Q7's function
        static int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        #endregion

        #region Q8's function
        static string ChangeChar(string text, int position, char newChar)
        {
            char[] chars = text.ToCharArray();
            chars[position] = newChar;

            return new string(chars);
        }
        #endregion 


        // ---- ENUM AND STRUCT: ---- \\

        #region Q1's Enum
        enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        #endregion

        #region Q2 and Q7 Struct
        struct Person
        {
            public string Name;
            public int Age;
        }
        #endregion

        #region Q3's enum
        enum Season
        {
            Spring, Summer, Autumn, Winter
        }
        #endregion

        #region Q4's enum
        [Flags]
        enum Permissions
        {
            Read, Write, Delete, Execute
        }
        #endregion

        #region Q5's enum
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion

        #region Q6's struct 
        struct Point
        {
            public double X;
            public double Y;
        }
        #endregion 


        static void Main(string[] args)
        {
            #region 1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            // Passing by value creates a different copy in a function and doesn't change the original value 
            //int x = 10;
            //ChangeValueTo99(x);
            //Console.WriteLine(x); // prints 10 and not 99

            //// Passing by reference changes the original variable's value
            //int k = 7;
            //ChangeValueTo70(ref k); // prints 70 and not 7
            //Console.WriteLine(k);
            #endregion

            #region 2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            // pass by val
            //int[] arrayByValue = { 111, 2, 3 };
            //PassArrByVal(arrayByValue);
            //Console.WriteLine(arrayByValue[0]); // prints 111 and not 0

            //// pass by ref
            //int[] arrayByRef = {7, 8, 9};
            //PassByRef(ref arrayByRef);
            //Console.WriteLine(arrayByRef[0]); // prints 0 and not 7
            #endregion

            #region 3. Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Calculate(9, 18, 5, 40);
            #endregion

            #region 4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Sum Of Digits = {SumDigits(num)}");
            #endregion

            #region 5. Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.WriteLine(IsPrime(7));
            #endregion

            #region 6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 5, 8, 2, 10, 1 };
            //int min = 0, max = 0;

            //MinMaxArray(arr, ref min, ref max);

            //Console.WriteLine($"Min = {min}, Max = {max}");
            #endregion

            #region 7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine(Factorial(5));
            #endregion

            #region 8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //string result = ChangeChar("Hello", 1, 'a');
            //Console.WriteLine(result);
            #endregion

            // ---- ENUM AND STRUCT: ---- \\

            #region 1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region 2.Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];

            //people[0].Name = "Ali";
            //people[0].Age = 20;

            //people[1].Name = "Ahmed";
            //people[1].Age = 25;

            //people[2].Name = "Sara";
            //people[2].Age = 22;

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Name: {people[i].Name}, Age: {people[i].Age}");
            //}

            #endregion

            #region 3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.Write("Enter season name: ");
            //string season = Console.ReadLine();

            //switch (season.ToLower())
            //{
            //    case "spring":
            //        Console.WriteLine("March To May");
            //        break;

            //    case "summer":
            //        Console.WriteLine("June To August");
            //        break;

            //    case "autumn":
            //        Console.WriteLine("September To November");
            //        break;

            //    case "winter":
            //        Console.WriteLine("December To February");
            //        break;
            //}

            #endregion

            #region 4.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            Permissions user = Permissions.Read | Permissions.Write;

            Console.WriteLine(user);

            user |= Permissions.Delete;

            Console.WriteLine(user);

            user &= ~Permissions.Write;

            Console.WriteLine(user);

            Console.WriteLine(user.HasFlag(Permissions.Read));
            #endregion

            #region 5.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.Write("Enter Color: ");
            //string color = Console.ReadLine();

            //if (color.ToLower() == "red" ||
            //    color.ToLower() == "green" ||
            //    color.ToLower() == "blue")
            //{
            //    Console.WriteLine("Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine("Not Primary Color");
            //}

            #endregion

            #region 6. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point p1;
            //Point p2;

            //Console.Write("X1: ");
            //p1.X = double.Parse(Console.ReadLine());

            //Console.Write("Y1: ");
            //p1.Y = double.Parse(Console.ReadLine());

            //Console.Write("X2: ");
            //p2.X = double.Parse(Console.ReadLine());

            //Console.Write("Y2: ");
            //p2.Y = double.Parse(Console.ReadLine());

            //double distance =
            //    Math.Sqrt(
            //        Math.Pow(p2.X - p1.X, 2) +
            //        Math.Pow(p2.Y - p1.Y, 2));

            //Console.WriteLine(distance);
            #endregion

            #region 7.Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Name: ");
            //    people[i].Name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    people[i].Age = int.Parse(Console.ReadLine());
            //}

            //Person oldest = people[0];

            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}

            //Console.WriteLine("Oldest Person:");
            //Console.WriteLine(oldest.Name);
            //Console.WriteLine(oldest.Age);

            #endregion 
        }
    }
}
