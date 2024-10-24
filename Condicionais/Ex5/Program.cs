Console.WriteLine(@"
+---------------------------------------+
|               Bem Vindo               |
|                  Ao                   |
|            Programa Maças             |
+---------------------------------------+
");
        
        
        Console.WriteLine("Digite o número de maçãs compradas:");
        float numeroDeMacas = float.Parse(Console.ReadLine());
        
        double precoPorMaca;

        if (numeroDeMacas < 12){
            precoPorMaca = 0.30;
        } else {
            precoPorMaca = 0.25;
        }

        double valorTotal = numeroDeMacas * precoPorMaca;

        Console.WriteLine($"O valor total da compra é: R$ {valorTotal}");
