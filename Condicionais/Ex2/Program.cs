Console.WriteLine(@"
+---------------------------------------+
|               Bem Vindo               |
|                  Ao                   |
|           Programa Futtable           |
+---------------------------------------+
");

Console.WriteLine("Qual é o placar do primeiro time?");
int placarA = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Qual é o placar do segundo time?");
int placarB = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (placarA > placarB)
{
     Console.WriteLine(@"
+-----------------------------------+
|           Vitoria time 1          |
+-----------------------------------+
");
   
} else if (placarA < placarB)
{
    Console.WriteLine(@"
+-----------------------------------+
|           Vitoria time 2          |
+-----------------------------------+
");
} else {
    Console.WriteLine(@"
+-----------------------------------+
|              EMPATE               |
+-----------------------------------+
");
}