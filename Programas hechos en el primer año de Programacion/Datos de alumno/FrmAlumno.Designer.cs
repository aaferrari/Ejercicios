/*
 * Creado por SharpDevelop.
 * Usuario: Administrador
 * Fecha: 28/04/2009
 * Hora: 10:37 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Mi_primera_interfaz
{
	partial class FrmAlumno
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
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnGrabar = new System.Windows.Forms.Button();
			this.rdoFemenino = new System.Windows.Forms.RadioButton();
			this.rdoMasculino = new System.Windows.Forms.RadioButton();
			this.lblSexo = new System.Windows.Forms.Label();
			this.txtNDocumento = new System.Windows.Forms.TextBox();
			this.lblNDocumento = new System.Windows.Forms.Label();
			this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
			this.lblTipoDocumento = new System.Windows.Forms.Label();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.lblApellido = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtLegajo = new System.Windows.Forms.TextBox();
			this.lblLegajo = new System.Windows.Forms.Label();
			this.lblNota1 = new System.Windows.Forms.Label();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.lblNota2 = new System.Windows.Forms.Label();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.lblNota3 = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.lblRPromedio = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblAlumLibres = new System.Windows.Forms.Label();
			this.lblCAlumLibres = new System.Windows.Forms.Label();
			this.lblCAlumRegulares = new System.Windows.Forms.Label();
			this.lblAlumRegulares = new System.Windows.Forms.Label();
			this.lblCAlumPromocionados = new System.Windows.Forms.Label();
			this.lblAlumPromocionados = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnNuevo
			// 
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnNuevo.Location = new System.Drawing.Point(32, 281);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(82, 27);
			this.btnNuevo.TabIndex = 42;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSalir.Location = new System.Drawing.Point(218, 281);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(57, 27);
			this.btnSalir.TabIndex = 41;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnGrabar
			// 
			this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnGrabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnGrabar.Location = new System.Drawing.Point(123, 281);
			this.btnGrabar.Name = "btnGrabar";
			this.btnGrabar.Size = new System.Drawing.Size(89, 27);
			this.btnGrabar.TabIndex = 39;
			this.btnGrabar.Text = "Grabar";
			this.btnGrabar.UseVisualStyleBackColor = true;
			this.btnGrabar.Click += new System.EventHandler(this.BtnGrabarClick);
			// 
			// rdoFemenino
			// 
			this.rdoFemenino.AutoSize = true;
			this.rdoFemenino.BackColor = System.Drawing.SystemColors.Control;
			this.rdoFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rdoFemenino.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rdoFemenino.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rdoFemenino.Location = new System.Drawing.Point(196, 164);
			this.rdoFemenino.Name = "rdoFemenino";
			this.rdoFemenino.Size = new System.Drawing.Size(98, 24);
			this.rdoFemenino.TabIndex = 34;
			this.rdoFemenino.TabStop = true;
			this.rdoFemenino.Text = "Femenino";
			this.rdoFemenino.UseVisualStyleBackColor = false;
			this.rdoFemenino.CheckedChanged += new System.EventHandler(this.RdoFemeninoCheckedChanged);
			// 
			// rdoMasculino
			// 
			this.rdoMasculino.AutoSize = true;
			this.rdoMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rdoMasculino.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rdoMasculino.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rdoMasculino.Location = new System.Drawing.Point(89, 164);
			this.rdoMasculino.Name = "rdoMasculino";
			this.rdoMasculino.Size = new System.Drawing.Size(98, 24);
			this.rdoMasculino.TabIndex = 33;
			this.rdoMasculino.TabStop = true;
			this.rdoMasculino.Text = "Masculino";
			this.rdoMasculino.UseVisualStyleBackColor = true;
			this.rdoMasculino.CheckedChanged += new System.EventHandler(this.RdoMasculinoCheckedChanged);
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblSexo.Location = new System.Drawing.Point(40, 164);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(49, 20);
			this.lblSexo.TabIndex = 32;
			this.lblSexo.Text = "Sexo:";
			this.lblSexo.Click += new System.EventHandler(this.LblSexoClick);
			// 
			// txtNDocumento
			// 
			this.txtNDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtNDocumento.Location = new System.Drawing.Point(146, 126);
			this.txtNDocumento.MaxLength = 10;
			this.txtNDocumento.Name = "txtNDocumento";
			this.txtNDocumento.Size = new System.Drawing.Size(149, 26);
			this.txtNDocumento.TabIndex = 31;
			this.txtNDocumento.TextChanged += new System.EventHandler(this.TxtNDocumentoTextChanged);
			// 
			// lblNDocumento
			// 
			this.lblNDocumento.AutoSize = true;
			this.lblNDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblNDocumento.Location = new System.Drawing.Point(16, 125);
			this.lblNDocumento.Name = "lblNDocumento";
			this.lblNDocumento.Size = new System.Drawing.Size(135, 20);
			this.lblNDocumento.TabIndex = 30;
			this.lblNDocumento.Text = "N° de documento:";
			this.lblNDocumento.Click += new System.EventHandler(this.LblNDocumentoClick);
			// 
			// cboTipoDocumento
			// 
			this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.cboTipoDocumento.Items.AddRange(new object[] {
									"DNI",
									"Libreta de Enrrolamiento",
									"Cedulon Federal"});
			this.cboTipoDocumento.Location = new System.Drawing.Point(146, 96);
			this.cboTipoDocumento.Name = "cboTipoDocumento";
			this.cboTipoDocumento.Size = new System.Drawing.Size(149, 28);
			this.cboTipoDocumento.TabIndex = 29;
			this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CboTipoDocumentoSelectedIndexChanged);
			// 
			// lblTipoDocumento
			// 
			this.lblTipoDocumento.AutoSize = true;
			this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblTipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTipoDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblTipoDocumento.Location = new System.Drawing.Point(2, 97);
			this.lblTipoDocumento.Name = "lblTipoDocumento";
			this.lblTipoDocumento.Size = new System.Drawing.Size(149, 20);
			this.lblTipoDocumento.TabIndex = 28;
			this.lblTipoDocumento.Text = "Tipo de documento:";
			this.lblTipoDocumento.Click += new System.EventHandler(this.LblTipoDocumentoClick);
			// 
			// txtApellido
			// 
			this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtApellido.Location = new System.Drawing.Point(146, 67);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(149, 26);
			this.txtApellido.TabIndex = 27;
			this.txtApellido.TextChanged += new System.EventHandler(this.TxtApellidoTextChanged);
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblApellido.Location = new System.Drawing.Point(82, 69);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(69, 20);
			this.lblApellido.TabIndex = 26;
			this.lblApellido.Text = "Apellido:";
			this.lblApellido.Click += new System.EventHandler(this.LblApellidoClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtNombre.Location = new System.Drawing.Point(146, 38);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(149, 26);
			this.txtNombre.TabIndex = 25;
			this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombreTextChanged);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblNombre.Location = new System.Drawing.Point(81, 39);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(69, 20);
			this.lblNombre.TabIndex = 24;
			this.lblNombre.Text = "Nombre:";
			this.lblNombre.Click += new System.EventHandler(this.LblNombreClick);
			// 
			// txtLegajo
			// 
			this.txtLegajo.Enabled = false;
			this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtLegajo.Location = new System.Drawing.Point(146, 9);
			this.txtLegajo.MaxLength = 10;
			this.txtLegajo.Name = "txtLegajo";
			this.txtLegajo.Size = new System.Drawing.Size(148, 26);
			this.txtLegajo.TabIndex = 23;
			this.txtLegajo.TextChanged += new System.EventHandler(this.TxtLegajoTextChanged);
			// 
			// lblLegajo
			// 
			this.lblLegajo.AutoSize = true;
			this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblLegajo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLegajo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblLegajo.Location = new System.Drawing.Point(89, 9);
			this.lblLegajo.Name = "lblLegajo";
			this.lblLegajo.Size = new System.Drawing.Size(61, 20);
			this.lblLegajo.TabIndex = 22;
			this.lblLegajo.Text = "Legajo:";
			this.lblLegajo.Click += new System.EventHandler(this.LblLegajoClick);
			// 
			// lblNota1
			// 
			this.lblNota1.AutoSize = true;
			this.lblNota1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNota1.Location = new System.Drawing.Point(16, 190);
			this.lblNota1.Name = "lblNota1";
			this.lblNota1.Size = new System.Drawing.Size(56, 20);
			this.lblNota1.TabIndex = 43;
			this.lblNota1.Text = "Nota 1";
			// 
			// txtNota1
			// 
			this.txtNota1.Location = new System.Drawing.Point(21, 211);
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(46, 26);
			this.txtNota1.TabIndex = 44;
			// 
			// txtNota2
			// 
			this.txtNota2.Location = new System.Drawing.Point(80, 211);
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(46, 26);
			this.txtNota2.TabIndex = 46;
			// 
			// lblNota2
			// 
			this.lblNota2.AutoSize = true;
			this.lblNota2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNota2.Location = new System.Drawing.Point(75, 190);
			this.lblNota2.Name = "lblNota2";
			this.lblNota2.Size = new System.Drawing.Size(56, 20);
			this.lblNota2.TabIndex = 45;
			this.lblNota2.Text = "Nota 2";
			// 
			// txtNota3
			// 
			this.txtNota3.Location = new System.Drawing.Point(135, 212);
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(46, 26);
			this.txtNota3.TabIndex = 48;
			// 
			// lblNota3
			// 
			this.lblNota3.AutoSize = true;
			this.lblNota3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNota3.Location = new System.Drawing.Point(130, 191);
			this.lblNota3.Name = "lblNota3";
			this.lblNota3.Size = new System.Drawing.Size(56, 20);
			this.lblNota3.TabIndex = 47;
			this.lblNota3.Text = "Nota 3";
			// 
			// lblPromedio
			// 
			this.lblPromedio.AutoSize = true;
			this.lblPromedio.Location = new System.Drawing.Point(20, 249);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(80, 20);
			this.lblPromedio.TabIndex = 49;
			this.lblPromedio.Text = "Promedio:";
			// 
			// lblRPromedio
			// 
			this.lblRPromedio.AutoSize = true;
			this.lblRPromedio.Location = new System.Drawing.Point(93, 250);
			this.lblRPromedio.Name = "lblRPromedio";
			this.lblRPromedio.Size = new System.Drawing.Size(18, 20);
			this.lblRPromedio.TabIndex = 50;
			this.lblRPromedio.Text = "0";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(121, 248);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(99, 20);
			this.lblEstado.TabIndex = 51;
			this.lblEstado.Text = "__________";
			// 
			// lblAlumLibres
			// 
			this.lblAlumLibres.AutoSize = true;
			this.lblAlumLibres.Location = new System.Drawing.Point(63, 316);
			this.lblAlumLibres.Name = "lblAlumLibres";
			this.lblAlumLibres.Size = new System.Drawing.Size(56, 20);
			this.lblAlumLibres.TabIndex = 52;
			this.lblAlumLibres.Text = "Libres:";
			// 
			// lblCAlumLibres
			// 
			this.lblCAlumLibres.AutoSize = true;
			this.lblCAlumLibres.Location = new System.Drawing.Point(117, 316);
			this.lblCAlumLibres.Name = "lblCAlumLibres";
			this.lblCAlumLibres.Size = new System.Drawing.Size(18, 20);
			this.lblCAlumLibres.TabIndex = 53;
			this.lblCAlumLibres.Text = "0";
			// 
			// lblCAlumRegulares
			// 
			this.lblCAlumRegulares.AutoSize = true;
			this.lblCAlumRegulares.Location = new System.Drawing.Point(224, 317);
			this.lblCAlumRegulares.Name = "lblCAlumRegulares";
			this.lblCAlumRegulares.Size = new System.Drawing.Size(18, 20);
			this.lblCAlumRegulares.TabIndex = 55;
			this.lblCAlumRegulares.Text = "0";
			// 
			// lblAlumRegulares
			// 
			this.lblAlumRegulares.AutoSize = true;
			this.lblAlumRegulares.Location = new System.Drawing.Point(141, 317);
			this.lblAlumRegulares.Name = "lblAlumRegulares";
			this.lblAlumRegulares.Size = new System.Drawing.Size(86, 20);
			this.lblAlumRegulares.TabIndex = 54;
			this.lblAlumRegulares.Text = "Regulares:";
			// 
			// lblCAlumPromocionados
			// 
			this.lblCAlumPromocionados.AutoSize = true;
			this.lblCAlumPromocionados.Location = new System.Drawing.Point(202, 340);
			this.lblCAlumPromocionados.Name = "lblCAlumPromocionados";
			this.lblCAlumPromocionados.Size = new System.Drawing.Size(18, 20);
			this.lblCAlumPromocionados.TabIndex = 57;
			this.lblCAlumPromocionados.Text = "0";
			// 
			// lblAlumPromocionados
			// 
			this.lblAlumPromocionados.AutoSize = true;
			this.lblAlumPromocionados.Location = new System.Drawing.Point(82, 339);
			this.lblAlumPromocionados.Name = "lblAlumPromocionados";
			this.lblAlumPromocionados.Size = new System.Drawing.Size(123, 20);
			this.lblAlumPromocionados.TabIndex = 56;
			this.lblAlumPromocionados.Text = "Promocionados:";
			// 
			// FrmAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(307, 369);
			this.Controls.Add(this.lblCAlumPromocionados);
			this.Controls.Add(this.lblAlumPromocionados);
			this.Controls.Add(this.lblCAlumRegulares);
			this.Controls.Add(this.lblAlumRegulares);
			this.Controls.Add(this.lblCAlumLibres);
			this.Controls.Add(this.lblAlumLibres);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.lblRPromedio);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.txtNota3);
			this.Controls.Add(this.lblNota3);
			this.Controls.Add(this.txtNota2);
			this.Controls.Add(this.lblNota2);
			this.Controls.Add(this.txtNota1);
			this.Controls.Add(this.lblNota1);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnGrabar);
			this.Controls.Add(this.rdoFemenino);
			this.Controls.Add(this.rdoMasculino);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.txtNDocumento);
			this.Controls.Add(this.lblNDocumento);
			this.Controls.Add(this.cboTipoDocumento);
			this.Controls.Add(this.lblTipoDocumento);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.txtLegajo);
			this.Controls.Add(this.lblLegajo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmAlumno";
			this.Text = "Datos de alumno";
			this.Load += new System.EventHandler(this.FrmAlumnoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	  	private System.Windows.Forms.Label lblLegajo;
		private System.Windows.Forms.TextBox txtLegajo;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.Label lblTipoDocumento;
		private System.Windows.Forms.ComboBox cboTipoDocumento;
		private System.Windows.Forms.Label lblNDocumento;
		private System.Windows.Forms.TextBox txtNDocumento;
		private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.Button btnGrabar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblRPromedio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblAlumLibres;
        private System.Windows.Forms.Label lblCAlumLibres;
        private System.Windows.Forms.Label lblCAlumRegulares;
        private System.Windows.Forms.Label lblAlumRegulares;
        private System.Windows.Forms.Label lblCAlumPromocionados;
        private System.Windows.Forms.Label lblAlumPromocionados;
	}
}
