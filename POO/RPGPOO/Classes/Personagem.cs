namespace RPGPOO.Classes
{
    public class personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string IA;

        public void Atacar()
        {
            Console.WriteLine("O personagem atacou!");
        }

        public string Defender()
        {
            return "O personagem defendeu!";
        }

        public void RestaurarArmadura()
        {
            Console.WriteLine("O personagem restaurou a armadura!");
        }
    }

}
