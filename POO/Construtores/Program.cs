using Construtores.Classes;

Console.WriteLine(@$"
+----------------------+
|   PROGRAMA VEÍCULO   |
+----------------------+
");

Veículo carro1 = new Veículo("Ford", "Ka", 2000, "Vermelho");
Veículo carro2 = new Veículo("Ford", "Ka", 2000, "Vermelho");


carro1.ExibirDados();
carro2.ExibirDados();

Console.WriteLine(@$"
+----------------------+
|    PROGRAMA ALUNO    |
+----------------------+
");

Aluno aluno1 = new Aluno("agatha", 16, "torloni");
Aluno aluno2 = new Aluno("kaue", 16, "torloni");
Aluno aluno3 = new Aluno("laura", 17, "torloni");

aluno1.ExibirDados();
aluno2.ExibirDados();
aluno3.ExibirDados();

Console.WriteLine(@$"
+----------------------+
|    PROGRAMA JOGO     |
+----------------------+
");

Jogo jogo1 = new Jogo("little nightmares", 80, "terror");
Jogo jogo2 = new Jogo("minecraft", 100, "aventura");
Jogo jogo3 = new Jogo("five night freddy's", 180, "terror");

jogo1.ExibirDados();
jogo2.ExibirDados();
jogo3.ExibirDados();

