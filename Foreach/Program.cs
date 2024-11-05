string[] frutas = {"melancia", "morango", "banana", "kiwi", "uva", "amora", "goiaba", "maça",};

Console.WriteLine($"sua sacola contém {frutas.lenght} frutas!");

foreach (string f in frutas)
{
    Console.Write($"{f}, ");
}

Console.WriteLine();