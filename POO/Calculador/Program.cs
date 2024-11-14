
using Calculator.Calculadora;
Console.Clear();

Console.WriteLine(@$"*** Programa de Calculadora! ***

    1. somar
    2. subtrair
    3. multiplicar
    4. dividir

");

Calculadora calculadora = new Calculadora();

Console.WriteLine("Digite o primeiro número:");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
float numero2 = float.Parse(Console.ReadLine());

      
calculadora.numero1 = numero1;
calculadora.numero2 = numero2;

    calculadora.Somar();
    calculadora.Subtrair();
    calculadora.Multiplicar();
    calculadora.Dividir();

