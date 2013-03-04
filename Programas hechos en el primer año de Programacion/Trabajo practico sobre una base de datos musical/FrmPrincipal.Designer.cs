/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 31/10/2009
 * Hora: 09:59 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Trabajo_practico_sobre_una_base_de_datos_musical
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnsBarraMenu = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.consulta1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consulta2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.lblNombreTabla = new System.Windows.Forms.Label();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.grpGrupos = new System.Windows.Forms.GroupBox();
			this.nmdIdGrupo = new System.Windows.Forms.NumericUpDown();
			this.lblIdGrupo = new System.Windows.Forms.Label();
			this.grpSolistaConjunto = new System.Windows.Forms.GroupBox();
			this.rdbNo = new System.Windows.Forms.RadioButton();
			this.rdbSi = new System.Windows.Forms.RadioButton();
			this.nmdIntegrantes = new System.Windows.Forms.NumericUpDown();
			this.lblIntegrantes = new System.Windows.Forms.Label();
			this.cmbCompanias = new System.Windows.Forms.ComboBox();
			this.lblNombreCompania = new System.Windows.Forms.Label();
			this.txtNombreGrupo = new System.Windows.Forms.TextBox();
			this.lblNombreGrupo = new System.Windows.Forms.Label();
			this.cmbTablas = new System.Windows.Forms.ComboBox();
			this.grpTemas = new System.Windows.Forms.GroupBox();
			this.nmdIdTema = new System.Windows.Forms.NumericUpDown();
			this.lblIdTema = new System.Windows.Forms.Label();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.lblObservaciones = new System.Windows.Forms.Label();
			this.cmbAutor = new System.Windows.Forms.ComboBox();
			this.lblAutor = new System.Windows.Forms.Label();
			this.nmdDuracion = new System.Windows.Forms.NumericUpDown();
			this.lblDuracion = new System.Windows.Forms.Label();
			this.cmbAlbum = new System.Windows.Forms.ComboBox();
			this.lblAlbum = new System.Windows.Forms.Label();
			this.txtTituloTema = new System.Windows.Forms.TextBox();
			this.lblTituloTema = new System.Windows.Forms.Label();
			this.btnGrupos = new System.Windows.Forms.Button();
			this.btnTemas = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.grpConsultasExtrasLaboratorio = new System.Windows.Forms.GroupBox();
			this.grpConsulta4 = new System.Windows.Forms.GroupBox();
			this.txtIngresoCompania = new System.Windows.Forms.TextBox();
			this.lblIngresoCompania = new System.Windows.Forms.Label();
			this.btnEnviarConsulta4 = new System.Windows.Forms.Button();
			this.grpConsulta3 = new System.Windows.Forms.GroupBox();
			this.nmdDuracionPromedio = new System.Windows.Forms.NumericUpDown();
			this.lblDuracionPromedio = new System.Windows.Forms.Label();
			this.btnEnviarConsulta = new System.Windows.Forms.Button();
			this.mnsBarraMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.grpGrupos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmdIdGrupo)).BeginInit();
			this.grpSolistaConjunto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmdIntegrantes)).BeginInit();
			this.grpTemas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmdIdTema)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmdDuracion)).BeginInit();
			this.grpConsultasExtrasLaboratorio.SuspendLayout();
			this.grpConsulta4.SuspendLayout();
			this.grpConsulta3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmdDuracionPromedio)).BeginInit();
			this.SuspendLayout();
			// 
			// mnsBarraMenu
			// 
			this.mnsBarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1});
			this.mnsBarraMenu.Location = new System.Drawing.Point(0, 0);
			this.mnsBarraMenu.Name = "mnsBarraMenu";
			this.mnsBarraMenu.Size = new System.Drawing.Size(766, 24);
			this.mnsBarraMenu.TabIndex = 0;
			this.mnsBarraMenu.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.consulta1ToolStripMenuItem,
									this.consulta2ToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
			this.toolStripMenuItem1.Text = "Menu de consultas";
			// 
			// consulta1ToolStripMenuItem
			// 
			this.consulta1ToolStripMenuItem.Name = "consulta1ToolStripMenuItem";
			this.consulta1ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.consulta1ToolStripMenuItem.Text = "Consulta 1";
			this.consulta1ToolStripMenuItem.Click += new System.EventHandler(this.consulta1ToolStripMenuItem_Click);
			// 
			// consulta2ToolStripMenuItem
			// 
			this.consulta2ToolStripMenuItem.Name = "consulta2ToolStripMenuItem";
			this.consulta2ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.consulta2ToolStripMenuItem.Text = "Consulta 2";
			this.consulta2ToolStripMenuItem.Click += new System.EventHandler(this.Consulta2ToolStripMenuItemClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridView1.Location = new System.Drawing.Point(7, 34);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(501, 157);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// lblNombreTabla
			// 
			this.lblNombreTabla.Location = new System.Drawing.Point(9, 202);
			this.lblNombreTabla.Name = "lblNombreTabla";
			this.lblNombreTabla.Size = new System.Drawing.Size(130, 18);
			this.lblNombreTabla.TabIndex = 2;
			this.lblNombreTabla.Text = "Nombre de la tabla:";
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(220, 197);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(288, 36);
			this.btnMostrar.TabIndex = 4;
			this.btnMostrar.Text = "Traer la tabla elegida a memoria y mostrarla en el datagrid";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// grpGrupos
			// 
			this.grpGrupos.Controls.Add(this.nmdIdGrupo);
			this.grpGrupos.Controls.Add(this.lblIdGrupo);
			this.grpGrupos.Controls.Add(this.grpSolistaConjunto);
			this.grpGrupos.Controls.Add(this.nmdIntegrantes);
			this.grpGrupos.Controls.Add(this.lblIntegrantes);
			this.grpGrupos.Controls.Add(this.cmbCompanias);
			this.grpGrupos.Controls.Add(this.lblNombreCompania);
			this.grpGrupos.Controls.Add(this.txtNombreGrupo);
			this.grpGrupos.Controls.Add(this.lblNombreGrupo);
			this.grpGrupos.Location = new System.Drawing.Point(12, 236);
			this.grpGrupos.Name = "grpGrupos";
			this.grpGrupos.Size = new System.Drawing.Size(328, 130);
			this.grpGrupos.TabIndex = 5;
			this.grpGrupos.TabStop = false;
			this.grpGrupos.Text = "Datos del grupo";
			// 
			// nmdIdGrupo
			// 
			this.nmdIdGrupo.Location = new System.Drawing.Point(73, 19);
			this.nmdIdGrupo.Maximum = new decimal(new int[] {
									268435455,
									1042612833,
									542101086,
									0});
			this.nmdIdGrupo.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nmdIdGrupo.Name = "nmdIdGrupo";
			this.nmdIdGrupo.Size = new System.Drawing.Size(36, 20);
			this.nmdIdGrupo.TabIndex = 8;
			this.nmdIdGrupo.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// lblIdGrupo
			// 
			this.lblIdGrupo.Location = new System.Drawing.Point(6, 21);
			this.lblIdGrupo.Name = "lblIdGrupo";
			this.lblIdGrupo.Size = new System.Drawing.Size(72, 14);
			this.lblIdGrupo.TabIndex = 7;
			this.lblIdGrupo.Text = "N° de grupo:";
			// 
			// grpSolistaConjunto
			// 
			this.grpSolistaConjunto.Controls.Add(this.rdbNo);
			this.grpSolistaConjunto.Controls.Add(this.rdbSi);
			this.grpSolistaConjunto.Location = new System.Drawing.Point(159, 19);
			this.grpSolistaConjunto.Name = "grpSolistaConjunto";
			this.grpSolistaConjunto.Size = new System.Drawing.Size(158, 66);
			this.grpSolistaConjunto.TabIndex = 6;
			this.grpSolistaConjunto.TabStop = false;
			this.grpSolistaConjunto.Text = "¿Es este grupo un conjunto?";
			// 
			// rdbNo
			// 
			this.rdbNo.Location = new System.Drawing.Point(66, 42);
			this.rdbNo.Name = "rdbNo";
			this.rdbNo.Size = new System.Drawing.Size(39, 17);
			this.rdbNo.TabIndex = 1;
			this.rdbNo.TabStop = true;
			this.rdbNo.Text = "No";
			this.rdbNo.UseVisualStyleBackColor = true;
			// 
			// rdbSi
			// 
			this.rdbSi.Location = new System.Drawing.Point(66, 19);
			this.rdbSi.Name = "rdbSi";
			this.rdbSi.Size = new System.Drawing.Size(39, 17);
			this.rdbSi.TabIndex = 0;
			this.rdbSi.TabStop = true;
			this.rdbSi.Text = "Si";
			this.rdbSi.UseVisualStyleBackColor = true;
			// 
			// nmdIntegrantes
			// 
			this.nmdIntegrantes.Location = new System.Drawing.Point(66, 101);
			this.nmdIntegrantes.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nmdIntegrantes.Name = "nmdIntegrantes";
			this.nmdIntegrantes.Size = new System.Drawing.Size(36, 20);
			this.nmdIntegrantes.TabIndex = 5;
			this.nmdIntegrantes.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// lblIntegrantes
			// 
			this.lblIntegrantes.Location = new System.Drawing.Point(6, 103);
			this.lblIntegrantes.Name = "lblIntegrantes";
			this.lblIntegrantes.Size = new System.Drawing.Size(63, 14);
			this.lblIntegrantes.TabIndex = 4;
			this.lblIntegrantes.Text = "Integrantes:";
			// 
			// cmbCompanias
			// 
			this.cmbCompanias.FormattingEnabled = true;
			this.cmbCompanias.Location = new System.Drawing.Point(58, 69);
			this.cmbCompanias.Name = "cmbCompanias";
			this.cmbCompanias.Size = new System.Drawing.Size(95, 21);
			this.cmbCompanias.TabIndex = 3;
			// 
			// lblNombreCompania
			// 
			this.lblNombreCompania.Location = new System.Drawing.Point(1, 72);
			this.lblNombreCompania.Name = "lblNombreCompania";
			this.lblNombreCompania.Size = new System.Drawing.Size(60, 18);
			this.lblNombreCompania.TabIndex = 2;
			this.lblNombreCompania.Text = "Compania:";
			// 
			// txtNombreGrupo
			// 
			this.txtNombreGrupo.Location = new System.Drawing.Point(58, 43);
			this.txtNombreGrupo.Name = "txtNombreGrupo";
			this.txtNombreGrupo.Size = new System.Drawing.Size(95, 20);
			this.txtNombreGrupo.TabIndex = 1;
			// 
			// lblNombreGrupo
			// 
			this.lblNombreGrupo.Location = new System.Drawing.Point(11, 47);
			this.lblNombreGrupo.Name = "lblNombreGrupo";
			this.lblNombreGrupo.Size = new System.Drawing.Size(48, 18);
			this.lblNombreGrupo.TabIndex = 0;
			this.lblNombreGrupo.Text = "Nombre:";
			// 
			// cmbTablas
			// 
			this.cmbTablas.FormattingEnabled = true;
			this.cmbTablas.Items.AddRange(new object[] {
									"Grupos",
									"Temas"});
			this.cmbTablas.Location = new System.Drawing.Point(107, 199);
			this.cmbTablas.Name = "cmbTablas";
			this.cmbTablas.Size = new System.Drawing.Size(107, 21);
			this.cmbTablas.TabIndex = 6;
		//	this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);
			// 
			// grpTemas
			// 
			this.grpTemas.Controls.Add(this.nmdIdTema);
			this.grpTemas.Controls.Add(this.lblIdTema);
			this.grpTemas.Controls.Add(this.txtObservaciones);
			this.grpTemas.Controls.Add(this.lblObservaciones);
			this.grpTemas.Controls.Add(this.cmbAutor);
			this.grpTemas.Controls.Add(this.lblAutor);
			this.grpTemas.Controls.Add(this.nmdDuracion);
			this.grpTemas.Controls.Add(this.lblDuracion);
			this.grpTemas.Controls.Add(this.cmbAlbum);
			this.grpTemas.Controls.Add(this.lblAlbum);
			this.grpTemas.Controls.Add(this.txtTituloTema);
			this.grpTemas.Controls.Add(this.lblTituloTema);
			this.grpTemas.Location = new System.Drawing.Point(346, 239);
			this.grpTemas.Name = "grpTemas";
			this.grpTemas.Size = new System.Drawing.Size(150, 177);
			this.grpTemas.TabIndex = 7;
			this.grpTemas.TabStop = false;
			this.grpTemas.Text = "Datos de temas";
			// 
			// nmdIdTema
			// 
			this.nmdIdTema.Location = new System.Drawing.Point(74, 15);
			this.nmdIdTema.Maximum = new decimal(new int[] {
									268435455,
									1042612833,
									542101086,
									0});
			this.nmdIdTema.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nmdIdTema.Name = "nmdIdTema";
			this.nmdIdTema.Size = new System.Drawing.Size(70, 20);
			this.nmdIdTema.TabIndex = 11;
			this.nmdIdTema.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// lblIdTema
			// 
			this.lblIdTema.Location = new System.Drawing.Point(7, 17);
			this.lblIdTema.Name = "lblIdTema";
			this.lblIdTema.Size = new System.Drawing.Size(72, 14);
			this.lblIdTema.TabIndex = 10;
			this.lblIdTema.Text = "N° de tema:";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(80, 117);
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(66, 20);
			this.txtObservaciones.TabIndex = 9;
			// 
			// lblObservaciones
			// 
			this.lblObservaciones.Location = new System.Drawing.Point(2, 118);
			this.lblObservaciones.Name = "lblObservaciones";
			this.lblObservaciones.Size = new System.Drawing.Size(85, 14);
			this.lblObservaciones.TabIndex = 8;
			this.lblObservaciones.Text = "Observaciones:";
			// 
			// cmbAutor
			// 
			this.cmbAutor.FormattingEnabled = true;
			this.cmbAutor.Location = new System.Drawing.Point(40, 62);
			this.cmbAutor.Name = "cmbAutor";
			this.cmbAutor.Size = new System.Drawing.Size(107, 21);
			this.cmbAutor.TabIndex = 7;
			// 
			// lblAutor
			// 
			this.lblAutor.Location = new System.Drawing.Point(7, 64);
			this.lblAutor.Name = "lblAutor";
			this.lblAutor.Size = new System.Drawing.Size(58, 16);
			this.lblAutor.TabIndex = 6;
			this.lblAutor.Text = "Autor:";
			// 
			// nmdDuracion
			// 
			this.nmdDuracion.Location = new System.Drawing.Point(75, 145);
			this.nmdDuracion.Maximum = new decimal(new int[] {
									100000000,
									0,
									0,
									0});
			this.nmdDuracion.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nmdDuracion.Name = "nmdDuracion";
			this.nmdDuracion.Size = new System.Drawing.Size(69, 20);
			this.nmdDuracion.TabIndex = 5;
			this.nmdDuracion.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// lblDuracion
			// 
			this.lblDuracion.Location = new System.Drawing.Point(1, 143);
			this.lblDuracion.Name = "lblDuracion";
			this.lblDuracion.Size = new System.Drawing.Size(78, 31);
			this.lblDuracion.TabIndex = 4;
			this.lblDuracion.Text = "Duracion\r\n(en minutos)";
			// 
			// cmbAlbum
			// 
			this.cmbAlbum.FormattingEnabled = true;
			this.cmbAlbum.Location = new System.Drawing.Point(41, 90);
			this.cmbAlbum.Name = "cmbAlbum";
			this.cmbAlbum.Size = new System.Drawing.Size(107, 21);
			this.cmbAlbum.TabIndex = 3;
			// 
			// lblAlbum
			// 
			this.lblAlbum.Location = new System.Drawing.Point(4, 93);
			this.lblAlbum.Name = "lblAlbum";
			this.lblAlbum.Size = new System.Drawing.Size(60, 18);
			this.lblAlbum.TabIndex = 2;
			this.lblAlbum.Text = "Album:";
			// 
			// txtTituloTema
			// 
			this.txtTituloTema.Location = new System.Drawing.Point(39, 37);
			this.txtTituloTema.Name = "txtTituloTema";
			this.txtTituloTema.Size = new System.Drawing.Size(107, 20);
			this.txtTituloTema.TabIndex = 1;
			// 
			// lblTituloTema
			// 
			this.lblTituloTema.Location = new System.Drawing.Point(5, 39);
			this.lblTituloTema.Name = "lblTituloTema";
			this.lblTituloTema.Size = new System.Drawing.Size(48, 18);
			this.lblTituloTema.TabIndex = 0;
			this.lblTituloTema.Text = "Titulo:";
			// 
			// btnGrupos
			// 
			this.btnGrupos.Location = new System.Drawing.Point(10, 372);
			this.btnGrupos.Name = "btnGrupos";
			this.btnGrupos.Size = new System.Drawing.Size(104, 52);
			this.btnGrupos.TabIndex = 8;
			this.btnGrupos.Text = "Agregar o modificar datos en la tabla grupos";
			this.btnGrupos.UseVisualStyleBackColor = true;
			this.btnGrupos.Click += new System.EventHandler(this.BtnGruposClick);
			// 
			// btnTemas
			// 
			this.btnTemas.Location = new System.Drawing.Point(245, 372);
			this.btnTemas.Name = "btnTemas";
			this.btnTemas.Size = new System.Drawing.Size(95, 52);
			this.btnTemas.TabIndex = 9;
			this.btnTemas.Text = "Agregar o modificar datos en la tabla temas";
			this.btnTemas.UseVisualStyleBackColor = true;
			this.btnTemas.Click += new System.EventHandler(this.BtnTemasClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(143, 370);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(79, 54);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "Eliminar registro seleccionado";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// grpConsultasExtrasLaboratorio
			// 
			this.grpConsultasExtrasLaboratorio.Controls.Add(this.grpConsulta4);
			this.grpConsultasExtrasLaboratorio.Controls.Add(this.grpConsulta3);
			this.grpConsultasExtrasLaboratorio.Location = new System.Drawing.Point(520, 33);
			this.grpConsultasExtrasLaboratorio.Name = "grpConsultasExtrasLaboratorio";
			this.grpConsultasExtrasLaboratorio.Size = new System.Drawing.Size(236, 338);
			this.grpConsultasExtrasLaboratorio.TabIndex = 11;
			this.grpConsultasExtrasLaboratorio.TabStop = false;
			this.grpConsultasExtrasLaboratorio.Text = resources.GetString("grpConsultasExtrasLaboratorio.Text");
			// 
			// grpConsulta4
			// 
			this.grpConsulta4.Controls.Add(this.txtIngresoCompania);
			this.grpConsulta4.Controls.Add(this.lblIngresoCompania);
			this.grpConsulta4.Controls.Add(this.btnEnviarConsulta4);
			this.grpConsulta4.Location = new System.Drawing.Point(10, 218);
			this.grpConsulta4.Name = "grpConsulta4";
			this.grpConsulta4.Size = new System.Drawing.Size(219, 104);
			this.grpConsulta4.TabIndex = 6;
			this.grpConsulta4.TabStop = false;
			this.grpConsulta4.Text = "Consulta N°4";
			// 
			// txtIngresoCompania
			// 
			this.txtIngresoCompania.Location = new System.Drawing.Point(146, 26);
			this.txtIngresoCompania.Name = "txtIngresoCompania";
			this.txtIngresoCompania.Size = new System.Drawing.Size(65, 20);
			this.txtIngresoCompania.TabIndex = 5;
			// 
			// lblIngresoCompania
			// 
			this.lblIngresoCompania.Location = new System.Drawing.Point(3, 20);
			this.lblIngresoCompania.Name = "lblIngresoCompania";
			this.lblIngresoCompania.Size = new System.Drawing.Size(147, 32);
			this.lblIngresoCompania.TabIndex = 4;
			this.lblIngresoCompania.Text = "Ingrese aqui el nombre de una compania (o parte de el):";
			// 
			// btnEnviarConsulta4
			// 
			this.btnEnviarConsulta4.Location = new System.Drawing.Point(55, 55);
			this.btnEnviarConsulta4.Name = "btnEnviarConsulta4";
			this.btnEnviarConsulta4.Size = new System.Drawing.Size(106, 30);
			this.btnEnviarConsulta4.TabIndex = 3;
			this.btnEnviarConsulta4.Text = "Obtener resultados";
			this.btnEnviarConsulta4.UseVisualStyleBackColor = true;
			this.btnEnviarConsulta4.Click += new System.EventHandler(this.BtnEnviarConsulta4Click);
			// 
			// grpConsulta3
			// 
			this.grpConsulta3.Controls.Add(this.nmdDuracionPromedio);
			this.grpConsulta3.Controls.Add(this.lblDuracionPromedio);
			this.grpConsulta3.Controls.Add(this.btnEnviarConsulta);
			this.grpConsulta3.Location = new System.Drawing.Point(8, 96);
			this.grpConsulta3.Name = "grpConsulta3";
			this.grpConsulta3.Size = new System.Drawing.Size(219, 104);
			this.grpConsulta3.TabIndex = 0;
			this.grpConsulta3.TabStop = false;
			this.grpConsulta3.Text = "Consulta N°3";
			// 
			// nmdDuracionPromedio
			// 
			this.nmdDuracionPromedio.Location = new System.Drawing.Point(156, 24);
			this.nmdDuracionPromedio.Maximum = new decimal(new int[] {
									1000000,
									0,
									0,
									0});
			this.nmdDuracionPromedio.Name = "nmdDuracionPromedio";
			this.nmdDuracionPromedio.Size = new System.Drawing.Size(49, 20);
			this.nmdDuracionPromedio.TabIndex = 5;
			// 
			// lblDuracionPromedio
			// 
			this.lblDuracionPromedio.Location = new System.Drawing.Point(3, 20);
			this.lblDuracionPromedio.Name = "lblDuracionPromedio";
			this.lblDuracionPromedio.Size = new System.Drawing.Size(158, 32);
			this.lblDuracionPromedio.TabIndex = 4;
			this.lblDuracionPromedio.Text = "Duracion promedio del album igual o mayor que:";
			// 
			// btnEnviarConsulta
			// 
			this.btnEnviarConsulta.Location = new System.Drawing.Point(55, 55);
			this.btnEnviarConsulta.Name = "btnEnviarConsulta";
			this.btnEnviarConsulta.Size = new System.Drawing.Size(106, 30);
			this.btnEnviarConsulta.TabIndex = 3;
			this.btnEnviarConsulta.Text = "Obtener resultados";
			this.btnEnviarConsulta.UseVisualStyleBackColor = true;
			this.btnEnviarConsulta.Click += new System.EventHandler(this.BtnEnviarConsultaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 428);
			this.Controls.Add(this.grpConsultasExtrasLaboratorio);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnTemas);
			this.Controls.Add(this.btnGrupos);
			this.Controls.Add(this.grpTemas);
			this.Controls.Add(this.cmbTablas);
			this.Controls.Add(this.grpGrupos);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.lblNombreTabla);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.mnsBarraMenu);
			this.MainMenuStrip = this.mnsBarraMenu;
			this.Name = "MainForm";
			this.Text = "Trabajo practico sobre una base de datos musical";
			this.mnsBarraMenu.ResumeLayout(false);
			this.mnsBarraMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.grpGrupos.ResumeLayout(false);
			this.grpGrupos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmdIdGrupo)).EndInit();
			this.grpSolistaConjunto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmdIntegrantes)).EndInit();
			this.grpTemas.ResumeLayout(false);
			this.grpTemas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmdIdTema)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmdDuracion)).EndInit();
			this.grpConsultasExtrasLaboratorio.ResumeLayout(false);
			this.grpConsulta4.ResumeLayout(false);
			this.grpConsulta4.PerformLayout();
			this.grpConsulta3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmdDuracionPromedio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtIngresoCompania;
		private System.Windows.Forms.Button btnEnviarConsulta4;
		private System.Windows.Forms.Label lblIngresoCompania;
		private System.Windows.Forms.GroupBox grpConsulta4;
		private System.Windows.Forms.Button btnEnviarConsulta;
		private System.Windows.Forms.Label lblDuracionPromedio;
		private System.Windows.Forms.NumericUpDown nmdDuracionPromedio;
		private System.Windows.Forms.GroupBox grpConsulta3;
		private System.Windows.Forms.GroupBox grpConsultasExtrasLaboratorio;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblIdGrupo;
		private System.Windows.Forms.Label lblIdTema;
		private System.Windows.Forms.NumericUpDown nmdIdTema;
		private System.Windows.Forms.NumericUpDown nmdIdGrupo;
		private System.Windows.Forms.Button btnTemas;
		private System.Windows.Forms.Button btnGrupos;
		private System.Windows.Forms.ComboBox cmbCompanias;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.NumericUpDown nmdDuracion;
		private System.Windows.Forms.NumericUpDown nmdIntegrantes;
		private System.Windows.Forms.GroupBox grpGrupos;
		private System.Windows.Forms.Label lblTituloTema;
		private System.Windows.Forms.TextBox txtTituloTema;
		private System.Windows.Forms.Label lblAlbum;
		private System.Windows.Forms.ComboBox cmbAlbum;
		private System.Windows.Forms.Label lblDuracion;
		private System.Windows.Forms.Label lblAutor;
		private System.Windows.Forms.ComboBox cmbAutor;
		private System.Windows.Forms.Label lblObservaciones;
		private System.Windows.Forms.GroupBox grpTemas;
		private System.Windows.Forms.ComboBox cmbTablas;
		private System.Windows.Forms.Label lblNombreGrupo;
		private System.Windows.Forms.TextBox txtNombreGrupo;
		private System.Windows.Forms.Label lblNombreCompania;
		private System.Windows.Forms.Label lblIntegrantes;
		private System.Windows.Forms.RadioButton rdbSi;
		private System.Windows.Forms.RadioButton rdbNo;
		private System.Windows.Forms.GroupBox grpSolistaConjunto;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.Label lblNombreTabla;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripMenuItem consulta2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consulta1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.MenuStrip mnsBarraMenu;
	}
}
