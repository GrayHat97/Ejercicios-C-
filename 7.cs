float cuenta = 200000;

if (cuenta<150000)
{
    Console.WriteLine($"Pagar con efectivo");
}
else if (cuenta>=150000 & cuenta<=300000)
{
    Console.WriteLine($"Pagar con celular");
}
else if (cuenta > 300000 & cuenta <= 600000)
{
    Console.WriteLine($"Pagar con tarjeta de debito");
}
else
{
    Console.WriteLine($"Pagar con tarjeta de credito");
}
