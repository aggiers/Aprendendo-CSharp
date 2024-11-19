
namespace PilaresPOO.Classes
{
    public abstract class Personagem
    {
        public string nome;

        public int idade;

        // virtual transforma um método para ser SOBRESCRITO

        public virtual void Atacar()
        {
            Console.WriteLine($"O personagem está atacando! 🗡️");
        }
    }
}