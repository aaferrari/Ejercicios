/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 31/10/2009
 * Hora: 09:59 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Trabajo_practico_sobre_una_base_de_datos_musical
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
        SqlConnection conexion=new SqlConnection();
        SqlCommand comando=new SqlCommand();
        SqlDataReader Lector=null;
		Trabajo_practico_sobre_una_base_de_datos_musical.Temas[] DatosTemas = new Temas[200];
		Trabajo_practico_sobre_una_base_de_datos_musical.Grupos[] DatosGrupos = new Grupos[200];
		DataSet Seteador=new DataSet(); //La idea de usar el adaptador y el Dataset para el DatagridView provienen de http://www.mygnet.net/codigos/csharp/manejo_de_base_datos/mostrar_datos_en_un_datagrid_usando_dataset_en_c_sharp_dot_net.1258
		DataSet SeteadorClonado=new DataSet(); //Esto es basicamente la copia del dataset anterior, pero se utilizara con motivos de limpieza
		SqlDataAdapter Adaptador;
		Temas Cancion;
		Grupos Grupito;
		bool llamada;
		string inconsulta;
        int NumeroFila;
    	DataTable DatosTabla;

		public MainForm()
		{
			llamada=false;
 
			InitializeComponent();
            grpGrupos.Enabled = false;
            grpTemas.Enabled = false;
            btnEliminar.Enabled = false;
            btnGrupos.Enabled = false;
            btnTemas.Enabled = false;

		}
		
		private void Conector()
        {
            conexion.ConnectionString ="Data Source=snowball;Initial Catalog=cd;User ID=alumno1w1;Password=alumno1w1";
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
		
		private void actualizador(string tabla)
        {
            Limpiador();
			for (int contador = 0; contador < 200; contador++) //for simple para limpiar los vectores cada vez que se va a caregar una tabla
                { DatosGrupos[contador] = null;
				  DatosTemas[contador] = null;}
			//Las siguientes lineas son para blanquear textboxs, borrar comboboxs y poner los numericupdown en su valor por defecto
			cmbAlbum.Items.Clear();
			cmbAutor.Items.Clear();
			cmbCompanias.Items.Clear();
			txtNombreGrupo.Text="";
			txtObservaciones.Text="";
			txtTituloTema.Text="";
			nmdDuracion.Value=1;
			nmdIdGrupo.Value=1;
			nmdIdTema.Value=1;
			nmdIntegrantes.Value=1;
			Conector();
			comando.CommandText = "select * from "+tabla;
            int registros = 0;
            if (cmbTablas.SelectedIndex == 0)//Si el combobox es igual a 0, el string sera igual a grupos, sino sera igual a temas
        	{
          	
            	Adaptador=new SqlDataAdapter("select grupo.id_grupo,Grupo.descripcion,Grupo.id_compania,Companias.descripcion,cant_integrantes,solista_conjunto from grupo inner join companias on grupo.id_compania=companias.id_compania", conexion);
            	
            	if (llamada==false)
            		{Adaptador.Fill(Seteador, "Grupo");
            		dataGridView1.DataSource=Seteador;}
            	else
            		{Adaptador.Fill(SeteadorClonado, "Grupo");
            		dataGridView1.DataSource=SeteadorClonado;}
            	dataGridView1.DataMember="Grupo";
            	Lector = comando.ExecuteReader();
            	
            	while (Lector.Read() == true)//Esto carga e vector con los registros de la tabla
                   	{
            		DatosGrupos[registros]=new Grupos();
            		DatosGrupos[registros].IdGrupo=Convert.ToInt32(Lector["id_grupo"]);
            		DatosGrupos[registros].Descripcion=Convert.ToString(Lector["descripcion"]);
            		DatosGrupos[registros].IdCompania=Convert.ToInt32(Lector["id_compania"]);
            		DatosGrupos[registros].Integrantes=Convert.ToByte(Lector["cant_integrantes"]);
            		DatosGrupos[registros].SolistaConjunto=Convert.ToByte(Lector["solista_conjunto"]);
                   	registros++;
                	}
            	Lector.Close(); //Cerramos el datareader antes de hacer otra consulta, sino el programa tirara un error de que ya hay un DataReader abierto
            	comando.CommandText="select * from Companias";
            	Lector=comando.ExecuteReader();
            	while (Lector.Read() == true)//Esto carga los registros del combobox de las companias
                   	{
    				cmbCompanias.Items.Add(Lector["descripcion"].ToString());
    				cmbCompanias.ValueMember=Lector["id_compania"].ToString();
            		}
               	}
            else
            	{if (cmbTablas.SelectedIndex == 1)//Si el combobox es igual a 1, el string sera igual a temas (esta comprobacion extra es por si es necesario agregar mas tablas)
        	{
                Adaptador = new SqlDataAdapter("select temas.id_album, album.titulo, temas.id_tema, temas.titulo, temas.id_autor, autores.nombre, temas.duracion, temas.observaciones from Temas, autores, album where Temas.id_album=Album.id_album and Temas.id_autor=Autores.id_autor ", conexion);
            	
            	if (llamada==false)
            		{Adaptador.Fill(Seteador, "Temas");
            		dataGridView1.DataSource=Seteador;}
            	else
            		{Adaptador.Fill(SeteadorClonado, "Temas");
            		dataGridView1.DataSource=SeteadorClonado;}
            	dataGridView1.DataMember="Temas";
            	Lector = comando.ExecuteReader();
            	
            	while (Lector.Read() == true)
                   	{
            		DatosTemas[registros]=new Temas();
            		DatosTemas[registros].IdAlbum=Convert.ToInt32(Lector["id_album"]);
            		DatosTemas[registros].IdTema=Convert.ToInt32(Lector["id_tema"]);
            		DatosTemas[registros].IdAutor=Convert.ToInt32(Lector["id_autor"]);
            		DatosTemas[registros].Duracion=Convert.ToInt32(Lector["duracion"]);
            		DatosTemas[registros].Titulo=Lector["titulo"].ToString();
            		DatosTemas[registros].Observaciones=Lector["observaciones"].ToString();
                   	registros++;
                	}
            	Lector.Close();
            	comando.CommandText = "select * from Autores";
            	Lector = comando.ExecuteReader();
            	while (Lector.Read() == true)
            	{
                	cmbAutor.Items.Add(Lector["nombre"].ToString());
                	cmbAutor.ValueMember = Lector["id_autor"].ToString();
            	}
				Lector.Close();
            	comando.CommandText = "select * from Album";
            	Lector = comando.ExecuteReader();
            	while (Lector.Read() == true)
            	{
                	cmbAlbum.Items.Add(Lector["titulo"].ToString());
                	cmbAlbum.ValueMember = Lector["id_album"].ToString();
            	}

            	}

            	}
            Lector.Close();
            conexion.Close();
        }
		
        private void btnMostrar_Click(object sender, EventArgs e)
        {
        	string tabla;//Variable que se utilizara para el metodo selecteador
        	if (cmbTablas.SelectedIndex == 0)//Si el combobox es igual a 0, el string sera igual a grupos, sino sera igual a temas
        	{tabla="Grupo";
            HABILITADOR_SELECTIVO(true);
        	 actualizador(tabla);//Ejecuta el metodo con el string grupos
        	}
        	else
        	{if (cmbTablas.SelectedIndex == 1)
        		{tabla="Temas";
                HABILITADOR_SELECTIVO(false);
        		actualizador(tabla);//Sino se ejecuta el metodo con el string temas
        		}
        	}
        	//Tambien podria haber puesto la llamada al metodo actualizador() aqui para evitar repeticiones, pero cuando compilo aparece un error de "Uso de la variable local no asignada 'tabla'"
        }

		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int ubicador;
            NumeroFila = dataGridView1.CurrentCell.ColumnIndex;
			if (DatosGrupos[0] != null)
			{
				ubicador=Convert.ToInt32(dataGridView1.CurrentRow.Index);
				txtNombreGrupo.Text=DatosGrupos[ubicador].Descripcion;
				nmdIntegrantes.Value=DatosGrupos[ubicador].Integrantes;
			   // cmbCompanias.ValueMember=Convert.ToString(DatosGrupos[ubicador].IdCompania-1);
                cmbCompanias.Text= Convert.ToString(dataGridView1[1, NumeroFila].Value);
				if (DatosGrupos[ubicador].SolistaConjunto == 0)//Este if es para determinar si el grupo es solista o no
					{rdbNo.Checked=true;}
				else
					{if (DatosGrupos[ubicador].SolistaConjunto == 1)//Agrego este if extra para comprobar que se hizo clic sobre el Radiobuton
						{rdbSi.Checked=true;}
					}
		
				nmdIdGrupo.Value=DatosGrupos[ubicador].IdGrupo;
			}
			else
			{
				if (DatosTemas[0] != null) //Este if dentro del else es para tener un mayor control sobre la seleccion
				{
				ubicador=Convert.ToInt32(dataGridView1.CurrentRow.Index);
				/*cmbAlbum.ValueMember=Convert.ToString(DatosTemas[ubicador].IdAlbum-1);
				cmbAutor.ValueMember=Convert.ToString(DatosTemas[ubicador].IdAutor-1);*/
                cmbAlbum.Text = Convert.ToString(dataGridView1[3, NumeroFila].Value);
                cmbAutor.Text = Convert.ToString(dataGridView1[5, NumeroFila].Value);
				nmdDuracion.Value=DatosTemas[ubicador].Duracion;
				txtTituloTema.Text=DatosTemas[ubicador].Titulo;
				txtObservaciones.Text=DatosTemas[ubicador].Observaciones;
				nmdIdTema.Value=DatosTemas[ubicador].IdTema;
				}
			}
			}
		
		private void Actualizador_y_modificador(string inconsulta)//Se crea una variable string aqui para que actue de parametro con los botones que se encargan del A.B.M
			{
			Conector();
			comando.CommandText=inconsulta;
			comando.ExecuteNonQuery();
			string tabla;//Variable que se utilizara para el metodo selecteador
        	if (cmbTablas.SelectedIndex == 0)//Si el combobox es igual a 0, el string sera igual a grupos, sino sera igual a temas
        	{tabla="Grupo";
        	conexion.Close();
        	 actualizador(tabla);//Ejecuta el metodo con el string grupos
        	}
        	else
        	{if (cmbTablas.SelectedIndex == 1)
        		{tabla="Temas";
        		conexion.Close();
        		actualizador(tabla);//Sino se ejecuta el metodo con el string temas
        		}
        	}
		}

		
		void BtnGruposClick(object sender, EventArgs e)
		{
			
         	bool modifonuevo;
         	if (txtNombreGrupo.Text!= "" || cmbCompanias.SelectedIndex!= -1 || rdbSi.Checked!= false || rdbNo.Checked!= false)
         		{
         	Grupito=new Grupos();
         	Grupito.IdGrupo=Convert.ToInt32(nmdIdGrupo.Value);
         	Grupito.Descripcion=txtNombreGrupo.Text;
         	Grupito.IdCompania=Convert.ToInt32(cmbCompanias.ValueMember);
         	Grupito.Integrantes=Convert.ToByte(nmdIntegrantes.Value);
         	if (rdbSi.Checked == true)//Este if es para determinar si el grupo es solista o no
				{Grupito.SolistaConjunto=1;}
			else
				{Grupito.SolistaConjunto=0;}
			int contadorcillo=0;
            modifonuevo=false;
            while (modifonuevo == false && DatosGrupos[contadorcillo]!=null)//Este while basicamente le indica al programa que mientras la bandera este en falso, que compruebe si el id del grupo del vector no es igual al que esta almacenado en el objeto actual; de ser asi, entonces el contador se incrementa y el while empieza de nuevo, sino pone la bandera en falso y el while termina
                {if (DatosGrupos[contadorcillo].IdGrupo != Grupito.IdGrupo)
                		{contadorcillo++;}
                	else
                		{modifonuevo=true;}
                }
                if (modifonuevo == false)
                	{inconsulta="insert into Grupo (descripcion,id_compania,cant_integrantes,solista_conjunto) values ('"+Grupito.Descripcion+"',"+Grupito.IdCompania+","+Grupito.Integrantes+","+Grupito.SolistaConjunto+")";
                	}
                else
                	{inconsulta="update Grupo set descripcion='"+Grupito.Descripcion+"',id_compania="+Grupito.IdCompania+",cant_integrantes="+Grupito.Integrantes+",solista_conjunto="+Grupito.SolistaConjunto+" where id_grupo="+Grupito.IdGrupo; 
                	}
                Limpiador();
                Actualizador_y_modificador(inconsulta);
                }

		}
		
		private void Limpiador()//Metodo para limpiar el DataGridView de manera decente
			{
			SeteadorClonado=Seteador.Clone();
            llamada = true;
            dataGridView1.Columns.Clear();//Borramos las columnas (si hay) para evitar que se dupliquen los datos (el truco lo encontre en http://walterrojasa.blogspot.com/2008/06/como-eliminar-datos-o-filas-en-un.html)
			}
		
		void BtnTemasClick(object sender, EventArgs e)
		{
         	bool modifonuevo;
			if (cmbAlbum.SelectedIndex != -1 || cmbAutor.SelectedIndex != -1 || txtObservaciones.Text != "" || txtTituloTema.Text != "")//Verifica que los controles no esten vacios (excepto los NumericUpDown, a esos no hace falta validarlos
			{
         	Cancion=new Temas();
         	Cancion.Duracion=Convert.ToInt32(nmdDuracion.Value);
         	Cancion.IdAlbum=Convert.ToInt32(cmbAlbum.ValueMember);
            Cancion.IdAutor =Convert.ToInt32(cmbAutor.ValueMember);
         	Cancion.IdTema=Convert.ToInt32(nmdIdTema.Value);
         	Cancion.Observaciones=txtObservaciones.Text;
         	Cancion.Titulo=txtTituloTema.Text;
			int contadorcillo=0;
            modifonuevo=false;
            while (modifonuevo == false && DatosTemas[contadorcillo]!=null)//Este while basicamente le indica al programa que mientras la bandera este en falso, que compruebe si el id del grupo del vector no es igual al que esta almacenado en el objeto actual; de ser asi, entonces el contador se incrementa y el while empieza de nuevo, sino pone la bandera en falso y el while termina
                {if (DatosTemas[contadorcillo].IdTema != Cancion.IdTema)
                		{contadorcillo++;}
                	else
                		{modifonuevo=true;}
                }
            
                if (modifonuevo == false)
                {
                    inconsulta = "insert into Temas (id_album,id_autor,duracion,titulo,observaciones) values (" + Cancion.IdAlbum + "," + Cancion.IdAutor + "," + Cancion.Duracion + ",'" + Cancion.Titulo + "','" + Cancion.Observaciones + "')";
                	}
                else
                	{inconsulta="update Temas set id_album="+Cancion.IdAlbum+",id_autor="+Cancion.IdAutor+",duracion="+Cancion.Duracion+",titulo='"+Cancion.Titulo+"',observaciones='"+Cancion.Observaciones+"' where id_tema="+Cancion.IdTema; 
                	}
                Limpiador();
                Actualizador_y_modificador(inconsulta);
             }
			else 
			{MessageBox.Show("¿No le esta faltando completar algun campo?. Por favor revise que no se este olvidando de nada y vuelva a intentarlo", "Error casi catastrofico", MessageBoxButtons.OK, MessageBoxIcon.Error);}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Esta seguro de que quiere borrar este registro (al menos asegurece de tener una copia de esto por si las dudas)?", "Borrando un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
				
				if (DatosGrupos[0] != null)
					{try //Aqui se coloca el código que queremos vigilar
            			{
						string inconsulta = "delete from Grupo where id_grupo=" + DatosGrupos[Convert.ToInt32(dataGridView1.CurrentRow.Index)].IdGrupo;
                		Limpiador();
                		Actualizador_y_modificador(inconsulta);
                		}
   					catch(SqlException)//Aqui se indica lo que se quiere hacer si sucede una excepción (en este caso, mostrar un mensaje de error)
            		{MessageBox.Show("Este registro no puede ser eliminado ya que al parecer esta vinculado con otro/s registro/s de alguna tabla en la base de datos. Si en serio quieres eliminar este registro, por favor asegurece de eliminar los registros vinculados al mismo primero", "Error de inamobilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();//Cerramos la conexion o el programa dara problemas
                    }
   					}
				
   					else
					{if (DatosTemas[0] != null)
					{try //Aqui se coloca el código que queremos vigilar
            			{
						string inconsulta = "delete from Temas where id_tema=" + DatosTemas[Convert.ToInt32(dataGridView1.CurrentRow.Index)].IdTema;
                    	Limpiador();
                    	Actualizador_y_modificador(inconsulta);
                    	}
				   catch(SqlException)//Aqui se indica lo que se quiere hacer si sucede una excepción (en este caso, mostrar un mensaje de error)
            		{MessageBox.Show("Este registro no puede ser eliminado ya que al parecer esta vinculado con otro/s registro/s de alguna tabla en la base de datos. Si en serio quieres eliminar este registro, por favor asegurece de eliminar los registros vinculados al mismo primero", "Error de inamobilidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.Close();
                   }
                	}
					}
				}
				
				
		else
			{MessageBox.Show("Si quiere eliminar un registro primero seleccionelo", "Error bobo", MessageBoxButtons.OK, MessageBoxIcon.Error);}//Si no se cumplen las otras condiciones, entonces el programa deberia mostrar este error
			}

        private void HABILITADOR_SELECTIVO(bool SioNo)
        {
            grpGrupos.Enabled = SioNo;
            grpTemas.Enabled = !SioNo;
            btnGrupos.Enabled = SioNo;
            btnTemas.Enabled = !SioNo;
            btnEliminar.Enabled = true;
        }

        private void actualizador_para_Laboratorio(string consulta)
        {
            Conector();
            Adaptador = new SqlDataAdapter(consulta, conexion);
            Adaptador.Fill(Seteador,consulta);
            dataGridView1.DataSource = Adaptador;
        }
        
        private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta consulta muestra el titulo del album, la compania, el genero y el nombre de grupo y para ello se hacen las composciones necesarias de las tablas correspondientes");
           Conector();
            comando.CommandText = "select album.titulo as Album, companias.descripcion as Compania, generos.descricpion as Genero, grupo.descripcion as Grupos from album, generos, grupo, companias where album.id_genero=generos.id_genero and album.id_grupo=grupo.id_grupo and album.id_compania=companias.id_compania";
            DatosTabla=new DataTable();//Esta forma para mostrar os datos provino de http://groups.google.com.ar/group/microsoft.public.es.csharp/browse_thread/thread/67112f0aa50b8699/27d2fcfaebe5a01e
            Lector=comando.ExecuteReader();
            DatosTabla.Load(Lector);
            dataGridView1.DataSource=DatosTabla;
            conexion.Close();
        }
		
		void Consulta2ToolStripMenuItemClick(object sender, EventArgs e)
		{
            MessageBox.Show("Esta consulta muestra los costos totales de los albumes, el costo promedio, la cantidad de albumes y su genero agrupado todo por genero");
			Conector();
            comando.CommandText = "select sum(album.costo) as 'Costos totales', avg(album.costo) as 'Costos promedios', count(album.id_album) as 'Cantidad de albumes de cada genero', generos.descricpion as 'Genero' from album, generos where album.id_genero=generos.id_genero group by generos.descricpion";
            DatosTabla=new DataTable();
            Lector=comando.ExecuteReader();
            DatosTabla.Load(Lector);
            dataGridView1.DataSource=DatosTabla;
            conexion.Close();
		}

		void BtnEnviarConsultaClick(object sender, EventArgs e)
		{
            MessageBox.Show("Esta consulta muestra la cantidad de temas, el promedio de duracion del album y el nombre del mismo agrupado todo por el titulo del album teniendo como condicion la duracion promedio ingresada por el teclado (o por los controles de arriba y abajo");
			Conector();
			comando.CommandText = "select count(temas.id_tema) as 'Cantidad de temas por album', avg(album.duracion_album) as 'Duracion promedio por album', album.titulo as 'Nombre del album' from temas, album where album.id_album=temas.id_album group by album.titulo having avg(album.duracion_album) >="+Convert.ToInt32(nmdDuracionPromedio.Value);
            DatosTabla=new DataTable();
            Lector=comando.ExecuteReader();
            DatosTabla.Load(Lector);
           dataGridView1.DataSource=DatosTabla;
            conexion.Close();
		}
		
		void BtnEnviarConsulta4Click(object sender, EventArgs e)
		{
            MessageBox.Show("Esta consulta muestra el titulo del album, la cantidad de temas que contiene y el nombre de la compania que se escriba en el textbox correspondiente y la fecha de lanzamiento mas reciente en donde el nombre de la compania sea el mismo que se puso antes");
			Conector();
			comando.CommandText = "SELECT album.titulo as Album, album.cant_temas as \"Temas que contiene el album\", companias.descripcion as Compania from album, companias where companias.id_compania=album.id_compania and companias.descripcion like '%"+txtIngresoCompania.Text+"%' and fecha_lanzamiento=(select max(fecha_lanzamiento) from album, companias where companias.id_compania=album.id_compania and companias.descripcion like '%"+txtIngresoCompania.Text+"%')";
            DatosTabla=new DataTable();
            Lector=comando.ExecuteReader();
            DatosTabla.Load(Lector);
           dataGridView1.DataSource=DatosTabla;
            conexion.Close();
		}
	}
}
