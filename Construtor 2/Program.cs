Console.WriteLine("Construtor 2");

Aluno aluno = new Aluno("Marcos", 23, "Masculino", "S");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "Zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public Aluno(string nome) => Nome = nome;

    public Aluno(string nome, int idade, string sexo, string aprovado):this(nome)
    {
        this.Idade = idade;
        this.Sexo = sexo;
        this.Aprovado = aprovado;
    }
}
