using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba
{
    public class Programa
    {
        static void Main(string[] args) //Metodo principal de un programa
        {Alumno oFulano = new Alumno();
/*        oFulano.pLegajo=4747489;
        oFulano.pNombre="Fulano de tal";
        oFulano.pDni=15675; */
        Console.WriteLine("Este programa pide que se ingresen tres datos y luego termina al presionar enter"); // Muestra un mensaje en la consola
        Console.Write("Ingrese el numero de legajo: ");
        oFulano.pLegajo=int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del alumno: ");
        oFulano.pNombre=string.Copy(Console.ReadLine());
        Console.Write("Ingrese el DNI del alumno: ");
        oFulano.pDni=int.Parse(Console.ReadLine());
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Datos del alumno");
        Console.WriteLine(oFulano.toString());
        Console.ReadLine();
        }
}
}