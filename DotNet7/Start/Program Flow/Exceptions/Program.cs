using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 600;
            int y = 10;
            int result;

            // TODO: try-catch expressions make error checking easier
            try {
                if(x > 1000){
                    throw new ArgumentOutOfRangeException("x", "x must be less than 1000");
                }
                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            }
            catch(DivideByZeroException e){
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e){
                Console.WriteLine("1000 is the limit");
                Console.WriteLine(e.Message);
            }
            finally{

            }
        }
    }
}
