Console.WriteLine("ingrese el numero de llantas a comprar");
int numerollantas = int.Parse(Console.ReadLine());
float precio = 0;
if (numerollantas < 5)
{
    precio = numerollantas * 240000;
    Console.WriteLine($"el precio es {precio} ");

}
else if (numerollantas == 6 || numerollantas == 7)
{
    precio = numerollantas * 221000;
    Console.WriteLine($"el precio es {precio} ");
}
else if (numerollantas > 7)
{
    precio = numerollantas * 180000;
    Console.WriteLine($"el precio es {precio} ");
}

