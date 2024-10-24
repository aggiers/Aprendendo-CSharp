Console.WriteLine(@"
+---------------------------------------+
|               Bem Vindo               |
|                  Ao                   |
|          Programa Banco XPTO          |
+---------------------------------------+
");

float salario;
float totalGasto;

Console.WriteLine($"Digite seu salario: ");
salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o total gasto dese mês:");
totalGasto = float.Parse(Console.ReadLine());

if(salario >= totalGasto){
    Console.WriteLine($"Gastos dentro do orçamento!");
} else {
    Console.WriteLine($"Orçamento estourado!");
}