Console.WriteLine("Métodos");

Aluno aluno = new();
aluno.Consultar();

Console.ReadKey();



public class Aluno
{
    public string? nome;
    public int idade;
    public char sexo;
    public string? aprovado;
    
    public void Consultar()
    {
        var aluno = new Aluno();

        Console.WriteLine("Nome: ");
        aluno.nome = Console.ReadLine();
        Console.WriteLine("Idade: ");
        aluno.idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo");
        aluno.sexo = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Aprovado (S)im (N)ão: ");
        aluno.aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);

    }
}


public class Curso
{
    public void Resultado(Aluno aluno)
    {

        Console.WriteLine($"\n O aluno {aluno.nome}, sexo {aluno.sexo} com {aluno.idade} anos");

        if (aluno.aprovado == "S")
        {
            Console.WriteLine("\n foi Aprovado");
        } else
        {
            Console.WriteLine("\n foi Reprovado");
        }
    }
}

