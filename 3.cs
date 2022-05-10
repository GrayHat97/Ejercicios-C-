Console.WriteLine($"Ingrese algun numero");

int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese otro numero");

int numero1 = int.Parse(Console.ReadLine());

if (numero>numero1)
{
    Console.WriteLine($"El numero mayor es  { numero}");
    Console.WriteLine($"El numero menor es  { numero1}");
}
else if (numero1 > numero)
{
    Console.WriteLine($"El numero mayor es  { numero1}");
    Console.WriteLine($"El numero menor es  { numero}");
}
else
{
    Console.WriteLine("ambos numeros son iguales");
}
