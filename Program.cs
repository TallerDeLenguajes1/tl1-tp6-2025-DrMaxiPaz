// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

Console.WriteLine("Ingrese un numero: ");
string numero = Console.ReadLine();
if (int.TryParse(numero, out int numeroEntero))
{
    Console.WriteLine("El numero es: " + numeroEntero);
    if (numeroEntero > 0)
    {
        string invertido = "";
        while (numeroEntero >= 1)
        {
            invertido += numeroEntero % 10;
            numeroEntero /= 10;
        }
        Console.WriteLine("\n\tEl numero invertido es:" + invertido);
    }
    else
    {
        Console.WriteLine("\n\tEl numero es negativo");
    }
}
else
{
    Console.WriteLine("No es un numero");
}

