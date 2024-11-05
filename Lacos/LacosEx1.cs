Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Laço              |
+---------------------------------------+
");

int qtdHomem = 0;
int qtdMulher = 0;
int qtdEsporte = 0;
int qntNaoGostaEsportes = 0;

Console.WriteLine($"quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "f")
    {
        qtdMulher++;
    } 
    else 
    {
        qtdHomem++;
    }

    Console.WriteLine($"Você gosta de esporte? sim/nao");
    string esporte = Console.ReadLine();

    if(esporte == "sim")
    {
        qtdEsporte++;
    }
    else if (esporte == "nao")
    {
        qntNaoGostaEsportes++;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite 'sim' ou 'nao'.");
        i--; 
    }
} 

float percentual = (100 / qtdDeEntrevistados) * qtdEsporte;

Console.WriteLine($"quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"quantidade de homens: {qtdHomem}");
Console.WriteLine($"quantidade de entrevistados: {qtdMulher + qtdHomem}");
Console.WriteLine($"Total de pessoas que gostaram : {qtdEsporte}");
Console.WriteLine($"Total que não gostam de esportes: {qntNaoGostaEsportes}");
Console.WriteLine($"percentual de pessoas que gostam de esportes: {percentual} %");

