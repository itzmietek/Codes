using System; 

public class Program 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Witaj!");
        Console.WriteLine("Podaj swoją wagę (w kg):");
        double waga = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj swój wzrost (w metrach):");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = waga / (wzrost * wzrost);
        double roundedBmi = Math.Round(bmi, 2); 

        Console.WriteLine($"Your Bmi is: {roundedBmi}");

        if (roundedBmi < 18.5) 
        {
            Console.WriteLine("Bmi too low by " + Math.Round((18.5 - roundedBmi), 2));
        } 
        else if (roundedBmi >= 18.5 && roundedBmi <= 25) 
        {
            Console.WriteLine("good weight");
        } 
        else 
        {
            Console.WriteLine("Bmi too high by " + Math.Round((roundedBmi - 25), 2));
        }
    }
}
