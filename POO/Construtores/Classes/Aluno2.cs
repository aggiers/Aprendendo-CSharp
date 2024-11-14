
namespace Construtores.Classes
{
    public class Aluno2
    {
        public string nome { get; set; }
        public int CPF { get; set; }

        public Aluno2() { }
        public Aluno2(string _chuchu){
            nome = _chuchu;
        }
        public Aluno2(string _nome, int _cpf){
            nome = _nome;
            CPF = _cpf;
        }
    }

}