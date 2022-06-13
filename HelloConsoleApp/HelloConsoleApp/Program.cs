using Humanizer;

namespace HelloDotnet
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello dotnet {args}");
            HumanizeQuantities();
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("Sum is equal = ", c);
        }


        static void HumanizeQuantities()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }
}