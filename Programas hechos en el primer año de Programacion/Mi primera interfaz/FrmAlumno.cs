/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 28/04/2009
 * Hora: 10:37 p.m.
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mi_primera_interfaz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FrmAlumno : Form
	{
		public FrmAlumno()
		{
			//
			// La llamada InitializeComponent() es requerida para soportar el diseñador de Windows Forms.
			//
			InitializeComponent();
            btnNuevo.Select(); //Ideal para hacer foco en un boton o elemento del programa
		
			//
			// TODO: Añadir codigo constructor despues de la llamada InitializeComponent().
			//
		}
		
		
		void BtnSalirClick(object sender, EventArgs e)
	      {
            if (MessageBox.Show("¿Seguro que queres salir de esta aplicacion?", "¿Salis che?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.Yes)
            { this.Close();
            }
        }
		
		void CboTipoDocumentoSelectedIndexChanged(object sender, EventArgs e)
		{
			cboTipoDocumento.SelectedIndex = -1; // Sirve para blanquear el combobox (seria util si hubiera algo de texto aqui)

		}
		
		void FrmAlumnoLoad(object sender, EventArgs e)
		{ //Aqui se define coo se vera el formulario cuando el programa se abra
			txtLegajo.Enabled = false;
            txtApellido.Enabled = false;
            txtNDocumento.Enabled = false;
            txtNombre.Enabled = false;
            cboTipoDocumento.Enabled = false;
            rdoFemenino.Enabled = false;
            rdoMasculino.Enabled = false;
            chkSoltero.Enabled = false;
            btnCancelar.Enabled = false;
            btnGrabar.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            btnSalir.Enabled = true;
   		}
		
		private void habilitador(bool queseyo) //Metodo booleano para setear los campos del formulario y que se puede usar con los botones
        {
            txtLegajo.Enabled = queseyo;
            txtApellido.Enabled = queseyo;
            txtNDocumento.Enabled = queseyo;
            txtNombre.Enabled = queseyo;
            cboTipoDocumento.Enabled = queseyo;
            rdoFemenino.Enabled = queseyo;
            rdoMasculino.Enabled = queseyo;
            chkSoltero.Enabled = queseyo;
            btnCancelar.Enabled = queseyo;
            btnGrabar.Enabled = queseyo; //verdadero
            btnNuevo.Enabled = !queseyo; //falso (ojo con el !)
            btnModificar.Enabled = !queseyo;
/*          btnBorrar.Enabled = !queseyo;
            btnSalir.Enabled = !queseyo; 

            Las 2 lineas de arriba fueron deshabilitadas por las dudas */
        }
		
		void BtnNuevoClick(object sender, EventArgs e) // Este boton hace que los componentes deshabilitados se activen para permitir el ingreso de datos 
		{
			habilitador(true);
				/* Esta forma de setear los campos se puede usar en lugar del metodo "habilitador", pero, tiene la desventaja de que cuando se le agreguen nuewvos elementos al formulario, habra que hacer varias ediciones mas en el codigo fuente del formulario para que esto funcione bien
	        
			txtLegajo.Enabled = true;
            txtApellido.Enabled = true;
            txtNDocumento.Enabled = true;
            txtNombre.Enabled = true;
            cboTipoDocumento.Enabled = true;
            rdoFemenino.Enabled = true;
            rdoMasculino.Enabled = true;
            chkSoltero.Enabled = true;
            btnCancelar.Enabled = true;
            btnGrabar.Enabled = true;
            txtApellido.Text = "rjnrg";
            txtLegajo.Text = "fhktyk";
            txtNDocumento.Text = "";
            txtNombre.Text = ""; */
		}
		
	    void BtnBorrarClick(object sender, EventArgs e)
		{
			habilitador(false);
		}
		
		void LblLegajoClick(object sender, EventArgs e)
		{
			
		}
		
		void TxtLegajoTextChanged(object sender, EventArgs e)
		{
            if (String.IsNullOrEmpty(txtLegajo.Text)) ;
            {
                MessageBox.Show("Aca solo se pueden ingresar numeros, y no jodas mas.", "Solo numeros che", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

           // para validar un numero en c#
            int i = 0;
            bool num = int.TryParse(txtLegajo.Text, out i);
            if (num == true)
            {
                //es numero
            }
            else
            {
               // MessageBox.Show("Aca solo se pueden ingresar numeros, y no jodas mas.", "Solo numeros che", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
		}
		
		void LblNombreClick(object sender, EventArgs e)
		{
			
		}
		
		void TxtNombreTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void LblApellidoClick(object sender, EventArgs e)
		{
			
		}
		
		void TxtApellidoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void LblTipoDocumentoClick(object sender, EventArgs e)
		{
			
		}
		
		void LblNDocumentoClick(object sender, EventArgs e)
		{
			
		}
		
		void TxtNDocumentoTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void LblSexoClick(object sender, EventArgs e)
		{
			
		}
		
		void RdoMasculinoCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void RdoFemeninoCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void LblSolteroClick(object sender, EventArgs e)
		{
			
		}
		
		void ChkSolteroCheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnGrabarClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			
		}

        private void MensajeError()
        {         
                MessageBox.Show("Aca solo se pueden ingresar numeros, y no jodas mas.", "Solo numeros che", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
	}
}