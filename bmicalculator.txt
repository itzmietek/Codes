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

        Console.WriteLine($"Twoje BMI wynosi: {roundedBmi}");

        if (roundedBmi < 18.5) 
        {
            Console.WriteLine("BMI za małe o " + Math.Round((18.5 - roundedBmi), 2));
        } 
        else if (roundedBmi >= 18.5 && roundedBmi <= 25) 
        {
            Console.WriteLine("Waga prawidłowa");
        } 
        else 
        {
            Console.WriteLine("BMI za duże o " + Math.Round((roundedBmi - 25), 2));
        }
    }
}
