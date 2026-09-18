namespace sharp;

public class Test
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter a number №2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Умножение: " + number * number2);
    }
}