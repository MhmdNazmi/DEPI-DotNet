using Day_01_G03;
using System.Threading;
namespace DEPI_Session12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ Restriction Operators

            #region 1. Find all products that are out of stock.

            /* Fluent Syntax */
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

            /* Query Syntax */
            //var result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock == 0
            //             select p;
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            /* Fluent Synatx */
            //var result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            /* Query Syntax */
            //var result = from p in ListGenerator.ProductsList
            //             where p.UnitsInStock > 0 && p.UnitPrice > 3
            //             select p;
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = arr.Where((word, index) => word.Length < index);
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            /* Fluent Syntax */
            //var result = ListGenerator.ProductsList
            //    .FirstOrDefault(p => p.UnitsInStock == 0);
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ListGenerator.ProductsList
            //    .FirstOrDefault(p => p.UnitPrice > 1000);
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Where(n => n > 5).ElementAt(1);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            //var count = arr.Count(n => n % 2 == 1);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var result = ListGenerator.CustomersList.Select(c => new
            //{
            //    c.CustomerName,
            //    OrderCount = c.Orders.Length
            //});
            #endregion

            #region 3. Return a list of categories and how many products each has  (missed)
            //var result = ListGenerator.ProductsList
            //    .GroupBy(c => c.Category)
            //    .Select(p => new
            //    {
            //        Category = p.Key,
            //        Count = p.Count()
            //    });
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = arr.Sum();
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            string[] words = File.ReadAllLines("dictionary_english.txt");

            //int totalChar = words.Sum(w => w.Length);
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int shortestWord = words.Min(w => w.Length);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int longestWord = words.Max(w => w.Length);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //double avgWords = words.Average(w => w.Length);
            #endregion

            #endregion // HERE

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name
            //var result = ListGenerator.ProductsList.OrderBy(p => p.ProductName);
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array. (missed)
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ListGenerator.ProductsList
            //    .OrderByDescending(p => p.UnitsInStock);
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = arr.OrderBy(s=> s.Length).ThenBy(s => s);
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array. (case-insensitive missed)
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = arr.OrderBy(s => s).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest
            //var result = ListGenerator.ProductsList.OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = arr.OrderBy(w => w.Length).ThenByDescending(w => w,
            //StringComparer.OrdinalIgnoreCase);
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = arr.Where(w => w[1] == 'i').Reverse();
            #endregion

            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var result = ListGenerator.ProductsList.Select(p => p.ProductName);
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new
            //{
            //    wUpper = w.ToUpper(),
            //    wLower = w.ToLower()
            //});
            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ListGenerator.ProductsList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice
            //});
            #endregion

            #region 4. Determine if the value of int in an array match their position in the array
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = arr.Select((value, index) => new
            //{
            //    Number = value,
            //    InPlace = value == index
            //});
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var result = ListGenerator.CustomersList.SelectMany(c => c.Orders).Where(o => o.Total < 500);
            #endregion


            #region 7. Select all orders where the order was made in 1998 or later.
            //var result = ListGenerator.CustomersList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            #endregion
            #endregion
        }
    }
}
