// See https://aka.ms/new-console-template for more information
using pooCalculaIdade;

Console.WriteLine("Programa que calcula a idade de uma pessoa!");
Pessoa p = new Pessoa();
Console.WriteLine("Nome da pessoa:");
p.Nome = Console.ReadLine();
Console.WriteLine("Ano de nascimento:");
p.AnoNascimento = Convert.ToInt32 (Console.ReadLine());
p.ExibirDados();
Console.ReadKey();
