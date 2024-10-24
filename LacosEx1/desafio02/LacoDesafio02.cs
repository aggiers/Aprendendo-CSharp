// DesafioLaco02: Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// Total de Homens;
// Total de Mulheres;
// Média de idade dos Homens;
// Média de idade das mulheres.


Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Laço              |
+---------------------------------------+
");

int totalHomens = 0;
int totalMulheres = 0;
int somaIdadeHomens = 0;
int somaIdadeMulheres = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Pessoa {i + 1} :)");

        Console.Write("Sua idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        Console.Write("Seu peso: ");
        float peso = float.Parse(Console.ReadLine()!);

        Console.Write("Seu sexo (m/f): ");
        char sexo = char.Parse(Console.ReadLine());

        if (sexo == 'm')
        {
            totalHomens++;
            somaIdadeHomens += idade;
        }
        else if (sexo == 'f')
        {
            totalMulheres++;
            somaIdadeMulheres += idade;
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, insira 'm' ou 'f'.");
            i--; 
        }

            Console.WriteLine(); 
        }

        float mediaIdadeHomens = totalHomens > 0 ? somaIdadeHomens / totalHomens : 0;
        float mediaIdadeMulheres = totalMulheres > 0 ? somaIdadeMulheres / totalMulheres : 0;

        Console.WriteLine($"Total de Homens: {totalHomens}");
        Console.WriteLine($"Total de Mulheres: {totalMulheres}");
        Console.WriteLine($"Média de idade dos Homens: {mediaIdadeHomens}");
        Console.WriteLine($"Média de idade das Mulheres: {mediaIdadeMulheres}");
