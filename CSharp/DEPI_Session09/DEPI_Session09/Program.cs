using System;
using System.Dynamic;
using System.Numerics;

namespace DEPI_Session09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Primary Constructor & Records

            #region Q2
            //Patient p1 = new Patient(1, "John Doe", "01000000000", "No prior conditions");
            //Patient p2 = new Patient(1, "John Doe", "01000000000", "No prior conditions");
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());

            //// Are they equal? Why?
            //// Hashcodes aren't equal because they are different objects craeted using "new" keyword
            //// Different memory addresses produce different hash codes

            //Console.WriteLine(p1.Equals(p2));
            //// False,
            //// because p1 and p2 are different object references created with different memory addresses

            //p1 = p2;
            //Console.WriteLine(p1.Equals(p2));
            //// check Equals again. What changed?
            //// result is now "True", Both variables now reference to the same object in memory
            #endregion

            #region Q3
            //PatientDto dto01 = new PatientDto(1, "John Doe", "01000000000");
            //PatientDto dto02 = new PatientDto(1, "John Doe", "01000000000");

            //Console.WriteLine(dto01.GetHashCode());
            //Console.WriteLine(dto02.GetHashCode());

            //// Are they equal? Why?
            //// Yes, because records use "value equality" 
            //// 2 different records create the same hash code when values are identical

            //Console.WriteLine(dto01.Equals(dto02));
            //// What changed?
            //// Nothing changes in the result, because both records have the same values.


            //// explain the difference you observed between the class and the record.
            ///* 
            //* DIFFERENCE OBSERVED BETWEEN CLASS AND RECORD:
            //* - Classes use REFERENCE EQUALITY: Two instances with identical property values 
            //*   are NOT equal unless they point to the exact same memory address.
            //* - Records use VALUE EQUALITY: Two separate record instances with identical property 
            //*   values ARE equal and generate identical hash codes.
            //*/

            #endregion

            #region Q4
            Patient p = new Patient(1, "Name", "01000000000", "no history");

            PatientDto dto = PatientMapper.MapFromModelToDto(p);
            Console.WriteLine(p);
            #endregion

            #endregion


            #region Singleton

            #region Q5 & Q6
            AppLogger Log1 = AppLogger.GetLogger();
            AppLogger Log2 = AppLogger.GetLogger();
            AppLogger Log3 = AppLogger.GetLogger();
            AppLogger Log4 = AppLogger.GetLogger();

            Console.WriteLine(Log1.GetHashCode());
            Console.WriteLine(Log2.GetHashCode());
            Console.WriteLine(Log3.GetHashCode());
            Console.WriteLine(Log4.GetHashCode());

            // All hash codes are identical because all variables refer to the same object
            #endregion

            #endregion

            #region var & dynamic

            #region Q7
            //Patient p1 = new Patient(1, "Ali", "01011111111", "None");

            //var p2 = new Patient(2, "Sara", "01022222222", "Headache");

            //dynamic p3 = new Patient(3, "Mona", "01033333333", "Flu");
            //Console.WriteLine(p3);

            //// Difference:
            ///* VAR: Resolved at "compile time", the compiler infers the exact type based on
            //* the assignment. Strong typing is maintained, type can't change later.
            //* 
            //* DYNAMIC: Resolved at "runtime", bypasses compile time type checking completely
            //* Errors (like calling non existent methods) are caught only during execution.
            //*/
            #endregion

            #endregion

            #region Anonymous Types
            //Q8

            //var doctor01 = new
            //{
            //    Name = "Sara",
            //    Specialty = "Cardiology",
            //    ExperienceYears = 8,
            //    Salary = 25_000
            //};

            //var doctor02 = new
            //{
            //    Name = "Sara",
            //    Specialty = "Cardiology",
            //    ExperienceYears = 8,
            //    Salary = 25_000
            //};

            //Console.WriteLine(doctor01.Name);
            //Console.WriteLine(doctor01.Specialty);

            //Console.WriteLine(doctor01.GetHashCode());
            //Console.WriteLine(doctor02.GetHashCode());

            //Console.WriteLine(doctor01.GetType());

            //Console.WriteLine(doctor01.Equals(doctor02));

            //Console.WriteLine(doctor01);

            /* compare anonymous-type equality with class equality and record equality:
            * 
            *  Class equality: Reference based, equal only if it has the same reference
            *  Record equality: Value based, equal only if the properties match
            *  Anonymous type equality: Value based, compiler automatically overrides "Equals"
            *   and GetHashCode to compare property values, similar to records
            */
            #endregion

            #region Extension Methods
            // Q9 and Q10

            //Console.WriteLine("Stethoscope".IsShorterThan(5));

            //Console.WriteLine("Ab".Repeat(4));


            #endregion



        }
    }
}
