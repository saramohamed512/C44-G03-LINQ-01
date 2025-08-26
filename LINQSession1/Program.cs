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
        }
    }
}