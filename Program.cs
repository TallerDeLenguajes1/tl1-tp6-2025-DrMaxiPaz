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


Console.WriteLine("\n\t\tCalculadora");
string opcion = "";

while (opcion != "no")
{
    Console.WriteLine("\n\t1. Sumar\n\t2. Restar\n\t3. Multiplicar\n\t4. Dividir\n\tIngresa un operacion a realizar:");

    string operacion = Console.ReadLine();
    Console.WriteLine("Ingrese el primer numero: ");
    float n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    float n2 = int.Parse(Console.ReadLine());
    switch (operacion)
    {
        case "1":
            Console.WriteLine("\n\tLa suma de los numeros es: " + (n1 + n2));
            break;
        case "2":
            Console.WriteLine("\n\tLa resta de los numeros es: " + (n1 - n2));
            break;
        case "3":
            Console.WriteLine("\n\tLa multiplicacion de los numeros es: " + (n1 * n2));
            break;
        case "4":
            Console.WriteLine("\n\tLa division de los numeros es: " + (n1 / n2));
            break;
        default:
            Console.WriteLine("\n\tOPcion invalida..");
            break;
    }
    Console.WriteLine("\n\tDesea seguir calculando (si/no):");
    opcion = Console.ReadLine();
}


