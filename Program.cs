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
Console.WriteLine("Ingrese un numero: ");
float numero2 = float.Parse(Console.ReadLine());
Console.WriteLine("\n\tEl valor absoluto del numero es: " + float.Abs(numero2));
Console.WriteLine("\n\tEl cuadrado del numero es: " + float.Pow(numero2,2));
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
Console.WriteLine("\n\tla parte entera del numero " +numero2 + " es " + (int)numero2 );

List<float> lista = []; 
Console.WriteLine("Ingrese un numero: ");
lista.Add(float.Parse(Console.ReadLine()));
Console.WriteLine("Ingrese otro numero: ");
lista.Add(float.Parse(Console.ReadLine()));
Console.WriteLine("El numero maximo es: " + lista.Max());
Console.WriteLine("El numero minimo es: " + lista.Min());


