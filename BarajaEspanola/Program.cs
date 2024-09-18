
Random random = new Random();
var valores = new List<string>{"As", "2", "3", "4", "5", "6", "7", "8", "9", "Sota", "Caballo", "Rey"};
var palos = new List<string>{"Oros", "Copas", "Espadas", "Bastos"};
var cartas = new List<string>();
int jugadores = 4;
foreach (string palo in palos)
{
    Console.WriteLine(palo.ToUpper());
    foreach (var valor  in valores)
    {
        string carta = $"{valor} de {palo}";
        cartas.Add(carta);
        Console.WriteLine(carta);   
    }
    Console.WriteLine();
}

cartas = cartas.OrderBy(x => random.Next()).ToList();

for (int i = 1; i <= jugadores; i++)
{
    Console.WriteLine($"JUGADOR {i}");
    for (int j = 0; j < 4; j++)
    {
        int num = random.Next(0, cartas.Count);
        Console.WriteLine(cartas[num]);
        cartas.Remove(num);
    }
    Console.WriteLine();
}


