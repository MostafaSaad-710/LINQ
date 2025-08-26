using System.Collections;
using System.Linq;
using static LINQ.ListGenerator;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicity-Type Local Variables [var - dynamic]

            //// Implicity-Type Local Variables [var - dynamic]

            //// var
            //var Data01 = "Ahmed";

            //// Compiler Can Detect The Datatype Of The Local Variable Based On Initial Value
            //// Must Be Initialized
            //// Can't Initialize The Local Variable With Null
            //// Can't Change Datatype of The Local Variable After Initialization
            //// Can't Use var as Parameter Or Return Type

            ////Data01 = 12; // Invalid

            //// dynamic: Like var in JS

            //dynamic Data02 = null;

            //// CLR Detect The Datatype Of The Local Variable Based On Last Value, At Runtime
            //// Don't Need To Be Initialized
            //// Can Initialize The Local Variable With Null
            //// Can Change Datatype Of The Local Variable After Initialization
            //// Can use dynamic Keyword as Parameter Or Return Type
            //// Be Careful When Use Dynamic
            //// Like var in JS Or Object in C#

            ////Console.WriteLine(Data02.GetType().Name);

            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4f;
            //Console.WriteLine(Data02.GetType().Name); 

            //var X = () => Console.WriteLine("hello");
            //var Y = delegate (){ Console.WriteLine("hello"); };

            #endregion

            #region Anonymous Type
            ////Anonymous Type

            ////Employee E01 = new Employee() { Id = 1 , Name = "Ahmed" , Salary = 1200};

            //var E01 = new { Id = 1, Name = "Ahmed", Salary = 1200.0m };
            //var E02 = new { Id = 2, Name = "Ahmed", Salary = 1200.0m };
            //var E03 = E02 with { Id = 3 };

            //////Console.WriteLine( E01.Id);
            //////Console.WriteLine( E02.Name);

            //////E01.Id = 2; // invalid : immutable Can't change its vlue after creation

            ////Console.WriteLine(E01.GetType().Name);  // <>f__AnonymousType0`3
            ////Console.WriteLine(E02.GetType().Name);  // <>f__AnonymousType0`3

            ////// the same anonymous Type as long as :
            ////// 1. the same property name [case sensitive]
            ////// 2. the same property order

            ////Console.WriteLine( E01); //{ Id = 1, Name = Ahmed, Salary = 1200,0 }
            ////Console.WriteLine( E02); //{ Id = 2, Name = Ahmed, Salary = 1200,0 }
            ////Console.WriteLine( E03); //{ Id = 3, Name = Ahmed, Salary = 1200,0 }
            ////// compiler will be override on ToString

            //Console.WriteLine(E01.GetHashCode()); //compiler will be override on GetHashCode
            //Console.WriteLine(E02.GetHashCode());

            //if(E01.Equals(E02)) //compiler will be override on Equale (compare values no ref)
            //    Console.WriteLine( "E01 == E02");
            //else 
            //    Console.WriteLine( "E01 != E02"); 
            #endregion

            #region Extension method
            //// Extension method : method cereated in someclass and i can use it in onuther class 

            //int number = 12345;

            //var res01 = intExtenstion.Reverse(number);

            //var res02 = number.Reverse(); // Extension method

            //Console.WriteLine(res01);  // 54321
            //Console.WriteLine(res02);  // 54321 
            #endregion

            #region What is LINQ
            // LINQ: Language Integrated Query
            //        : 40+ Extension Methods (LINQ Operators) Against Any Data [Data in Sequence]
            //        : Regardless Data Store
            //        : 13 Category
            //        : LINQ Operators Exists in Built-in Class "Enumerable"

            // Sequence : Object From Class Implement Interface "IEnumerable"
            // Local Sequence  : L2O, L2XML
            // Remote Sequence : L2EF

            // Input Sequence -> LINQ Operator -> Output Sequence
            // Input Sequence -> LINQ Operator -> One Value
            //                  -> LINQ Operator -> Output Sequence

            #endregion

            #region LINQ Sentax
            // LINQ Sentax

            // 1. Fluent Syntax

            // Use LINQ Methods

            //// 1.1. LINQ Operator as => Class Member Method through class "Enumerable"

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var res = Enumerable.Where(nums, X => X % 2 == 0);

            //foreach (var item in res)
            //{
            //    Console.Write( $"{item} ");
            //}

            //// 1.2. LINQ Operator as => Extension Method through secuance [Recommended]

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var res = nums.Where(X => X % 2 == 0);

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");
            //}

            //// 2. Query Sentax [Query Expression] Like SQL Style
            //// Start from
            //// End select , group by
            //// Query Sentax easier than Fluent (Join , Group by , Let , Into)

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var res = from N in nums
            //          where N % 2 == 0
            //          select N;

            //foreach (var item in res)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region LINQ Execution Ways

            //: LINQ Execution Ways
            // 1. Differed Execution Way   : 10 Category
            // 2. Immediate Execution Way  : 3 Category [Elements Operator, Casting Operators, Aggregate Operators]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0); // Differed

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result) // here
            //{
            //    Console.Write("item ");
            //

            //List<int> Numbers = new List<int>()  {1, 2, 3, 4, 5, 6, 8, 9, 10} ;

            //var result = Numbers.Where(X => X % 2 == 0).ToList(); //Immediate


            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result)
            //{ Console.Write("{item} "); }



            #endregion

            // LINQ : 40+ Extension Methods
            // LINQ : 13 Category

            #region 1. Filteration Operator - Where / OfType

            ////-------- Where ---------
            ////========================

            //EX: All Priduct out stock 

            ///// Fluent sentax 
            //var result = ProductList.Where(P => P.UnitsInStock == 0);


            //// Query sentax [Query Expresion]

            //var result = from p in ProductList
            //             where p.UnitsInStock ==0
            //             select p;

            ////EX: Category is Meat/Poultry


            //var result = ProductList.Where(p => p.Category == "Meat/Poultry");

            //var result = from p in ProductList
            //             where p.Category == "Meat/Poultry"
            //             select p;


            ////EX: Category is Meat/Poultry and UnitsInStock > 0

            //var result = ProductList.Where(p => p.Category == "Meat/Poultry" && p.UnitsInStock > 0) ;

            //var result = from p in ProductList
            //             where p.Category == "Meat/Poultry" && p.UnitsInStock > 0
            //             select p;


            //var result = ProductList.Where((P, index) => index < 10 && P.UnitsInStock == 0);
            //var result = ProductList.Where((P, index) => index < 5);
            //var result = ProductList.Where((P, index) => index < 10 && P.UnitsInStock == 0);
            //var result = ProductList.Where(p => p.UnitsInStock > 0).Where((p,i) => i < 5);
            // Indexed where valid only in fluent syntax
            // can't be written using Query sentax [Query Expresion]


            ////-------- OfType ---------
            ////=========================

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3f, ProductList[0] , ProductList[1] };

            //var result = arrayList.OfType<float>();





            //foreach (var item in result)
            //{
            //    Console.WriteLine(item );
            //}


            #endregion

            #region 2. Transformation Operator - Select / SelectMany
            // 2.Transformation Operator - Select / SelectMany

            //var result = ProductList.Select(p => p.ProductName);
            //var result = ProductList.Select(p => p.ProductName , p.ProductID); // this invalid 
            //var result = ProductList.Select(p => { return p.ProductName; });   // native code => i can't return more one value. 

            ////Fluent Sentax
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Seafood")
            //                        .Select(p => new
            //                        {
            //                            Name = p.ProductName,
            //                            p.Category,
            //                            OldPrice = p.UnitPrice,
            //                            NewPrice = p.UnitPrice - p.UnitPrice * 0.1M

            //                        });


            ////Query Sentax
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Seafood"
            //             select new
            //             {
            //                 Name = p.ProductName,
            //                 p.Category,
            //                 OldPrice = p.UnitPrice,
            //                 NewPrice = p.UnitPrice - p.UnitPrice * 0.1M

            //             };

            //-------- SelectMany ---------
            //=============================


            //////var result = CustomerList.Select(C => C.CustomerName);
            //////var result = CustomerList.Select(C => C.Orders); // if one the property is sequence when use select, reselt will be name space.
            //var result = CustomerList.SelectMany(C => C.Orders);                                             // 

            ////var result = from c in CustomerList
            ////             from o in c.Orders
            ////             select o;


            //// Indexed Select valid only in fluent syntax
            //// can't be written using Query sentax [Query Expresion]
            //var result = ProductList.Select((p, i) => new { i, p.ProductName }).Where(p => p.i < 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Ordering Operator 

            //Sorting

            //var result = ProductList.Where(p => p.Category == "Meat/Poultry" && p.UnitsInStock > 0)
            //                        .OrderBy(p => p.UnitsInStock)
            //                        .ThenByDescending(p => p.UnitPrice)
            //                        .Select(p => new
            //                        {
            //                            p.ProductName,
            //                            p.UnitPrice,
            //                            p.UnitsInStock
            //                        });


            //Note: ThenBy work only with data from OrderBy.

            //var result = from p in ProductList
            //             orderby p.UnitPrice descending , p.UnitsInStock
            //             where p.Category == "Meat/Poultry" && p.UnitsInStock > 0
            //             select new {
            //                 p.ProductName,
            //                 p.UnitPrice,
            //                 p.UnitsInStock

            //             };


            //var result = ProductList.Reverse<Product>();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region 4. Element Operator - Immediate Execution

            //ProductList = new List<Product>();



            //var result = ProductList.First(); //Mat throw Excution [Sequence contains no elements]
            //var result = ProductList.Last(); //Mat throw Excution [Sequence contains no elements]

            //var result = ProductList.First(p => p.UnitsInStock == 1000); //May throw Excution [Sequence contains no matching element]
            //var result = ProductList.Last(p => p.UnitsInStock == 0); //Mat throw Excution [Sequence contains no matching element]


            // return null replace throw Excution 

            //var result = ProductList.FirstOrDefault(); 
            //var result = ProductList.FirstOrDefault(new Product() { ProductName = "Defulte Product" });
            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000);
            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000 , new Product() { ProductName = "Defulte Product" } );


            //var result = ProductList.LastOrDefault(); 
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Defulte Product" });
            //var result = ProductList.LastOrDefault(p => p.UnitsInStock == 1000);
            //var result = ProductList.LastOrDefault(p => p.UnitsInStock == 1000, new Product() { ProductName = "Defulte Product" });


            //------- Single -------
            //=======================


            //ProductList = new List<Product>() { new Product() { ProductName = "hamada" } };

            //var result = ProductList.Single(); // May throw Exeption
            ////Sequence contains no elements
            //// Sequence contains more than one element


            //var result = ProductList.Single(p => p.UnitsInStock == 0); // May throw Exeption
            //// Sequence contains no matching element
            //// Sequence contains more than one matching element

            //------- Single -------
            //======================

            // Overload number 1
            //var result = ProductList.SingleOrDefault(); // May throw Exeption
            //// Sequence contains more than one matching element
            //// return defulte value [null] if sequence id Empty


            // Overload number 2
            //var result = ProductList.SingleOrDefault(new Product() { ProductName = "Defulte Product" }); // May throw Exeption
            //// Sequence contains more than one matching element
            //// return defulte value [new Product() { ProductName = "Defulte Product" }] if sequence id Empty


            // Overload number 3
            //var result = ProductList.SingleOrDefault(p => p.UnitsInStock == 0); // May throw Exeption
            //// Sequence contains more than one matching element
            //// return defulte value [null] if sequence id Empty

            // Overload number 4
            // var result = ProductList.SingleOrDefault(p => p.UnitsInStock == 0, new Product() { ProductName = "Defulte Product" }); // May throw Exeption
            //var result = ProductList.SingleOrDefault(p => p.UnitsInStock == 1000, new Product() { ProductName = "Defulte Product" }); // May throw Exeption
            //// Sequence contains more than one matching element
            //// return defulte value [new Product() { ProductName = "Defulte Product" }] if sequence id Empty


            //Console.WriteLine(result?.ProductName?? "NA" );

            #endregion

            #region 5. Aggregate Operators - Immediate Execution
            #region Count
            //var Result = ProductList.Count();

            //Result = ProductList.Count;

            //Result = ProductList.Where(P => P.UnitsInStock == 0)
            //                    .Count();
            //Result = ProductList.Count(P => P.UnitsInStock == 0); 
            #endregion

            #region Max, MaxBy
            //var Result = ProductList.Max();
            //Result = ProductList.Max(new ProductComparer());
            //Result = ProductList.OrderByDescending(P => P.UnitPrice)
            //                    .FirstOrDefault();
            ////Result = ProductList.Max(P => P.UnitPrice);
            //Result = ProductList.MaxBy(P => P.UnitPrice); 
            #endregion

            #region Min, MinBy
            //var Result = ProductList.Min();
            //Result = ProductList.Min(new ProductComparer());
            //Result = ProductList.OrderBy(P => P.UnitsInStock)
            //                    .FirstOrDefault();
            ////Result = ProductList.Min(P => P.UnitsInStock);
            //Result = ProductList.MinBy(P => P.UnitsInStock); 
            #endregion

            #region Sum, Average
            //var Result = ProductList.Sum(P => P.UnitPrice);
            //var Result = ProductList.Average(P => P.UnitPrice); 
            #endregion

            #region Aggregate
            //string[] names = { "Omar", "Ahmed", "Mohamed", "Ibrahim" };
            //string message = "Hello";
            //var Result = names.Aggregate((result, name) => $"{result} {name}");

            //Result = names.Aggregate(message, (result, name) => $"{result} {name}");

            //Result = names.Aggregate(message, (result, name) => $"{result} {name}", (s) => s.Replace(" ", ",")); 
            #endregion

            //Console.WriteLine(Result); 
            #endregion

            #region 6. Casting Operators - Immediate Execution
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //Product[] arr = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> dict = ProductList.Where(P => P.UnitsInStock == 0)
            //                                            .ToDictionary(P => P.ProductID);

            //Dictionary<long, string> dict01 = ProductList.Where(P => P.UnitsInStock == 0)
            //                                             .ToDictionary(P => P.ProductID, P => P.ProductName);

            //HashSet<Product> set = ProductList.Where(P => P.UnitsInStock == 0)
            //                                  .ToHashSet();

            //ImmutableHashSet<Product> ImmSet = ProductList.Where(P => P.UnitsInStock == 0)
            //                                              .ToImmutableHashSet();

            //List<object> list1 = new List<object>()
            //{
            //    new Product() { ProductID = 100, ProductName = "Test" },
            //    9,
            //    new Order(){OrderDate = DateTime.Now, OrderID = 10358, Total = 196},
            //    new Product() { ProductID = 101, ProductName = "Test01" },
            //    "Hello",
            //    1.6,
            //    'c'
            //};

            //var Result = list1.OfType<Product>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 7. Generation Operators - Deffered Execution
            //var Result = Enumerable.Range(1, 100);

            //var Result = Enumerable.Repeat(new Product() { ProductID = 100, ProductName = "Test" }, 100);

            //var Result = Enumerable.Empty<Product>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 8. Set Operators - Union Family - Deffered Execution
            #region Example 01
            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(51, 100);

            //var Result = seq01.Union(seq02);

            //Result = seq01.Concat(seq02);

            //Result = Result.Distinct();

            //Result = seq01.Intersect(seq02);

            //Result = seq01.Except(seq02);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Example 02
            //var seq01 = new List<Product>()
            //{
            //    new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
            //    UnitPrice = 18.00M, UnitsInStock = 100},
            //    new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
            //    UnitPrice = 19.0000M, UnitsInStock = 17 },
            //    new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
            //    UnitPrice = 10.0000M, UnitsInStock = 13 }
            //};

            //var seq02 = new List<Product>()
            //{
            //    new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
            //    UnitPrice = 18.00M, UnitsInStock = 100},
            //    new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
            //    UnitPrice = 19.0000M, UnitsInStock = 17 },
            //    new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
            //    UnitPrice = 10.0000M, UnitsInStock = 13 },
            //    new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
            //    UnitPrice = 22.0000M, UnitsInStock = 53 },
            //    new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
            //    UnitPrice = 21.3500M, UnitsInStock = 0 }
            //};

            //var Result = seq01.Union(seq02);
            //var Result = seq01.Union(seq02, new ProductEqualityComparer());
            //Result = Result.Distinct(new ProductEqualityComparer());
            //Result = seq01.Intersect(seq02, new ProductEqualityComparer());
            //Result = seq01.Except(seq02, new ProductEqualityComparer());

            //Result = seq01.UnionBy(seq02, P => P.ProductID); // C# 10.0 Feature
            //Result = seq01.DistinctBy(P => P.ProductID);

            //List<long> ids = new List<long>() { 1, 2, 3 };
            //Result = seq01.IntersectBy(ids, P => P.ProductID);
            //Result = seq02.ExceptBy(ids, P => P.ProductID);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #endregion

            #region 9. Quantifier Operators - Return Boolean Value
            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(1, 100);

            //Console.WriteLine(ProductList.Any());
            //Console.WriteLine(ProductList.Any(P => P.UnitsInStock == 0));
            //Console.WriteLine(ProductList.Any(P => P.UnitsInStock > 150));
            //Console.WriteLine(ProductList.All(P => P.UnitsInStock == 0));
            //Console.WriteLine(ProductList.All(P => P.UnitsInStock > 0));
            //Console.WriteLine(seq01.SequenceEqual(seq02)); 
            #endregion

            #region 10. Zipping Operators 
            //List<string> words = new List<string>()
            //{
            //    "ten",
            //    "twenty",
            //    "thirty",
            //    "fourty"
            //};

            //int[] nums = { 10, 20, 30, 40, 50, 60 };

            ////var Result = words.Zip(nums);

            ////var Result = words.Zip(nums, new int[] { 1, 2, 3, 4 });

            //var Result = words.Zip(nums, (w, n) => $"{n} - {w}");

            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 11. Grouping Operators
            #region Example 01
            //// Query Syntax
            //var Result = from P in ProductList
            //             group P by P.Category;

            //// Fluent Syntax
            //Result = ProductList.GroupBy(P => P.Category);

            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach(var item2 in item)
            //    {
            //        Console.WriteLine($"\t{item2}");
            //    }
            //} 
            #endregion

            #region Example 2.1
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //                 into PrdGroup
            //             where PrdGroup.Count() > 10
            //             select PrdGroup;

            //Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                    .GroupBy(P => P.Category)
            //                    .Where(PrdGroup => PrdGroup.Count() > 10); 

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine($"\t{item2}");
            //    }
            //}
            #endregion

            #region Example 2.2
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into PrdGroup
            //             where PrdGroup.Count() > 10
            //             select new
            //             {
            //                 Category = PrdGroup.Key,
            //                 Count = PrdGroup.Count()
            //             };

            //Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                    .GroupBy(P => P.Category)
            //                    .Where(PrdGroup => PrdGroup.Count() > 10)
            //                    .Select(PrdGroup => new
            //                    {
            //                        Category = PrdGroup.Key,
            //                        Count = PrdGroup.Count()
            //                    }); 
            #endregion

            #region Example 2.3 [CountBy]
            //var Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                        .CountBy(P => P.Category)
            //                        .Where(G => G.Value > 10); 
            #endregion

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 12. Partitioning Operators
            #region Take, TakeLast, Skip, SkipLast
            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Take(5);

            //Result = ProductList.Where(P => P.UnitsInStock > 0).Take(new Range(4, 9));

            //Result = ProductList.Where(P => P.UnitsInStock > 0).TakeLast(5);

            //Result = ProductList.Where(P => P.UnitsInStock > 0).Skip(5);

            //Result = ProductList.Where(P => P.UnitsInStock > 0).SkipLast(5);

            //int PageSize = 10;
            //int PageIndex = 4;

            //Result = ProductList.Where(P => P.UnitsInStock > 0)
            //                    .Skip(PageSize * (PageIndex - 1))
            //                    .Take(PageSize);

            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region TakeWhile, SkipWhile
            ////                0  1  2  3  4  5  6  7  8
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2 };

            ////var Result = numbers.TakeWhile((n, i) => n > i);

            //var Result = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var n in Result)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion
            #endregion

            #region 13. let / into
            //List<string> names = new List<string>()
            //{
            //    "Omar",
            //    "Aly",
            //    "Mohamed",
            //    "Ahmed",
            //    "Mahmoud",
            //    "Ibrahim"
            //};

            // AOUIE
            // aouie

            #region into
            //var Result = from n in names
            //             select Regex.Replace(n, "[AOUIEaouie]", string.Empty)
            //             // Restart query with introducing range variable
            //             into NoVowelName
            //             where NoVowelName.Length > 3
            //             select NoVowelName; 
            #endregion

            #region let
            //var Result = from n in names
            //             // Continue query with add new range variable
            //             let NoVowelName = Regex.Replace(n, "[AOUIEaouie]", string.Empty)
            //             where NoVowelName.Length > 3
            //             select NoVowelName; 
            #endregion

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

        }
    }
}
