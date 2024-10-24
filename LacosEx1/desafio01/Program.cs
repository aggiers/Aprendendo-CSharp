Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Laço              |
+---------------------------------------+
");

int qtdHomem = 0; 
int qtdMulher = 0; 
int qtdResposta = 0; 
int qtdNResposta = 0; 
int qtdEntrevistados = 10;


for (int i = 1; i <= qtdEntrevistados; i++)
{
Console.WriteLine($"Qual é o seu sexo ? f/m");
string sexo = Console.ReadLine();


    if (sexo == "f")
    {
        qtdMulher++;
    }else{
        qtdHomem++;
    }

    Console.WriteLine($"Você gostou do produto ? n/s");
    string resposta = Console.ReadLine();
    
    if (resposta == "s")
    {
        qtdResposta++;
    }else{
        qtdNResposta++;
    }
    
}
    float percentual = (100 / qtdHomem) * qtdNResposta;

Console.WriteLine($"O número de pessoas que responderam SIM: {qtdResposta}");
Console.WriteLine($"O número de pessoas que responderam NÃO: {qtdNResposta}");
Console.WriteLine($"O número de mulheres que responderam SIM: {qtdMulher}");
Console.WriteLine($"A porcentagem de homens que responderam NÃO: {percentual}%");