// Faça um programa que carregue 1 array tamanho 6 com números inteiros.
// Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Arrays01          |
+---------------------------------------+
");


int[] numeros = new int[6];
int qtdPares = 0, qtdImpares = 0;


Console.WriteLine("Digite 6 números inteiros:");
for (int i = 0; i < 6; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        qtdPares++;
    }
    else
    {
        qtdImpares++;
    }
}

Console.WriteLine($"\nQuantidade de números pares: {qtdPares}");
Console.WriteLine($"Quantidade de números ímpares: {qtdImpares}");