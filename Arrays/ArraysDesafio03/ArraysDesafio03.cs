// Faça um programa que receba a temperatura média de cada 
// mês do ano e armazene essas temperaturas em um vetor. 
// Calcule e imprima a maior e a menor temperatura do ano.


Console.WriteLine(@"
+---------------------------------------+
|              Bem Vindo                |
|                  Ao                   |
|            Programa Arrays03          |
+---------------------------------------+
");

float[] temperaturas = new float[12];

        
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Digite a temperatura média do mês {i + 1}: ");
            temperaturas[i] = int.Parse(Console.ReadLine()!);
        }

       
        float maiorTemperatura = temperaturas[0];
        float menorTemperatura = temperaturas[0];

        for (int i = 1; i < 12; i++)
        {
            if (temperaturas[i] > maiorTemperatura)
                maiorTemperatura = temperaturas[i];
            if (temperaturas[i] < menorTemperatura)
                menorTemperatura = temperaturas[i];
        }

        
        Console.WriteLine($"A maior temperatura do ano foi: {maiorTemperatura}°C");
        Console.WriteLine($"A menor temperatura do ano foi: {menorTemperatura}°C");