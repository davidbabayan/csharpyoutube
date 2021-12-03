public class Greeting
{
    public static void Welcome()
    {
        string text = System.IO.File.ReadAllText(@"Messages\Welcome.txt");
        System.Console.WriteLine("\n");
        System.Console.WriteLine(text);
        System.Console.WriteLine("\n");
        System.Console.WriteLine("---------------------------------------------------------------------------");
        System.Console.WriteLine("\n");
    }

    public static void Bye()
    {
        string text = System.IO.File.ReadAllText(@"Messages\Bye.txt");
        System.Console.WriteLine("\n");
        System.Console.WriteLine("---------------------------------------------------------------------------");
        System.Console.WriteLine("\n");
        System.Console.WriteLine(text);
    }
}