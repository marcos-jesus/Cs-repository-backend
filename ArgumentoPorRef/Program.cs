Console.WriteLine("Passagem de argumento por referencia (ref)");

int x = 20;
Console.WriteLine("\n Valor de x  antes do calculo " + x);

Calculo calculo = new Calculo();
calculo.Dobrar(ref x);
Console.WriteLine("\n Valor de x após o dobrar " + x);
Console.ReadKey();


public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine("\n Valor do parâmetro y no método dobrar " + y);
    }
}
