using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Rectangulo
{
    public class Programa
    {
        static void Main(string[] args)         
        {
        	Rectangulo oRect1 = new Rectangulo(57,78758);
            Console.WriteLine(oRect1.toString());
            Console.ReadLine();
            Console.WriteLine("A continuacion se muestran los datos y el perimetro del primer rectangulo");
            Console.WriteLine(oRect1.toString());
            Console.WriteLine(" ------------------------------------------------------------------------ ");
            Console.WriteLine(oRect1.perimetro());
            Console.WriteLine(" -----------------");
            Console.WriteLine("La superficie es: ");
            Console.WriteLine(oRect1.superficie());
            Console.ReadLine();
            
            Rectangulo oRect2 = new Rectangulo(21, 657); //Otra forma de definir los datos de una clase
    /*        oRect2.Ancho=21;
            oRect2.Alto=657; */
            Console.WriteLine("A continuacion se muestra el alto, ancho, superficie y perimetro del rectangulo que se ingreso previamente al definir la segunda clase.");
            Console.WriteLine(oRect2.Alto);
            Console.WriteLine(oRect2.Ancho);
            Console.WriteLine(oRect2.superficie());
            Console.WriteLine(oRect2.perimetro());
            Console.ReadLine();
            Console.WriteLine("Y para terminar pongo un rectangulo que se va a dibujar en la consola para que el programa quede mas bonito ;) ");
            Console.WriteLine("                                    ________________ " +"\n"+ "                                   |               | " +"\n"+ "                                   |               | " +"\n"+ "                                   |               | " +"\n"+ "                                   |               | " +"\n"+ "                                   |               | " +"\n"+ "                                   |               | " +"\n"+ "                                   |               | " +"\n"+ "                                   |_______________| ");

            
        }
    }
}