using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome { get; set; }
        public int preço { get; set; }
        public string categoria { get; set; }


        public Jogo(string nm, int pr, string ct){
            nome = nm;
            preço = pr;
            categoria = ct;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"
            nome: {nome}
            preço: {preço}
            categoria: {categoria}
            ");
        }
    }
}