Console.WriteLine("Construtor 1");


//Aluno aluno = new Aluno();

Aluno aluno = new Aluno("Marcos", 23, "Masculino", "S");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "Zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


Console.ReadKey();


//// Construtor é um tipo especial de método, sempre que invocar new o construtor será chamado.
//// Se não defirmos um construtor, ele criara um padrão por baixo dos panos, não possui retorno void nem nada.

//// Construtor Padrão com Classe Aluno
//public class Aluno
//{
//    // Construtor padrão ele fica oculto se não adicionarmos um. Possui mesmo nome da classe sem retorno.
//    //public Aluno();

//    public string? Nome;
//    public int Idade;
//    public string? Sexo;
//    public string? Aprovado;
//}


public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
    public Aluno(string nome, int idade, string sexo, string aprovado) 
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
}

