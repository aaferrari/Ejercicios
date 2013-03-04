namespace Objetos_matriciales
{
    partial class FrmVideo
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
        	this.rdoFemenino = new System.Windows.Forms.RadioButton();
        	this.rdoMasculino = new System.Windows.Forms.RadioButton();
        	this.txtNDocumento = new System.Windows.Forms.TextBox();
        	this.lblNDocumento = new System.Windows.Forms.Label();
        	this.txtApellido = new System.Windows.Forms.TextBox();
        	this.lblApellido = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.grpSexo = new System.Windows.Forms.GroupBox();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.btnMostrar = new System.Windows.Forms.Button();
        	this.lstColectora = new System.Windows.Forms.ListBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.grpMatrizdeSexos = new System.Windows.Forms.GroupBox();
        	this.lblMujeres = new System.Windows.Forms.Label();
        	this.lblHombres = new System.Windows.Forms.Label();
        	this.lstMujeres = new System.Windows.Forms.ListBox();
        	this.lstHombres = new System.Windows.Forms.ListBox();
        	this.grpSexo.SuspendLayout();
        	this.grpMatrizdeSexos.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// rdoFemenino
        	// 
        	this.rdoFemenino.AutoSize = true;
        	this.rdoFemenino.BackColor = System.Drawing.SystemColors.Control;
        	this.rdoFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.rdoFemenino.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.rdoFemenino.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        	this.rdoFemenino.Location = new System.Drawing.Point(108, 27);
        	this.rdoFemenino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.rdoFemenino.Name = "rdoFemenino";
        	this.rdoFemenino.Size = new System.Drawing.Size(98, 24);
        	this.rdoFemenino.TabIndex = 43;
        	this.rdoFemenino.TabStop = true;
        	this.rdoFemenino.Text = "Femenino";
        	this.rdoFemenino.UseVisualStyleBackColor = false;
        	// 
        	// rdoMasculino
        	// 
        	this.rdoMasculino.AutoSize = true;
        	this.rdoMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.rdoMasculino.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.rdoMasculino.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        	this.rdoMasculino.Location = new System.Drawing.Point(8, 26);
        	this.rdoMasculino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.rdoMasculino.Name = "rdoMasculino";
        	this.rdoMasculino.Size = new System.Drawing.Size(98, 24);
        	this.rdoMasculino.TabIndex = 42;
        	this.rdoMasculino.TabStop = true;
        	this.rdoMasculino.Text = "Masculino";
        	this.rdoMasculino.UseVisualStyleBackColor = true;
        	// 
        	// txtNDocumento
        	// 
        	this.txtNDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtNDocumento.Location = new System.Drawing.Point(133, 69);
        	this.txtNDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.txtNDocumento.MaxLength = 10;
        	this.txtNDocumento.Name = "txtNDocumento";
        	this.txtNDocumento.Size = new System.Drawing.Size(204, 26);
        	this.txtNDocumento.TabIndex = 40;
        	// 
        	// lblNDocumento
        	// 
        	this.lblNDocumento.AutoSize = true;
        	this.lblNDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblNDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.lblNDocumento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        	this.lblNDocumento.Location = new System.Drawing.Point(2, 68);
        	this.lblNDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblNDocumento.Name = "lblNDocumento";
        	this.lblNDocumento.Size = new System.Drawing.Size(135, 20);
        	this.lblNDocumento.TabIndex = 39;
        	this.lblNDocumento.Text = "N° de documento:";
        	// 
        	// txtApellido
        	// 
        	this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtApellido.Location = new System.Drawing.Point(68, 37);
        	this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.txtApellido.Name = "txtApellido";
        	this.txtApellido.Size = new System.Drawing.Size(269, 26);
        	this.txtApellido.TabIndex = 38;
        	// 
        	// lblApellido
        	// 
        	this.lblApellido.AutoSize = true;
        	this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.lblApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        	this.lblApellido.Location = new System.Drawing.Point(4, 40);
        	this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblApellido.Name = "lblApellido";
        	this.lblApellido.Size = new System.Drawing.Size(69, 20);
        	this.lblApellido.TabIndex = 37;
        	this.lblApellido.Text = "Apellido:";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtNombre.Location = new System.Drawing.Point(68, 7);
        	this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(269, 26);
        	this.txtNombre.TabIndex = 36;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.AutoSize = true;
        	this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
        	this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        	this.lblNombre.Location = new System.Drawing.Point(2, 9);
        	this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(69, 20);
        	this.lblNombre.TabIndex = 35;
        	this.lblNombre.Text = "Nombre:";
        	// 
        	// grpSexo
        	// 
        	this.grpSexo.Controls.Add(this.rdoMasculino);
        	this.grpSexo.Controls.Add(this.rdoFemenino);
        	this.grpSexo.Location = new System.Drawing.Point(89, 105);
        	this.grpSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.grpSexo.Name = "grpSexo";
        	this.grpSexo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.grpSexo.Size = new System.Drawing.Size(206, 59);
        	this.grpSexo.TabIndex = 44;
        	this.grpSexo.TabStop = false;
        	this.grpSexo.Text = "Sexo";
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(10, 169);
        	this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(218, 25);
        	this.btnGuardar.TabIndex = 45;
        	this.btnGuardar.Text = "Guardar datos en la matriz";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
        	// 
        	// btnMostrar
        	// 
        	this.btnMostrar.Location = new System.Drawing.Point(10, 195);
        	this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.btnMostrar.Name = "btnMostrar";
        	this.btnMostrar.Size = new System.Drawing.Size(314, 52);
        	this.btnMostrar.TabIndex = 46;
        	this.btnMostrar.Text = "Mostrar en la lista los datos guardados en la matriz";
        	this.btnMostrar.UseVisualStyleBackColor = true;
        	this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
        	// 
        	// lstColectora
        	// 
        	this.lstColectora.FormattingEnabled = true;
        	this.lstColectora.ItemHeight = 20;
        	this.lstColectora.Location = new System.Drawing.Point(10, 253);
        	this.lstColectora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.lstColectora.Name = "lstColectora";
        	this.lstColectora.Size = new System.Drawing.Size(327, 104);
        	this.lstColectora.TabIndex = 47;
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(30, 22);
        	this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(236, 52);
        	this.button1.TabIndex = 48;
        	this.button1.Text = "Pasar personas por sus sexos a las listas correspondientes";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// grpMatrizdeSexos
        	// 
        	this.grpMatrizdeSexos.Controls.Add(this.lblMujeres);
        	this.grpMatrizdeSexos.Controls.Add(this.lblHombres);
        	this.grpMatrizdeSexos.Controls.Add(this.lstMujeres);
        	this.grpMatrizdeSexos.Controls.Add(this.lstHombres);
        	this.grpMatrizdeSexos.Controls.Add(this.button1);
        	this.grpMatrizdeSexos.Location = new System.Drawing.Point(344, 12);
        	this.grpMatrizdeSexos.Name = "grpMatrizdeSexos";
        	this.grpMatrizdeSexos.Size = new System.Drawing.Size(341, 345);
        	this.grpMatrizdeSexos.TabIndex = 49;
        	this.grpMatrizdeSexos.TabStop = false;
        	this.grpMatrizdeSexos.Text = "Personas segun su sexo";
        	// 
        	// lblMujeres
        	// 
        	this.lblMujeres.Location = new System.Drawing.Point(12, 216);
        	this.lblMujeres.Name = "lblMujeres";
        	this.lblMujeres.Size = new System.Drawing.Size(69, 21);
        	this.lblMujeres.TabIndex = 52;
        	this.lblMujeres.Text = "Mujeres:";
        	// 
        	// lblHombres
        	// 
        	this.lblHombres.Location = new System.Drawing.Point(7, 83);
        	this.lblHombres.Name = "lblHombres";
        	this.lblHombres.Size = new System.Drawing.Size(74, 20);
        	this.lblHombres.TabIndex = 51;
        	this.lblHombres.Text = "Hombres:";
        	// 
        	// lstMujeres
        	// 
        	this.lstMujeres.FormattingEnabled = true;
        	this.lstMujeres.ItemHeight = 20;
        	this.lstMujeres.Location = new System.Drawing.Point(7, 237);
        	this.lstMujeres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.lstMujeres.Name = "lstMujeres";
        	this.lstMujeres.Size = new System.Drawing.Size(327, 104);
        	this.lstMujeres.TabIndex = 50;
        	// 
        	// lstHombres
        	// 
        	this.lstHombres.FormattingEnabled = true;
        	this.lstHombres.ItemHeight = 20;
        	this.lstHombres.Location = new System.Drawing.Point(6, 103);
        	this.lstHombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.lstHombres.Name = "lstHombres";
        	this.lstHombres.Size = new System.Drawing.Size(327, 104);
        	this.lstHombres.TabIndex = 49;
        	// 
        	// FrmVideo
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(690, 367);
        	this.Controls.Add(this.grpMatrizdeSexos);
        	this.Controls.Add(this.lstColectora);
        	this.Controls.Add(this.btnMostrar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.grpSexo);
        	this.Controls.Add(this.txtNDocumento);
        	this.Controls.Add(this.lblNDocumento);
        	this.Controls.Add(this.txtApellido);
        	this.Controls.Add(this.lblApellido);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Name = "FrmVideo";
        	this.Text = "Videoclub Berreta";
        	this.grpSexo.ResumeLayout(false);
        	this.grpSexo.PerformLayout();
        	this.grpMatrizdeSexos.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ListBox lstHombres;
        private System.Windows.Forms.ListBox lstMujeres;
        private System.Windows.Forms.Label lblHombres;
        private System.Windows.Forms.Label lblMujeres;
        private System.Windows.Forms.GroupBox grpMatrizdeSexos;
        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.TextBox txtNDocumento;
        private System.Windows.Forms.Label lblNDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstColectora;
    }
}

