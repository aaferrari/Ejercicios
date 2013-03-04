using System;
using System.Collections.Generic;
using System.Text;

namespace Mi_primera_interfaz
{
    public class Alumno
    {
        int legajo;
        string nombre;
        string apellido;
        int doc;
        int tdoc;
        int sexo;
        int nota1;
        int nota2;
        int nota3;

        public int Legajo
        {
            set { legajo = value; }
            get { return legajo; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {set {apellido=value;}
         get {return apellido;}}

        public int Doc
        {
            set { doc = value; }
            get { return doc; }
        }

        public int Tdoc
        {
            set { tdoc = value; }
            get { return tdoc; }
        }

        public int Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        } 

        public int Nota1
        {
            set { nota1 = value; }
            get { return nota1; }
        }

        public int Nota2
        {
            set { nota2 = value; }
            get { return nota2; }
        }

        public int Nota3
        {
            set { nota3 = value; }
            get { return nota3; }
        }
        
        public int Promedio()
        {return (nota1+nota2+nota3)/3;}

        public Alumno()
        {
            legajo = 0;
            nombre = "";
            apellido= "";
            doc = 0;
            tdoc = 0;
            sexo = 0;
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
        }

        public string toString()
        { return "El alumno es " + nombre + " " + apellido + " y su legajo es el " + legajo + ". Su sexo es " + SexoCondicionado() + ", su documento es un " + TipoDeDocumento() + " con el numero " + doc + ". Sus notas son " + nota1 + ", " + nota2 + " y " + nota3 + ". Su promedio final es de " + Promedio()+". Y otra cosa: " +Consuelo(); }

        public string CondicionAlumno() //Esto devuelve la condicion del alumno dependiendo del promedio que determine el programa
        {
            if (Promedio() == 4 || Promedio() > 4 && (nota1 > 4||nota1 ==4 && nota2 > 4 || nota2 ==4 && nota3 > 4 || nota3 ==4))
            {
                if (this.Promedio() > 8 || Promedio() == 8 && (nota1 > 8 || nota1 == 8 && nota2 > 8 || nota2 == 8 && nota3 > 8 || nota3 == 8))
                { return "Promocionado"; }
                else
                { return "Regular"; }
            }
            else { return "Libre"; }
        }
        
        public string SexoCondicionado()
        {
            if (sexo == 1) //Aca puede se igual a cualquier caracter, pero el profesor lo queria hacer con 1
            {
                if (sexo == 2)
                { return "femenino"; }
                else
                { return "masculino"; }
            }
            else
            { return "no indicado"; }//Por si no se marca ninguno de los radiobotones (gracias Hernan) 
        }
        
        public string TipoDeDocumento()
        {
            if (tdoc == 1)
            { return "DNI"; }
            else
            {if (tdoc == 2)
                { return "Cedulon Federal"; }
                else
                {if (tdoc == 3)
                	{ return "Libreta de Enrrolamiento"; }
                else
                { return "no indicado"; }}}
            				
            }
             
        public string Consuelo()
        { if (Promedio() ==4 ||Promedio() >=4)
        	{ return "felicitaciones niño, parece que tienes futuro"; }
          else
          	{ return "buuuuuuuuuuuuuuuuuuuuuuu, apestas, buuuuuuuuuuuuuuuuuuu"; }
          }
    }
}
