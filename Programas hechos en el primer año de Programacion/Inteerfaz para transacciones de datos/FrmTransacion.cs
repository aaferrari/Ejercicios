using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Inteerfaz_para_transacciones_de_datos
{
    public partial class FrmTransacion : Form
    {OleDbConnection conexion = new OleDbConnection();//Tambien podria ser OdbcConnection conexion; por si se la quiere instanciar luego
        OleDbCommand comando = new OleDbCommand();//Ejecute el comando a usar en la base de datos
        OleDbDataReader Lector = null; // El null no hace falta ya que no es necesario instanciarlo ni nada
       // string Consulta; //Declaramos 2 string; uno para conectar y otro para ejecutar comandos
        string cadena_conexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBF.mdb";
        Inteerfaz_para_transacciones_de_datos.Clientes[] DatosFulano = new Clientes[50];
       // Articulo Cosa;
        Inteerfaz_para_transacciones_de_datos.Articulo[] DatosCosa = new Articulo[50];
        Pedidos Orden;
       // Detalle Detallacion;
        Inteerfaz_para_transacciones_de_datos.Detalle[] DetallesVectoriales;
       // Inteerfaz_para_transacciones_de_datos.Pedidos[] PedidosVectoriales;
		int contador_vectorial;
		//ArrayList lista;
		double total;
		double subtotal;
        
        public FrmTransacion()
        {
        	contador_vectorial=0;
        	DetallesVectoriales = new Detalle[100];
          //  PedidosVectoriales = new Pedidos[100];
        	total=0;
        	subtotal=0;
        	InitializeComponent();
        }

        private void FrmTransacion_Load(object sender, EventArgs e)
        {
        	actualizador();
        	CargadorDeComboboxses();
        }



        private void Conector()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        	if (cmbCliente.SelectedIndex!=-1)
        		 {
			int ubicador=cmbCliente.SelectedIndex;
			txtDireccion.Text=DatosFulano[ubicador].Calle+" "+DatosFulano[ubicador].NumeroCa.ToString()+", B° "+DatosFulano[ubicador].Barrio.ToString();
			}
        }

        private void CargadorDeComboboxses()
        {
           /* conexion.ConnectionString = cadena_conexion;
            conexion.Open(); */
           Conector();
            comando.CommandText = "select * from t_clientes";
            Lector = comando.ExecuteReader();
            while (Lector.Read() == true)
            {
                cmbCliente.Items.Add(Lector["n_cliente"].ToString());
                cmbCliente.ValueMember = Lector["id_cliente"].ToString();
            }
            Lector.Close();
            comando.CommandText = "select * from t_articulos";
            Lector = comando.ExecuteReader();
            while (Lector.Read() == true)
            {
                cmbArticulo.Items.Add(Lector["n_articulo"].ToString());
                cmbArticulo.ValueMember = Lector["id_articulo"].ToString();
            }
            Lector.Close();
            conexion.Close();
        }

        private void actualizador()
        {
            Conector();
            comando.CommandText = "select * from t_articulos";
            Lector = comando.ExecuteReader();
            int registros = 0;
                     while (Lector.Read() == true)
            {
            	DatosCosa[registros]=new Articulo();
                //Cosa = new Articulo();
                DatosCosa[registros].CodigoArti = Convert.ToInt32(Lector["id_articulo"]);
                DatosCosa[registros].NombreArti = Lector["n_articulo"].ToString();
                DatosCosa[registros].Precio = Convert.ToDouble(Lector["precio"]);
               // DatosCosa[registros] = Cosa;
                registros++;
            }
            Lector.Close();
            comando.CommandText = "select * from t_clientes";
            Lector = comando.ExecuteReader();
            registros = 0;
           // DatosFulano = new Clientes[50];
            while (Lector.Read() == true)
            {//Fulano=new Clientes();
            	DatosFulano[registros]=new Clientes();
            	DatosFulano[registros].Barrio=Convert.ToInt32(Lector["id_barrio"]);
            	DatosFulano[registros].Calle=Lector["calle"].ToString();
            	DatosFulano[registros].CodigoClle=Convert.ToInt32(Lector["id_cliente"]);
            	DatosFulano[registros].NombreClie=Lector["n_cliente"].ToString();
            	DatosFulano[registros].NumeroCa=Convert.ToInt32(Lector["calle_nro"]);
            	//DatosFulano[registros]=Fulano;
            	registros++;
            }
            Lector.Close();
            conexion.Close();
        }

      /*  private OleDbDataReader buscador(string consulta)
        {
            Conector();
            comando.CommandText = consulta;
            OleDbDataReader coincidencia = comando.ExecuteReader();
            return coincidencia;
        }

        private void btnBuscar()
        {if (txtCliente.text == "")
        {MessageBox.Show("Debe ingresar nun nombre de cliente valido");}
        else
        {string query="select * from cliente where id_cliente="+txtCliente.text 
            Lector=buscador(query);
            if (Lector.Read() ==true)
            {txtCliente.text =Lector["n_cliente"].ToString();}
            else
            {MessageBox.Show("Cliente no encontrado. \nNo existe o no es de este planeta");}
        }
        ------------------------------------------------------------------------------ 
         *Tambien puede ser de la siguiente manera:
       private void btnBuscar()
        {if (txtCliente.text != "")
        {Conector();
            comando.CommandText="select * from cliente where id_cliente="+txtCliente.text;
        
            Lector=comando.ExecuteReader();
            if (Lector.Read() ==true)
            {txtCliente.text =Lector["n_cliente"].ToString();}
            else
        {MessageBox.Show("Cliente no encontrado. \nNo existe o no es de este planeta");}
        }}
       * 
       * Esto tambien se puede hacer para el articulo, solo hay que cambiar la sentencia de conexion. Esto se puede usar en lugar de las clases y vectores de siempre.
         */


        void CmbArticuloSelectedIndexChanged(object sender, EventArgs e)
        {
        	if (cmbArticulo.SelectedIndex != -1)
        		{int ubicador=cmbArticulo.SelectedIndex;
        		txtPrecio.Text=DatosCosa[ubicador].Precio.ToString();}
        }
        
        void BtnResultadoClick(object sender, EventArgs e)
        {
        	int ubicador=cmbArticulo.SelectedIndex;
        	txttotal.Text=Convert.ToString(DatosCosa[ubicador].Precio*Convert.ToDouble(txtCantidad.Text));
        }
        
        void BtnGuardarClick(object sender, EventArgs e)
        {
        	string insercion;
        	Orden=new Pedidos();
            Orden.CodigoClle=DatosFulano[cmbCliente.SelectedIndex].CodigoClle;
        	Orden.Descuento=Convert.ToDouble(txtDescuento.Text);
        	Orden.Fecha=Convert.ToDateTime(DTPFecha.Value);
        	Orden.Subtotal=subtotal;
        	Orden.Total=total;
        	Orden.CodigoPed=Convert.ToInt32(txtPedido.Text);
        	Orden.Sucursal=Convert.ToInt32(txtSucursal.Text);
		//	Orden = PedidosVectoriales[contador_vectorial];
			Conector(); //Abro la conexion aqui para mantenerla abierta durante toda la insercion de registros
			insercion="insert into t_pedidos values ("+Orden.CodigoPed+","+Orden.Sucursal+","+Orden.CodigoClle+",'"+Orden.Fecha+"',"+Orden.Subtotal+","+Orden.Descuento+","+Orden.Total+")";
			Insertador(insercion);
			conexion.Close();
			Conector();
			for (int cuenta_inserciones=0;cuenta_inserciones < contador_vectorial; cuenta_inserciones++)
			{insercion="insert into t_detalles_pedidos values ("+DetallesVectoriales[cuenta_inserciones].CodigoPed+","+DetallesVectoriales[cuenta_inserciones].Sucursal+","+DetallesVectoriales[cuenta_inserciones].CodigoArti+","+DetallesVectoriales[cuenta_inserciones].Cantidad+","+DetallesVectoriales[cuenta_inserciones].Precio+")";
				Insertador(insercion);}
			conexion.Close(); //Ceramos la conexion aqui para optimizar un poco la velocidad del programa al evitar que abra y cierre la conexion tantas veces como registros deba insertar

            //Instanciar todos LostFocus parametors
            //Aqui se debe hacer un for para insertar todos los detalles (ya que un pedido puede tenervarios detalles)
        }
        
        void BtnAgregarClick(object sender, EventArgs e)//Al principio hice lo del datagrid con lo que sale en http://www.c-sharpcorner.com/UploadFile/mahesh/ArrayListBinding10212005102338AM/ArrayListBinding.aspx?ArticleID=ea893798-1d66-4f55-8e4a-4581c3921cb5, pero como me parecio bastante complejo, entonces segui investigandoy encontre una buena alternativa; agregar filas co las columnas hechas, este truco provino de http://groups.google.com/group/microsoft.public.es.csharp/browse_thread/thread/5f4243b5a3a810cb
        {
        	subtotal=subtotal+Convert.ToDouble(txttotal.Text);
        	txtSubtotal.Text=Convert.ToString(subtotal);
        	total=subtotal-Convert.ToDouble(txtDescuento.Text);
        	txtTotalDef.Text=Convert.ToString(total);
            DetallesVectoriales[contador_vectorial] = new Detalle();
            DetallesVectoriales[contador_vectorial].Cantidad = Convert.ToInt32(txtCantidad.Text);
            DetallesVectoriales[contador_vectorial].CodigoArti = DatosCosa[cmbArticulo.SelectedIndex].CodigoArti;
            DetallesVectoriales[contador_vectorial].Precio = DatosCosa[cmbArticulo.SelectedIndex].Precio;
            DetallesVectoriales[contador_vectorial].CodigoPed = Convert.ToInt32(txtPedido.Text);
            DetallesVectoriales[contador_vectorial].Sucursal = Convert.ToInt32(txtSucursal.Text);

        	//Detallacion= DetallesVectoriales[contador_vectorial];
        	dataGridView1.Rows.Add(DatosCosa[cmbArticulo.SelectedIndex].NombreArti, txtCantidad.Text, txttotal.Text);
          	contador_vectorial++;
          	
        }

        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtPrecio.Text != " ")
            {
                int ubicador = cmbArticulo.SelectedIndex;
                txttotal.Text = Convert.ToString(DatosCosa[ubicador].Precio * Convert.ToDouble(txtCantidad.Text));
            }
            else
            { MessageBox.Show("Falta ingresar la cantidad o el pedido, no sea flojo y revise si le falta algo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        
      /*  public ArrayList Listador()
        {
        	lista=new ArrayList();
        	lista.Add(new ClaseExtra(cmbArticulo.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txttotal.Text)));
        	return lista;
        } */
        
        
        void BtnNuevoClick(object sender, EventArgs e)
        {//Al hacer clic en este boton, se borrara el contenido de los textboxs, los comboboxes se pondrna en el item -1 (o sea que quedaran vacias) y se borraran las filas del datagrid. Esto se hace parahacer un nuevo pedido
        	if (MessageBox.Show("¿Esta seguro de que quiere iniciar un pedido nuevo (se van a borrar todos los datos ingresados en el programa hasta ahora (escepto la fecha))?. De ser asi, al menos asegurece de que los datos hayan sido correctamente guiardados en la base de datos correspondiente.", "Haciendo un nuevo pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
        		{
        	txtCantidad.Text="";
        	txtDescuento.Text="";
        	txtDireccion.Text="";
        	txtPedido.Text="";
        	txtPrecio.Text="";
        	txtSubtotal.Text="";
        	txtSucursal.Text="";
        	txttotal.Text="";
        	txtTotalDef.Text="";
        	cmbArticulo.SelectedIndex=-1;
        	cmbCliente.SelectedIndex=-1;
        	dataGridView1.RowCount=1; //Elimina todas las filas del datagrid. Esto lo encontre en http://www.kriptus.com/foro/eliminar-filas-datagrid-sin-datasource-t24649.html?s=7f53e34a616ecff33ede74dc4fe808aa&amp;
        	for (int nuleador = 0; nuleador < 100; nuleador++)//Pone todos los espacions de los vectores a null para poder reutilizarlas
                { DetallesVectoriales[nuleador] = null;
        		   //PedidosVectoriales[nuleador] = null;
        		}
        	}
        }
        
        private void Insertador(string insercion)
        {
          	comando.CommandText=insercion;
        	comando.ExecuteNonQuery();
        }
        	
    }
}//Hay que terminar este programa para la proxima y para que sirva de practica. Tambien se debe tener en cuenta que el DataGrid se deben agregar solo los registros que el usuario vaya guardando y unicamente el Articulo, Cantidad e Importe (para eto creo que tambien se debe utilizar una matriz o algo asi) y en los textboxs que aparecen debaj de este, se deben ir actualizando sus valores mientras se vayan agregando nuevos registros