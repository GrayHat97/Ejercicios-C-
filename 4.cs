
Console.WriteLine($"Ingrese su primera nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese su segunda nota");
double nota2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese su tercera nota");
double nota3 = double.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese su cuarta nota");
double nota4 = double.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese su quinta nota");
double nota5 = double.Parse(Console.ReadLine());

double promedio = (nota1 + nota2 + nota3 + nota4 + nota5);
promedio = promedio / 5;

Console.WriteLine(promedio);

if (promedio >= 3)
{
    Console.WriteLine("El estudiante aprobo");
}
else
{
    Console.WriteLine("El estudiante reprobo");
}