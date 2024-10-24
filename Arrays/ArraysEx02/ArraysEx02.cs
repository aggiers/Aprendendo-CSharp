// Faça um programa que carregue dois vetores de 10 elementos
// numéricos cada um e imprima a intercalação desses dois.

Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Arrays02          |
+---------------------------------------+
");


int[] vetor1 = new int[10];
int[] vetor2 = new int[10];
int[] vetorIntercalado = new int[20];  

Console.WriteLine("Por gentileza, digite 10 números para o primeiro vetor:");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Vetor 1 - Elemento {i + 1}: ");
    vetor1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Agora, por favor, digite 10 números para o segundo vetor:");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Vetor 2 - Elemento {i + 1}: ");
    vetor2[i] = int.Parse(Console.ReadLine());
}


for (int i = 0, j = 0; i < 10; i++, j += 2)
{
    vetorIntercalado[j] = vetor1[i];      
    vetorIntercalado[j + 1] = vetor2[i]; 
}

Console.WriteLine("Vetor intercalado:");

foreach (int num in vetorIntercalado)
{
    Console.Write(num + " ");
}