using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    public abstract class Persona
    {
        string nombre;
        bool sexo;
        int dni;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public bool Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }

        public int DNI
        {
            set { dni = value; }
            get { return dni; }
        }

       public Persona()
       {nombre="";
        sexo=true;
        dni=0;}

        public string SexoBooleano()
        {if (sexo==true)
    {return "masculino";}
            else
            {return "femenino";}}

        public string toString()
        {return ", su nombre es "+nombre+", su DNI es "+dni+" y su sexo es"+SexoBooleano();}
    }

   public class Cliente : Persona
    {
        int numerocliente;

        public int NumeroCliente
        {
            set { numerocliente = value; }
            get { return numerocliente; }
        }

        public Cliente()
            : base()
        { numerocliente = 0; }

        public string toString()
        { return "El cliente tiene el numero " + numerocliente + base.toString(); }
    }

    public class Cuenta
    {
        int numerocuenta;
        int tipocuenta;
        double saldo;
        Cliente frecuentador;

        public int NumeroCuenta
        {
            set { numerocuenta = value; }
            get { return numerocuenta; }
        }

        public int TipoCuenta
        {
            set { tipocuenta = value; }
            get { return tipocuenta; }
        }

        public double Saldo
        {
            set { saldo = value; }
            get { return saldo; }
        }

        public Cliente Frecuentador
        {
            set { frecuentador = value; }
            get { return frecuentador; }
        }

        public string CuentaEntera()
        {
            if (tipocuenta == 1)
            { return "cuenta corriete"; }
            else
            { return "caja de ahorro"; }
        }

        public Cuenta()
        {
            numerocuenta = 0;
            tipocuenta = 0;
            saldo = 0;
            frecuentador = null;
        }

        public string toString()
        { return "Datos de cuenta: El numero de cuenta es" + numerocuenta + ", la cuenta es " + CuentaEntera()+"Datos del cliente:"+(frecuentador.toString()); }
    }
}
