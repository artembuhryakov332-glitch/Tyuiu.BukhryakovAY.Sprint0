using Tyuiu.BukhryakovAY.Sprint0.Task4.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DataService.Addition(10, 2));
        Console.WriteLine(DataService.Subtruction(7, 2));
        Console.WriteLine(DataService.Multiplication(15, 3));
        Console.WriteLine(DataService.Division(10, 2));
        Console.ReadKey();
    }
}