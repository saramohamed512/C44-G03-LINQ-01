namespace LINQSession1Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var outOfStock = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var product in outOfStock)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var expensiveInStock = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var product in expensiveInStock)
            //{
            //    Console.WriteLine($"{product.ProductName} - ${product.UnitPrice}");
            //}

            #endregion
            #region 3. Returns digits whose name is shorter than their value.
            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var shortNamedDigits = digits.Where((d, index) => d.Length < index);
            //foreach (var digit in shortNamedDigits)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var firstOutOfStock = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(firstOutOfStock?.ProductName);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var expensiveProduct = ListGenerator.ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine($"{expensiveProduct?.ProductName ?? "None"}");
            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondGreaterThan5 = numbers.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(secondGreaterThan5);
            #endregion
            #endregion
        }
    }
}