using System.Numerics;
using System.Threading.Tasks.Dataflow;

Console.WriteLine(@"
+-------------------------------------+
|       Programa de cadastros         |
+-------------------------------------+
|                Ola! :)              |
| Por favor digite seus dados abaixo  |
+-------------------------------------+

");

Console.WriteLine(); //linha vazia

//  pedir os dados de cadastro
    Console.WriteLine($"digite seu nome:");
    string nome = Console.ReadLine()!;
    Console.WriteLine($"olá {nome}, digite seu sobrenome:");
    string sobrenome = Console.ReadLine()!;

    //data
    Console.WriteLine($"informe sua data de nascimento:");
    string dtNasc = Console.ReadLine()!;

    //email
    Console.WriteLine($"informe seu e-mail:");
    string email = Console.ReadLine()!;

    //telefone
    Console.WriteLine($"informe seu telefone:");
    UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

    //cpf
    Console.WriteLine($"informe seu CPF:");
    UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

    //endereço
    Console.WriteLine($"informe seu endereço:");
    string endereco = Console.ReadLine()!;

    //idade - calcular baseado na data de nascimento
    Console.WriteLine($"em que ano você nasceu?:");
    int anoNascimento = int.Parse(Console.ReadLine());
    int anoAtual = DateTime.Now.Year;
    int idade = anoAtual - anoNascimento;

    //estado civil
    Console.WriteLine($"informe seu estado civil:");
    string estadocivil = Console.ReadLine()!;

    Console.WriteLine();

    // informações
    Console.WriteLine($"nome: {nome} {sobrenome}");
    Console.WriteLine($"data de nascimento: {dtNasc}");
    Console.WriteLine($"email: {email}");
    Console.WriteLine($"telefone: {telefone}");
    Console.WriteLine($"endereço: {endereco}");
    Console.WriteLine($"idade: {idade}");
    Console.WriteLine($"estado civil: {estadocivil}");

