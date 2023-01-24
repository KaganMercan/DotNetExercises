using System;

namespace DotNetExercises.src
{
    public class ReadAndWrite
    {
        public static void writelineMethod()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Enter name and surname: ");
            string? s = Console.ReadLine();
        }
    }
}