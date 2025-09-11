using DotNet.Models;

Pessoa p = new Pessoa();
p.Nome = "Neto";
p.Idade = 23;

p.Apresentar();

DateTime dataAtual = DateTime.Now;

Console.WriteLine($"E são:  {dataAtual.ToString("HH")} Horas e {dataAtual.ToString("mm")} Minutos");