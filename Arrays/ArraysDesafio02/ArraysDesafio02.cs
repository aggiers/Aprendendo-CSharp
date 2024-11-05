Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Arrays02          |
+---------------------------------------+
");

int[] arrayNumeros1 = {5, 10, 15, 20, 25, 30, 35, 40, 45, 50};
int[] arrayNumeros2 = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
int[] arrayDeVinteNumeros = new int [20];

Console.WriteLine($"LISTA DOS NÚMEROS:");
for (int i = 0; i < arrayDeVinteNumeros.Length; i++)
{
    Console.WriteLine($"{arrayNumeros1[i]}");
    Console.WriteLine($"{arrayNumeros2[i]}");
    
}