namespace PilaresPOO.Classes
{
    public class Pessoa
    {
        // atributos -- caracteristicas
        // visibilidade tipoDeDado nomeDaProp

        public string ? Nome;
        public int Idade;
        public float Peso;
        public float Altura;
        public string ? Cpf;

        // metodos - ações
        // visibilidade tipodeDeRetorno nome(parametros) {corpo}

        // envelhecer
        public void envelhecer()
        {
            Idade++;
        }

        // engordar
        public void Engordar(float _kg)
        {
            Peso = Peso + _kg;
        }

        // emagrecer
        public void Emagrecer(float _kg)
        {
            Peso = Peso - _kg;
        }
    }
}