Console.WriteLine("Ingrese un numero");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro numero");
int numero2 = int.Parse(Console.ReadLine());

int numeromayor = 0;
int numeromedio = 0;
int numeromenor = 0;

if (numero > numero1 & numero > numero2)
{
    numeromayor = numero;
}
else if (numero > numero1 || numero >numero2)
    numeromedio = numero;
else
{
    numeromenor = numero;
}
if (numero1 > numero & numero1 > numero2)
{
    numeromayor = numero1;
}
else if (numero1 > numero || numero1 > numero2)
    numeromedio = numero1;
else
{
    numeromenor = numero1;
}
if (numero2 > numero & numero2 > numero1)
{
    numeromayor = numero2;
}
else if (numero2 > numero1 || numero2 > numero)
{
    numeromedio = numero2;
}
else
{
    numeromenor = numero2;
}

Console.WriteLine(numeromayor);
Console.WriteLine(numeromedio);
Console.WriteLine(numeromenor);




