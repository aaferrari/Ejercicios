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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chkSoltero = new System.Windows.Forms.CheckBox();
            this.lblSoltero = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNuevo.Location = new System.Drawing.Point(7, 223);
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
            this.btnSalir.Location = new System.Drawing.Point(205, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 27);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(101, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 27);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrabar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGrabar.Location = new System.Drawing.Point(283, 223);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(89, 27);
            this.btnGrabar.TabIndex = 39;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.BtnGrabarClick);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBorrar.Location = new System.Drawing.Point(203, 223);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(72, 27);
            this.btnBorrar.TabIndex = 38;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(96, 223);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 27);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
            // 
            // chkSoltero
            // 
            this.chkSoltero.AutoSize = true;
            this.chkSoltero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSoltero.Location = new System.Drawing.Point(203, 195);
            this.chkSoltero.Name = "chkSoltero";
            this.chkSoltero.Size = new System.Drawing.Size(15, 14);
            this.chkSoltero.TabIndex = 36;
            this.chkSoltero.UseVisualStyleBackColor = true;
            this.chkSoltero.CheckedChanged += new System.EventHandler(this.ChkSolteroCheckedChanged);
            // 
            // lblSoltero
            // 
            this.lblSoltero.AutoSize = true;
            this.lblSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoltero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSoltero.Location = new System.Drawing.Point(143, 190);
            this.lblSoltero.Name = "lblSoltero";
            this.lblSoltero.Size = new System.Drawing.Size(64, 20);
            this.lblSoltero.TabIndex = 35;
            this.lblSoltero.Text = "Soltero:";
            this.lblSoltero.Click += new System.EventHandler(this.LblSolteroClick);
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoFemenino.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoFemenino.Location = new System.Drawing.Point(196, 164);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(98, 24);
            this.rdoFemenino.TabIndex = 34;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            this.rdoFemenino.CheckedChanged += new System.EventHandler(this.RdoFemeninoCheckedChanged);
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.txtNDocumento.Size = new System.Drawing.Size(125, 26);
            this.txtNDocumento.TabIndex = 31;
            this.txtNDocumento.TextChanged += new System.EventHandler(this.TxtNDocumentoTextChanged);
            // 
            // lblNDocumento
            // 
            this.lblNDocumento.AutoSize = true;
            this.lblNDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.cboTipoDocumento.Location = new System.Drawing.Point(146, 96);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(123, 28);
            this.cboTipoDocumento.TabIndex = 29;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CboTipoDocumentoSelectedIndexChanged);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.txtLegajo.Size = new System.Drawing.Size(177, 26);
            this.txtLegajo.TabIndex = 23;
            this.txtLegajo.TextChanged += new System.EventHandler(this.TxtLegajoTextChanged);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLegajo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLegajo.Location = new System.Drawing.Point(89, 9);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(61, 20);
            this.lblLegajo.TabIndex = 22;
            this.lblLegajo.Text = "Legajo:";
            this.lblLegajo.Click += new System.EventHandler(this.LblLegajoClick);
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(85)))), ((int)(((byte)(94)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(377, 297);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.chkSoltero);
            this.Controls.Add(this.lblSoltero);
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
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
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
		private System.Windows.Forms.Label lblSoltero;
		private System.Windows.Forms.CheckBox chkSoltero;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnGrabar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnNuevo;
	}
}
