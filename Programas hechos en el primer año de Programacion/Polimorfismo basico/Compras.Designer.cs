namespace Polimorfismo_basico
{
    partial class Compras
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
        	this.lblCodigo = new System.Windows.Forms.Label();
        	this.txtCodigo = new System.Windows.Forms.TextBox();
        	this.lblMarca = new System.Windows.Forms.Label();
        	this.txtMarca = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblPrecio = new System.Windows.Forms.Label();
        	this.txtPrecio = new System.Windows.Forms.TextBox();
        	this.grpTipoCompra = new System.Windows.Forms.GroupBox();
        	this.rdbPaquete = new System.Windows.Forms.RadioButton();
        	this.rdbSuelto = new System.Windows.Forms.RadioButton();
        	this.lblCantidad = new System.Windows.Forms.Label();
        	this.txtCantidad = new System.Windows.Forms.TextBox();
        	this.lblMedida = new System.Windows.Forms.Label();
        	this.txtMedida = new System.Windows.Forms.TextBox();
        	this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
        	this.btnProcesar = new System.Windows.Forms.Button();
        	this.lstSuelto = new System.Windows.Forms.ListBox();
        	this.lblSuelto = new System.Windows.Forms.Label();
        	this.lblEnpaquetado = new System.Windows.Forms.Label();
        	this.lstEnpaquetados = new System.Windows.Forms.ListBox();
        	this.btnSueltos = new System.Windows.Forms.Button();
        	this.btnEnpaquetados = new System.Windows.Forms.Button();
        	this.grpTipoCompra.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// lblCodigo
        	// 
        	this.lblCodigo.AutoSize = true;
        	this.lblCodigo.Location = new System.Drawing.Point(12, 9);
        	this.lblCodigo.Name = "lblCodigo";
        	this.lblCodigo.Size = new System.Drawing.Size(49, 15);
        	this.lblCodigo.TabIndex = 0;
        	this.lblCodigo.Text = "Codigo:";
        	// 
        	// txtCodigo
        	// 
        	this.txtCodigo.Location = new System.Drawing.Point(62, 8);
        	this.txtCodigo.Name = "txtCodigo";
        	this.txtCodigo.Size = new System.Drawing.Size(177, 21);
        	this.txtCodigo.TabIndex = 1;
        	// 
        	// lblMarca
        	// 
        	this.lblMarca.AutoSize = true;
        	this.lblMarca.Location = new System.Drawing.Point(16, 32);
        	this.lblMarca.Name = "lblMarca";
        	this.lblMarca.Size = new System.Drawing.Size(48, 15);
        	this.lblMarca.TabIndex = 2;
        	this.lblMarca.Text = "Marca: ";
        	// 
        	// txtMarca
        	// 
        	this.txtMarca.Location = new System.Drawing.Point(62, 31);
        	this.txtMarca.Name = "txtMarca";
        	this.txtMarca.Size = new System.Drawing.Size(177, 21);
        	this.txtMarca.TabIndex = 3;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.AutoSize = true;
        	this.lblNombre.Location = new System.Drawing.Point(9, 54);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(55, 15);
        	this.lblNombre.TabIndex = 4;
        	this.lblNombre.Text = "Nombre:";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(62, 54);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(177, 21);
        	this.txtNombre.TabIndex = 5;
        	// 
        	// lblPrecio
        	// 
        	this.lblPrecio.AutoSize = true;
        	this.lblPrecio.Location = new System.Drawing.Point(9, 79);
        	this.lblPrecio.Name = "lblPrecio";
        	this.lblPrecio.Size = new System.Drawing.Size(55, 15);
        	this.lblPrecio.TabIndex = 6;
        	this.lblPrecio.Text = "Precio: $";
        	// 
        	// txtPrecio
        	// 
        	this.txtPrecio.Location = new System.Drawing.Point(62, 77);
        	this.txtPrecio.Name = "txtPrecio";
        	this.txtPrecio.Size = new System.Drawing.Size(177, 21);
        	this.txtPrecio.TabIndex = 7;
        	// 
        	// grpTipoCompra
        	// 
        	this.grpTipoCompra.Controls.Add(this.rdbPaquete);
        	this.grpTipoCompra.Controls.Add(this.rdbSuelto);
        	this.grpTipoCompra.Location = new System.Drawing.Point(12, 103);
        	this.grpTipoCompra.Name = "grpTipoCompra";
        	this.grpTipoCompra.Size = new System.Drawing.Size(228, 40);
        	this.grpTipoCompra.TabIndex = 8;
        	this.grpTipoCompra.TabStop = false;
        	this.grpTipoCompra.Text = "Eliga el tippo de compra a realizar";
        	// 
        	// rdbPaquete
        	// 
        	this.rdbPaquete.AutoSize = true;
        	this.rdbPaquete.Location = new System.Drawing.Point(128, 16);
        	this.rdbPaquete.Name = "rdbPaquete";
        	this.rdbPaquete.Size = new System.Drawing.Size(99, 19);
        	this.rdbPaquete.TabIndex = 1;
        	this.rdbPaquete.TabStop = true;
        	this.rdbPaquete.Text = "Enpaquetado";
        	this.rdbPaquete.UseVisualStyleBackColor = true;
        	// 
        	// rdbSuelto
        	// 
        	this.rdbSuelto.AutoSize = true;
        	this.rdbSuelto.Location = new System.Drawing.Point(9, 15);
        	this.rdbSuelto.Name = "rdbSuelto";
        	this.rdbSuelto.Size = new System.Drawing.Size(110, 19);
        	this.rdbSuelto.TabIndex = 0;
        	this.rdbSuelto.TabStop = true;
        	this.rdbSuelto.Text = "Producto suelto";
        	this.rdbSuelto.UseVisualStyleBackColor = true;
        	// 
        	// lblCantidad
        	// 
        	this.lblCantidad.AutoSize = true;
        	this.lblCantidad.Location = new System.Drawing.Point(5, 152);
        	this.lblCantidad.Name = "lblCantidad";
        	this.lblCantidad.Size = new System.Drawing.Size(59, 15);
        	this.lblCantidad.TabIndex = 9;
        	this.lblCantidad.Text = "Cantidad:";
        	// 
        	// txtCantidad
        	// 
        	this.txtCantidad.Location = new System.Drawing.Point(62, 150);
        	this.txtCantidad.Name = "txtCantidad";
        	this.txtCantidad.Size = new System.Drawing.Size(177, 21);
        	this.txtCantidad.TabIndex = 10;
        	// 
        	// lblMedida
        	// 
        	this.lblMedida.AutoSize = true;
        	this.lblMedida.Location = new System.Drawing.Point(9, 174);
        	this.lblMedida.Name = "lblMedida";
        	this.lblMedida.Size = new System.Drawing.Size(52, 15);
        	this.lblMedida.TabIndex = 11;
        	this.lblMedida.Text = "Medida:";
        	// 
        	// txtMedida
        	// 
        	this.txtMedida.Location = new System.Drawing.Point(62, 174);
        	this.txtMedida.Name = "txtMedida";
        	this.txtMedida.Size = new System.Drawing.Size(88, 21);
        	this.txtMedida.TabIndex = 12;
        	// 
        	// cmbUnidadMedida
        	// 
        	this.cmbUnidadMedida.FormattingEnabled = true;
        	this.cmbUnidadMedida.Location = new System.Drawing.Point(153, 174);
        	this.cmbUnidadMedida.Name = "cmbUnidadMedida";
        	this.cmbUnidadMedida.Size = new System.Drawing.Size(87, 23);
        	this.cmbUnidadMedida.TabIndex = 13;
        	// 
        	// btnProcesar
        	// 
        	this.btnProcesar.Location = new System.Drawing.Point(62, 203);
        	this.btnProcesar.Name = "btnProcesar";
        	this.btnProcesar.Size = new System.Drawing.Size(138, 42);
        	this.btnProcesar.TabIndex = 14;
        	this.btnProcesar.Text = "Almacenar datos para mostrarlos mas tarde";
        	this.btnProcesar.UseVisualStyleBackColor = true;
        	this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
        	// 
        	// lstSuelto
        	// 
        	this.lstSuelto.FormattingEnabled = true;
        	this.lstSuelto.ItemHeight = 15;
        	this.lstSuelto.Location = new System.Drawing.Point(248, 40);
        	this.lstSuelto.Name = "lstSuelto";
        	this.lstSuelto.Size = new System.Drawing.Size(224, 79);
        	this.lstSuelto.TabIndex = 15;
        	// 
        	// lblSuelto
        	// 
        	this.lblSuelto.AutoSize = true;
        	this.lblSuelto.Location = new System.Drawing.Point(266, 6);
        	this.lblSuelto.Name = "lblSuelto";
        	this.lblSuelto.Size = new System.Drawing.Size(187, 30);
        	this.lblSuelto.TabIndex = 16;
        	this.lblSuelto.Text = "Aqui se mostraran los productos\r\n que se hayan comprado sueltos:";
        	// 
        	// lblEnpaquetado
        	// 
        	this.lblEnpaquetado.AutoSize = true;
        	this.lblEnpaquetado.Location = new System.Drawing.Point(257, 155);
        	this.lblEnpaquetado.Name = "lblEnpaquetado";
        	this.lblEnpaquetado.Size = new System.Drawing.Size(216, 30);
        	this.lblEnpaquetado.TabIndex = 18;
        	this.lblEnpaquetado.Text = "Y aqui se mostraran los productos que\r\n se hayan comprado en paquetes:";
        	// 
        	// lstEnpaquetados
        	// 
        	this.lstEnpaquetados.FormattingEnabled = true;
        	this.lstEnpaquetados.ItemHeight = 15;
        	this.lstEnpaquetados.Location = new System.Drawing.Point(251, 189);
        	this.lstEnpaquetados.Name = "lstEnpaquetados";
        	this.lstEnpaquetados.Size = new System.Drawing.Size(224, 79);
        	this.lstEnpaquetados.TabIndex = 17;
        	// 
        	// btnSueltos
        	// 
        	this.btnSueltos.Location = new System.Drawing.Point(278, 122);
        	this.btnSueltos.Name = "btnSueltos";
        	this.btnSueltos.Size = new System.Drawing.Size(162, 25);
        	this.btnSueltos.TabIndex = 19;
        	this.btnSueltos.Text = "Mostrar productos sueltos";
        	this.btnSueltos.UseVisualStyleBackColor = true;
        	this.btnSueltos.Click += new System.EventHandler(this.BtnSueltosClick);
        	// 
        	// btnEnpaquetados
        	// 
        	this.btnEnpaquetados.Location = new System.Drawing.Point(264, 271);
        	this.btnEnpaquetados.Name = "btnEnpaquetados";
        	this.btnEnpaquetados.Size = new System.Drawing.Size(203, 25);
        	this.btnEnpaquetados.TabIndex = 20;
        	this.btnEnpaquetados.Text = "Mostrar productos enpaquetados";
        	this.btnEnpaquetados.UseVisualStyleBackColor = true;
        	this.btnEnpaquetados.Click += new System.EventHandler(this.BtnEnpaquetadosClick);
        	// 
        	// Compras
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(484, 302);
        	this.Controls.Add(this.btnEnpaquetados);
        	this.Controls.Add(this.btnSueltos);
        	this.Controls.Add(this.lblEnpaquetado);
        	this.Controls.Add(this.lstEnpaquetados);
        	this.Controls.Add(this.lblSuelto);
        	this.Controls.Add(this.lstSuelto);
        	this.Controls.Add(this.btnProcesar);
        	this.Controls.Add(this.cmbUnidadMedida);
        	this.Controls.Add(this.txtMedida);
        	this.Controls.Add(this.lblMedida);
        	this.Controls.Add(this.txtCantidad);
        	this.Controls.Add(this.lblCantidad);
        	this.Controls.Add(this.grpTipoCompra);
        	this.Controls.Add(this.txtPrecio);
        	this.Controls.Add(this.lblPrecio);
        	this.Controls.Add(this.txtNombre);
        	this.Controls.Add(this.lblNombre);
        	this.Controls.Add(this.txtMarca);
        	this.Controls.Add(this.lblMarca);
        	this.Controls.Add(this.txtCodigo);
        	this.Controls.Add(this.lblCodigo);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Name = "Compras";
        	this.Text = "Compras y registros";
        	this.grpTipoCompra.ResumeLayout(false);
        	this.grpTipoCompra.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button btnEnpaquetados;
        private System.Windows.Forms.Button btnSueltos;

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox grpTipoCompra;
        private System.Windows.Forms.RadioButton rdbPaquete;
        private System.Windows.Forms.RadioButton rdbSuelto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ListBox lstSuelto;
        private System.Windows.Forms.Label lblSuelto;
        private System.Windows.Forms.Label lblEnpaquetado;
        private System.Windows.Forms.ListBox lstEnpaquetados;
    }
}

