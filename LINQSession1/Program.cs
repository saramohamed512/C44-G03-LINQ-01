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
        }
    }
}