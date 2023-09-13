Console.WriteLine("Passando argumento por Out");
Console.WriteLine();


Circulo calcula = new();
Console.WriteLine("Informe o Circulo");
double raio = Convert.ToDouble(Console.ReadLine());
double perimetro = calcula.CalculaPerimetroArea(raio, out double area);

Console.WriteLine($"O Valor do perimetro é: {perimetro}");
Console.WriteLine($"O Valor da área é: {area}");

Console.ReadKey();

public class Circulo
{
    public double CalculaPerimetroArea(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
