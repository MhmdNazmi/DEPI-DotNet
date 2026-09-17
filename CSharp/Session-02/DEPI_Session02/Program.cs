namespace DEPI_Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Write a program that allows the user to enter a number then print it.
            //Console.Write("Enter a number to get printed: ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);

            //Console.WriteLine(num);
            #endregion

            #region 2. Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen.
            //string text = "abc";
            //int num = int.Parse(text);
            //Console.WriteLine(num);

            // What'll happen: Program throws FormatException
            #endregion

            #region 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen.

            //float a = 3.2f, b = 8.5f;
            //float division = a / b;

            //Console.WriteLine(division);

            // What'll happen: prints 0.3764706 as a rounded result due to precision limits
            #endregion

            #region 4. Write C# program that Extract a substring from a given string.
            //string text = "coding in c#";
            //string substring = text.Substring(1, 5);
            //Console.WriteLine(substring);
            #endregion

            #region 5. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen.
            //int a = 0;
            //int b = a;
            //b = 9;

            //Console.WriteLine($"a = {a}, b = {b}");

            // What happens: a = 0, b = 9. variable a doesn't get changed because value types are stored in the stack,
            // and each variable has its own independent copy.

            #endregion

            #region 6. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen.
            //string[] arr1 = {"A", "B", "C" };
            //string[] arr2 = arr1;
            //arr2[0] = "M";

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            // What Happens: both are stored as "M" because arrays are reference types, 
            // So arr1 and arr2 point at the same address in memory

            #endregion

            #region 7. Write C# program that take two string variables and print them as one variable 
            //string text1 = "A B C ";
            //string text2 = "D E F ";
            //string fullText = text1 + text2;
            //Console.WriteLine(fullText);
            #endregion


            //MCQ Section:
            #region 8. Which of the following statements is correct about the C#.NET code snippet given below?
            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            // b) A value 1 will be assigned to d.
            #endregion

            #region 9. Which of the following is the correct output for the C# code given below?
            // Console.WriteLine(13 / 2 + " " + 13 % 2); 
            // d) 6 1
            #endregion

            #region 10. What will be the output of the C# code given below?
            //int num = 1, z = 5;


            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            // output 7 7
            #endregion



        }
    }
}
