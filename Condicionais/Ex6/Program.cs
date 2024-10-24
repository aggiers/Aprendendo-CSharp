
Console.WriteLine(@"
+---------------------------------------+
|               Bem Vindo               |
|                  Ao                   |
|             Programa Média            |
+---------------------------------------+
");

Console.Write("Digite a média do aluno: ");
float media = float.Parse(Console.ReadLine());

Console.Write("Digite a frequência do aluno (em %): ");
float frequencia = float.Parse(Console.ReadLine());

if (frequencia < 75){
    Console.WriteLine("Aluno reprovado por falta.");
} else if (media >= 7.0 || frequencia >= 75){
    Console.WriteLine("Aluno aprovado.");
} else if (media >= 3.0){
    Console.WriteLine("Aluno em recuperação.");
} else {
    Console.WriteLine("Aluno reprovado.");
}
    
