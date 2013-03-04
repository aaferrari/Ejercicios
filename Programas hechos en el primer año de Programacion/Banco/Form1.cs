using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Banco
{
    public partial class Banco : Form
    {int cantidadcuentascorrientes;
     int cantidadcajasahorros;
     double saldototal;
     double saldocuentacorriente;
     double saldocajasahorro;
     double cuentacuentas;
     double saldomayor;
     int cosobandera;
     int cuentahombres;
     int cuentamujeres;
     
        public Banco()
        {
            InitializeComponent();
            cantidadcajasahorros=0;
            cantidadcuentascorrientes=0;
            saldototal=0;
            saldocajasahorro=0;
            saldocuentacorriente=0;
            cuentacuentas = 0;
            saldomayor=0;
            cosobandera=0;
            cuentahombres=0;
            cuentamujeres=0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente Fulanito = new Cliente();
            Cuenta ICaiman=new Cuenta();
            Fulanito.DNI = Convert.ToInt32(txtDNI.Text);
            Fulanito.Nombre = txtNombre.Text;
            Fulanito.NumeroCliente = Convert.ToInt32(txtNumeroCliente.Text);
            ICaiman.Frecuentador = Fulanito; //eSTO ES IMPORTANTE YA QUE desaprueba parciales
            ICaiman.NumeroCuenta = Convert.ToInt32(txtNumeroCuenta.Text);
            ICaiman.Saldo = Convert.ToDouble(txtSaldo.Text);
            ICaiman.TipoCuenta=Convert.ToInt32(cmbTipoCuenta.SelectedIndex +1/*Basicamente le dice al combobox que le sume 1 a los valores del mismo (ya que por defecto se inicia en 0)*/);
            Fulanito.Sexo = Convert.ToBoolean(rdoHombre.Checked);

            if (ICaiman.Frecuentador.Sexo == true)//Hay que tener cuidado con esto ya que los datos deben ser tomados del objeto y no de la interfaz
            { Fulanito.Sexo = true;
            	cuentahombres=cuentahombres+1;}
            else
            { Fulanito.Sexo = false;
              cuentamujeres=cuentamujeres+1;}

           /* if (cmbTipoCuenta.SelectedIndex == 1)
            { ICaiman.TipoCuenta = 1; }
            else
            { ICaiman.TipoCuenta = 2; } */

            MessageBox.Show(ICaiman.toString());

            if (ICaiman.TipoCuenta == 1)
            {
                cantidadcuentascorrientes = cantidadcuentascorrientes + 1;
                saldocuentacorriente = saldocuentacorriente + ICaiman.Saldo;
            }
            else
            {
                cantidadcajasahorros = cantidadcajasahorros + 1;
                saldocajasahorro = saldocajasahorro + ICaiman.Saldo;
            }

            lblCCuentaCorriente.Text = "Cantidad y saldo de las cuentas corrientes: " + Convert.ToString(cantidadcuentascorrientes )+", $"+Convert.ToString(saldocuentacorriente);
            lblCCajaAhorro.Text = "Cantidad y saldo de las cajas de ahorro: " + Convert.ToString(cantidadcajasahorros)+", $"+Convert.ToString(saldocajasahorro);
            lblSaldoTotal.Text = "Saldo Total: $" + Convert.ToString(saldototal = saldototal + ICaiman.Saldo);
            lblSaldoPromedio.Text="Saldo Promedio: $"+Convert.ToString((saldocajasahorro+saldocuentacorriente)/(cantidadcajasahorros+cantidadcuentascorrientes));//Tambien podria haber sido el "saldo total" dividido un contador general, pero el profe lo quiere asi
            lblPromedioCuentaCorriente.Text="Promedio del saldo de las cuentas corrientes: $"+Convert.ToString(saldocuentacorriente/cantidadcuentascorrientes);
            lblPromedioCajasAhorro.Text="Promedio del saldo de las cajas de ahorro: $"+Convert.ToString(saldocajasahorro/cantidadcajasahorros);
            
            if (cosobandera==0)
            {cosobandera=1;
             saldomayor=ICaiman.Saldo;
             lblSaldoMayor.Text="El cliente con mayor saldo es "+Convert.ToString(ICaiman.Frecuentador.Nombre)+"\ncon un saldo de $"+Convert.ToString(ICaiman.Saldo);}
            else
            {if (ICaiman.Saldo > saldomayor)
            	{saldomayor=ICaiman.Saldo;
             lblSaldoMayor.Text="El cliente con mayor saldo es "+Convert.ToString(ICaiman.Frecuentador.Nombre)+"\ncon un saldo de $"+Convert.ToString(ICaiman.Saldo);}
            }

            lblPorTipoCuenta.Text="Porcentaje de las cuentas corrientes: %"+Convert.ToString(cantidadcuentascorrientes*100/(cantidadcuentascorrientes+cantidadcajasahorros))
            +"\nPorcentaje de las cajas de ahorro: %"+Convert.ToString(cantidadcajasahorros*100/(cantidadcuentascorrientes+cantidadcajasahorros));
            lblCSexos.Text="Porcentaje y cantidad de mujeres: "+Convert.ToString(cuentamujeres)+", %"+Convert.ToString(cuentamujeres*100/(cuentamujeres+cuentahombres))
            +"\nPorcentaje y cantidad de hombres: "+Convert.ToString(cuentahombres)+", %"+Convert.ToString(cuentahombres*100/(cuentamujeres+cuentahombres));
            lblRegistros.Text="Cantidad de registros hasta ahora: "+Convert.ToString(cuentacuentas=cuentacuentas+1);
        }

        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}