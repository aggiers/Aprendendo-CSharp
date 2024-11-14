using System;
namespace Calculator.Calculadora
{
    public class Calculadora
    {
        public float numero1; 
        public float numero2;

        public void Somar()
        {
            Console.WriteLine($"resultado da soma: {numero1 + numero2}");
        }
        public void Subtrair()
        {
            Console.WriteLine($"resultado da subtração: {numero1 - numero2}");
        }
        public void Multiplicar()
        {
            Console.WriteLine($"resultado da multiplicação: {numero1 * numero2}");
        }
        public void Dividir()
        {
            if (numero2 != 0)
            {
                Console.WriteLine($"resultado da divisão: {numero1 /numero2}");
            }
            else
            {
                Console.WriteLine("erro: divisão por zero.");
            }
        }
    }
}
