using System;
using System.Collections.Generic;
using System.Text;

namespace Consultas_medicas
{
    public class Persona // El abstrac es para indicar que esta es una clase abtracta (por que es una abstracion de la realidad y bla, bla, bla)
    {
        string nombre;
        int dni;
        string apellido;
        bool sexo;
        int tipodoc;


        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int DNI
        {
            set { dni = value; }
            get { return dni; }
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

        public int TipoDoc
        {
            set { tipodoc = value; }
            get { return tipodoc; }
        }

        public string SexoBooleano()
        {
            if (sexo)// Equivale al "if (sexo == true)"
                return "masculino";
            else
                return "femenino";
        }

        public string TipoDocumentoCondicionado()
        {
            string td; //Variable local del metodo o algo asi
            if (tipodoc == 1)
                td = "DNI";
            else
                if (tipodoc == 2)
                    td = "Cedulon Federal";
                else
                    td = "Libreta de Enrolamiento";
            return td; //Retorna lo que se eligio
        }

        public Persona()
        {
            nombre = "";
            apellido = "";
            dni = 0;
            tipodoc = 0;
            sexo = true;
        }

        public string toString()
        { return "Su nombre es " + nombre + ", su tipo de documento es "+TipoDocumentoCondicionado()+ ", su numero de documento es " + dni + " y su sexo es " + SexoBooleano() + ". "; }

    }

    public class Medico : Persona
    {
        int matricula;
        int especialidad;

        public int Matricula
        {
            set { matricula = value; }
            get { return matricula; }
        }

        public int Especialidad
        {
            set { especialidad = value; }
            get { return especialidad; }
        }

        public string EspecialidadSwitcheana()
        {string eso;
            switch (especialidad)
            {case 1:/* Si es string deberia ser algo como "A"*/ {eso="Pediatria";
             break;}
            case 2: {eso="Clinica";
             break;}
            case 3: {eso="Cardiologo";
             break;}
            default :{eso="Otra cosa que nada que ver";
            break;}}
            return eso;
        }

        public Medico(): base()
        {
            matricula = 0;
            especialidad = 0;
        }

        public string toString()
        { return "\nDatos del doctor: " + base.toString() + " con matricula N°" + matricula + " y su especialidad es " + EspecialidadSwitcheana(); }
    }

    public class Paciente : Persona
    {
        int numerohc;
        string obrasocial;

        public int NumeroHC
        {
            set { numerohc = value; }
            get { return numerohc; }
        }

        public string ObraSocial
        {
            set { obrasocial = value; }
            get { return obrasocial; }
        }

        public Paciente()
            : base()
        {
            numerohc = 0;
            obrasocial = "";
        }

        public string toString()
        { return "\nDatos del paciente: " + base.toString() + ", su numero de historia clinica es " + numerohc + " y su obra social es " + obrasocial; }
    }

    public class Consulta
    {
        int consultorio;
        DateTime fecha;
        double importe;
        Medico medicus;
        Paciente pacientae;

        public int Consultorio
        {
            set { consultorio = value; }
            get { return consultorio; }
        }

        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public double Importe
        {
            set { importe = value; }
            get { return importe; }
        }

        public Medico Medicus
        {
            set { medicus = value; }
            get { return medicus; }
        }

        public Paciente Pacientae
        {
            set { pacientae = value; }
            get { return pacientae; }
        }

        public Consulta()
        {
            consultorio = 0;
            fecha = DateTime.Now.Date;//Usa la fecha de hoy
            importe = 0;
            medicus = null;
            pacientae = null;
        }

        public string toString()
        { return "Datos generales de la consulta: el consultorio donde toca atender hoy " + fecha + " es el N°" + consultorio + " y el importe a cobrar es de $" + importe + "."+(medicus.toString()) + (pacientae.toString()); }
    }
}
