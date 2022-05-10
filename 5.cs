
Console.WriteLine("Hello, World!");

Console.WriteLine("Bienvenido");
Console.WriteLine("A= Para calcular el área de un cuadrado.");
Console.WriteLine("B= Para calcular el área de un rectángulo.");
Console.WriteLine("C= Para calcular el área de un triángulo.");
Console.WriteLine("D= Para calcular el área de un círculo.");
Console.WriteLine("E= Para calcular el área de un rombo.");
Console.WriteLine("F= Para calcular el área de un trapecio.");
Console.WriteLine("Por favor escriba el caracter que corresponda: ");

char caracter = char.Parse(Console.ReadLine());

switch (caracter)
{
    case 'A' or 'a':

        Console.WriteLine($"Calcular área de un cuadrado ");
        Console.WriteLine($"Ingrese un lado del cuadrado");
        double cuadrado = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese el otro lado del cuadrado");
        double cuadrado1 = double.Parse(Console.ReadLine());
        double resultadocuadrado = cuadrado * cuadrado1;
        Console.WriteLine($"El área del cuadrado es {resultadocuadrado}");
        break;

    case 'B' or 'b':
        Console.WriteLine($"Calcular área de un rectangulo ");
        Console.WriteLine($"Ingrese  altura");
        double rectangulo = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese base");
        double rectangulo1 = double.Parse(Console.ReadLine());
        double resultadorectangulo = rectangulo * rectangulo1;
        Console.WriteLine($"El área del rectangulo es {resultadorectangulo}");
        break;
    case 'C' or 'c':
        Console.WriteLine($"Calcular área de un triangulo ");
        Console.WriteLine($"Ingrese  base");
        double triangulo = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese altura");
        double triangulo1 = double.Parse(Console.ReadLine());
        double resultadotriangulo = triangulo * triangulo1 / 2;
        Console.WriteLine($"El área del rectangulo es {resultadotriangulo}");
        break;
    case 'D' or 'd':
        Console.WriteLine($"Calcular área de un circulo ");
        Console.WriteLine($"Ingrese  el radio del circulo");
        double circulo = double.Parse(Console.ReadLine());
        double resultadocirculo = Math.PI * (Math.Pow(circulo, 2));
        Console.WriteLine($"El área del circulo es {resultadocirculo}");
        break;
    case 'E' or 'e':
        Console.WriteLine($"Calcular área de un Rombo ");
        Console.WriteLine($"Ingrese  el diagonal mayor");
        double rombo = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese  el diagonal menor");
        double rombo1 = double.Parse(Console.ReadLine());
        double resultadorombo = rombo * rombo1 / 2;
        Console.WriteLine($"El área del circulo es {resultadorombo}");
        break;
    case 'F' or 'f':
        Console.WriteLine($"Calcular área de un trapecio ");
        Console.WriteLine($"Ingrese una base");
        double trapecio = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese  la otra base");
        double trapecio1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ingrese  la altura");
        double trapecio2 = double.Parse(Console.ReadLine());
        double resultadotrapecio = ((trapecio + trapecio1) * trapecio2) / 2;
        Console.WriteLine($"El área del circulo es {resultadotrapecio}");
        break;
    default:
        Console.WriteLine($"no eligio la opción correcta.");
        break;

}