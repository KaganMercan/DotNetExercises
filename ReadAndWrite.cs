namespace console_programming;
class ReadAndWrite
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter your surname: ");
        string? surname = Console.ReadLine();
        Console.WriteLine(name + " " +surname);
    }
}
