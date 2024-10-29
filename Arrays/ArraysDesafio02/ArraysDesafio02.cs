Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Arrays02          |
+---------------------------------------+
");

int[] vetor1 = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
int[] vetor2 = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
int[] vetorIntercalado = [20];  

for (int i = 0; i < 10; i++)
{
    Console.Write(vetor1 [i]);
    vetor1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    Console.Write(vetor2 [i]);
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