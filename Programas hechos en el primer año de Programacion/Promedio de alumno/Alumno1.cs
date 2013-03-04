using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Alumno1
    {
        int legajo;
        string nombre;
        double nota1;
        double nota2;

        public int pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public double pNota1
        { set { nota1 = value;}
            get { return nota1; }
        }

        public double pNota2
        {
            set { nota2 = value; }
            get { return nota2; }
        }

        public Alumno1()
        {
            legajo = 0;
            nombre = " ";
            nota1 = 0;
            nota2 = 0;
        }

        public Alumno1(int leg, string nom, double n1, double n2)
        {
            legajo = leg;
            nombre = nom;
            nota1 = n1;
            nota2 = n2;
        }

        public double promedio()
        { return (nota1 + nota2)/2;}

        public string toString()
        {
            return "Legago: " + legajo +
                    "\nNombre: " + nombre +
                    "\nNota 1: " + nota1 +
                    "\nNota 2: " + nota2 +
                    "\nPromedio: " + promedio();
        }
           
    }
}
