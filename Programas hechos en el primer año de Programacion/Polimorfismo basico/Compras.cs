using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Polimorfismo_basico
{
    public partial class Compras : Form
    {
        int incrementador;
        Producto[] DatosDeLaCompra = new Producto[5];
        public Compras()
        {
            for (int incrementador = 0; incrementador < 5; incrementador++)
                { DatosDeLaCompra[incrementador] = null; }
            InitializeComponent();

        }

        public void btnProcesar_Click(object sender, EventArgs e)
        {if (rdbPaquete.Checked == true)
            {
               /* txtCantidad.Enabled = true;
                txtMedida.Enabled = false;
                cmbUnidadMedida.Enabled = false; */
                Pack CompraEmpaquetada = new Pack();
                CompraEmpaquetada.Cantidad = Convert.ToInt32(txtCantidad.Text);
                CompraEmpaquetada.Codigo = Convert.ToInt32(txtCodigo.Text);
                CompraEmpaquetada.Marca = txtMarca.Text;
                CompraEmpaquetada.Nombre = txtNombre.Text;
                CompraEmpaquetada.Precio = Convert.ToDouble(txtPrecio.Text);
                if(rdbPaquete.Checked == true) //Si un radioboton fue seleccionado, entonces el atributo controlador guardara uno u otro numero, luego esto se usara en los otros botones para que determinen si lo que van a mostrar es un producto suelto o empaquetado
                {CompraEmpaquetada.Controlador =1;}
                		
                    if (incrementador < 5)
                    {
                        DatosDeLaCompra[incrementador] = CompraEmpaquetada;
                        incrementador++;
                    }
                    else
                    {MessageBox.Show("Esta matriz se lleno, por favor, vaciela y pruebe de nuevo");
                    }
                
            }
            else
            {
                if (rdbSuelto.Checked == true)
                {
                   /* txtCantidad.Enabled = false;
                    txtMedida.Enabled = true;
                    cmbUnidadMedida.Enabled = true; */
                    Suelto CompraSuelta = new Suelto();
                    CompraSuelta.Codigo = Convert.ToInt32(txtCodigo.Text);
                    CompraSuelta.Marca = txtMarca.Text;
                    CompraSuelta.Medida = Convert.ToInt32(txtMedida.Text);
                    CompraSuelta.Nombre = txtNombre.Text;
                    CompraSuelta.Precio = Convert.ToDouble(txtPrecio.Text);
                    CompraSuelta.Unidad_medida = cmbUnidadMedida.Text;
                    if (rdbSuelto.Checked == true)
                    	{CompraSuelta.Controlador =2;}
                    
                    if (incrementador < 5)
                    	{DatosDeLaCompra[incrementador]=CompraSuelta;
                    	 incrementador++;}
                    else
                    	{MessageBox.Show("Esta matriz se lleno, por favor, vaciela y pruebe de nuevo");}
                    
                    
                }
                
                else
                {MessageBox.Show("Seleccione alguna de las opciones primero si quiere que el programa procese los datos que ya se ingresaron de forma debida", "Error no fatal", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        }

        
        void BtnSueltosClick(object sender, EventArgs e)
        {for(int incremental=0;incremental < 5;incremental++)
        	{if(DatosDeLaCompra[incremental] !=null && DatosDeLaCompra[incremental].Controlador == 2)
        	{lstSuelto.Items.Add(DatosDeLaCompra[incremental].toString());}}
        	
        }
        
        void BtnEnpaquetadosClick(object sender, EventArgs e)
        {for(int incremental=0;incremental<5;incremental++)
        	{if(DatosDeLaCompra[incremental] !=null && DatosDeLaCompra[incremental].Controlador==1)
        		{lstEnpaquetados.Items.Add(DatosDeLaCompra[incremental].toString());}

            }
        	
        }
    }
    
}