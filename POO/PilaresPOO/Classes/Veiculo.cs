
namespace PilaresPOO.Classes
{
    public class Veiculo
    {
        public string marca { get; set; }
        public int qtdportas { get; set; }
        public string modelo { get; set; }
        public string cor { get; set; }
        public float potencia { get; set; }
        public int qtdpassageiros { get; set; }

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