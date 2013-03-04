/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 30/04/2009
 * Hora: 01:29 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Promedios_del_alumnado
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno
	{
            int legajo;
            string nombre;
            decimal nota1;
            decimal nota2;
            decimal nota3;
         //   decimal redondeador;

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

            public decimal pNota1
            {
                set { nota1 = value; }
                get { return nota1; }
            }

            public decimal pNota2
            {
                set { nota1 = value; }
                get { return nota2; }
            }

            public decimal pNota3
            {
                set { nota1 = value; }
                get { return nota3; }
            }
            
        /*    public decimal pRedondeador
            {
                set { redondeador = value; }
                get { return redondeador; }
            } */
               
            public decimal CalcularPromedio()
            { return (nota1 + nota2 + nota3)/3; }

            public string toString()
            {
                return "El nombre del alumno es " + nombre + " y su legajo es " + legajo + ". La nota 1 es " + nota1 + ", la nota 2 es " + nota2 + " y la nota 3 es " + nota3 + ". Para terminar, el promedio final es " + CalcularPromedio();
            }
            
            public Alumno(decimal n1, decimal n2, decimal n3)
            { legajo=0;
            nombre = "";
              nota1=n1;
              nota2=n2;
              nota3=n3;
            }
	}
}
