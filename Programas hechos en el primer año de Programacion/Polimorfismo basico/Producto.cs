using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo_basico
{
   public abstract class Producto
   {
       int codigo;
       string nombre;
       string marca;
       double precio;
       int controlador; //Esto servira para ver si es un producto suelto o un enpaquetado a la hora de poner los datos en los listboxes

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

       public string Marca
       {
           set { marca = value; }
           get { return marca; }
       }

       public double Precio
       {
           set { precio = value; }
           get { return precio; }
       }
       
       public int Controlador
       	{ set {controlador=value;}
       	  get {return controlador;}}

       public abstract double getPrecio();// Si a un metodo abstracto se le pone como "void", entonces cuando se ejecute el programa, luego este metodo no podra retornar resultados

       public abstract string toString();

       public Producto()
       {
           codigo = 0;
           nombre = "";
           marca = "";
           precio = 0;
           controlador=0;
       }
    }

    public class Pack : Producto
    {
        int cantidad;

        public int Cantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }

        public override double getPrecio()
        { return base.Precio * cantidad; }

        public override string toString()
        {
            return base.Codigo + ";" + base.Marca + ";" + base.Nombre + ";"+cantidad+";"+ + base.Precio + ";" + getPrecio();
        }

        public Pack()
            : base()
        { cantidad = 0; }
    }

    public class Suelto : Producto
    {
        double medida;
        string unidad_medida;

        public double Medida
        {
            set { medida = value; }
            get { return medida; }
        }

        public string Unidad_medida
        {
            set { unidad_medida = value; }
            get { return unidad_medida; }
        }

        public override double getPrecio()
        { return base.Precio * medida; }

        public override string toString()
        {
            return base.Codigo + ";" + base.Marca + ";" + base.Nombre + ";" + medida + ";" + unidad_medida + ";" + +base.Precio + ";" + getPrecio();
        }
        
        public Suelto():
        	base()
        	{medida=0;
        	unidad_medida="";}
    }
}
