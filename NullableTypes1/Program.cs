internal class Program
{
    private static void Main(string[] args)
    {

        int? b = null;

        if(b.HasValue)
        {
            Console.WriteLine($"b = {b.Value}");
        }else
        {
            Console.WriteLine("b não possui um valor");
        }

        bool calc = !(9 != 8) && (5 >= 7 || 8 >= 6);

        if(calc)
        {
            Console.WriteLine(calc);
        }else
        {
            Console.WriteLine("False");
        }
        Console.ReadKey();
    }
}