Console.WriteLine("Ternário e Uniario");

//Console.WriteLine("Informe o número \n");

//var n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"O negativo de {n} é {-n}");


//Console.WriteLine("Informe o temperatura: \n");
//var temp = Convert.ToDouble(Console.ReadLine());

//var resultado = temp > 27 ? "Quente" : "Normal";
//Console.WriteLine($"O tempo está: {resultado}");

Console.WriteLine("Informe o valor de X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de Y");
int y = Convert.ToInt32(Console.ReadLine());

string? status1 = null;

Console.WriteLine($"Status: {status1}");

string resultado = 
       x > y ? "X é maior que Y" : 
       x < y ? "X é menor que Y" : 
       x == y ? "X é igual a Y" : "Sem resultado";
Console.WriteLine(resultado);

Console.ReadKey();
