namespace NetExceptionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if(Int32.TryParse(Console.ReadLine(), out int num))
            //    Console.WriteLine(num);

            //try
            //{
            //    int n = 10;
            //    int d = Int32.Parse(Console.ReadLine()!);
            //    int m = n / d;

            //    Console.WriteLine($"Operation!");
            //}
            //catch (DivideByZeroException e)
            //{

            //    Console.WriteLine($"Special Exception! {e.Message}");
            //}
            //catch(Exception e) 
            //{
            //    Console.WriteLine($"Exception! {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine($"Finally block");
            //}

            try
            {
                //Method();
                User user = new User();
                user.Age = -10;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine($"{ex.TargetSite}");
                Console.WriteLine($"{ex.StackTrace}");
            }

            

            Console.WriteLine($"Program work block");
        }

        static void Method()
        {
            int a = 100;
            int b = Int32.Parse(Console.ReadLine()!);

            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine($"{ex.TargetSite}");
                Console.WriteLine($"{ex.StackTrace}");
                //throw ex;
            }
            finally { Console.WriteLine(); }
        }
    }
}