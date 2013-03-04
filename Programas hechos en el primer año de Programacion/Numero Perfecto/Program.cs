using System;
using System.Collections.Generic;
using System.Text;

namespace Numero_Perfecto
{
    class Program
    {
private static bool EsPerfecto(Int64 n)
{
    Int64 numero = 0;
    for (Int64 i = 1; i < n; i++)
        if (n % i == 0) numero += i;
    return (n == numero);
}
 
private static void Lista(int cant)
{
    for (Int64 i = 1; cant > 0; i++)
    {
        if (EsPerfecto(i))
        {
            Console.WriteLine(i);
            cant--;
        }
    }
}
 
static void Main(string[] args)
{
    Console.WriteLine("Bienvenido a la calculadora de numeros perfectos. Presione una tecla para continuar");
    Console.ReadLine();
    Console.WriteLine("----------------------------------------");
    Lista(10);//Imprime los primeros n
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Fin del programa, presione una tecla para salir");
    Console.ReadLine();
}}}