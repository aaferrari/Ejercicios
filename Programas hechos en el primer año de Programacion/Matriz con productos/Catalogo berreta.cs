using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matriz_con_productos
{
    public partial class Form1 : Form
    {//int contador;
        
        int fila;
        int columna;
        Producto[,] DatosDeLaCosa = new Producto[2, 3];
        public Form1()
        {
            for (int fila = 0; fila < 2; fila++)//Hago un for doble para poner todo a null
            {//Tambien se podria barrer todas as columnas en vez de las filas
                for (int columna = 0; columna < 3; columna++)
                { DatosDeLaCosa[fila, columna] = null; }
            }
            InitializeComponent();
        }

        private void btnGuardarMatriz_Click(object sender, EventArgs e)
        {
            Producto Cosa = new Producto();
            Cosa.Cantidad = Convert.ToInt32(txtCantidad.Text);
            Cosa.Codigo = Convert.ToInt32(txtCodigo.Text);
            Cosa.Nombre = txtNombre.Text;
            Cosa.Precio = Convert.ToDouble(txtPrecio.Text);
            Cosa.Tipo = Convert.ToInt32(cmbTipo.SelectedIndex + 1);
            if (fila < 2)
            {
                if (columna < 3)
                {
                    DatosDeLaCosa[fila, columna] = Cosa;
                    columna++;
                }
                else
                { fila++;
                columna = 0;  }
            }
            else
            { MessageBox.Show("Matriz llena, vaciela si quiere agregar mas datos", "Listo", MessageBoxButtons.OK); }
            /* Otra forma de hacerlo seria:
             * contador++;
             * if(columna==3)
             *  {columna=0;
             *   fila++;}
             * if (fila==2
             * {MessageBox.Show("Se lleno", MessageBoxButtons.OK); } */
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            double totalsucursal = 0;
            double totalDeTotales = 0; //Acumulador para los totales

         for (int fila = 0; fila < 2; fila++)//Hago un for doble para poer todo a null
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (DatosDeLaCosa[fila, columna] != null)
                    {
                        lstColector.Items.Add(DatosDeLaCosa[fila, columna].toString());
                        totalsucursal = totalsucursal + DatosDeLaCosa[fila, columna].Precio;
                    }
                    
                }// Esto va acumulando los productos de una sucursal hasta pasar a la siguiente
              totalDeTotales = totalDeTotales + totalsucursal;//Esto va acumulando los totales para ser luego mostrado en el final
              lstColector.Items.Add(Convert.ToString("Total de la sucursal "+(fila+1)+": $"+ totalsucursal));// Esto agrega el total de los productos en la lista justo antes de pasar a otra sucursal
              totalsucursal = 0;//Lo pone a cero para sumar la siguiente
            }
            lstColector.Items.Add(Convert.ToString("Total de todas las sucursales: $"+ totalDeTotales));//Y esto muestra el total de las 2 sucursales
            lstColector.Items.Add("-----------------------------------");
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            double totalProductos = 0;
            double TotalesDeLosProductos = 0; //Acumulador para los totales

            for (int columna = 0; columna < 3; columna++)
            {
                for (int fila = 0; fila < 2; fila++)
                {
                    if (DatosDeLaCosa[fila, columna] != null)
                    {
                        //totalProductos = Convert.ToDouble(DatosDeLaCosa[fila, columna].);
                        totalProductos = totalProductos + DatosDeLaCosa[fila, columna].Precio;
                    }

                }// Esto va acumulando los productos de una sucursal hasta pasar a la siguiente
                TotalesDeLosProductos = TotalesDeLosProductos + totalProductos;//Esto va acumulando los totales para ser luego mostrado en el final
                lstColector.Items.Add(Convert.ToString("Total de un producto: $" + totalProductos));// Esto agrega el total de los productos en la lista justo antes de pasar a otra sucursal
                totalProductos = 0;//Lo pone a cero para sumar la siguiente
            }
            lstColector.Items.Add(Convert.ToString("Total de todos los productos: $" + TotalesDeLosProductos));//Y esto muestra el total de las 2 sucursales
            lstColector.Items.Add("-----------------------------------");
        }

        private void btnBuscaProductos_Click(object sender, EventArgs e)
        {int incrementadorDeTipos=0;
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    if (DatosDeLaCosa[fila, columna].Tipo == cmbTipo.SelectedIndex + 1 && DatosDeLaCosa[fila, columna] != null)
                    {
                        lstColector.Items.Add(DatosDeLaCosa[fila, columna].toString());
                        incrementadorDeTipos = incrementadorDeTipos + DatosDeLaCosa[fila, columna].Cantidad;
                    }
                }
            }
            lstColector.Items.Add(Convert.ToString("Cantidad de productos que coinciden con "+cmbTipo.SelectedText.ToString() + ": "+incrementadorDeTipos));
            lstColector.Items.Add("-----------------------------------");
        }

        private void btnLimpiador_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                { DatosDeLaCosa[fila, columna] = null; }
            }

            lstColector.Items.Clear();
        }

        private void btnSumarPorCategoria_Click(object sender, EventArgs e)
        {
            double totalTipoAlimento = 0;
            double totalTipoLimpieza=0;
            double totalTipoBazar=0;

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    switch (DatosDeLaCosa[fila, columna].Tipo)
                    {
                        case 1: { totalTipoAlimento = totalTipoAlimento + DatosDeLaCosa[fila, columna].Cantidad; break; }
                        case 2: { totalTipoBazar=totalTipoBazar+DatosDeLaCosa[fila, columna].Cantidad; break; }
                        case 3: { totalTipoLimpieza = totalTipoLimpieza + DatosDeLaCosa[fila, columna].Cantidad; break; }
                    }
                }
            }
            lstColector.Items.Add("Cantidad de productos de Limpieza: " + totalTipoLimpieza);
            lstColector.Items.Add("Cantidad de productos de Bazar: " + totalTipoBazar);
            lstColector.Items.Add("Cantidad de productos de alimentacion: " + totalTipoAlimento);
            lstColector.Items.Add("-----------------------------------");
        }
    }
}/*        {double promedio;
            for (int contador = 0; contador < DatosDeLaCosa.Length; contador++) // i < c
            {
                if (DatosDeLaCosa[contador] != null) //
                { lstColector.Items.Add(DatosDeLaCosa[contador].toString());
                  promedio=promedio+DatosDeLaCosa[contador].Precio;
                }
            }
        lstColector.Items.Add(Convert.ToString(promedio/contador);
        } */
/*El if anterior tambien podria ser;
 * ----------------------------------
 * {DatosDeLaCosa[contador] = new Producto();
 * DatosDeLaCosa[contador]Cantidad = Convert.ToInt32(txtCantidad.Text);
DatosDeLaCosa[contador]Codigo = Convert.ToInt32(txtCodigo.Text);
DatosDeLaCosa[contador]Nombre = txtNombre.Text;
DatosDeLaCosa[contador]Precio = Convert.ToDouble(txtPrecio.Text);
DatosDeLaCosa[contador]Tipo = Convert.ToInt32(cmbTipo.SelectedIndex + 1);
 * contador++;} */