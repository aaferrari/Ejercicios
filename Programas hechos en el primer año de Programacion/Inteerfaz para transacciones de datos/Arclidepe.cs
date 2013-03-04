using System;
using System.Collections.Generic;
using System.Text;

namespace Inteerfaz_para_transacciones_de_datos
{
 public class Articulo
    {
        int codigo_articulo;
        string nombre_articulo;
        double precio;

        public int CodigoArti
        {
            set { codigo_articulo = value; }
            get { return codigo_articulo; }
        }

        public string NombreArti
        {
            set { nombre_articulo = value; }
            get { return nombre_articulo; }
        }

        public double Precio
        {
            set { precio = value; }
            get { return precio; }
        }

        public Articulo()
        {
            codigo_articulo = 0;
            nombre_articulo = "";
            precio = 0;
        }
    }

    public class Clientes
    {
        int codigo_cliente;
        string nombre_cliente;
        string calle;
        int numero_calle;
        int barrio;

        public int CodigoClle
        {
            set { codigo_cliente = value; }
            get { return codigo_cliente; }
        }

        public string NombreClie
        {
            set { nombre_cliente = value; }
            get { return nombre_cliente; }
        }

        public string Calle
        {
            set { calle = value; }
            get { return calle; }
        }

        public int NumeroCa
        {
            set { numero_calle = value; }
            get { return numero_calle; }
        }

        public int Barrio
        {
            set { barrio = value; }
            get { return barrio; }
        }

        public Clientes()
        {
            codigo_cliente = 0;
            nombre_cliente = "";
            calle = "";
            numero_calle = 0;
            barrio = 0;
        }
    } 

    public class Pedidos
    {
        int codigo_pedido;
        int sucursal;
        int codigo_cliente;
        DateTime fecha;
        double subtotal;
        double descuentillo;
        double total;




        public int CodigoPed
        {
            set { codigo_pedido = value; }
            get { return codigo_pedido; }
        }

        public int Sucursal
        {
            set { sucursal = value; }
            get { return sucursal; }
        }

        public int CodigoClle
        {
            set { codigo_cliente = value; }
            get { return codigo_cliente; }
        }

        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public double Subtotal
        {
            set { subtotal = value; }
            get { return subtotal; }
        }

        public double Descuento
        {
            set { descuentillo = value; }
            get { return descuentillo; }
        }

        public double Total
        {
            set { total = value; }
            get { return total; }
        }

        public Pedidos()
        {
            codigo_cliente = 0;
            codigo_pedido = 0;
            descuentillo = 0;
            subtotal = 0;
            sucursal = 0;
            total = 0;
            fecha = DateTime.Today;
        }
    }

    public class Detalle
    {
        int codigo_articulo;
        double precio;
        int cantidad;
        int codigo_pedido;
        int sucursal;

        public int CodigoArti
        {
            set { codigo_articulo = value; }
            get { return codigo_articulo; }
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

        public int CodigoPed
        {
            set { codigo_pedido = value; }
            get { return codigo_pedido; }
        }

        public int Sucursal
        {
            set { sucursal = value; }
            get { return sucursal; }
        }

        public Detalle()
        {

            cantidad = 0;
            codigo_articulo = 0;
            precio = 0;
            codigo_pedido = 0;
            sucursal = 0;
        }
    }

   /* public class ClaseExtra
    {
        public string nombre_articulo;
        public int cantidad;
        public double importe;
        
        public string Articulo
        {set {nombre_articulo=value;}
         get {return nombre_articulo;}
         }
        
        public int Cantidad
        {set  {cantidad=value;}
         get  {return cantidad;}}
        
        public double Importe
        {set  {importe=value;}
         get  {return importe;}}
        
        public ClaseExtra(string nombre_articulo, int cantidad, double importe)
        {
           this.nombre_articulo=nombre_articulo;
           this.cantidad=cantidad;
           this.importe=importe;
        }
    } */
}
