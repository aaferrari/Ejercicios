using System;
using System.Collections.Generic;
using System.Text;

namespace Cursado_con_profesor
{
    public class Persona // El abstrac es para indicar que esta es una clase abtracta (por que es una abstracion de la realidad y bla, bla, bla)
    {
        string nombre;
        int dni;
        string apellido;

        int sexo;
        string domicilio;
        int telefono;


        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int DNI
        {
            set { dni = value; }
            get { return dni; }
        }

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public int Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public string Domicilio
        {
            set { domicilio = value; }
            get { return domicilio; }
        }

        public int Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public Persona()
        {
            nombre = "";
            apellido = "";
            dni = 0;
            telefono = 0;
            sexo = 0;
            domicilio = "";
        }

        public string toString()
        { return "Su nombre es " + nombre + ", su DNI es " + dni + " y su sexo es " + SexoCondicionado()+". "; }

        public string SexoCondicionado()
        {
            if (sexo == 1)
            { return "masculino"; }
            else
                if (sexo == 2)
                { return "femenino"; }
                else
                { return "no indicado"; }//Por si no se marca ninguno de los radiobotones (metodo alternativo propuesto por Botta)
       }
    }

    public class Profesor:Persona
    {
        int legajo;
        double sueldo;
            
        public int Legajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        public double Sueldo
        {
            set { sueldo = value; }
            get { return sueldo; }
        }

        public Profesor():base()
        {
            legajo = 0;
            sueldo = 0;
        }

        public string toString()
        { return base.toString() + "tiene el legajo N°" + legajo + " y un sueldo de $" + sueldo; }/* Se instancia el toString de la clase Persona */
    }

    public class Curso
    {
        int aula;
        string nombre;
        string turno;
        Profesor profe; //(aca se llama a la clase Profesor cono un atributo de la clase curso

        public int Aula
        {
            set { aula = value; }
            get { return aula; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Turno
        {
            set { turno = value; }
            get { return turno; }
        }

        public Profesor Profe
        {
            set { profe = value; }
            get { return profe; }
        }

        public Curso()
        {
            aula = 0;
            nombre = "";
            turno = "";
            profe = null;
        }

        public string toString()
        { return "Datos del curso: se registra el aula N°" + aula + " con nombre " + nombre + " y el turno es " + turno + ".\nDatos del profesor: " + (profe.toString()); }
    }
}
