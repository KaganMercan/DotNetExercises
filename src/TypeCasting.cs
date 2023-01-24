using System;

namespace DotNetExercises.src
{
    public class TypeCasting
    {
        public static void cast()
        {
            // Implicit Conversion(Bilinçsiz dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);
            // Explicit Conversion(Bilinçli dönüşüm)
            int k = 4;
            byte l = (byte)k;
            // ToString 
            int x = 6;
            string y = x.ToString();
            Console.WriteLine("y: " + y);
        }
    }
}
