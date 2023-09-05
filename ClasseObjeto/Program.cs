internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Classe e Objeto");


        Pessoa p1 = new(); // => Objeto
        p1.nome = "Marcos";
        p1.idade = 23;
        p1.sexo = 'M';

        Console.WriteLine($"Nome: {p1.nome} - Idade: {p1.idade} -  Sexo: {p1.sexo} ");

        Pessoa p2 = new(); // => Objeto
        p2.nome = "Lúcia";
        p2.idade = 46;
        p2.sexo = 'F';

        Console.WriteLine($"Nome: {p2.nome} - Idade: {p2.idade} - Sexo: {p2.sexo}");
    }
}

class Pessoa
{
    // Atributos 
    public string? nome;
    public int idade;
    public char sexo;

}