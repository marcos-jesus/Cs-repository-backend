Console.WriteLine("Try Catch");

Console.WriteLine("x / y");

Console.WriteLine("\n Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());


try
{
    int z = x / y;
    Console.WriteLine($"O valor de x / y é {z} ");
}
catch (Exception ex)
{
    Console.WriteLine($"\nNão existe divisão por zero, tente outro número");
    Console.WriteLine($"\n Erro: <<< {ex.Message}");
    Console.WriteLine($"\n Detalhes: {ex?.StackTrace?.ToString()}");
} finally
{
    Console.WriteLine("Em processamento...");
}
Console.ReadKey();