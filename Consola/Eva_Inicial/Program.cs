//<-------------Ejercicio 1---------------->
if (DateTime.Now.Hour <= 14 )
    Console.WriteLine("Buenos días");
else if (DateTime.Now.Hour >= 14)
    Console.WriteLine("Buenos tardes");

//<-------------Ejercicio 2---------------->
Console.WriteLine($"Buenos días {Environment.UserName}");

//<-------------Ejercicio 3---------------->
Console.WriteLine($"Son las {DateTime.Now:HH:mm} del {DateTime.Now:dd/MM/yy}");

//<-------------Ejercicio 4---------------->
string? frase = Console.ReadLine();
Console.WriteLine(frase);

//<-------------Ejercicio 5---------------->
string palabra = "Meteorito";
for (int i = 0; i < palabra.Length; i++)
{
    char letra = palabra[i];
    Console.WriteLine(letra);
}

//<-------------Ejercicio 6---------------->
string palabraInversa = "";
for (int i = palabra.Length -1; i >= 0; i--)
{
    char letra = palabra[i];
    palabraInversa = palabraInversa + letra;
}
Console.WriteLine(palabraInversa);

//<-------------Ejercicio 7---------------->
string frase2 = "Hola a todos";
string[] palabras = frase2.Split(' ');
Console.WriteLine(palabras.Length);