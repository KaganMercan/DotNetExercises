using System;

namespace DotNetExercises.src
{
    class Operators
    {
        public static void print()
        {
            // Logical Operators
            //  ||, &&, !
            bool isSuccess = false;
            bool isCompleted = false;

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("At least one of the boolean controllers is return true.");
            }
            else
            {
                Console.WriteLine("All boolean controllers are false.");
            }
            // Relational Operators
            //  <, >, <=, >=, ==, !=

            int var1 = 3;
            int var2 = 4;
            bool result = var1 < var2;
            Console.WriteLine(result);

            // Arithmetical Operators
            //  +, -, *, /
            int num1 = 10;
            int num2 = 11;
            Console.WriteLine(num1 * num2);
        }
    }
}
