Console.WriteLine("Tipo Anônimo!");

//var aluno = new
//{
//    Nome = "Marcos",
//    Idade = 23
//};

//Console.WriteLine($"{aluno.Nome} tem {aluno.Idade} anos.");


var aluno = new
{
    Id = 1,
    Nome = "Marcos",
    Email = "marcosjesus@gmail.com",
    Endereco = new { Id = 1, Cidade = "Guarulhos", Pais = "Brasil" }
};

Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Endereco.Cidade);

Console.ReadKey();

// Propriedades em tipos anônimos são somente leitura.
// Não pode reatribuir valores para ele.
