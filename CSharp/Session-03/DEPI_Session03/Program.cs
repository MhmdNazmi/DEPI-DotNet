using System;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DEPI_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Enter Number: ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region 2. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Insert integer: ");
            //int num;
            //int.TryParse(Console.ReadLine(), out num);
            //if (num < 0)
            //    Console.WriteLine("negative");
            //else
            //    Console.WriteLine("positive");
            #endregion

            #region 3. Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("You'll enter 3 numbers.");
            //int[] num = new int[3];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write($"Number {i+1}: ");
            //    int.TryParse ( Console.ReadLine(), out num[i] );
            //}
            //int max = num.Max();
            //int min = num.Min();

            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Min = {min}");

            #endregion

            #region 4. Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else {
            //    Console.WriteLine("Odd");
            //}
            #endregion

            #region 5. Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Console.Write("Enter a character: ");
            //char ch = char.ToLower(Console.ReadKey().KeyChar);
            //Console.WriteLine();

            //string vowels = "aeiou";

            //if (vowels.Contains(ch))
            //{
            //    Console.WriteLine("vowel");
            //}
            //else if (char.IsLetter(ch))
            //{
            //    Console.WriteLine("consonant");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            #endregion

            #region 6. Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region 7. Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("Enter number: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{n} x {i} = {n*i}");
            //}
            #endregion

            #region 8. Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter number: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region 9. Write a program that takes two integers then prints the power.
            //Console.Write("Enter base number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("Enter power number: ");
            //int power = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= power; i++)
            //{
            //    result *= num;
            //}

            //Console.WriteLine(result);
            #endregion

            #region 10. Write a program to enter marks of five subjects and calculate total, average and percentage.
            //int total = 0;

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Enter subject {i} grade: ");
            //    total += int.Parse(Console.ReadLine());
            //}

            //double average = total / 5.0;
            //double percentage = average;

            //Console.WriteLine($"Total = {total}");
            //Console.WriteLine($"Average = {average}");
            //Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region 11. Write a program to input the month number and print the number of days in that month.
            //Console.Write("Enter month number: ");
            //int month = int.Parse(Console.ReadLine());

            //// Modern C# switch expression with relational list matching
            //string days = month switch
            //{
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 => "31 Days",
            //    4 or 6 or 9 or 11 => "30 Days",
            //    2 => "28 or 29 Days",
            //    _ => "Invalid Month"
            //};

            //Console.WriteLine(days);
            #endregion

            #region 12. Write a program to create a Simple Calculator.
            //Console.Write("First number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Operator (+, -, *, /): ");
            //char opr = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("Second Number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //string result = opr switch
            //{
            //    '+' => $"{num1 + num2}",
            //    '-' => $"{num1 - num2}",
            //    '*' => $"{num1 * num2}",
            //    '/' => num2 != 0 ? $"{num1 / num2}" : "Can't divide by zero",
            //    _ => "Invalid Operator"
            //};

            //Console.WriteLine(result);
            #endregion

            #region 13. Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter text: ");
            //string text = Console.ReadLine();

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //}

            #endregion

            #region 14. Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    reversed = reversed * 10 + digit;
            //    num /= 10;
            //}

            //Console.WriteLine(reversed);

            #endregion

            #region 15. Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Start: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("End: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("Prime Numbers:");

            //for (int i = start; i <= end; i++)
            //{
            //    if (i < 2)
            //        continue;

            //    bool isPrime = true;

            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //        Console.Write(i + " ");
            //}
            #endregion

            #region 16. Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //string binary = "";

            //while (num > 0)
            //{
            //    binary = (num % 2) + binary;
            //    num /= 2;
            //}

            //Console.WriteLine(binary);
            #endregion

            #region 17. Create a program that asks the user to input three points (x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.
            //double ReadDouble(string label)
            //{
            //    Console.Write($"{label}: ");
            //    return double.Parse(Console.ReadLine());
            //}

            //double x1 = ReadDouble("x1"), y1 = ReadDouble("y1");
            //double x2 = ReadDouble("x2"), y2 = ReadDouble("y2");
            //double x3 = ReadDouble("x3"), y3 = ReadDouble("y3");

            //double area =
            //    x1 * (y2 - y3) +
            //    x2 * (y3 - y1) +
            //    x3 * (y1 - y2);

            //if (area == 0)
            //    Console.WriteLine("Points lie on a straight line");
            //else
            //    Console.WriteLine("Points do not lie on a straight line");

            #endregion

            #region 18. 
            /* ==========
                Within a company, the efficiency of workers is evaluated based on the
                duration required to complete a specific task. A worker's efficiency level
                is determined as follows:
                - If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
                - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
                - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
                - If the worker takes more than 5 hours, they are required to leave the company.
                To calculate the efficiency of a worker, the time taken for the task is
                obtained via user input from the keyboard.
                ==========
             */

            //Console.Write("Enter hours worked: ");
            //double hours = double.Parse(Console.ReadLine());

            //if (hours >= 2 && hours < 3)
            //    Console.WriteLine("Highly Efficient");
            //else if (hours >= 3 && hours < 4)
            //    Console.WriteLine("Increase Speed");
            //else if (hours >= 4 && hours < 5)
            //    Console.WriteLine("Training Required");
            //else if (hours >= 5)
            //    Console.WriteLine("Leave Company");
            //else
            //    Console.WriteLine("Invalid Input");
            #endregion

            #region 19. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n* n.
            //Console.Write("Enter Size: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region 20. Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Array size: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //int sum = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine($"Sum = {sum}");

            #endregion

            #region 21. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int size = 4;

            //int[] arr1 = {22, 64, 544, 98 };
            //int[] arr2 = {1, 55, 39, 71 };

            //int[] merged = new int[size * 2];
            //for (int i = 0; i < size; i++)
            //{
            //    merged[i] = arr1[i];
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    merged[size + i] = arr2[i];
            //}

            //Array.Sort(merged);

            //foreach (int value in merged)
            //{
            //    Console.Write($"{value} ");
            //}
            #endregion

            #region 22. Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = {1, 2, 3, 41, 1, 10, 2, 2, 41, 49 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool counted = false;

            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            counted = true;
            //            break;
            //        }
            //    }

            //    if (!counted)
            //    {
            //        int count = 0;

            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //                count++;
            //        }

            //        Console.WriteLine($"{arr[i]} occurs {count} times");
            //    }
            //}
            #endregion

            #region 23.Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("Size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];

            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine("Max = " + max);
            //Console.WriteLine("Min = " + min);
            #endregion

            #region 24. Write a program in C# Sharp to find the second largest element in an array.
            //Console.Write("Size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //foreach (int num in arr)
            //{
            //    if (num > largest)
            //    {
            //        secondLargest = largest;
            //        largest = num;
            //    }
            //    else if (num > secondLargest && num != largest)
            //    {
            //        secondLargest = num;
            //    }
            //}

            //Console.WriteLine("Second Largest = " + secondLargest);
            #endregion

            #region 25. Longest Distance Between Equal Cells
            //Console.Write("Size: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = size - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;

            //            if (distance > maxDistance)
            //                maxDistance = distance;

            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("Longest Distance = " + maxDistance);
            #endregion

            #region 26. Given a list of space separated words, reverse the order of the words.
            //Console.Write("Enter Sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');

            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i]);

            //    if (i > 0)
            //        Console.Write(" ");
            //}
            #endregion

            #region 27. Copy One 2D Array to Another
            //Console.Write("Rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];

            //Console.WriteLine("Enter Elements:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}

            //Console.WriteLine("Second Array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}
            #endregion

            #region 28. Write a Program to Print One Dimensional Array in Reverse Order
            //Console.Write("Size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Reversed Array:");

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
        }
    }
}
