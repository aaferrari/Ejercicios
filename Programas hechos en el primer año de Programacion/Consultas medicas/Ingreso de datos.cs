using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Consultas_medicas
{
    public partial class FrmConsultasMedicas : Form
    {
        double consultamascara;
        double consultamenoscara;
        int porclinica;
        int porpediatrica;
        int porcardiologica;
        int chombre;
        int cmujer;
        int porhombre;
        int pormujer;
        int contadorgeneral;
        int totalesespecialidades;
        int totalsexos;
        int banderaonoseque;

        public FrmConsultasMedicas()
        {
            InitializeComponent();
            consultamascara = 0;
            consultamenoscara = 0;
            porcardiologica = 0;
            porclinica = 0;
            porhombre = 0;
            pormujer = 0;
            porpediatrica = 0;
            chombre = 0;
            cmujer = 0;
            contadorgeneral = 0;
            totalesespecialidades =0;
            banderaonoseque=0;
        }

        private void btnRegistrador_Click(object sender, EventArgs e)
        {
        	Medico Fulano = new Medico();
            Paciente Mengano = new Paciente();
            Consulta ConsultorioDelHorror = new Consulta(); //Los objetos de clases compuestas se deben crear despues de los objetos de clases con herencia ;-)
            Fulano.Apellido=txtApellidoMed.Text;
            Fulano.DNI=Convert.ToInt32(txtNDocMed.Text);
            Fulano.Matricula=Convert.ToInt32(txtMatricula.Text);
            Fulano.Nombre=txtNombreMed.Text;
            Fulano.Especialidad=Convert.ToInt32(cmbEspecialidad.SelectedIndex+1);
            Fulano.TipoDoc=Convert.ToInt32(cmbTipoDocMed.SelectedIndex+1);
            Fulano.Sexo=Convert.ToBoolean(rdbHombreMed.Checked);
            Mengano.Apellido=txtApellidoPac.Text;
            Mengano.DNI=Convert.ToInt32(txtNDocPac.Text);
            Mengano.Nombre=txtNombrePac.Text;
            Mengano.NumeroHC=Convert.ToInt32(txtHistorial.Text);
            Mengano.ObraSocial=txtObraSocial.Text;
            Mengano.TipoDoc=Convert.ToInt32(cmbTipoDocPac.SelectedIndex+1);
            Mengano.Sexo=Convert.ToBoolean(rdbHombrePac.Checked);
            ConsultorioDelHorror.Consultorio = Convert.ToInt32(txtConsultorio.Text);
            ConsultorioDelHorror.Importe=Convert.ToDouble(txtImporteConsulta.Text);
            ConsultorioDelHorror.Medicus=Fulano;//Medico de esta consulta
            ConsultorioDelHorror.Pacientae=Mengano;//Paciente de esta consulta

            if (ConsultorioDelHorror.Medicus.Sexo == true)
            {Fulano.Sexo=true;}
            else
            {Fulano.Sexo=false;}

            if (ConsultorioDelHorror.Pacientae.Sexo ==true)
            {Mengano.Sexo=true;}
            else
            {Mengano.Sexo=false;}

            if (ConsultorioDelHorror.Medicus.TipoDoc == 1)// Parte de la informacion para hacer esto proviene de http://mundocharp.blogspot.com/2006/07/ver-valores-combobox.html
            { Fulano.TipoDoc = 1; }
            else
            {
                if (ConsultorioDelHorror.Medicus.TipoDoc == 2)
                { Fulano.TipoDoc = 2; }
                else
                { Fulano.TipoDoc = 3; }

            }

            if (ConsultorioDelHorror.Pacientae.TipoDoc == 1)
            { Mengano.TipoDoc = 1; }
            else
            {
                if (ConsultorioDelHorror.Pacientae.TipoDoc == 2)
                { Mengano.TipoDoc = 2; }
                else
                { Mengano.TipoDoc = 3; }
            }
            
            if (ConsultorioDelHorror.Medicus.Especialidad ==1)
            {Fulano.Especialidad=1;}
            else
            {if (ConsultorioDelHorror.Medicus.Especialidad==2)
            		{Fulano.Especialidad=2;}
             else
             	{Fulano.Especialidad=3;}}
            
            MessageBox.Show(ConsultorioDelHorror.toString());
            if (banderaonoseque==0)//Mayor importe
               {banderaonoseque=1;
                consultamascara=ConsultorioDelHorror.Importe;
                lblPrecioConsultaCara.Text = Convert.ToString(consultamascara);
            }
            else
            {if (ConsultorioDelHorror.Importe > consultamascara)
                {consultamascara=ConsultorioDelHorror.Importe;
                lblPrecioConsultaCara.Text = Convert.ToString(consultamascara);
            }}

            if (ConsultorioDelHorror.Importe < consultamascara) //Menor importe
            {consultamenoscara = ConsultorioDelHorror.Importe;
            lblPrecioConsultaMenosCara.Text = Convert.ToString(consultamenoscara);}
           else
           {if (consultamenoscara > ConsultorioDelHorror.Importe && consultamenoscara < consultamascara)
            {consultamenoscara=ConsultorioDelHorror.Importe;
            lblPrecioConsultaMenosCara.Text = Convert.ToString(consultamenoscara);
            }}
            lblPrecioPromedio.Text = Convert.ToString(ConsultorioDelHorror.Importe / (contadorgeneral = contadorgeneral + 1));

            switch (ConsultorioDelHorror.Medicus.Especialidad)
            {case 1: { 
                	porpediatrica++;
                	totalesespecialidades = porcardiologica + porclinica + porpediatrica;
                	lblCPorcentajePedriatico.Text = Convert.ToString(porpediatrica  * 100);//Saca el porcentaje de las consultas pediatricas
                	break; } 
             case 2 :{
                	porclinica++;
                	totalesespecialidades = porcardiologica + porclinica + porpediatrica;
                	lblCPorcentajeClinico.Text = Convert.ToString(porclinica  * 100);//Saca el porcentaje de las consultas clinicas
                 break;}
             case 3: {
            			porcardiologica++;
            			totalesespecialidades = porcardiologica + porclinica + porpediatrica; ;//Suma los contadores de las especialidades (el resultado se utilizara luego para determinar un porcentaje)
            			lblCPorcentajeCardiologo.Text = Convert.ToString(porcardiologica  * 100); //Saca el porcentaje de las consultas cardiologicas
                break;}
            }
            
            if (ConsultorioDelHorror.Pacientae.Sexo)//Se le podria agregar tambien .......  == true, pero, es exactamente lo mismo
            {  porhombre++; }
            else
            { pormujer++; }
            lblCPacienteHombre.Text=Convert.ToString(porhombre);
            lblCPacienteMujer.Text=Convert.ToString(pormujer);
            totalsexos=porhombre+pormujer;//Inicializo el atributo aqui para evitar el error de "division por cero" (esto es lo mismo que el atributo del porcentaje de especialidades, pero, para los sexos)
            lblCPorcentajeHombres.Text=Convert.ToString(porhombre/totalsexos*100);
            lblCPorcentajeMujeres.Text=Convert.ToString(pormujer/totalsexos*100);
        
        }

    }

}