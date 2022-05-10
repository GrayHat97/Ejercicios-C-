Console.WriteLine($"Ingrese algun numero");

int numero= int.Parse(Console.ReadLine());

if (numero==0) {
    Console.WriteLine("El numero es impar");
                   }   
else if((numero % 2) == 0) {
    Console.WriteLine("El numero es par");
                            }   
    else { 
           Console.WriteLine("El numero es impar");
         }

