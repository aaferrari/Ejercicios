using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Conector_a_la_DB_Vivero_Fenix
{
    public partial class FrmConector : Form
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader Lector = null;
        Plantas[] Datos;
        Plantas Herbarios;
        string cadena_conexion = "Data Source=SNOWBALL;Initial Catalog=vivero_1w3;Persist Security Info=True;User ID=alumno1w3;Password=alumno1w3";
        string Consulta;
        public FrmConector()
        {
            InitializeComponent();
            actualizador();
        }

        private void FrmConector_Load(object sender, EventArgs e)
        {

        }

        public void actualizador()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            Consulta = "select * from plantas";
            comando.Connection = conexion;
            comando.CommandText = Consulta;
            Lector = comando.ExecuteReader();
            int cantidades_de_registros = 0;
            Datos = new Plantas[8];
            while (Lector.Read() == true)
            {
                Herbarios = new Plantas();
                Herbarios.Codigo = Convert.ToInt32(Lector["COD_PLANTA"]);
                Herbarios.Descripcion = Convert.ToString(Lector["DESCRIPCION"]);
                Herbarios.CodigoPlanta = Convert.ToInt32(Lector["COD_TIPO_PLANTA"]);
                Herbarios.Precio = Convert.ToDouble(Lector["PRECIO"]);
                Herbarios.Stock = Convert.ToInt32(Lector["STOCK"]);
                Herbarios.Clima = Convert.ToString(Lector["clima"]);
                Datos[cantidades_de_registros] = Herbarios;
                lstMostrador.Items.Add(Datos[cantidades_de_registros].toString());
                cantidades_de_registros++;
                
            }
        conexion.Close();
                Lector.Close();
        }

        private void actualizadorTabla(string modificador)//Realiza una operacion que no es una lectura de la tabla
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandText = modificador;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {//Primeramente se debe validar si lo que hacemos es aregar un nuevo registro o si modificamos uno existente meidante if un con bandera
            string consulta;
            bool nuevo_registro;
            if (nuevo_registro == true)
            {//Hay que validar la clave primaria
                Plantas Hierbas=new Plantas();
                 Hierbas.Codigo = Convert.ToInt32(txtCodigoPlanta.Text);
                 Hierbas.Descripcion = txtNombrePlanta;
                Hierbas.CodigoPlanta = Convert.ToInt32(txtCodigoPlanta.Text);
                Hierbas.Precio = Convert.ToDouble(txtPrecio.Text);
                Hierbas.Stock = Convert.ToInt32(txtStock.Text);
                Hierbas.Clima = Convert.ToString(cmbClima.SelectedIndex+1);
                consulta="insert into plantas values ("+Hierbas.Codigo+","+Hierbas.Descripcion+","+Hierbas.CodigoPlanta+","+Hierbas.Precio+","+Hierbas.Stock+","+Hierbas.Clima+")"; //Tambien se puede hacer eso con los textbox, pero eso romperia el modelo orientado a objetos
            }
            else
            {
                consulta = "Update Plantas set descripcion=" + Datos[lstMostrador.SelectedIndex].Descripcion + " and clima=" + Datos[lstMostrador.SelectedIndex].Clima+ " and cod_tipo_planta=" + Datos[lstMostrador.SelectedIndex].CodigoPlanta+ " and precio=" + Datos[lstMostrador.SelectedIndex].Precio+ " and stock=" + Datos[lstMostrador.SelectedIndex].Stock+ " where COD_PLANTA=" + Datos[lstMostrador.SelectedIndex].Codigo;
            }
            actualizadorTabla(consulta);
            actualizador();
            nuevo_registro=false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void lstMostrador_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numerador = lstMostrador.SelectedIndex;
            txtCodigoPlanta.Text = Convert.ToString(Datos[numerador].Codigo);
            txtNombrePlanta.Text = Datos[numerador].Descripcion;
            txtPrecio.Text = Convert.ToString(Datos[numerador].Precio);
            txtStock.Text = Convert.ToString(Datos[numerador].Stock);
            cmbTipoPlanta.SelectedIndex = Convert.ToInt32(Datos[numerador].CodigoPlanta)-1;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que quiere borrar este registro (al menos asegurece de tener una copia de esto)?", "Borrando un registro", MessageBoxIcon.Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string consulta = "delete from plantas ...." + Datos[lstMostrador.SelectedIndex].Codigo;
                actualizadorTabla(consulta);
            }
        }

        private void CargadorDeComboboxses(/*definir aqui (o en donde convenga) la forma de tomar la tabla, las columnas y las claves*/)
        {
            while (Lector.Read() = true)
            {
                cmbTipoPlanta.Items.Add();
                cmbTipoPlanta.ValueMember = Lector["tipo_planta"];
                cmbTipoPlanta.DisplayMember = Lector["nombre"];
            }
        }
    }
}