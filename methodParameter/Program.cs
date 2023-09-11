Console.WriteLine("#Método com Parametro");


Calculadora calc = new Calculadora();

var valor = calc.Subtrair(10,10);

Console.WriteLine(valor);

Console.ReadKey();
class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    } public int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    } public int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    } public int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }

}
