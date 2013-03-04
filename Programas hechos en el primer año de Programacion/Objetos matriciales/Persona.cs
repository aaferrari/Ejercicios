using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos_matriciales
{
   public class Persona
    {   string nombre;
        string apellido;
        int doc;
        int sexo;

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

        public int Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        } 

        public Persona()
        {
            nombre = "";
            apellido= "";
            doc = 0;
            sexo = 0;
        }

        public string toString()
        { return  nombre + ";" + apellido + ";" + SexoCondicionado() + ";" + doc; }

        public string SexoCondicionado()
        {
            if (sexo == 1) //Aca puede se igual a cualquier caracter, pero el profesor lo queria hacer con 1
            {return "masculino"; }
                
 			else
            { if (sexo == 2)
                { return "femenino"; }
 			  else
 				{return "no indicado"; }//Por si no se marca ninguno de los radiobotones (gracias Hernan)
            }
            
        }
    }
}
