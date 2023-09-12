Console.WriteLine("Sobrecarga de métodos");

Email email = new Email();

email.Enviar("Rua Laurinda de Almeida");
email.Enviar("Rua Laurinda de Almeida", 1000);
email.Enviar(2000,"Rua Laurinda de Almeida");
email.Enviar("Rua Laurinda de Almeida", "Motivo de sobrecarga");
Console.ReadKey();

public class Email
{
    public void Enviar(string endereco )
    {
        Console.WriteLine($"Endereço: {endereco}");
    }public void Enviar(string endereco, decimal valor )
    {
        Console.WriteLine($"Endereço: {endereco}, Valor: {valor}");
    }public void Enviar(string endereco, string assunto )
    {
        Console.WriteLine($"Endereço: {endereco}, Assunto: {assunto}");
    }public void Enviar(decimal valor ,string endereco)
    {
        Console.WriteLine($"Endereço: {endereco}, valor: {valor}");
    }
}
