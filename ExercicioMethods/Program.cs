﻿Console.WriteLine("Exercicio Prático de Métodos");

Cadastro cadastro = new Cadastro();

var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

// Alterar Renda
cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda alterada", cliente);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente() { }
}

public class Cadastro
{
    public Cliente Registrar()
    {
        Cliente cliente = new("Marcos", 23, 7800);
        return cliente;
    }
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 12800;
        return cliente;
    }

    public void ExibirDados(Cliente cliente)
    {
        Console.WriteLine($"Cliente:{cliente.Nome} | Idade: {cliente.Idade} | Renda:" +
            $"{cliente.Renda.ToString("c")}");
    }

    public void ExibirDados(string texto, Cliente cliente)
    {
        Console.WriteLine($"\n {texto}\t");
        Console.WriteLine($"Cliente:{cliente.Nome} | Idade:{cliente.Idade} anos | Renda:{cliente.Renda.ToString("c")}");
    }
}