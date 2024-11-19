using System.Dynamic;

namespace PilaresPOO.Classes
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public string ? Curso { get; set; }
        public float Media { get; set; }
    }
}