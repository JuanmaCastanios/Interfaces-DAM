/*
    Ejemplo 1
*/
Console.WriteLine("Hola Tete, cómo te llamas?");
Console.WriteLine("Escribe tu nombre: ");
String? nombre = Console.ReadLine();
if (nombre == String.Empty)
    Console.WriteLine("Es nulo");
else
    //Console.WriteLine("Hola " + nombre);
    Console.WriteLine($"Hola {nombre.ToUpper()}");