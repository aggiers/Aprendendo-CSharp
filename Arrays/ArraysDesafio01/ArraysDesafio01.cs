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
        int contadorPares = 0;
        int contadorImpares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o número para a posição {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                contadorPares++;
            }
            else
            {
                contadorImpares++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {contadorPares}");
        Console.WriteLine($"Quantidade de números ímpares: {contadorImpares}");