using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Factura
{
    public partial class Facturador : Form
    {
        int cantVentas;
        double totalGral;

        public Facturador()
        {
            InitializeComponent();
            cantVentas = 0;
            totalGral = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Factura Cosas1 = new Factura(); //Tambien podria ser el "Factura Cosas1" en "public partial class Facturador : Form" y luego solo seria escribir el Cosas1= new Factura() (ideal para cuando se usa el mismo objeto en otros botones
  //          totalGral=totalGral + Cosas1.Total(); Esto no sirve
            Cosas1.Art=txtArticulo.Text;
            Cosas1.Cantidad=Convert.ToInt32(txtCantidad.Text);
            Cosas1.Cliente=txtCliente.Text; //No es necesario poner "Convert.ToString" cuando se escribe texto normal
            Cosas1.Nfactura=Convert.ToInt32(txtNumero.Text);
            Cosas1.Precio=Convert.ToDouble(txtPrecio.Text);
            txtTotal.Text=Convert.ToString(Cosas1.Total());
            lblRCantidadVentas.Text=Convert.ToString(cantVentas++);
            lblRTotalGeneral.Text = Convert.ToString(totalGral += Cosas1.Total());
            MessageBox.Show(Convert.ToString(Cosas1.toString()), "Datos que se ingresaron recien", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Nota: Los numeros no oueden ser convertidos en "float" debido a que no existe en .NET Framework
    }
}