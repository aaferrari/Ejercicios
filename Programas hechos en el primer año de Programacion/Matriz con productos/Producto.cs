using System;
using System.Collections.Generic;
using System.Text;

namespace Matriz_con_productos
{
   public class Producto
   {
       int codigo;
       string nombre;
       int tipo;
       double precio;
       int cantidad;

       public int Codigo
       {
           set { codigo = value; }
           get { return codigo; }
       }

       public string Nombre
       {
           set { nombre = value; }
           get { return nombre; }
       }

       public int Tipo
       {
           set { tipo = value; }
           get { return tipo; }
       }

       public double Precio
       {
           set { precio = value; }
           get { return precio; }
       }

       public int Cantidad
       {
           set { cantidad = value; }
           get { return cantidad; }
       }

       public Producto()
       {
           codigo = 0;
           nombre = "";
           tipo = 0;
           precio = 0;
           cantidad = 0;
       }

       public string TipoCondicionado()
       {
           string TipoProducto;
           if (tipo == 1)
               TipoProducto = "Alimento";
           else
               if (tipo == 2)
                   TipoProducto = "Limpieza";
               else
                   TipoProducto = "Bazar";
           return TipoProducto;
       }

       public string toString()
       { return codigo + "|" + nombre + "|" + TipoCondicionado() + "|" + precio + "|" + cantidad; }


    }
}
