using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Empleaducho
{
    public partial class FrmEmpleadito : Form
    {
      int contadorEmpleados;
       double acumuladorTotales; 

        public FrmEmpleadito()
        {
         InitializeComponent();
          contadorEmpleados=0;
            acumuladorTotales = 0; 
        }

        private void FrmEmpleadito_Load(object sender, EventArgs e)
        {

        }

        private void Grabar_Click(object sender, EventArgs e)
        {
            Calculadora EmpleaditoMiserable = new Calculadora();
            EmpleaditoMiserable.Legajo = Convert.ToInt32(txtLegajo.Text);
            EmpleaditoMiserable.Empleado = Convert.ToString(txtEmpleado.Text);
            EmpleaditoMiserable.Remuneraciones = Convert.ToDouble(txtRemuneraciones.Text);
            EmpleaditoMiserable.Asignaciones = Convert.ToDouble(txtAsignaciones.Text);
            EmpleaditoMiserable.Retenciones = Convert.ToDouble(txtRetenciones.Text);
            lblTotalSueldoNeto.Text = Convert.ToString(EmpleaditoMiserable.SueldoNeto());
            lblRCantidadEmpleados.Text = Convert.ToString(contadorEmpleados = contadorEmpleados + 1); //Hay que poner todo a Convert.ToString, sino el compilador tira errores
            lblRTotalEmpleados.Text = Convert.ToString(acumuladorTotales = acumuladorTotales + EmpleaditoMiserable.SueldoNeto());
            lblRTotalRemuneraciones.Text = Convert.ToString(acumuladorTotales = acumuladorTotales + EmpleaditoMiserable.Remuneraciones);
            lblRTotalAsignaciones.Text = Convert.ToString(acumuladorTotales = acumuladorTotales + EmpleaditoMiserable.Asignaciones);
            lblRTotalRetenciones.Text = Convert.ToString(acumuladorTotales = acumuladorTotales + EmpleaditoMiserable.Retenciones);
            MessageBox.Show(EmpleaditoMiserable.toString(), "Datos que se procesaron en el programa", MessageBoxButtons.OK);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que queres salir de este pseudo programa (por que a menos que tengas todos los datos que se muestran, anotados en algun lado, se van a perder)?", "¿Salis che?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
    == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("¿Esta seguro de que quiere borrar los datos que ya se ingresaron (fijese que no los va a poder recuperar de nuevo)?", "BRDI (borado rapido de los datos ingresados)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        	    == DialogResult.Yes)

            {txtLegajo.Text="";
            txtEmpleado.Text = "";
            txtAsignaciones.Text = "";
            txtRemuneraciones.Text = "";
            txtRetenciones.Text = "";}
        }

    }
}