using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_con_bases_de_datos
{
    public partial class FrnControlVuelos : Form
    {int vuelosbs;
     int vuelosmendoza;
     int vuelosSantaFe;
     int pilotosCategoriaA;
     int ContadorGeneral;
     double MontosPromedio;
        public FrnControlVuelos()
        {vuelosbs=0;
         pilotosCategoriaA=0;
         ContadorGeneral=0;
         MontosPromedio=0;
         vuelosmendoza=0;
         vuelosSantaFe=0;
            InitializeComponent();
        }
        
        void BtnRegistrarClick(object sender, EventArgs e)
        {
        	Vuelo viajecito=new Vuelo();
        	Piloto Fulano=new Piloto();
        	Fulano.Apellido=txtApellido.Text;
        	Fulano.Categoria=Convert.ToInt32(cmbCategoria.SelectedIndex+1);
        	Fulano.Nombre=txtNombre.Text;
        	Fulano.Sexo=Convert.ToBoolean(rbtHombre.Checked);
        	viajecito.Destino=Convert.ToInt32(cmbDestino.SelectedIndex+1);
        	viajecito.Monto=Convert.ToDouble(txtMonto.Text);
        	viajecito.Numero=Convert.ToInt32(txtNumero.Text);
        	viajecito.Origen=txtOrigen.Text;
        	viajecito.Piloto=Fulano;
        	if (viajecito.Destino==1)
        		{vuelosbs=vuelosbs+1;
        		lblVuelosBsAs.Text="Cantidad de vuelos con destino a Buenos Aires: "+vuelosbs;}
        	
        	if (viajecito.Piloto.Categoria==1)
        		{pilotosCategoriaA=pilotosCategoriaA+1;
        		lblVuelosPilotoA.Text="Cantidad de vuelos con pilotos de categoria A: "+pilotosCategoriaA;}
        	
        	lblMontoPromedio.Text="Monto promedio de los vuelos: "+Convert.ToString((MontosPromedio=MontosPromedio+viajecito.Monto)/(ContadorGeneral=ContadorGeneral+1));
        	
        	if (viajecito.Destino==2)
        		{vuelosmendoza=vuelosmendoza+1;}
        	if (viajecito.Destino==3)
        		{vuelosSantaFe=vuelosSantaFe+1;}
        	lblPorcentajeBsAs.Text="Porcentaje de vuelos hechos a Buenos Aires: %"+Convert.ToString(vuelosbs*100/(vuelosbs+vuelosmendoza+vuelosSantaFe));
        	lblPorcentajeMendoza.Text="Porcentaje de vuelos hechos a Mendoza: %"+Convert.ToString(vuelosmendoza*100/(vuelosbs+vuelosmendoza+vuelosSantaFe));
        	lblPorcentajeSantaFe.Text="Porcentaje de vuelos hechos a Santa Fe: %"+Convert.ToString(vuelosSantaFe*100/(vuelosbs+vuelosmendoza+vuelosSantaFe));
        	MessageBox.Show(viajecito.toString());
        }
    }
}