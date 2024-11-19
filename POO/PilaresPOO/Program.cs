using PilaresPOO.Classes;
Console.Clear();

ContaCorrente ctAggy = new ContaCorrente();
ctAggy.Titular = "Agatha Tobias Gomes";
ctAggy.Depositar(1000000f);

Console.WriteLine($"Titular da Conta: {ctAggy.Titular}");
Console.WriteLine($"Saldo da Conta: {ctAggy.getSaldo()}");

float valorSacado = ctAggy.Sacar(1200f);

Console.WriteLine($"Valor do saque: {valorSacado}");
Console.WriteLine($"Novo saldo: R${ctAggy.getSaldo()}");