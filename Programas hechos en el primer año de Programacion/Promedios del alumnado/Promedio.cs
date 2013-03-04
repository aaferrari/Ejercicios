using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Promedios_del_alumnado
{
    public partial class FrmPromedio : Form
    {int contador; //Incrementa + 1 el label de cantidad
    decimal sumapromedios; //Suma los promedios que se van calculando
  
        public FrmPromedio()
        {
            InitializeComponent();
         // Debajo se inicializan los dos metodos que puse antes
            contador = 0;
            sumapromedios=0;
        
          }

        private void FrmPromedio_Load(object sender, EventArgs e)
        {
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
          
        }

        
        void TxtNombreTextChanged(object sender, EventArgs e)
        {
        	
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnRegistrar_Click(object sender, EventArgs e)
        { //Mejor se hace el nuevo objeto aqui o sino te volves loco
            Alumno Fulano1 = new Alumno(Convert.ToDecimal(txtNota1.Text), Convert.ToDecimal(txtNota2.Text), Convert.ToDecimal(txtNota3.Text));
            Fulano1.pLegajo = Convert.ToInt32(txtLegajo.Text);
            Fulano1.pNombre = Convert.ToString(txtNombre.Text);
       /*   Fulano1.pNota1 = Convert.ToInt32(txtNota1.Text);
            Fulano1.pNota2 = Convert.ToInt32(txtNota2.Text);
            Fulano1.pNota3 = Convert.ToInt32(txtNota3.Text); */
            lblResultado.Text = Convert.ToString(Fulano1.CalcularPromedio());
            MessageBox.Show(Convert.ToString(Fulano1.toString()), "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblRCantidad.Text = Convert.ToString(contador = contador + 1); //Tambien podria haber sido "contador=contador++"
            lblRPromedioGeneral.Text = Convert.ToString(sumapromedios = sumapromedios + Fulano1.CalcularPromedio() /*Aqui tambien puede ser "sumapromedios+=(Fulano1.CalcularPromedio())" */ / contador);
        }

        public void txtLegajo_TextChanged(object sender, EventArgs e)
        { //Lo que abajo se muestra es un validador defectuoso, para mas informacion vease: http://www.laneros.com/archive/index.php/t-79541.html
        	/*if ((e.TextChanged >= 47 && e.TextChanged <= 58) || (e.TextChanged==8) )
			{
			e.Handled = false;
			return;
			}
			else
			{
			e.Handled = true;
			return;
			} */
	   } 
        
        
        void BtnNuevoClick(object sender, EventArgs e)
        {txtLegajo.Text="";
         txtNombre.Text="";
         txtNota1.Text="";
         txtNota2.Text="";
         txtNota3.Text="";
       
        }
    }

}