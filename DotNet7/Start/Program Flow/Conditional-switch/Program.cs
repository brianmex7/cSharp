using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 20;

            // TODO: The switch statement
            switch (theVal)
            {
                case 50:
                    Console.WriteLine("The number is 50");
                    break;
                case 40:
                    Console.WriteLine("The number is not 50");
                    break;
                case 30:
                    Console.WriteLine("The number isn't 50");
                    break;
                case 20:
                    Console.WriteLine("The number ain't 50");
                    break;
                case 10:
                case 0:
                    Console.WriteLine("The number isn't 50");
                    break;
                default:
                    Console.WriteLine("The number is something else");
                    break;
            }

        }
    }
}
