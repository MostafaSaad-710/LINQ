using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Linq;
using static Assignment.ListGenerator;



namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators

            //// 1. Find all products that are out of stock.
            //var result = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Element Operators

            ////1.Get first Product out of Stock

            //var result = ProductList.First(p => p.UnitsInStock == 0);

            //Console.WriteLine( result);

            ////2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned

            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock > 1000);

            //Console.WriteLine(result?.ProductName?? "No Product Found");

            #endregion

            #region Aggregate Operators

            //// Q01
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(x => x % 2 == 1);
            //Console.WriteLine(result);

            //// Q02
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);

            //// Q04
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Sum(w => w.Length);
            //Console.WriteLine(result);

            //// Q04
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result = words.Min(w => w.Length);
            //Console.WriteLine(result);

            //// Q05
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q06
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //// Q08
            //var result = ProductList.GroupBy(p => p.Category)
            //                       .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Ordering Operators 

            //// Q01

            //var result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q02

            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q03

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.OrderBy(s => s.Length).ThenBy(s => s);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q04

            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            ////Q05

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(A => A.Length).ThenByDescending( A=> A.ToUpper());

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // Q06


            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where(A => A[1] == 'i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation Operators 

            //// Q01

            //var result = ProductList.Select(p => p.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q02

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select( w => new { Uper = w.ToUpper() , Lower = w.ToLower()});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q03

            //---------------------------------------------
            // I couldn’t solve it with the fluent syntax
            //----------------------------------------------

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.a} Is Less Than {item.b}");
            //}

            //// Q04

            //var result = CustomerList.SelectMany(C => C.Orders).Where(S => S.Total < 500.00m);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Set Operators

            //// Q01
            //var result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q02
            //var result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q03
            //var result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q04
            //var result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region LINQ - Partitioning Operators

            //// Q01
            //var result = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q02
            //var result = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Skip(2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q03
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((n, i) => n >= i);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //// Q04
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }
    }
}
