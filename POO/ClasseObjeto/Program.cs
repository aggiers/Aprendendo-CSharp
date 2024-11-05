// importando as classes de dentro da pasta classes
using System.Net.Http.Headers;
using ClasseObjeto.Classes;

// cria o objetivo/variavel animal
Animal cachorro = new Animal();
Animal gato = new Animal();

cachorro.nome = "luna";
cachorro.especie = "bull terrier";
cachorro.cor = "branco";
cachorro.idade = 1;

gato.nome = "branca";
gato.especie = "fêmea";
gato.cor = "branco";
gato.idade = 10;


Console.WriteLine($"nome do cachorro: {cachorro.nome}");
Console.WriteLine($"idade do cachorro: {cachorro.idade}");
Console.WriteLine($"cor do cachorro: {cachorro.cor}");
Console.WriteLine($"cor do cachorro: {cachorro.especie}");

Console.WriteLine();

Console.WriteLine($"nome do gato: {gato.nome}");
Console.WriteLine($"idade do gato: {gato.idade}");
Console.WriteLine($"cor do gato: {gato.cor}");
Console.WriteLine($"raça do gato: {gato.especie}");

cachorro.FazerBarulho("au au");
Console.WriteLine($"Idade de {cachorro.nome} é {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"nova idade de {cachorro.nome} é {cachorro.idade}");




