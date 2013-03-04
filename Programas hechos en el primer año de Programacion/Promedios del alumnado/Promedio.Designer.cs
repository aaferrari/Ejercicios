namespace Promedios_del_alumnado
{
    partial class FrmPromedio
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
        	this.lblLegajo = new System.Windows.Forms.Label();
        	this.txtLegajo = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNota1 = new System.Windows.Forms.Label();
        	this.lblNota2 = new System.Windows.Forms.Label();
        	this.lblNota3 = new System.Windows.Forms.Label();
        	this.txtNota1 = new System.Windows.Forms.TextBox();
        	this.txtNota2 = new System.Windows.Forms.TextBox();
        	this.txtNota3 = new System.Windows.Forms.TextBox();
        	this.lblPromedio = new System.Windows.Forms.Label();
        	this.lblResultado = new System.Windows.Forms.Label();
        	this.btnRegistrar = new System.Windows.Forms.Button();
        	this.btnNuevo = new System.Windows.Forms.Button();
        	this.lblCantidad = new System.Windows.Forms.Label();
        	this.lblRCantidad = new System.Windows.Forms.Label();
        	this.lblPromedioGeneral = new System.Windows.Forms.Label();
        	this.lblRPromedioGeneral = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// lblLegajo
        	// 
        	this.lblLegajo.AutoSize = true;
        	this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblLegajo.Location = new System.Drawing.Point(10, 14);
        	this.lblLegajo.Name = "lblLegajo";
        	this.lblLegajo.Size = new System.Drawing.Size(61, 20);
        	this.lblLegajo.TabIndex = 0;
        	this.lblLegajo.Text = "Legajo:";
        	// 
        	// txtLegajo
        	// 
        	this.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtLegajo.Location = new System.Drawing.Point(71, 12);
        	this.txtLegajo.Name = "txtLegajo";
        	this.txtLegajo.Size = new System.Drawing.Size(84, 26);
        	this.txtLegajo.TabIndex = 1;
        //	this.txtLegajo.TextChanged += new System.EventArgs(this.txtLegajo_TextChanged);
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.AutoSize = true;
        	this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblNombre.Location = new System.Drawing.Point(6, 53);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(69, 20);
        	this.lblNombre.TabIndex = 2;
        	this.lblNombre.Text = "Nombre:";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtNombre.Location = new System.Drawing.Point(71, 49);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(114, 26);
        	this.txtNombre.TabIndex = 3;
        	this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombreTextChanged);
        	// 
        	// lblNota1
        	// 
        	this.lblNota1.AutoSize = true;
        	this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblNota1.Location = new System.Drawing.Point(13, 96);
        	this.lblNota1.Name = "lblNota1";
        	this.lblNota1.Size = new System.Drawing.Size(56, 20);
        	this.lblNota1.TabIndex = 4;
        	this.lblNota1.Text = "Nota 1";
        	// 
        	// lblNota2
        	// 
        	this.lblNota2.AutoSize = true;
        	this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblNota2.Location = new System.Drawing.Point(76, 96);
        	this.lblNota2.Name = "lblNota2";
        	this.lblNota2.Size = new System.Drawing.Size(56, 20);
        	this.lblNota2.TabIndex = 5;
        	this.lblNota2.Text = "Nota 2";
        	// 
        	// lblNota3
        	// 
        	this.lblNota3.AutoSize = true;
        	this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblNota3.Location = new System.Drawing.Point(139, 96);
        	this.lblNota3.Name = "lblNota3";
        	this.lblNota3.Size = new System.Drawing.Size(56, 20);
        	this.lblNota3.TabIndex = 6;
        	this.lblNota3.Text = "Nota 3";
        	// 
        	// txtNota1
        	// 
        	this.txtNota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtNota1.Location = new System.Drawing.Point(21, 120);
        	this.txtNota1.MaxLength = 2;
        	this.txtNota1.Name = "txtNota1";
        	this.txtNota1.Size = new System.Drawing.Size(38, 26);
        	this.txtNota1.TabIndex = 7;
        	this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
        	// 
        	// txtNota2
        	// 
        	this.txtNota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtNota2.Location = new System.Drawing.Point(83, 119);
        	this.txtNota2.MaxLength = 2;
        	this.txtNota2.Name = "txtNota2";
        	this.txtNota2.Size = new System.Drawing.Size(38, 26);
        	this.txtNota2.TabIndex = 8;
        	// 
        	// txtNota3
        	// 
        	this.txtNota3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.txtNota3.Location = new System.Drawing.Point(146, 120);
        	this.txtNota3.MaxLength = 2;
        	this.txtNota3.Name = "txtNota3";
        	this.txtNota3.Size = new System.Drawing.Size(38, 26);
        	this.txtNota3.TabIndex = 9;
        	// 
        	// lblPromedio
        	// 
        	this.lblPromedio.AutoSize = true;
        	this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblPromedio.Location = new System.Drawing.Point(15, 162);
        	this.lblPromedio.Name = "lblPromedio";
        	this.lblPromedio.Size = new System.Drawing.Size(80, 20);
        	this.lblPromedio.TabIndex = 10;
        	this.lblPromedio.Text = "Promedio:";
        	// 
        	// lblResultado
        	// 
        	this.lblResultado.AutoSize = true;
        	this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblResultado.Location = new System.Drawing.Point(90, 162);
        	this.lblResultado.Name = "lblResultado";
        	this.lblResultado.Size = new System.Drawing.Size(0, 20);
        	this.lblResultado.TabIndex = 11;
        	this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
        	// 
        	// btnRegistrar
        	// 
        	this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.btnRegistrar.Location = new System.Drawing.Point(98, 189);
        	this.btnRegistrar.Name = "btnRegistrar";
        	this.btnRegistrar.Size = new System.Drawing.Size(84, 30);
        	this.btnRegistrar.TabIndex = 12;
        	this.btnRegistrar.Text = "Registrar";
        	this.btnRegistrar.UseVisualStyleBackColor = true;
        	this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
        	// 
        	// btnNuevo
        	// 
        	this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.btnNuevo.Location = new System.Drawing.Point(23, 189);
        	this.btnNuevo.Name = "btnNuevo";
        	this.btnNuevo.Size = new System.Drawing.Size(64, 30);
        	this.btnNuevo.TabIndex = 13;
        	this.btnNuevo.Text = "Nuevo";
        	this.btnNuevo.UseVisualStyleBackColor = true;
        	this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
        	// 
        	// lblCantidad
        	// 
        	this.lblCantidad.AutoSize = true;
        	this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblCantidad.Location = new System.Drawing.Point(14, 223);
        	this.lblCantidad.Name = "lblCantidad";
        	this.lblCantidad.Size = new System.Drawing.Size(73, 20);
        	this.lblCantidad.TabIndex = 14;
        	this.lblCantidad.Text = "Cantidad";
        	// 
        	// lblRCantidad
        	// 
        	this.lblRCantidad.AutoSize = true;
        	this.lblRCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblRCantidad.Location = new System.Drawing.Point(33, 249);
        	this.lblRCantidad.Name = "lblRCantidad";
        	this.lblRCantidad.Size = new System.Drawing.Size(0, 20);
        	this.lblRCantidad.TabIndex = 15;
        	// 
        	// lblPromedioGeneral
        	// 
        	this.lblPromedioGeneral.AutoSize = true;
        	this.lblPromedioGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblPromedioGeneral.Location = new System.Drawing.Point(92, 224);
        	this.lblPromedioGeneral.Name = "lblPromedioGeneral";
        	this.lblPromedioGeneral.Size = new System.Drawing.Size(107, 20);
        	this.lblPromedioGeneral.TabIndex = 16;
        	this.lblPromedioGeneral.Text = "Prom. general";
        	// 
        	// lblRPromedioGeneral
        	// 
        	this.lblRPromedioGeneral.AutoSize = true;
        	this.lblRPromedioGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.lblRPromedioGeneral.Location = new System.Drawing.Point(112, 250);
        	this.lblRPromedioGeneral.Name = "lblRPromedioGeneral";
        	this.lblRPromedioGeneral.Size = new System.Drawing.Size(0, 20);
        	this.lblRPromedioGeneral.TabIndex = 17;
        	// 
        	// FrmPromedio
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(200, 287);
        	this.Controls.Add(this.lblRPromedioGeneral);
        	this.Controls.Add(this.lblPromedioGeneral);
        	this.Controls.Add(this.lblRCantidad);
        	this.Controls.Add(this.lblCantidad);
        	this.Controls.Add(this.btnNuevo);
        	this.Controls.Add(this.btnRegistrar);
        	this.Controls.Add(this.lblResultado);
        	this.Controls.Add(this.lblPromedio);
        	this.Controls.Add(this.txtNota3);
        	this.Controls.Add(this.txtNota2);
        	this.Controls.Add(this.txtNota1);
        	this.Controls.Add(this.lblNota3);
        	this.Controls.Add(this.lblNota2);
        	this.Controls.Add(this.lblNota1);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Controls.Add(this.txtLegajo);
        	this.Controls.Add(this.lblLegajo);
        	this.Name = "FrmPromedio";
        	this.Text = "Promedio";
        	this.Load += new System.EventHandler(this.FrmPromedio_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        public System.Windows.Forms.Label lblLegajo;
        public System.Windows.Forms.TextBox txtLegajo;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblNota1;
        public System.Windows.Forms.Label lblNota2;
        public System.Windows.Forms.Label lblNota3;
        public System.Windows.Forms.TextBox txtNota1;
        public System.Windows.Forms.TextBox txtNota2;
        public System.Windows.Forms.TextBox txtNota3;
        public System.Windows.Forms.Label lblPromedio;
        public System.Windows.Forms.Label lblResultado;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRCantidad;
        private System.Windows.Forms.Label lblPromedioGeneral;
        private System.Windows.Forms.Label lblRPromedioGeneral;
    }
}

