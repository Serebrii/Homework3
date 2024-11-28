internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        try
        {
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Upisali ste broj N {n}");
        } catch(FormatException)
        {
            Console.WriteLine($"Ne upisali ste broj N(");
        }
        
    }
}