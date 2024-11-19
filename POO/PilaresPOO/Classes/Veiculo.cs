
namespace PilaresPOO.Classes
{
    public abstract class Veiculo
    {
        public string? marca;
        public int qtdportas;
        public string? modelo;
        public string? cor;
        public float potencia;
        public int qtdpassageiros;

        public void Buzinar()
        {
            Console.WriteLine($"BII BII!");
        }
        public void Ligar()
        {
            Console.WriteLine($"Ligando o {modelo} ");

        }
        public void Desligar()
        {
            Console.WriteLine($"{modelo} desligado");
        }


    }
}