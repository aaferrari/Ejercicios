using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Objetos_matriciales
{
    public partial class FrmVideo : Form
    {//int tamanio;
        int contador;
        Objetos_matriciales.Persona[] DatosdeFulanodeTal = new Persona[] {
        	        	null,
        	        	null,
        	        	null,
        	        	null,
        	        	null};
       // Persona FulanoDeTal;
        public FrmVideo()
        {//tamanio=0;//Indica el tamaño de la cantidad de datos contenidos en la matriz
         contador=0;

     /*    DatosdeFulanodeTal[0]=null;
        DatosdeFulanodeTal[1]=null;
        DatosdeFulanodeTal[2]=null;
        DatosdeFulanodeTal[3]=null;
        DatosdeFulanodeTal[4]=null; */ //En vez de poner a null todas los espacios de la matriz se lo podria hacer mediante un for
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona FulanoDeTal = new Persona();
            FulanoDeTal.Apellido = txtApellido.Text;//Tambien podria ser Matriz[contador].Apellido =....
            FulanoDeTal.Doc = Convert.ToInt32(txtNDocumento.Text);
            FulanoDeTal.Nombre = txtNombre.Text;
            FulanoDeTal.Sexo = Convert.ToInt32(rdoMasculino.Checked);
            if (rdoMasculino.Checked == true)
            { FulanoDeTal.Sexo = 1; }
            else
            {
                if (rdoFemenino.Checked == true)
                { FulanoDeTal.Sexo = 2; }
                else
                { FulanoDeTal.Sexo = 0; }
            }

            if (contador < 5)
            {
            	DatosdeFulanodeTal[contador] = FulanoDeTal;//Carga la persona en el vector
                contador++;
            }
            else
            {MessageBox.Show("Matriz llena", "Listo",MessageBoxButtons.OK);}
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador < DatosdeFulanodeTal.Length; contador++)
            {if (DatosdeFulanodeTal[contador] != null)
            	{lstColectora.Items.Add(DatosdeFulanodeTal[contador].toString()); }
            else
            {MessageBox.Show("Se esta intentando agregar una matriz vacia, se salteara y se pasara a la siguiente (si hay)", "Advertencia"); //Tambien se podria usar lstColectora.Items.Add(""); para que agregue una linea vacia en el listbox, pero a largo plazo seria un problema ;-)
            }
            }
            
        }
        
        void Button1Click(object sender, EventArgs e)
        {for (int contador = 0; contador < DatosdeFulanodeTal.Length; contador++)
        	{if (DatosdeFulanodeTal[contador].Sexo == 1) //Si el sexo es masculino agrega el dato correspondiente de ma matriz a un listbox, sino lo agrega a otro
            	{lstHombres.Items.Add(DatosdeFulanodeTal[contador].toString()); }
        	else
        		{lstMujeres.Items.Add(DatosdeFulanodeTal[contador].toString());}}
        }
    }
}