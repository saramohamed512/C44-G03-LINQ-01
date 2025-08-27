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
        }
    }
}