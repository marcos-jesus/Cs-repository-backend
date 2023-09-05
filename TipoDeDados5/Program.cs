Console.WriteLine("Definindo DateTime");
Console.WriteLine();

DateTime dataAtual = DateTime.Now;

Console.WriteLine($"Hoje: {dataAtual}\n");

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);

// adicionando valores

Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(9));
Console.WriteLine(dataAtual.AddYears(5));

// obter o dia da semana e do ano

Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

Console.ReadKey();