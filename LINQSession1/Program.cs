using LINQSession1.Data;
using System.Linq;

namespace LINQSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicite Type Local Variable 
            #region Var [Most recomended]
            //var Name = "Sara";
            ////var x = null; // invalid
            //Name= null; // valid
            ////var y; // invalid
            #endregion
            #region Dynamic
            //dynamic Data = "Ali";
            //Data = 5;
            //Data= true;
            //Data = 20.20;
            //dynamic x;
            //dynamic y=null;
            //Console.WriteLine(Data);
            #endregion

            #endregion
            #region Extension Method
            //int x = 12345;
            ////Console.WriteLine(IntExtention.Reverse(x));
            //int y=x.Reverse();
            //Console.WriteLine(y);


            #endregion
            #region Anonymous Type
            ////Employee employee = new Employee() {id=10, name="Ali", salary=9000};
            ////object Emp01= new { id = 10, name = "Ali", salary = 9000 };
            ////Anonymous Type
            //var Emp02= new { id = 10, Name = "Ali", salary = 9000 };
            //Console.WriteLine(Emp02.salary);
            //Console.WriteLine(Emp02.GetType().Name);
            //var Emp03= new { Id =Emp02.id,Name=Emp02.Name, Salary=4000};
            //Console.WriteLine(Emp03.GetType().Name);
            //var Emp04 = new { id = 10, Name = "sara", salary = 9000 };

            //Console.WriteLine(Emp04.GetType().Name);
            //var Emp05 = new { id = 10, Name = "Mohamed", salary = 9000 , age=24};

            //Console.WriteLine(Emp05.GetType().Name);
            #endregion
            #region LINQ
            //List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //List<int> OddNums = Numbers.Where(N  => N%2==1).ToList();
            //foreach (int n in OddNums) { 
            //    Console.WriteLine(n);
            //}
            #endregion
            #region LINQ Syntax
            #region Fluent Syntax
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //1.Call LINQ Operator as Static Method
            //var OddNums = Enumerable.Where(Numbers, N => N % 2 == 1);
            //foreach (int n in OddNums)
            //{
            //    Console.WriteLine(n);
            //}
            //2.Call LINQ Operator as Extention Method
            //var OddNums = Numbers.Where(N => N % 2 == 1);
            //foreach (int n in OddNums)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region Query Syntax
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNums=from N in Numbers
            //            where N%2==1
            //            select N;
            //foreach (int n in OddNums)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion
            #endregion
            #region LINQ Execution Ways
            #region Deferred Execution
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNums = Numbers.Where(N => N % 2 == 1);
            //Numbers.AddRange(new int []{ 11,12,13,14,15});
            //foreach (int n in OddNums)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region Immediate Execution

            #endregion
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNums = Numbers.Where(N => N % 2 == 1).ToList();
            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //foreach (int n in OddNums)
            //{
            //    Console.WriteLine(n);
            //}
            //Casting , Aggregate , Elements Operators
            #endregion
            #region Data Setup
            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.CustomerList[0]);

            #endregion
            #region Filteration Operators
            //where operator
            //deferred Exec
            #region Get Elements Out of Stock
            //var Result = ListGenerator.ProductList.Where(p => p.UnitsInStock == 0);
            //Result= from P in ListGenerator.ProductList
            //        where P.UnitsInStock == 0
            //        select P;
            //foreach (var Unit in Result) {
            //    Console.WriteLine(Unit);
            //}

            #endregion
            #region Get Products In Stock and In Category "meat"
            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");
            //Result=from P in ListGenerator.ProductList
            //       where P.UnitsInStock > 0 &&  P.Category == "Meat/Poultry"
            //       select P;
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Get from 10 products The products are out of stock
            //indexes where
            //var Result = ListGenerator.ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #endregion
            #region Ordering Opertators
            #region Get Products Ordered By Price Asc
            ////Fluent
            //var ResuLt = ListGenerator.ProductList.OrderBy(P => P.UnitPrice);
            ////query
            //ResuLt=from P in ListGenerator.ProductList
            //       orderby P.UnitPrice
            //       select P;
            //foreach (var Unit in ResuLt)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Get Products Ordered By Price DESC
            ////Fluent
            //var ResuLt = ListGenerator.ProductList.OrderByDescending(P => P.UnitPrice);
            ////query
            //ResuLt = from P in ListGenerator.ProductList
            //         orderby P.UnitPrice descending
            //         select P;
            //foreach (var Unit in ResuLt)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Get Products Ordered By Price Asc & number of items in stock
            ////Fluent
            //var ResuLt = ListGenerator.ProductList.OrderBy(P => P.UnitPrice).ThenBy(P=>P.UnitsInStock);
            ////query
            //ResuLt = from P in ListGenerator.ProductList
            //         orderby P.UnitPrice, P.UnitsInStock
            //         select P;
            //foreach (var Unit in ResuLt)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion


            #endregion
            #region Transformation (projection) Operators
            #region Get Product Name
            //var Result = ListGenerator.ProductList.Select(P => P.ProductName);
            //Result = from P in ListGenerator.ProductList
            //         select P.ProductName;
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Get Customer Name
            //var Result = ListGenerator.CustomerList.Select(P => P.CustomerName);
            //Result = from P in ListGenerator.CustomerList
            //         select P.CustomerName;
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Get Customer Orders
            //var Result = ListGenerator.CustomerList.SelectMany(P => P.Orders);
            //Result = from c in ListGenerator.CustomerList
            //         from o in c.Orders
            //         select o;


            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Get Product Id and Product Name
            //var Result = ListGenerator.ProductList
            //    .Select(P => new { ProductID = P.ProductID, ProductName= P.ProductName});
            //Result = from P in ListGenerator.ProductList
            //         select new
            //         {
            //             ProductID = P.ProductID,
            //             ProductName = P.ProductName
            //         };

            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion
            #region Get Product in Stock and Apply Discount 10%
            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0)
            //    .Select(P => new 
            //    { ID=P.ProductID, 
            //        ProductName=P.ProductName, 
            //        OldPrice=P.UnitPrice,
            //        NewPrice=P.UnitPrice-(P.UnitPrice*0.1M)
            //    });
            ////Query syntax
            //Result = from P in ListGenerator.ProductList
            //         where P.UnitsInStock > 0
            //         select new
            //         {
            //             ID = P.ProductID,
            //             ProductName = P.ProductName,
            //             OldPrice = P.UnitPrice,
            //             NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //         };


            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Unit);
            //}
            #endregion

            #endregion
            #region Element Operators
            //immediate execution
            //first
            //var Result = ListGenerator.ProductList.First();
            //var Result = ListGenerator.ProductList.Last();

            //var Result = ListGenerator.ProductList.FirstOrDefault();
            //var Result = ListGenerator.ProductList.LastOrDefault(P=>P.UnitsInStock==0);


            //************************************
            //ElementAt() | ElementAtDefault()
            //var Result = ListGenerator.ProductList.ElementAt(0);

            //var Result = ListGenerator.ProductList.ElementAtOrDefault(0);
            //single() | singleOrDefault()  (self_study)
            //var Result = ListGenerator.ProductList.Single(p => p.ProductID == 1);
            //var Result = ListGenerator.ProductList.SingleOrDefault(p => p.ProductID == 1);

            //var Result = (from P in ListGenerator.ProductList
            //             where P.UnitsInStock == 0
            //             select new
            //             {
            //                 ID = P.ProductID,
            //                 ProductName = P.ProductName,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - (P.UnitPrice * 0.1M)
            //             }).FirstOrDefault();


            //Console.WriteLine(Result);
            #endregion
        }
    }
}