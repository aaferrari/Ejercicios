namespace Conector_de_bases_de_datos
{
    partial class FrmConectorDB
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	this.lblDocumento = new System.Windows.Forms.Label();
        	this.txtDocumento = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.btnNuevo = new System.Windows.Forms.Button();
        	this.lstMostrador = new System.Windows.Forms.ListBox();
        	this.lblApellido = new System.Windows.Forms.Label();
        	this.txtApellido = new System.Windows.Forms.TextBox();
        	this.lblTipoDocumento = new System.Windows.Forms.Label();
        	this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
        	this.btnBorrar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnSalir = new System.Windows.Forms.Button();
        	this.lblEstadoCivil = new System.Windows.Forms.Label();
        	this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
        	this.grpSexo = new System.Windows.Forms.GroupBox();
        	this.rdbMujer = new System.Windows.Forms.RadioButton();
        	this.rdbHombre = new System.Windows.Forms.RadioButton();
        	this.grpFallecido = new System.Windows.Forms.GroupBox();
        	this.rdbNo = new System.Windows.Forms.RadioButton();
        	this.rdbSi = new System.Windows.Forms.RadioButton();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.ClmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmEstadoCiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmMuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.grpSexo.SuspendLayout();
        	this.grpFallecido.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// lblDocumento
        	// 
        	this.lblDocumento.AutoSize = true;
        	this.lblDocumento.Location = new System.Drawing.Point(4, 79);
        	this.lblDocumento.Name = "lblDocumento";
        	this.lblDocumento.Size = new System.Drawing.Size(118, 13);
        	this.lblDocumento.TabIndex = 0;
        	this.lblDocumento.Text = "Numero de documento:";
        	// 
        	// txtDocumento
        	// 
        	this.txtDocumento.Location = new System.Drawing.Point(120, 75);
        	this.txtDocumento.Name = "txtDocumento";
        	this.txtDocumento.Size = new System.Drawing.Size(199, 20);
        	this.txtDocumento.TabIndex = 1;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.AutoSize = true;
        	this.lblNombre.Location = new System.Drawing.Point(12, 11);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(95, 13);
        	this.lblNombre.TabIndex = 2;
        	this.lblNombre.Text = "Nombre del sujeto:";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(105, 8);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(215, 20);
        	this.txtNombre.TabIndex = 3;
        	// 
        	// btnNuevo
        	// 
        	this.btnNuevo.Location = new System.Drawing.Point(9, 164);
        	this.btnNuevo.Name = "btnNuevo";
        	this.btnNuevo.Size = new System.Drawing.Size(117, 53);
        	this.btnNuevo.TabIndex = 5;
        	this.btnNuevo.Text = "Habilitar todo para comenzar a cargar datos (y eso)";
        	this.btnNuevo.UseVisualStyleBackColor = true;
        	this.btnNuevo.Click += new System.EventHandler(this.btnCargar_Click);
        	// 
        	// lstMostrador
        	// 
        	this.lstMostrador.FormattingEnabled = true;
        	this.lstMostrador.Location = new System.Drawing.Point(325, 8);
        	this.lstMostrador.Name = "lstMostrador";
        	this.lstMostrador.Size = new System.Drawing.Size(218, 251);
        	this.lstMostrador.TabIndex = 4;
        	this.lstMostrador.SelectedIndexChanged += new System.EventHandler(this.LstMostradorSelectedIndexChanged);
        	// 
        	// lblApellido
        	// 
        	this.lblApellido.AutoSize = true;
        	this.lblApellido.Location = new System.Drawing.Point(11, 32);
        	this.lblApellido.Name = "lblApellido";
        	this.lblApellido.Size = new System.Drawing.Size(95, 13);
        	this.lblApellido.TabIndex = 6;
        	this.lblApellido.Text = "Apellido del sujeto:";
        	// 
        	// txtApellido
        	// 
        	this.txtApellido.Location = new System.Drawing.Point(105, 30);
        	this.txtApellido.Name = "txtApellido";
        	this.txtApellido.Size = new System.Drawing.Size(214, 20);
        	this.txtApellido.TabIndex = 7;
        	// 
        	// lblTipoDocumento
        	// 
        	this.lblTipoDocumento.AutoSize = true;
        	this.lblTipoDocumento.Location = new System.Drawing.Point(4, 57);
        	this.lblTipoDocumento.Name = "lblTipoDocumento";
        	this.lblTipoDocumento.Size = new System.Drawing.Size(102, 13);
        	this.lblTipoDocumento.TabIndex = 8;
        	this.lblTipoDocumento.Text = "Tipo de documento:";
        	// 
        	// cmbTipoDocumento
        	// 
        	this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbTipoDocumento.FormattingEnabled = true;
        	this.cmbTipoDocumento.Location = new System.Drawing.Point(105, 52);
        	this.cmbTipoDocumento.Name = "cmbTipoDocumento";
        	this.cmbTipoDocumento.Size = new System.Drawing.Size(214, 21);
        	this.cmbTipoDocumento.TabIndex = 9;
        	// 
        	// btnBorrar
        	// 
        	this.btnBorrar.Location = new System.Drawing.Point(128, 199);
        	this.btnBorrar.Name = "btnBorrar";
        	this.btnBorrar.Size = new System.Drawing.Size(164, 23);
        	this.btnBorrar.TabIndex = 11;
        	this.btnBorrar.Text = "Borrar datos que se han escrito";
        	this.btnBorrar.UseVisualStyleBackColor = true;
        	this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(50, 224);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(192, 38);
        	this.btnGuardar.TabIndex = 12;
        	this.btnGuardar.Text = "Actualizar el registro modificado en la base de datos o agregar otro nuevo";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(130, 163);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(118, 35);
        	this.btnCancelar.TabIndex = 13;
        	this.btnCancelar.Text = "Cancelar los cambios que se hicieron";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	// 
        	// btnSalir
        	// 
        	this.btnSalir.Location = new System.Drawing.Point(254, 170);
        	this.btnSalir.Name = "btnSalir";
        	this.btnSalir.Size = new System.Drawing.Size(41, 19);
        	this.btnSalir.TabIndex = 14;
        	this.btnSalir.Text = "Salir";
        	this.btnSalir.UseVisualStyleBackColor = true;
        	this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
        	// 
        	// lblEstadoCivil
        	// 
        	this.lblEstadoCivil.AutoSize = true;
        	this.lblEstadoCivil.Location = new System.Drawing.Point(10, 101);
        	this.lblEstadoCivil.Name = "lblEstadoCivil";
        	this.lblEstadoCivil.Size = new System.Drawing.Size(64, 13);
        	this.lblEstadoCivil.TabIndex = 15;
        	this.lblEstadoCivil.Text = "Estado civil:";
        	// 
        	// cmbEstadoCivil
        	// 
        	this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbEstadoCivil.FormattingEnabled = true;
        	this.cmbEstadoCivil.Location = new System.Drawing.Point(72, 97);
        	this.cmbEstadoCivil.Name = "cmbEstadoCivil";
        	this.cmbEstadoCivil.Size = new System.Drawing.Size(247, 21);
        	this.cmbEstadoCivil.TabIndex = 16;
        	// 
        	// grpSexo
        	// 
        	this.grpSexo.Controls.Add(this.rdbMujer);
        	this.grpSexo.Controls.Add(this.rdbHombre);
        	this.grpSexo.Location = new System.Drawing.Point(12, 122);
        	this.grpSexo.Name = "grpSexo";
        	this.grpSexo.Size = new System.Drawing.Size(159, 36);
        	this.grpSexo.TabIndex = 17;
        	this.grpSexo.TabStop = false;
        	this.grpSexo.Text = "Sexo";
        	// 
        	// rdbMujer
        	// 
        	this.rdbMujer.AutoSize = true;
        	this.rdbMujer.Location = new System.Drawing.Point(87, 14);
        	this.rdbMujer.Name = "rdbMujer";
        	this.rdbMujer.Size = new System.Drawing.Size(71, 17);
        	this.rdbMujer.TabIndex = 1;
        	this.rdbMujer.TabStop = true;
        	this.rdbMujer.Text = "Femenino";
        	this.rdbMujer.UseVisualStyleBackColor = true;
        	// 
        	// rdbHombre
        	// 
        	this.rdbHombre.AutoSize = true;
        	this.rdbHombre.Location = new System.Drawing.Point(8, 14);
        	this.rdbHombre.Name = "rdbHombre";
        	this.rdbHombre.Size = new System.Drawing.Size(73, 17);
        	this.rdbHombre.TabIndex = 0;
        	this.rdbHombre.TabStop = true;
        	this.rdbHombre.Text = "Masculino";
        	this.rdbHombre.UseVisualStyleBackColor = true;
        	// 
        	// grpFallecido
        	// 
        	this.grpFallecido.Controls.Add(this.rdbNo);
        	this.grpFallecido.Controls.Add(this.rdbSi);
        	this.grpFallecido.Location = new System.Drawing.Point(186, 124);
        	this.grpFallecido.Name = "grpFallecido";
        	this.grpFallecido.Size = new System.Drawing.Size(129, 34);
        	this.grpFallecido.TabIndex = 18;
        	this.grpFallecido.TabStop = false;
        	this.grpFallecido.Text = "¿Est@ acaso fallecio?";
        	// 
        	// rdbNo
        	// 
        	this.rdbNo.AutoSize = true;
        	this.rdbNo.Location = new System.Drawing.Point(67, 15);
        	this.rdbNo.Name = "rdbNo";
        	this.rdbNo.Size = new System.Drawing.Size(39, 17);
        	this.rdbNo.TabIndex = 1;
        	this.rdbNo.TabStop = true;
        	this.rdbNo.Text = "No";
        	this.rdbNo.UseVisualStyleBackColor = true;
        	// 
        	// rdbSi
        	// 
        	this.rdbSi.AutoSize = true;
        	this.rdbSi.Location = new System.Drawing.Point(22, 15);
        	this.rdbSi.Name = "rdbSi";
        	this.rdbSi.Size = new System.Drawing.Size(34, 17);
        	this.rdbSi.TabIndex = 0;
        	this.rdbSi.TabStop = true;
        	this.rdbSi.Text = "Si";
        	this.rdbSi.UseVisualStyleBackColor = true;
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        	        	        	this.ClmApellido,
        	        	        	this.ClmNombre,
        	        	        	this.ClmTipoDoc,
        	        	        	this.ClmDocumento,
        	        	        	this.ClmEstadoCiv,
        	        	        	this.ClmSexo,
        	        	        	this.ClmMuerto});
        	this.dataGridView1.Location = new System.Drawing.Point(549, 8);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.Size = new System.Drawing.Size(223, 256);
        	this.dataGridView1.TabIndex = 19;
        	this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
        	// 
        	// ClmApellido
        	// 
        	this.ClmApellido.HeaderText = "Apellido";
        	this.ClmApellido.Name = "ClmApellido";
        	// 
        	// ClmNombre
        	// 
        	this.ClmNombre.HeaderText = "Nombre/s";
        	this.ClmNombre.Name = "ClmNombre";
        	// 
        	// ClmTipoDoc
        	// 
        	this.ClmTipoDoc.HeaderText = "Tipo de documento";
        	this.ClmTipoDoc.Name = "ClmTipoDoc";
        	// 
        	// ClmDocumento
        	// 
        	this.ClmDocumento.HeaderText = "N° de documento";
        	this.ClmDocumento.Name = "ClmDocumento";
        	// 
        	// ClmEstadoCiv
        	// 
        	this.ClmEstadoCiv.HeaderText = "Estado Civil";
        	this.ClmEstadoCiv.Name = "ClmEstadoCiv";
        	// 
        	// ClmSexo
        	// 
        	this.ClmSexo.HeaderText = "Sexo";
        	this.ClmSexo.Name = "ClmSexo";
        	// 
        	// ClmMuerto
        	// 
        	this.ClmMuerto.HeaderText = "Fallecido";
        	this.ClmMuerto.Name = "ClmMuerto";
        	// 
        	// FrmConectorDB
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(784, 276);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.grpFallecido);
        	this.Controls.Add(this.grpSexo);
        	this.Controls.Add(this.cmbEstadoCivil);
        	this.Controls.Add(this.lblEstadoCivil);
        	this.Controls.Add(this.btnSalir);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.btnBorrar);
        	this.Controls.Add(this.cmbTipoDocumento);
        	this.Controls.Add(this.lblTipoDocumento);
        	this.Controls.Add(this.txtApellido);
        	this.Controls.Add(this.lblApellido);
        	this.Controls.Add(this.btnNuevo);
        	this.Controls.Add(this.lstMostrador);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Controls.Add(this.txtDocumento);
        	this.Controls.Add(this.lblDocumento);
        	this.Name = "FrmConectorDB";
        	this.Text = "Conector y Visualizador de bases de datos";
        	this.Load += new System.EventHandler(this.FrmConectorDB_Load);
        	this.grpSexo.ResumeLayout(false);
        	this.grpSexo.PerformLayout();
        	this.grpFallecido.ResumeLayout(false);
        	this.grpFallecido.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEstadoCiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmApellido;
        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion

        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListBox lstMostrador;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.GroupBox grpFallecido;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
    }
}

