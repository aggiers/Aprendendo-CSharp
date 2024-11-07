using RPGPOO.Classes;

Console.Clear();

personagem person = new personagem();

Console.WriteLine(@$"*** Programa de RPG! ***");
           
        Console.WriteLine("Digite o nome do seu personagem: ");
        person.nome = Console.ReadLine();

        Console.WriteLine("Digite a idade do seu personagem: ");
        person.idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o nome da armadura do personagem: ");
        person.armadura = Console.ReadLine();

        Console.WriteLine("Informe a I.A que o personagem utiliza: ");
        person.IA = Console.ReadLine();

            
        Console.WriteLine("\n" + person.nome + ",");
        Console.WriteLine(person.idade + ",");
        Console.WriteLine(person.armadura + ",");
        Console.WriteLine(person.IA + "\n");

           
        person.Atacar();
        person.RestaurarArmadura();
        person.Defender();
  