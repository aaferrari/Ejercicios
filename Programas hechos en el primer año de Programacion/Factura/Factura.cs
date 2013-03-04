using System;
using System.Collections.Generic;
using System.Text;

//Nota mental: Es mejor poner las clases y los atributos en public, sino los formularios que los necesiten no lo podran usar

namespace Factura
{
   public class Factura
    {
        int nfactura;
        string cliente;
        string art;
        double precio;
        int cantidad;

       public int Nfactura
        {
            set { nfactura = value; }
            get { return nfactura; }
        }

       public string Cliente
        {
            set { cliente = value; }
            get { return cliente; }
        }

       public string Art
        {
            set { art = value; }
            get { return art; }
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

       public double Total()
        { return precio * cantidad; }

       public Factura()
        {
            nfactura = 0;
            cliente = "";
            art = "";
            precio = 0;
            cantidad = 0;
        }
       
       public string toString()
       {return "Esta es la factura N° "+nfactura+", el nombre del cliente es "+cliente+", el articulo elegido fue "+art+", su precio unitario es de $"+precio+" y el total a pagar es de $"+Total();
       		}
    }
}
