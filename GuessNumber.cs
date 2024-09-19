using System; 

public class Program 
{
    public static void Main(string[] args) 
    {
        Random random = new Random();
        int n = random.Next(1, 10);
        Console.WriteLine("guess the drawn number between 1 and 10");
        int t = int.Parse(Console.ReadLine());
        if (t == n)
        {
            Console.WriteLine("you guessed correctly");
        }
        else if (t>10)
        {
            Console.WriteLine("Number is bigger than 10");
        }
        else
        {
            Console.WriteLine("you guessed wrong");
        }
        Console.WriteLine("Random number were : " + n);
    }
}
