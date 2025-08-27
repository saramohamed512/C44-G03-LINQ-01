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
            #region LINQ - Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int oddCount = numbers.Count(n => n % 2 != 0);
            //Console.WriteLine(oddCount);
            #endregion
            #region 2. Return a list of customers and how many orders each has.
            //var customerOrderCounts = ListGenerator.CustomersList.Select(c => new { c.CustomerName, OrderCount = c.Orders.Count() });
            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine($" {customer.CustomerName}: {customer.OrderCount} orders");
            //}

            #endregion
            #region 3. Return a list of categories and how many products each has
            //var categoryCounts = ListGenerator.ProductsList.GroupBy(p => p.Category)
            //                       .Select(g => new { Category = g.Key, Count = g.Count() });
            //foreach (var category in categoryCounts)
            //{
            //    Console.WriteLine($" {category.Category}: {category.Count} products");
            //}
            #endregion
            #region 4. Get the total of the numbers in an array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = numbers.Sum();
            //Console.WriteLine(total);
            #endregion
            string[] words = File.ReadAllLines("dictionary_english.txt");
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //long totalCharacters = 0;

            //// Count characters in each word/line
            //foreach (string word in words)
            //{
            //    // Skip empty lines and any potential comments/metadata
            //    if (!string.IsNullOrWhiteSpace(word) && !word.StartsWith("[") && !word.StartsWith("//"))
            //    {
            //        totalCharacters += word.Trim().Length;
            //    }
            //}

            //Console.WriteLine($"Total number of characters: {totalCharacters}");
            #endregion
            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int shortest = words.Min(w => w.Length);
            //Console.WriteLine($"Shortest word length: {shortest}");
            #endregion
            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int longest = words.Max(w => w.Length);
            //Console.WriteLine($"Longest word length: {longest}");
            #endregion
            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //double average = words.Average(w => w.Length);
            //Console.WriteLine($"Average word length: {average:F2}");
            #endregion
            #endregion
        }
    }
}