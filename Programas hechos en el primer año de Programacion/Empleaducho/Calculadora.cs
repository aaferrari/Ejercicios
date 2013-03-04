using System;
using System.Collections.Generic;
using System.Text;

namespace Empleaducho
{
   public class Calculadora
    {
        int legajo;
        string empleado;
        double remuneraciones;
        double asignaciones;
        double retenciones;

       public int Legajo
       {
           set { legajo = value; }
           get { return legajo; }
       }

       public string Empleado
       {
           set { empleado = value; }
           get { return empleado; }
       }

       public double Remuneraciones
       {
           set { remuneraciones = value; }
           get { return remuneraciones; }
       }

       public double Asignaciones
       {
           set { asignaciones = value; }
           get { return asignaciones; }
       }

       public double Retenciones
       {
           set { retenciones = value; }
           get { return retenciones; }
       }
       
   /*    public Calculadora()
       {legajo=0;
       	empleado="";
       	remuneraciones=0;
       	asignaciones=0;
       	retenciones=0;} */
      
       public double SueldoNeto()
       { return remuneraciones + asignaciones - retenciones; }

       public string toString()
       { return "El empleado " + empleado + " con el legajo N°" + legajo + " tiene $" + remuneraciones + " en remuneraciones, $" + asignaciones + " en asignaciones familiares y esas yerbas, $" + retenciones + " en retenciones de todo tipo y el sueldito que le toca cobrar este mes es de $" + SueldoNeto(); }

    }
}
