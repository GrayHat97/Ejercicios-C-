Console.WriteLine($"Ingrese algun numero");

int numero = int.Parse(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("El numero cero");
}
else if (numero > 0)
{
    Console.WriteLine("El numero es positivo");
}
else
{
    Console.WriteLine("El numero es negativo");
}


