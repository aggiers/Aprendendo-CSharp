
namespace PilaresPOO.Classes
{
    // subclasse herda o personagem

    public class Mago : Personagem
    {
        public override void Atacar()
        {
            Console.WriteLine($"O mago lança o seu feitiço! 🪄");
        }
    }
}