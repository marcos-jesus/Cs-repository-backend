﻿Console.WriteLine("Palavra This");

Teste t1 = new Teste();

t1.Num1 = 10;
t1.Num2 = 20;
t1.Exibir();

Teste t2 = new Teste();
t2.Num1 = 30;
t2.Num2 = 40;
t2.Exibir();

Console.ReadKey();


public class Teste
{
    public int Num1;
    public int Num2;

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\n this = {this}");
        Console.WriteLine("Num1: "+ t.Num1);
        Console.WriteLine("Num2: "+t.Num2);
    }

    public void Exibir()
    {
        PassarParametro(this);
    }
}