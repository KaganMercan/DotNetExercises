using System;

namespace DotNetExercises.src
{
    public class ErrorCatching
    {
        // TryCatch, Finally and Logical Errors
        public static void errorHandling()
        {
            // Use try for catch if there is an exception in our code block.
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("The number that you entered: " + number + "\n");
            }
            // Catch is for catching is exception.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            // Use finally program is throws error or not.
            finally
            {
                Console.WriteLine("Process Success");
            }
        }
    }
}
