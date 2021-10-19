using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine("remainder = " + remainder);
            Console.WriteLine("quotient = " + quotient);
            
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
            else
            {
                Console.WriteLine("Use the correct variables.");
            }




        }
     

    }
}
