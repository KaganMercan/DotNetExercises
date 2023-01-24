namespace console_programming;

class Variables
{
    public static void variableTest()
    {
        // Example of primitive data types
        int exampleInteger = 10;
        decimal exampleDecimal = 4.00m;
        double exampleDouble = 3.00;
        float exampleFloat = 3.00f;

        // Primitive data type checker
        if (typeof(string).IsPrimitive == true)
        {
            Console.WriteLine("Primitive data type");
        }
        else
        {
            Console.WriteLine("Not a primitive data type");
        }
    }
}
