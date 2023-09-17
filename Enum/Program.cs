using Enum;

Console.WriteLine("Enum");

//Console.WriteLine(DiasDasemana.Sabado);
//Console.WriteLine(DiasDasemana.Segunda);

//int dia1 = (int)DiasDasemana.Sabado;
//int dia2 = (int)DiasDasemana.Segunda;
//int dia3 = (int)DiasDasemana.Domingo;



//Console.WriteLine(dia1);
//Console.WriteLine(dia2);
//Console.WriteLine(dia3);


Console.WriteLine("Selecione uma categoria");
Console.WriteLine($"{Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes}");
Console.WriteLine($"{Categorias.Eletronicos}");
Console.WriteLine($"{Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos}");

int valor = Convert.ToInt32(Console.ReadLine());
var nomeEnum = (Categorias)valor;

Console.WriteLine($"Você selecionou a categoria: {nomeEnum.ToString()}");
Console.ReadKey();
