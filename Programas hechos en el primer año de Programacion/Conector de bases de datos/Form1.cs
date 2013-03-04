using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//Clase por defecto para trabajar con bases de datos
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; //Subclase para manejo de bases de datos

namespace Conector_de_bases_de_datos
{
    public partial class FrmConectorDB : Form
    {
        OleDbConnection conexion = new OleDbConnection();//Tambien podria ser OdbcConnection conexion; por si se la quiere instanciar luego
        OleDbCommand comando = new OleDbCommand();//Ejecute el comando a usar en la base de datos
        OleDbDataReader Lector = null; // El null no hace falta ya que no es necesario instanciarlo ni nada
        string Consulta; //Declaramos 2 string; uno para conectar y otro para ejecutar comandos
        string conexionador = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DBF.mdb";// Para no estar renegando con el string por mucho tiempo, se puede hacer una nueva conexion a base de datos hasta obtener la cadena y el @ evita que el programa tenga un conflicto con \
        Conector_de_bases_de_datos.Persona[] Gente = new Persona[100];
        Persona Fulanos;
		const int WM_SYSCOMMAND = 0x112;
		const int SC_CLOSE      = 0xF060;
		bool confirmacion_de_habilitacion;//Variable que se usara luego en el listbox
		int cantidades_de_registros;

        public FrmConectorDB()
        {
            InitializeComponent();
       /* for (int incrementador = 0; incrementador < 3; incrementador++)
                { Gente[incrementador] = null; }*/}

        protected override void WndProc(ref Message mensaje)
        {if(mensaje.Msg == WM_SYSCOMMAND)
        	{
        	if(mensaje.WParam == (IntPtr)SC_CLOSE)
        		Commiteador_y_cerrador();
        	base.WndProc(ref mensaje);
        	}
        	else
        		base.WndProc(ref mensaje);
        	}
        		        	
        private void FrmConectorDB_Load(object sender, EventArgs e)
        {/*int incremental=0;
            conexion.ConnectionString = conexionador;
            conexion.Open();//Abrimos la conexion (valga la reduncancia); Es este medoto tambien se le puede pasar el string de conexion como parametro en vez de estar haciendo un nuevo strin y luego escribir el open debajo, ademas, si el depurador se para aca, es por que hay un roblema con la cadena de conexion
            Consulta = "select * from personas"; //Ejecuta un comando SQL especificado
            comando.CommandText = Consulta; //Define de donde va a tomar el comando a ejecutar
            comando.Connection = conexion; //Indica que conexion se va a usar para ejecutar el comando
            Lector = comando.ExecuteReader(); //Ejecuta el comando indicado anteriormente
            Fulanos = new Persona();
            while (Lector.Read() == true) //Mientras lector.Read() sea verdadero, se ira agregando un item a a lista de las columnas 1 y 2 hasta el ultimo registro de la tabla
            { //lstMostrador.Items.Add(Lector.GetString(0) + ";" + Lector.GetString(1)); 
              //A continuacion se agrega una nueva forma para mostrar datos desde un vecto
                Fulanos.Apellido = Convert.ToString(Lector["apellido"]);
                Fulanos.EstadoCivil = Convert.ToInt32(Lector["estado_civil"]);
                Fulanos.Fallecimiento = Convert.ToBoolean(Lector["fallecio"]);
                Fulanos.Nombres = Convert.ToString(Lector["nombres"]);
                Fulanos.NroDocumento = Convert.ToInt32(Lector["documento"]);
                Fulanos.Sexo = Convert.ToInt32(Lector["sexo"]);
                Fulanos.TipoDocumento = Convert.ToInt16(Lector["tipo_documento"]);
                if (incremental < 3 && Gente[incremental] == null)
                    {
                        Gente[incremental] = Fulanos;
              	lstMostrador.Items.Add(Gente[incremental].toString());
                        incremental++;
                    }
              }
  
            conexion.Close();
            Lector.Close();*/

        	habilitador(false);
            actualizador();//Ejecutamos el metodo por primero vez para cargar la lista cuando se inicial el programa
        }

        public void actualizador()//Este metodo actualiza la lista cada vez que ocurre algun cambio en la base de datos (basicmante e lo que se habia hecho en el load la clase anterior, pero mejor redactado
        {conexion.ConnectionString = conexionador;
         conexion.Open();
         Consulta = "select * from personas order by apellido";
         comando.Connection=conexion;
         comando.CommandText=Consulta;
         Lector=comando.ExecuteReader();
         cantidades_de_registros = 0;
         
         while (Lector.Read() == true)//Quito el objeto que estaba de por medio y dejo solo el vector (correccion hecha a partir del ejemplo 2)
         {
         	Gente[cantidades_de_registros]= new Persona();
                Gente[cantidades_de_registros].Apellido = Convert.ToString(Lector["apellido"]);
                Gente[cantidades_de_registros].EstadoCivil = Convert.ToByte(Lector["estado_civil"]);
                Gente[cantidades_de_registros].Fallecimiento = Convert.ToBoolean(Lector["fallecio"]);
                Gente[cantidades_de_registros].Nombres = Convert.ToString(Lector["nombres"]);
               Gente[cantidades_de_registros].NroDocumento = Convert.ToInt32(Lector["documento"]);
                Gente[cantidades_de_registros].Sexo = Convert.ToByte(Lector["sexo"]);
                Gente[cantidades_de_registros].TipoDocumento = Convert.ToByte (Lector["tipo_documento"]);
                //Gente[cantidades_de_registros] = Fulanos;
                lstMostrador.Items.Add(Gente[cantidades_de_registros].toString());
                dataGridView1.Rows.Add(Gente[cantidades_de_registros].Apellido,Gente[cantidades_de_registros].Nombres,Gente[cantidades_de_registros].MostradorDeDocumentos(),Gente[cantidades_de_registros].NroDocumento,Gente[cantidades_de_registros].EstadoCivico(),Gente[cantidades_de_registros].Sexualizador(),Gente[cantidades_de_registros].MuertoONo());
             cantidades_de_registros++;
             
         /*

          for (int incrementador = 0; incrementador < cantidades_de_registros; incrementador++)
          {
                  Gente[incrementador] = Fulanos;
                  lstMostrador.Items.Add(Gente[incrementador].toString());
        
          */}
          conexion.Close();
          Lector.Close();
        }

        private void Actualizador_y_modificador(string inconsulta)//Se crea una variable string aqui para que actue de parametro con los botones que se ecargan del A.B.M
        {
        	//OleDbDataAdapter adaptador=new OleDbDataAdapter();
        	conexion.ConnectionString = conexionador;
        	conexion.Open();
            //OleDbTransaction Transaccion=conexion.BeginTransaction();
            comando.Connection=conexion;
        	comando.CommandType=CommandType.Text;
			comando.CommandText=inconsulta; //Toa la consulta parametrizada para que la ejecute
			//comando.Transaction=Transaccion;
			comando.ExecuteNonQuery();

			conexion.Close();
			lstMostrador.Items.Clear(); //Hay que limpiar la lista antes de actualizarla, sino mostrara registros repetidos
			dataGridView1.Rows.Clear();
			actualizador();
	//Terminar esta funcion con los parametros que se usan por primera vez en la otra funcion
        }

        public void btnCargar_Click(object sender, EventArgs e)
        {
        	habilitador(true);
            CargadorDeComboboxses();

            //Hacer el codigo para insertar los valores de los textboxs en la tabla personas. Lo que hay que hacer es abrir de nuevo la conexion poniendo todo el codigo anterior. cambiar la sentencia por un insert y el metodo Reader cambiarlo por un NonQuery()
            //La forma de hacer una sentencia de insercion: "insert into personas values"+Objeto.Apellido (o txtApellido.Text)+","+Objeto.Nombre (o txtNombre.Text)+","+.... y asi hasta terminar la sentencia
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {string inconsulta;
         bool modifonuevo;
                Fulanos = new Persona();
                Fulanos.Apellido = txtApellido.Text;
                Fulanos.EstadoCivil = Convert.ToByte(cmbEstadoCivil.SelectedIndex + 1);
                if (rdbNo.Checked == true)
                	{Fulanos.Fallecimiento = false;}
                else
                	{Fulanos.Fallecimiento = true;}
                Fulanos.Nombres = txtNombre.Text;
                Fulanos.NroDocumento = Convert.ToInt32(txtDocumento.Text);
                Fulanos.TipoDocumento = Convert.ToByte(cmbTipoDocumento.SelectedIndex + 1);
                if (rdbHombre.Checked == true && rdbMujer.Checked == false)
                	{Fulanos.Sexo =1;}
                else
                	{if (rdbHombre.Checked == false && rdbMujer.Checked == true)
                	{Fulanos.Sexo =2;}}
                
                int contadorcillo=0;
                modifonuevo=false;
                while (modifonuevo == false && Gente[contadorcillo]!=null)//Este while basicamente le indica al programa que mientras la bandera este en falso, que compruebe si el numero de documento del vector no es igual al que esta almacenado en el objeto actual; de ser asi, entonces el contador se incrementa y el while empieza de nuevo, sino poe la bandera en falso y el while termina (al menos en teoria)
                {if (Gente[contadorcillo].NroDocumento != Fulanos.NroDocumento)
                		{contadorcillo++;}
                	else
                		{modifonuevo=true;}
                }
                if (modifonuevo == false)
                	{inconsulta="insert into personas values (\""+Fulanos.Apellido+"\",\""+Fulanos.Nombres+"\","+Fulanos.TipoDocumento+","+Fulanos.NroDocumento+","+Fulanos.EstadoCivil+","+Fulanos.Sexo+","+Fulanos.Fallecimiento+")";
                	}
                else
                	{inconsulta="update personas set apellido='"+Fulanos.Apellido+"', nombres='"+Fulanos.Nombres+"', tipo_documento="+Fulanos.TipoDocumento+", estado_civil="+Fulanos.EstadoCivil+", sexo="+Fulanos.Sexo+", fallecio="+Fulanos.Fallecimiento+" where documento="+Fulanos.NroDocumento; 
                	}
                Actualizador_y_modificador(inconsulta);
          
              }
            //Validar los datos, luego inssertamos, modificamos o eliminamos los datos
        
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Se debe enviar un delete a la base de datos para que borre un registro determinado y preguntar antes de que se ejecute el delete y luego actualizamos
            if (MessageBox.Show("¿Esta seguro de que quiere borrar este registro (al menos asegurece de tener una copia de esto)?", "Borrando un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string inconsulta = "delete from personas where documento=" + Gente[lstMostrador.SelectedIndex].NroDocumento;
                Actualizador_y_modificador(inconsulta);
            }

        }
        
        void BtnSalirClick(object sender, EventArgs e)
        {Commiteador_y_cerrador();
        	
        }
        
        private void CargadorDeComboboxses()//En parte la informacion para terminar esto provino de http://www.forosdelweb.com/f29/llenar-combobox-con-datos-mysql-c-268344/ y por otro lado tambien fui corrigiendo los errores que surgian a la hora de compilar
        {conexion.ConnectionString=conexionador;
        	conexion.Open();
        	comando.CommandText="select * from tipo_documento";
        	Lector=comando.ExecuteReader();
        	while (Lector.Read() == true)
            {
            	cmbTipoDocumento.Items.Add(Lector["n_tipo_documento"].ToString());
            	cmbTipoDocumento.ValueMember = Lector["id_tipo_documento"].ToString();
           //     cmbTipoDocumento.DisplayMember = ;
            }
        	Lector.Close(); //Hay que cerrar el DataReader aqui, sino el programa tira un error de que ya hay un Datareader abierto
            comando.CommandText="select * from estado_civil";
            Lector=comando.ExecuteReader();
            while (Lector.Read() == true)
            {cmbEstadoCivil.Items.Add(Lector["n_estado_civil"].ToString());
            	cmbEstadoCivil.ValueMember=Lector["id_estado_civil"].ToString();
          //   cmbEstadoCivil.DisplayMember=;
              }
            conexion.Close();
            Lector.Close();
        }
        
        void LstMostradorSelectedIndexChanged(object sender, EventArgs e)
        {if (confirmacion_de_habilitacion == true)//Basicamente este se utilizara para saber si los campos ya fueron habilitados, en caso contrario mostrara un error
        	{int ubicador=lstMostrador.SelectedIndex;
        	txtApellido.Text=Gente[ubicador].Apellido;
        	txtDocumento.Text=Convert.ToString(Gente[ubicador].NroDocumento);
        	txtNombre.Text=Gente[ubicador].Nombres;
        	cmbEstadoCivil.SelectedIndex=Convert.ToInt32(Gente[ubicador].EstadoCivil)-1;
        	cmbTipoDocumento.SelectedIndex=Convert.ToInt32(Gente[ubicador].TipoDocumento)-1;
        	if (Gente[ubicador].Fallecimiento == true)
        		{rdbSi.Checked=true;}
        	else
				{rdbNo.Checked=true;}
        	
        	if (Gente[ubicador].Sexo == 1)
        		{rdbHombre.Checked=true;}
        	else
        		{rdbMujer.Checked=true;}}
        else
        {MessageBox.Show("Si quiere modificar algun registro, primero habilite los controles", "Creo que algo falta por hacer primero \"amigo\" ", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        
        }
        
        private void Commiteador_y_cerrador()
        	{
        	/*conexion.ConnectionString=conexionador;
        	conexion.Open();
        	comando.CommandText="commit";
        	comando.ExecuteNonQuery()
	        conexion.Close();*/
	        if (MessageBox.Show("¿Esta seguro de que desea salir?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)!=DialogResult.No)
        		{this.Close();}
	        }
        
         private void habilitador(bool queseyo)
         	{
         	txtApellido.Enabled = queseyo;
            txtDocumento.Enabled = queseyo;
            txtNombre.Enabled = queseyo;
            cmbTipoDocumento.Enabled = queseyo;
            cmbEstadoCivil.Enabled = queseyo;
            btnBorrar.Enabled = queseyo;
            btnGuardar.Enabled = queseyo;
            grpFallecido.Enabled = queseyo;
            grpSexo.Enabled = queseyo;
           confirmacion_de_habilitacion=queseyo; //Pongo esta variable a verdadero para que el listbox detecte que tengo los campos activados. Este truquito lo saque de http://social.msdn.microsoft.com/Forums/es-ES/vcses/thread/8de3eb92-0fe6-4cc7-8131-3811b71dce37
           }

        
        void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        	if (confirmacion_de_habilitacion == true)//Basicamente este se utilizara para saber si los campos ya fueron habilitados, en caso contrario mostrara un error
        	{int ubicador=Convert.ToInt32(dataGridView1.SelectedRows);
        	txtApellido.Text=Gente[ubicador].Apellido;
        	txtDocumento.Text=Convert.ToString(Gente[ubicador].NroDocumento);
        	txtNombre.Text=Gente[ubicador].Nombres;
        	cmbEstadoCivil.SelectedIndex=Convert.ToInt32(Gente[ubicador].EstadoCivil)-1;
        	cmbTipoDocumento.SelectedIndex=Convert.ToInt32(Gente[ubicador].TipoDocumento)-1;
        	if (Gente[ubicador].Fallecimiento == true)
        		{rdbSi.Checked=true;}
        	else
				{rdbNo.Checked=true;}
        	
        	if (Gente[ubicador].Sexo == 1)
        		{rdbHombre.Checked=true;}
        	else
        		{rdbMujer.Checked=true;}}
        else
        {MessageBox.Show("Si quiere modificar algun registro, primero habilite los controles", "Creo que algo falta por hacer primero \"amigo\" ", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        
        }
        }

}