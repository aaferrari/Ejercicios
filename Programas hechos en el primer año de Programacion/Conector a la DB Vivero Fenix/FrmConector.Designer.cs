namespace Conector_a_la_DB_Vivero_Fenix
{
    partial class FrmConector
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
            this.cmbClima = new System.Windows.Forms.ComboBox();
            this.lblClima = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbTipoPlanta = new System.Windows.Forms.ComboBox();
            this.lblTipoPlanta = new System.Windows.Forms.Label();
            this.txtCodigoPlanta = new System.Windows.Forms.TextBox();
            this.lblCodigoPlanta = new System.Windows.Forms.Label();
            this.lstMostrador = new System.Windows.Forms.ListBox();
            this.txtNombrePlanta = new System.Windows.Forms.TextBox();
            this.lblNombrePlanta = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbClima
            // 
            this.cmbClima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClima.FormattingEnabled = true;
            this.cmbClima.Items.AddRange(new object[] {
            "Seco",
            "Templado",
            "Humedo",
            "Mediterraneo"});
            this.cmbClima.Location = new System.Drawing.Point(243, 58);
            this.cmbClima.Name = "cmbClima";
            this.cmbClima.Size = new System.Drawing.Size(140, 21);
            this.cmbClima.TabIndex = 35;
            // 
            // lblClima
            // 
            this.lblClima.AutoSize = true;
            this.lblClima.Location = new System.Drawing.Point(207, 61);
            this.lblClima.Name = "lblClima";
            this.lblClima.Size = new System.Drawing.Size(35, 13);
            this.lblClima.TabIndex = 34;
            this.lblClima.Text = "Clima:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(253, 24);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar datos en la base de datos (definitivo)";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(271, 106);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(164, 23);
            this.btnBorrar.TabIndex = 30;
            this.btnBorrar.Text = "Borrar datos que se han escrito";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(49, 133);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(336, 26);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar los datos que se han escrito con los de la base de datos";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbTipoPlanta
            // 
            this.cmbTipoPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPlanta.FormattingEnabled = true;
            this.cmbTipoPlanta.Items.AddRange(new object[] {
            "COMUNES",
            "ESPECIALES",
            "EXOTICAS",
            "ARBUSTOS",
            "FLORES",
            "ARBOLES"});
            this.cmbTipoPlanta.Location = new System.Drawing.Point(105, 56);
            this.cmbTipoPlanta.Name = "cmbTipoPlanta";
            this.cmbTipoPlanta.Size = new System.Drawing.Size(94, 21);
            this.cmbTipoPlanta.TabIndex = 28;
            // 
            // lblTipoPlanta
            // 
            this.lblTipoPlanta.AutoSize = true;
            this.lblTipoPlanta.Location = new System.Drawing.Point(21, 59);
            this.lblTipoPlanta.Name = "lblTipoPlanta";
            this.lblTipoPlanta.Size = new System.Drawing.Size(78, 13);
            this.lblTipoPlanta.TabIndex = 27;
            this.lblTipoPlanta.Text = "Tipo de planta:";
            // 
            // txtCodigoPlanta
            // 
            this.txtCodigoPlanta.Location = new System.Drawing.Point(181, 34);
            this.txtCodigoPlanta.Name = "txtCodigoPlanta";
            this.txtCodigoPlanta.Size = new System.Drawing.Size(214, 20);
            this.txtCodigoPlanta.TabIndex = 26;
            // 
            // lblCodigoPlanta
            // 
            this.lblCodigoPlanta.AutoSize = true;
            this.lblCodigoPlanta.Location = new System.Drawing.Point(18, 36);
            this.lblCodigoPlanta.Name = "lblCodigoPlanta";
            this.lblCodigoPlanta.Size = new System.Drawing.Size(126, 13);
            this.lblCodigoPlanta.TabIndex = 25;
            this.lblCodigoPlanta.Text = "Identificador de la planta:";
            // 
            // lstMostrador
            // 
            this.lstMostrador.FormattingEnabled = true;
            this.lstMostrador.Location = new System.Drawing.Point(12, 168);
            this.lstMostrador.Name = "lstMostrador";
            this.lstMostrador.Size = new System.Drawing.Size(423, 251);
            this.lstMostrador.TabIndex = 23;
            this.lstMostrador.SelectedIndexChanged += new System.EventHandler(this.lstMostrador_SelectedIndexChanged);
            // 
            // txtNombrePlanta
            // 
            this.txtNombrePlanta.Location = new System.Drawing.Point(181, 12);
            this.txtNombrePlanta.Name = "txtNombrePlanta";
            this.txtNombrePlanta.Size = new System.Drawing.Size(215, 20);
            this.txtNombrePlanta.TabIndex = 22;
            // 
            // lblNombrePlanta
            // 
            this.lblNombrePlanta.AutoSize = true;
            this.lblNombrePlanta.Location = new System.Drawing.Point(19, 15);
            this.lblNombrePlanta.Name = "lblNombrePlanta";
            this.lblNombrePlanta.Size = new System.Drawing.Size(162, 13);
            this.lblNombrePlanta.TabIndex = 21;
            this.lblNombrePlanta.Text = "Descripcion general de la planta:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(75, 79);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(48, 20);
            this.txtPrecio.TabIndex = 20;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(22, 82);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 13);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio $:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(166, 80);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(48, 20);
            this.txtStock.TabIndex = 39;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(127, 83);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 38;
            this.lblStock.Text = "Stock:";
            // 
            // FrmConector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 431);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.cmbClima);
            this.Controls.Add(this.lblClima);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbTipoPlanta);
            this.Controls.Add(this.lblTipoPlanta);
            this.Controls.Add(this.txtCodigoPlanta);
            this.Controls.Add(this.lblCodigoPlanta);
            this.Controls.Add(this.lstMostrador);
            this.Controls.Add(this.txtNombrePlanta);
            this.Controls.Add(this.lblNombrePlanta);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Name = "FrmConector";
            this.Text = "Conector para plantas";
            this.Load += new System.EventHandler(this.FrmConector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClima;
        private System.Windows.Forms.Label lblClima;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbTipoPlanta;
        private System.Windows.Forms.Label lblTipoPlanta;
        private System.Windows.Forms.TextBox txtCodigoPlanta;
        private System.Windows.Forms.Label lblCodigoPlanta;
        private System.Windows.Forms.ListBox lstMostrador;
        private System.Windows.Forms.TextBox txtNombrePlanta;
        private System.Windows.Forms.Label lblNombrePlanta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
    }
}

