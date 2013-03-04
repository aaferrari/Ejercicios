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
    {	Alumno Fulano;
        int clibre;
        int cregular;
        int cpromocion;

        public FrmAlumno()
        {
            InitializeComponent();
            btnNuevo.Select(); //Ideal para hacer foco en un boton o elemento del programa
            clibre = 0;
            cregular = 0;
            cpromocion = 0;
            //
            // TODO: Añadir codigo constructor despues de la llamada InitializeComponent().
            //
        }


        void BtnSalirClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que queres salir de esta aplicacion?", "¿Salis che?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        void CboTipoDocumentoSelectedIndexChanged(object sender, EventArgs e)
        {
        //  cboTipoDocumento.SelectedIndex = -1; // Sirve para blanquear el combobox
         /* cboTipoDocumento.Items.Clear();
          cboTipoDocumento.Items.Add("DNI");
          cboTipoDocumento.Items.Add("Libreta de Enrrolamiento");
          cboTipoDocumento.Items.Add("Cedulon Federal"); */
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
            btnGrabar.Enabled = false;
            btnNuevo.Enabled = true;
            btnSalir.Enabled = true;
            txtNota1.Enabled=false;
            txtNota2.Enabled=false;
            txtNota3.Enabled=false;
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
            txtNota1.Enabled= queseyo;
            txtNota2.Enabled= queseyo;
            txtNota3.Enabled= queseyo;
            btnGrabar.Enabled = queseyo; //verdadero
            btnNuevo.Enabled = !queseyo; //falso (ojo con el !)
        }

        void BtnNuevoClick(object sender, EventArgs e) // Este boton hace que los componentes deshabilitados se activen para permitir el ingreso de datos 
        {
            habilitador(true);
        }

        void BtnBorrarClick(object sender, EventArgs e)
        {
            habilitador(false);
        }

        void LblLegajoClick(object sender, EventArgs e)
        {

        }

        void TxtLegajoTextChanged(object sender, EventArgs e)
        {// para validar un numero en c#
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

        void BtnGrabarClick(object sender, EventArgs e)
        {
            Fulano = new Alumno();
            Fulano.Legajo = Convert.ToInt32(txtLegajo.Text);
            Fulano.Nombre = Convert.ToString(txtNombre.Text);
            Fulano.Nota1 = Convert.ToInt32(txtNota1.Text);
            Fulano.Nota2 = Convert.ToInt32(txtNota2.Text);
            Fulano.Nota3 = Convert.ToInt32(txtNota3.Text);
            Fulano.Doc = Convert.ToInt32(txtNDocumento.Text);
            Fulano.Apellido = Convert.ToString(txtApellido.Text);
            Fulano.Tdoc = Convert.ToInt32(cboTipoDocumento.SelectedIndex + 1); //Tambien se puede hacer un if, pero eso es mas confuso
            Fulano.Sexo = Convert.ToInt32(rdoMasculino.Checked);
            if (rdoMasculino.Checked == true) //Si es masculino. Esta parte es para los radiobutons y la parte de string se muestra en el ToString()
            { Fulano.Sexo = 1; } //Masculino=1
            else
            {
                if (rdoFemenino.Checked == true)
                { Fulano.Sexo = 2; }
                else
                { Fulano.Sexo = 0; }//Esto es para indicar que no se selecciono ninguna de las opciones anteriores
            }
           
            if (cboTipoDocumento.SelectedIndex == 1)
            { Fulano.Tdoc = 1; }
            else
            	{if (cboTipoDocumento.SelectedIndex == 2 )
            	 { Fulano.Tdoc = 2; }
            	 else
            	 	{if (cboTipoDocumento.SelectedIndex == 3)
            	  	    { Fulano.Tdoc = 3; }
            		else
            		{ Fulano.Tdoc = 0; }}}
       
            lblRPromedio.Text = Convert.ToString(Fulano.Promedio());
            lblEstado.Text = Fulano.CondicionAlumno();
            // Lo que sigue son los condicionales para los contadores (gracias de nuevo Hernan)
            if (Fulano.Promedio() < 4)//Si es menor de 4
            {clibre = clibre + 1;}
            else
            {
                if (Fulano.Promedio() < 8)//Si es menor que 8 y mayor a 4
                {cregular = cregular + 1;}
                else
                {cpromocion = cpromocion + 1;}//Si es mayor que 4 y es de 8 o mas
            }
            lblCAlumLibres.Text = Convert.ToString(clibre);
            lblCAlumPromocionados.Text = Convert.ToString(cpromocion);
            lblCAlumRegulares.Text = Convert.ToString(cregular);
            MessageBox.Show(Fulano.toString());

        }

        private void MensajeError()
        {
            MessageBox.Show("Aca solo se pueden ingresar numeros, y no jodas mas.", "Solo numeros che", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
     }
}