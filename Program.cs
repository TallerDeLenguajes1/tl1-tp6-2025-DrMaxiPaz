// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

/*Console.WriteLine("Ingrese un numero: ");
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
*/
//ejercicio 3
/*
Console.WriteLine("Ingrese un numero: ");
float numero2 = float.Parse(Console.ReadLine());
Console.WriteLine("\n\tEl valor absoluto del numero es: " + float.Abs(numero2));
Console.WriteLine("\n\tEl cuadrado del numero es: " + float.Pow(numero2, 2));
if (numero2 > 0)
{
    Console.WriteLine("\n\tLa raiz cuadrada del numero es: " + float.Sqrt(numero2));
}
else
{
    Console.WriteLine("\n\t" + float.Sqrt(numero2) + " no posee raiz cuadrada");
}

if (float.IsEvenInteger(float.Sin(numero2)))
{
    Console.WriteLine("\n\tEl seno del numero es: " + float.Sin(numero2));
}
else
{
    Console.WriteLine("\n\t" + numero2 + " no posee seno");
}

if (float.IsEvenInteger(float.Cos(numero2)))
{
    Console.WriteLine("\n\tEl coseno del numero es: " + float.Cos(numero2));
}
else
{
    Console.WriteLine("\n\t" + numero2 + " no posee coseno");
}
Console.WriteLine("\n\tla parte entera del numero " + numero2 + " es " + (int)numero2);

List<float> lista = [];
Console.WriteLine("Ingrese un numero: ");
lista.Add(float.Parse(Console.ReadLine()));
Console.WriteLine("Ingrese otro numero: ");
lista.Add(float.Parse(Console.ReadLine()));
Console.WriteLine("El numero maximo es: " + lista.Max());
Console.WriteLine("El numero minimo es: " + lista.Min());
*/
// ejercicio 2
/*
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
            Console.WriteLine("\n\tLa suma de " + n1 + " con " + n2 + "  es: " + (n1 + n2).ToString());
            break;
        case "2":
            Console.WriteLine("\n\tLa resta de " + n1 + " con " + n2 + "  es: " + (n1 - n2).ToString());
            break;
        case "3":
            Console.WriteLine("\n\tLa multiplicacion de " + n1 + " con " + n2 + "  es: " + (n1 * n2).ToString());
            break;
        case "4":
            Console.WriteLine("\n\tLa division de " + n1 + " con " + n2 + "  es: " + (n1 / n2).ToString());
            break;
        default:
            Console.WriteLine("\n\tOPcion invalida..");
            break;
    }
    Console.WriteLine("\n\tDesea seguir calculando (si/no):");
    opcion = Console.ReadLine();
}
*/
// ejercicio 4

Console.WriteLine("Ingresa una oracion: ");
string oracion = Console.ReadLine();
Console.WriteLine("La longuitud de la oracion es: " + oracion.Length);
Console.WriteLine("\nIngresa otra oracion: ");
string oracion1 = Console.ReadLine();
Console.WriteLine("\nLa oracion concatenada es:" + oracion + oracion1);
Console.WriteLine("\nLa posicion de 'a' en la oracion es: " + (oracion.IndexOf('a') + 1));
Console.WriteLine("\nArmo otra oracion sin la primera letra  : " + oracion[1..]);

Console.WriteLine($"Los caracteres de {oracion} son: ");
foreach (char c in oracion)
{
    Console.WriteLine(c);
}
Console.WriteLine($"\nLa oracion en mayusculas es '{oracion.ToUpper()}' y en minusculas es '{oracion.ToLower()}'");
Console.WriteLine($"\nIngresa una cadena con la letra 'k' para separarla:");
string cadena = Console.ReadLine();
string[] partes = cadena.Split('k');
Console.WriteLine("\nPartes de la cadena separadas por 'k':");
foreach (string s in partes)
{
    Console.WriteLine(@$">{s}");
}
Console.WriteLine($"\nIngresa una operacion a realizar: ");
int.TryParse(Console.ReadLine(), out int resultado);
Console.WriteLine($"\nEl resultado de la operacion es {resultado}");

