using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Prueba_en_ComboBox
{
    public partial class frmPruebaComboBox : Form
    {int incrementador;
        int[] Matriz = new int[0];
        int contador = 0;
        public frmPruebaComboBox()
        {            
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("DNI");
            comboBox1.Items.Add("L.C.");
            comboBox1.Items.Add("L.E.");
            comboBox1.Items.Add("PAS");
            comboBox1.Items.Add("CF");
        }

        private void btnCargaManual_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Convert.ToString(txtIngreso.Text));
            txtIngreso.Text = ""; //Borra el contenido del textbox (opcional)
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Contains(txtIngreso.Text);
            if (comboBox1.Items.Contains(txtIngreso.Text))
            {MessageBox.Show("Felicidades, el valor ingresado fue encontrado", ":-)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.SelectedIndex =comboBox1.Items.IndexOf(txtIngreso.Text);}
            else
            { MessageBox.Show("Lo sentimos, el valor no fue encontrado en el ComboBox, pruebe mas tarde", ":-(",MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCargarPrincipio_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Insert(0, txtIngreso.Text);
            txtIngreso.Text = "";
        }

        private void btnBorrarDeCombobox_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(txtIngreso.Text);
            txtIngreso.Text = "";
        }

        private void btnBorarSeleccionado_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {   incrementador = 0;
            for (lstListaNumeros.SelectedIndex = -1;
                lstListaNumeros.Items.Count < 10; 
                incrementador++ )
            {lstListaNumeros.Items.Add(incrementador);}
        }

        private void btnCargarLista50a60_Click(object sender, EventArgs e)
        {incrementador = 50;
            for (lstListaNumeros.SelectedIndex = -1;
                lstListaNumeros.Items.Count < 10; 
                incrementador++ )
            {lstListaNumeros.Items.Add(incrementador);}

        }

        private void btnPasarPares_Click(object sender, EventArgs e)
        {// Truco sacado de: http://social.msdn.microsoft.com/Forums/es-ES/vcses/thread/fb2d9260-666a-4e04-8f87-dc852d799b5e
     	for (incrementador= 0; incrementador < lstListaNumeros.Items.Count;incrementador++ )
         {if (lstListaNumeros.Items.IndexOf(incrementador) % 2 ==0) //La forma para determinar si un numero es par proviene de http://latecladeescape.com/w0/trivialidades/algoritmo-para-saber-si-un-numero-es-par-o-impar-o-de-como-enrollarse-con-un-tema-de-lo-mas-tonto.html
         		lstListaNumeros2.Items.Add(lstListaNumeros.Items[incrementador]);}
         }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            lstNumerosVectoriales.Items.Clear(); //Borra la lista
            for(int incrementador=0;incrementador<5;incrementador++) //Pone todos los datos de la matriz a cero
            { Matriz[incrementador] = 0; }
            contador = 0;//Pone el contador a cero para comenzar a agregar datos nuevamente a la matriz
        }

        private void btnCargarAMatriz_Click(object sender, EventArgs e)
        {if (contador<5)//Permite cargar datos hasta que el contador cargue datos hasta llegar a 5, luego de eso mostrara un mensaje
        {Matriz[contador] = Convert.ToInt32(txtIngresoNumero.Text);
         contador=contador+1;
         txtIngresoNumero.Text = "";
         }
         else
        {MessageBox.Show("Se lleno la matriz, vaciala y proba de nuevo", "Ups");}
        }

        private void btnListarMatriz_Click(object sender, EventArgs e)
        {for(int incrementador=0;incrementador<5;incrementador++) //Pone todos los datos de la matriz a cero
            {lstNumerosVectoriales.Items.Add(Matriz[incrementador]).ToString();/*El ToString transforma los datos a strings para evitar errores */ }
            
        }

        private void btnCargarconIVA_Click(object sender, EventArgs e)
        {//Terminar esto desde http://www.programacionfacil.com/visual_csharp_express:listbox
        double dato;
        string[] MatrizOperacional=new string[5]; //Matriz intermedia que el programa usa mediante la ejecucion de los eventos de este boton
            for (int incrementador = 0; incrementador < 5; incrementador++)
            {  	dato=double.Parse(lstNumerosVectoriales.Items[incrementador].ToString()); //Barre el listbox desde el principio para obtener numero para procesar en la siguiente linea
            	dato=((dato * 21)/100)+dato;
            	MatrizOperacional[incrementador]=dato.ToString(); //Tambien podria haber sido "lstNumerosVectoriales.Items[incrementador]=dato.ToString()", pero el problema con esto es que por alguna razon sobreescribe los valores anteriores que estan en el listbox por los valores calculados
            	lstNumerosVectorialesConIVA.Items.Add(MatrizOperacional[incrementador]); //Esta instruccion simplemente agrega los datos almacenados en la matriz intermedia al listbox correspondiente
            }

        }



    }}
//Hacer un boton para borrar un dato que se escriba en el TextBox y otro para borrar un dato seleccionado en el ComboBox