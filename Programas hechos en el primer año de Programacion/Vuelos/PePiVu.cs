using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_con_bases_de_datos
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        bool sexo;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public bool Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public string SexoBooleano()
        {if (sexo==true)
        	{return "hombre"; }
         else
         	{return "mujer"; }}

        public Persona()
        {
            nombre = "";
            apellido = "";
            sexo = true;
        }

        public string toString()
        { return nombre +" "+ apellido + ", su sexo es " + SexoBooleano(); }
    }

    public class Piloto:Persona
    {
        int categoria;

        public int Categoria
        {
            set { categoria = value; }
            get { return categoria; }
        }

        public Piloto():base()
        { categoria = 0; }

        public string CategoriaSwicheana()
        {string loquesea;
        	switch (categoria)
        	{case 1: {loquesea="A"; break;}
        	 case 2: {loquesea="B"; break;}
        	 case 3: {loquesea="C"; break;}
    		 default :{loquesea="nula"; break;}}
            return loquesea;}
        	         	
        public string toString()
        { return base.toString()+" y es de castegoria " + CategoriaSwicheana(); }
    }

    public class Vuelo
    {
        int numero;
        string origen;
        int destino;
        double monto;
        Piloto piloto;

        public int Numero
        {
            set { numero = value; }
            get { return numero; }
        }

        public string Origen
        {
            set { origen = value; }
            get { return origen; }
        }

        public int Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public double Monto
        {
            set { monto = value; }
            get { return monto; }
        }

        public Piloto Piloto
        {
            set { piloto = value; }
            get { return piloto; }
        }

        public Vuelo()
        {
            numero = 0;
            origen = "";
            destino = 0;
            monto = 0;
            piloto = null;
        }

		public string DestinoSwitcheano()
        {string loquesea;
        	switch (destino)
        	{case 1: {loquesea="Buenos Aires"; break;}
        	 case 2: {loquesea="Santa Fe"; break;}
        	 case 3: {loquesea="Mendoza"; break;}
    		 default :{loquesea="Ninguno"; break;}}
            return loquesea;}
             
        public string toString()
        { return "El numero de este vuelo es " + numero + ", se va a salir desde " + origen + " y se aterrizara en " + DestinoSwitcheano() + ". El monto es de $" + monto + " y el piloto asignado es " + (piloto.toString()); }
    }
}
