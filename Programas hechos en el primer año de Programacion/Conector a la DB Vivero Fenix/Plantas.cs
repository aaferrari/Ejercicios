using System;
using System.Collections.Generic;
using System.Text;

namespace Conector_a_la_DB_Vivero_Fenix
{
   public class Plantas
   {
       int codigo;
       string descripcion;
       int codigo_tipo;
       double precio;
       int stock;
       string clima;

       public int Codigo
       {
           set { codigo = value; }
           get { return codigo; }
       }

       public string Descripcion
       {
           set { descripcion = value; }
           get { return descripcion; }
       }

       public int CodigoPlanta
       {
           set { codigo_tipo = value; }
           get { return codigo_tipo; }
       }

       public double Precio
       {
           set { precio = value; }
           get { return precio; }
       }

       public int Stock
       {
           set { stock = value; }
           get { return stock; }
       }

       public string Clima
       {
           set { clima = value; }
           get { return clima; }
       }

       public string toString()
       { return codigo + ";" + descripcion + ";" + codigo_tipo + "; $" + precio + ";" + stock +" unidades"+ ";" + clima; }

       public Plantas()
       {
           codigo_tipo = 0;
           codigo = 0;
           descripcion = "";
           precio = 0;
           stock = 0;
           clima = "";
       }
    }
}
