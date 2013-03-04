using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Prueba
{
    class Alumno
    {int legajo;
    string nombre;
    int dni;
        public int pLegajo
       {set {legajo = value;} //propiedades
        get {return legajo;}}

        public string pNombre
       {set {nombre = value;}
        get {return nombre;}}

        public int pDni
        {
            set { dni = value; }
            get { return dni; }
        }

   public Alumno() // Metodo inicializador de los atributos o contructor. Las clases pueden tener varios constructores o ninguno
   {legajo=0; 
    nombre="";
    dni=0;}

   public string toString()
        { return "Legajo: " +legajo+"\n"+
   		         "Nombre: " +nombre+"\n"+
                 "DNI: " +dni; } 

// Forma alternativa para ingresar datos (aun no funca)
/*   public string toString()
   { return Console.WriteLine("Ingrese el legajo del alumno: ");
   	 		Console.WriteLine("Ingrese el nombre del alumno: ");
     		Console.WriteLine("Ingrese el DNI del alumno: "); } */
}
}