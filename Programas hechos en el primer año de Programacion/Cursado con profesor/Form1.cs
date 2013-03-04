using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cursado_con_profesor
{
    public partial class FrmCursos : Form// Ejemplo general de herencia
    {
        double mayorsueldito;
        int contador;
        int cuentahombres;
        int cuentamujeres;
        public FrmCursos()
        {
            InitializeComponent();
            mayorsueldito = 0;
            contador = 0;
            cuentahombres = 0;
            cuentamujeres = 0;
        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        {// No es necesario hacer la clase Persona ya que el Profesor ya es una persona
            Profesor Fulano = new Profesor();
            Curso DondeSea = new Curso();
            Fulano.DNI = Convert.ToInt32(txtDNI.Text);
            Fulano.Legajo = Convert.ToInt32(txtLegajo.Text);
            Fulano.Nombre = txtNombre.Text;
            Fulano.Sueldo = Convert.ToDouble(txtSueldo.Text);
            DondeSea.Aula = Convert.ToInt32(txtAula.Text);
            DondeSea.Nombre = txtNombreAula.Text;
            DondeSea.Turno = txtTurno.Text;
            DondeSea.Profe = Fulano;
            if (mayorsueldito == 0) //Si el sueldo del profesor es igual que el atributo "mayorsueldo" (que por defecto esta en 0)
            {
                mayorsueldito = 1; //Se lo pone igual a 1 para que tenga algo que comparar la primera vez que se ingresen los datos
                mayorsueldito = DondeSea.Profe.Sueldo;
                lblCSueldoMayor.Text = Convert.ToString(mayorsueldito);
                lblNProfeCobraMas.Text = DondeSea.Profe.Nombre;
                lblNCursoDeMayorSueldo.Text = DondeSea.Nombre;
            }
            else
            {
                if (DondeSea.Profe.Sueldo > mayorsueldito) //Sino es igual al sueldo mayor, hace todo el proceso de nuevo y pasa por alto el valor ingrsado (o algo asi). Es para evitar poner un valor arbitrario que nos pueda perjudicar en el futuro
                {
                    mayorsueldito = DondeSea.Profe.Sueldo;
                    lblCSueldoMayor.Text = Convert.ToString(mayorsueldito);
                    lblNProfeCobraMas.Text = DondeSea.Profe.Nombre;
                    lblNCursoDeMayorSueldo.Text = DondeSea.Nombre;
                }
            }
            lblCRegistros.Text = Convert.ToString(contador = contador + 1);
            
                 if (rdbMasculino.Checked == true)
            { DondeSea.Profe.Sexo = 1; }
            else
            {
                if (rdbFemenino.Checked == true)
                { DondeSea.Profe.Sexo = 2; }
                else
                { DondeSea.Profe.Sexo = 0; } 
            }
            
            MessageBox.Show(DondeSea.toString()); //Lo recomendable es dejar el mensaje para lo ultimo, ya que parece que programa procesa las lineas de codigo de forma secuencial y esto puede hacer que no se muiestren todos los datos (como el sepso :-P )

            if (rdbFemenino.Checked==true)
            { lblCProfeF.Text = Convert.ToString(cuentamujeres = cuentamujeres + 1); }

            if (rdbMasculino.Checked == true)
            { lblCProfeM.Text = Convert.ToString(cuentahombres = cuentahombres + 1); } 
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTurno.Items.Add("Mañana");
            cmbTurno.Items.Add("Tarde");
            cmbTurno.Items.Add("Noche");
        }


    }
}