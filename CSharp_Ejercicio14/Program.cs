//Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).
Console.WriteLine("Ingrese un número entero positivo:");
int numero126 = Convert.ToInt32(Console.ReadLine());
int contador = 0;
while (numero126 > 0)
{
    numero126 /= 10;
    contador++;
}
Console.WriteLine("El número ingresado tiene " + contador + " cifras.");
