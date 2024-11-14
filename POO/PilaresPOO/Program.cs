// Herança
// Abstração
// Encapsulamento
// Polimorfismo

using PilaresPOO.Classes;



Console.WriteLine(@$"
+----------------------+
|   PROGRAMA PESSOA    |
+----------------------+
");


Pessoa aggy = new Pessoa();
aggy.Nome = "agatha";
Console.WriteLine($"{aggy.Nome} nasceu com {aggy.Idade} anos");




Console.WriteLine(@$"
+----------------------+
|    PROGRAMA ALUNO    |
+----------------------+
");


Aluno aura = new Aluno();
aura.Nome = "laura";
aura.Idade = 50;
aura.Peso = 80f;
aura.Altura = 1.60f;
aura.Cpf= "699.966.699-69";
aura.Matricula = 6969;
aura.Curso = "DEV";
aura.Media = 10f;

Console.WriteLine($"Dados do Aluno Exibido");

Console.WriteLine($"O aluno se chama: {aura.Nome}");
Console.WriteLine($"A idade do {aura.Nome}: {aura.Idade}");
Console.WriteLine($"O aluno tem o peso de: {aura.Peso}");
Console.WriteLine($"O aluno tem a altura de: {aura.Altura}");
Console.WriteLine($"CPF do aluno: {aura.Cpf}");
Console.WriteLine($"Aluno {aura.Nome}: {aura.Matricula}");
Console.WriteLine($"{aura.Nome} faz o curso de: {aura.Curso}");
Console.WriteLine($"A media do {aura.Nome} é: {aura.Media}");




Console.WriteLine(@$"
+------------------------+
|   PROGRAMA PROFESSOR   |
+------------------------+
");


Professor sam = new Professor(0707);
sam.Nome = "Samanta";
sam.Idade = 22;


Console.WriteLine($"Dados do Professor Exibido");

Console.WriteLine($"    Professor: {sam.Nome}");
Console.WriteLine($"    Idade: {sam.Idade}");
Console.WriteLine($"    Identificação do Professor: {sam.NIF}");

Console.WriteLine();
Console.WriteLine($"==================================================");
Console.WriteLine();



Console.WriteLine(@$"
+----------------------+
|   PROGRAMA VEÍCULO   |
+----------------------+
");

Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "Vermelho");
Veiculo carro2 = new Veiculo("Ford", "Ka", 2000, "Vermelho");

