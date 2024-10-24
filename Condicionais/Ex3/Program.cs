// Escreva um programa que leia as medidas    
//dos lados de um triângulo e escreva 
//se ele é Equilátero, Isósceles ou Escaleno. Sendo que:

// − Triângulo Equilátero: possui os 3 lados iguais.     
// − Triângulo Isóscele: possui 2 lados iguais.     
// − Triângulo Escaleno: possui 3 lados diferentes.

Console.WriteLine(@"
+---------------------------------------+
|               Bem Vindo               |
|                  Ao                   |
|          Programa Triângulos          |
+---------------------------------------+
");

        double lado1, lado2, lado3;

        Console.WriteLine("Digite a medida do primeiro lado do triângulo:");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a medida do segundo lado do triângulo:");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a medida do terceiro lado do triângulo:");
        lado3 = Convert.ToDouble(Console.ReadLine());

        if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0){
            Console.WriteLine(@"
            +------------------------------------------+
            |  As medidas devem ser maiores que zero.  |
            +------------------------------------------+
            ");
        } else if (lado1 == lado2 && lado2 == lado3){
            Console.WriteLine(@"
            +----------------------------+
            |  O triângulo é Equilátero. |
            +----------------------------+
            ");
        } else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3){
            Console.WriteLine(@"
            +----------------------------+
            |  O triângulo é Isósceles.  |
            +----------------------------+
            ");
        } else {
            Console.WriteLine(@"
            +----------------------------+
            |  O triângulo é Escaleno.   |
            +----------------------------+
            ");
        }