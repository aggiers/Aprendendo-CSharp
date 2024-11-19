

namespace PilaresPOO.Classes
{
    public class ContaCorrente : Conta
    {
        public float Limite { get; set; }

        public bool Transferir(float valor, Conta contaDestino)
        {
            return false;
        }
        public override bool Depositar(float valor)
        {
            if (valor > 0){
            Saldo = Saldo + valor;

            return true;

            } else {

            return false;
            }

        }


        public override float Sacar(float valor)
        {

            if (valor <= Saldo){
            Saldo = Saldo - valor;

            return valor;

            } else {

            return 0;
            }

        }
    }
}