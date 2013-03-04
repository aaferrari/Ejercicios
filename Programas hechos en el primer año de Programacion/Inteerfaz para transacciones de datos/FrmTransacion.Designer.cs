namespace Inteerfaz_para_transacciones_de_datos
{
    partial class FrmTransacion
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
        	this.grpCliente = new System.Windows.Forms.GroupBox();
        	this.txtDireccion = new System.Windows.Forms.TextBox();
        	this.lblDireccion = new System.Windows.Forms.Label();
        	this.cmbCliente = new System.Windows.Forms.ComboBox();
        	this.lblNombreCliente = new System.Windows.Forms.Label();
        	this.grpArticulo = new System.Windows.Forms.GroupBox();
        	this.btnResultado = new System.Windows.Forms.Button();
        	this.lblAsterisco = new System.Windows.Forms.Label();
        	this.txttotal = new System.Windows.Forms.TextBox();
        	this.lbltotal = new System.Windows.Forms.Label();
        	this.txtCantidad = new System.Windows.Forms.TextBox();
        	this.lblCantidad = new System.Windows.Forms.Label();
        	this.txtPrecio = new System.Windows.Forms.TextBox();
        	this.lblPrecio = new System.Windows.Forms.Label();
        	this.cmbArticulo = new System.Windows.Forms.ComboBox();
        	this.lblNombreArticulo = new System.Windows.Forms.Label();
        	this.lblSucursal = new System.Windows.Forms.Label();
        	this.txtSucursal = new System.Windows.Forms.TextBox();
        	this.txtPedido = new System.Windows.Forms.TextBox();
        	this.lblPedido = new System.Windows.Forms.Label();
        	this.DTPFecha = new System.Windows.Forms.DateTimePicker();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.ClmArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.ClmImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.btnNuevo = new System.Windows.Forms.Button();
        	this.btnSalir = new System.Windows.Forms.Button();
        	this.btnCancelar = new System.Windows.Forms.Button();
        	this.btnGuardar = new System.Windows.Forms.Button();
        	this.lblSubtotal = new System.Windows.Forms.Label();
        	this.txtSubtotal = new System.Windows.Forms.TextBox();
        	this.txtDescuento = new System.Windows.Forms.TextBox();
        	this.lblDescuento = new System.Windows.Forms.Label();
        	this.txtTotalDef = new System.Windows.Forms.TextBox();
        	this.lblTotalDef = new System.Windows.Forms.Label();
        	this.btnAgregar = new System.Windows.Forms.Button();
        	this.grpCliente.SuspendLayout();
        	this.grpArticulo.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// grpCliente
        	// 
        	this.grpCliente.Controls.Add(this.txtDireccion);
        	this.grpCliente.Controls.Add(this.lblDireccion);
        	this.grpCliente.Controls.Add(this.cmbCliente);
        	this.grpCliente.Controls.Add(this.lblNombreCliente);
        	this.grpCliente.Location = new System.Drawing.Point(16, 42);
        	this.grpCliente.Name = "grpCliente";
        	this.grpCliente.Size = new System.Drawing.Size(261, 71);
        	this.grpCliente.TabIndex = 0;
        	this.grpCliente.TabStop = false;
        	this.grpCliente.Text = "Datos del cliente";
        	// 
        	// txtDireccion
        	// 
        	this.txtDireccion.Location = new System.Drawing.Point(59, 38);
        	this.txtDireccion.Name = "txtDireccion";
        	this.txtDireccion.Size = new System.Drawing.Size(196, 20);
        	this.txtDireccion.TabIndex = 3;
        	// 
        	// lblDireccion
        	// 
        	this.lblDireccion.AutoSize = true;
        	this.lblDireccion.Location = new System.Drawing.Point(6, 38);
        	this.lblDireccion.Name = "lblDireccion";
        	this.lblDireccion.Size = new System.Drawing.Size(55, 13);
        	this.lblDireccion.TabIndex = 2;
        	this.lblDireccion.Text = "Direccion:";
        	// 
        	// cmbCliente
        	// 
        	this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbCliente.FormattingEnabled = true;
        	this.cmbCliente.Location = new System.Drawing.Point(57, 14);
        	this.cmbCliente.Name = "cmbCliente";
        	this.cmbCliente.Size = new System.Drawing.Size(198, 21);
        	this.cmbCliente.TabIndex = 1;
        	this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
        	// 
        	// lblNombreCliente
        	// 
        	this.lblNombreCliente.AutoSize = true;
        	this.lblNombreCliente.Location = new System.Drawing.Point(8, 17);
        	this.lblNombreCliente.Name = "lblNombreCliente";
        	this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
        	this.lblNombreCliente.TabIndex = 0;
        	this.lblNombreCliente.Text = "Nombre:";
        	// 
        	// grpArticulo
        	// 
        	this.grpArticulo.Controls.Add(this.btnResultado);
        	this.grpArticulo.Controls.Add(this.lblAsterisco);
        	this.grpArticulo.Controls.Add(this.txttotal);
        	this.grpArticulo.Controls.Add(this.lbltotal);
        	this.grpArticulo.Controls.Add(this.txtCantidad);
        	this.grpArticulo.Controls.Add(this.lblCantidad);
        	this.grpArticulo.Controls.Add(this.txtPrecio);
        	this.grpArticulo.Controls.Add(this.lblPrecio);
        	this.grpArticulo.Controls.Add(this.cmbArticulo);
        	this.grpArticulo.Controls.Add(this.lblNombreArticulo);
        	this.grpArticulo.Location = new System.Drawing.Point(285, 42);
        	this.grpArticulo.Name = "grpArticulo";
        	this.grpArticulo.Size = new System.Drawing.Size(228, 86);
        	this.grpArticulo.TabIndex = 1;
        	this.grpArticulo.TabStop = false;
        	this.grpArticulo.Text = "Datos del articulo";
        	// 
        	// btnResultado
        	// 
        	this.btnResultado.Location = new System.Drawing.Point(130, 56);
        	this.btnResultado.Name = "btnResultado";
        	this.btnResultado.Size = new System.Drawing.Size(17, 21);
        	this.btnResultado.TabIndex = 9;
        	this.btnResultado.Text = "=";
        	this.btnResultado.UseVisualStyleBackColor = true;
        	this.btnResultado.Click += new System.EventHandler(this.BtnResultadoClick);
        	// 
        	// lblAsterisco
        	// 
        	this.lblAsterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblAsterisco.Location = new System.Drawing.Point(64, 59);
        	this.lblAsterisco.Name = "lblAsterisco";
        	this.lblAsterisco.Size = new System.Drawing.Size(10, 10);
        	this.lblAsterisco.TabIndex = 8;
        	this.lblAsterisco.Text = "*";
        	// 
        	// txttotal
        	// 
        	this.txttotal.Location = new System.Drawing.Point(148, 57);
        	this.txttotal.Name = "txttotal";
        	this.txttotal.Size = new System.Drawing.Size(71, 20);
        	this.txttotal.TabIndex = 7;
        	// 
        	// lbltotal
        	// 
        	this.lbltotal.AutoSize = true;
        	this.lbltotal.Location = new System.Drawing.Point(146, 44);
        	this.lbltotal.Name = "lbltotal";
        	this.lbltotal.Size = new System.Drawing.Size(77, 13);
        	this.lbltotal.TabIndex = 6;
        	this.lbltotal.Text = "Total o importe";
        	// 
        	// txtCantidad
        	// 
        	this.txtCantidad.Location = new System.Drawing.Point(77, 56);
        	this.txtCantidad.Name = "txtCantidad";
        	this.txtCantidad.Size = new System.Drawing.Size(51, 20);
        	this.txtCantidad.TabIndex = 5;
        	this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
        	// 
        	// lblCantidad
        	// 
        	this.lblCantidad.AutoSize = true;
        	this.lblCantidad.Location = new System.Drawing.Point(76, 44);
        	this.lblCantidad.Name = "lblCantidad";
        	this.lblCantidad.Size = new System.Drawing.Size(49, 13);
        	this.lblCantidad.TabIndex = 4;
        	this.lblCantidad.Text = "Cantidad";
        	// 
        	// txtPrecio
        	// 
        	this.txtPrecio.Location = new System.Drawing.Point(23, 55);
        	this.txtPrecio.Name = "txtPrecio";
        	this.txtPrecio.Size = new System.Drawing.Size(40, 20);
        	this.txtPrecio.TabIndex = 3;
        	// 
        	// lblPrecio
        	// 
        	this.lblPrecio.AutoSize = true;
        	this.lblPrecio.Location = new System.Drawing.Point(11, 42);
        	this.lblPrecio.Name = "lblPrecio";
        	this.lblPrecio.Size = new System.Drawing.Size(52, 26);
        	this.lblPrecio.TabIndex = 2;
        	this.lblPrecio.Text = "     Precio\r\n$";
        	// 
        	// cmbArticulo
        	// 
        	this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbArticulo.FormattingEnabled = true;
        	this.cmbArticulo.Location = new System.Drawing.Point(52, 16);
        	this.cmbArticulo.Name = "cmbArticulo";
        	this.cmbArticulo.Size = new System.Drawing.Size(171, 21);
        	this.cmbArticulo.TabIndex = 1;
        	this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.CmbArticuloSelectedIndexChanged);
        	// 
        	// lblNombreArticulo
        	// 
        	this.lblNombreArticulo.AutoSize = true;
        	this.lblNombreArticulo.Location = new System.Drawing.Point(4, 18);
        	this.lblNombreArticulo.Name = "lblNombreArticulo";
        	this.lblNombreArticulo.Size = new System.Drawing.Size(47, 13);
        	this.lblNombreArticulo.TabIndex = 0;
        	this.lblNombreArticulo.Text = "Nombre:";
        	// 
        	// lblSucursal
        	// 
        	this.lblSucursal.AutoSize = true;
        	this.lblSucursal.Location = new System.Drawing.Point(17, 11);
        	this.lblSucursal.Name = "lblSucursal";
        	this.lblSucursal.Size = new System.Drawing.Size(51, 13);
        	this.lblSucursal.TabIndex = 2;
        	this.lblSucursal.Text = "Sucursal:";
        	// 
        	// txtSucursal
        	// 
        	this.txtSucursal.Location = new System.Drawing.Point(68, 8);
        	this.txtSucursal.Name = "txtSucursal";
        	this.txtSucursal.Size = new System.Drawing.Size(85, 20);
        	this.txtSucursal.TabIndex = 3;
        	// 
        	// txtPedido
        	// 
        	this.txtPedido.Location = new System.Drawing.Point(217, 8);
        	this.txtPedido.Name = "txtPedido";
        	this.txtPedido.Size = new System.Drawing.Size(85, 20);
        	this.txtPedido.TabIndex = 5;
        	// 
        	// lblPedido
        	// 
        	this.lblPedido.AutoSize = true;
        	this.lblPedido.Location = new System.Drawing.Point(161, 11);
        	this.lblPedido.Name = "lblPedido";
        	this.lblPedido.Size = new System.Drawing.Size(57, 13);
        	this.lblPedido.TabIndex = 4;
        	this.lblPedido.Text = "N° pedido:";
        	// 
        	// DTPFecha
        	// 
        	this.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        	this.DTPFecha.Location = new System.Drawing.Point(325, 9);
        	this.DTPFecha.Name = "DTPFecha";
        	this.DTPFecha.Size = new System.Drawing.Size(93, 20);
        	this.DTPFecha.TabIndex = 6;
        	this.DTPFecha.Value = new System.DateTime(2009, 10, 31, 0, 0, 0, 0);
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        	        	        	this.ClmArticulo,
        	        	        	this.ClmCantidad,
        	        	        	this.ClmImporte});
        	this.dataGridView1.Location = new System.Drawing.Point(16, 138);
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.ReadOnly = true;
        	this.dataGridView1.Size = new System.Drawing.Size(484, 88);
        	this.dataGridView1.TabIndex = 7;
        	// 
        	// ClmArticulo
        	// 
        	this.ClmArticulo.HeaderText = "Articulo";
        	this.ClmArticulo.Name = "ClmArticulo";
        	this.ClmArticulo.ReadOnly = true;
        	// 
        	// ClmCantidad
        	// 
        	this.ClmCantidad.HeaderText = "Cantidad";
        	this.ClmCantidad.Name = "ClmCantidad";
        	this.ClmCantidad.ReadOnly = true;
        	// 
        	// ClmImporte
        	// 
        	this.ClmImporte.HeaderText = "Importe";
        	this.ClmImporte.Name = "ClmImporte";
        	this.ClmImporte.ReadOnly = true;
        	// 
        	// btnNuevo
        	// 
        	this.btnNuevo.Location = new System.Drawing.Point(123, 260);
        	this.btnNuevo.Name = "btnNuevo";
        	this.btnNuevo.Size = new System.Drawing.Size(57, 26);
        	this.btnNuevo.TabIndex = 8;
        	this.btnNuevo.Text = "Nuevo";
        	this.btnNuevo.UseVisualStyleBackColor = true;
        	this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
        	// 
        	// btnSalir
        	// 
        	this.btnSalir.Location = new System.Drawing.Point(199, 260);
        	this.btnSalir.Name = "btnSalir";
        	this.btnSalir.Size = new System.Drawing.Size(57, 26);
        	this.btnSalir.TabIndex = 9;
        	this.btnSalir.Text = "Salir";
        	this.btnSalir.UseVisualStyleBackColor = true;
        	// 
        	// btnCancelar
        	// 
        	this.btnCancelar.Location = new System.Drawing.Point(199, 228);
        	this.btnCancelar.Name = "btnCancelar";
        	this.btnCancelar.Size = new System.Drawing.Size(57, 26);
        	this.btnCancelar.TabIndex = 11;
        	this.btnCancelar.Text = "Cancelar";
        	this.btnCancelar.UseVisualStyleBackColor = true;
        	// 
        	// btnGuardar
        	// 
        	this.btnGuardar.Location = new System.Drawing.Point(123, 228);
        	this.btnGuardar.Name = "btnGuardar";
        	this.btnGuardar.Size = new System.Drawing.Size(57, 26);
        	this.btnGuardar.TabIndex = 10;
        	this.btnGuardar.Text = "Guardar";
        	this.btnGuardar.UseVisualStyleBackColor = true;
        	this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
        	// 
        	// lblSubtotal
        	// 
        	this.lblSubtotal.AutoSize = true;
        	this.lblSubtotal.Location = new System.Drawing.Point(270, 229);
        	this.lblSubtotal.Name = "lblSubtotal";
        	this.lblSubtotal.Size = new System.Drawing.Size(58, 13);
        	this.lblSubtotal.TabIndex = 12;
        	this.lblSubtotal.Text = "Subtotal: $";
        	// 
        	// txtSubtotal
        	// 
        	this.txtSubtotal.Location = new System.Drawing.Point(329, 227);
        	this.txtSubtotal.Name = "txtSubtotal";
        	this.txtSubtotal.Size = new System.Drawing.Size(62, 20);
        	this.txtSubtotal.TabIndex = 13;
        	this.txtSubtotal.Text = "0";
        	// 
        	// txtDescuento
        	// 
        	this.txtDescuento.Location = new System.Drawing.Point(342, 253);
        	this.txtDescuento.Name = "txtDescuento";
        	this.txtDescuento.Size = new System.Drawing.Size(49, 20);
        	this.txtDescuento.TabIndex = 15;
        	this.txtDescuento.Text = "0";
        	// 
        	// lblDescuento
        	// 
        	this.lblDescuento.AutoSize = true;
        	this.lblDescuento.Location = new System.Drawing.Point(270, 255);
        	this.lblDescuento.Name = "lblDescuento";
        	this.lblDescuento.Size = new System.Drawing.Size(71, 13);
        	this.lblDescuento.TabIndex = 14;
        	this.lblDescuento.Text = "Descuento: $";
        	// 
        	// txtTotalDef
        	// 
        	this.txtTotalDef.Location = new System.Drawing.Point(329, 279);
        	this.txtTotalDef.Name = "txtTotalDef";
        	this.txtTotalDef.Size = new System.Drawing.Size(62, 20);
        	this.txtTotalDef.TabIndex = 17;
        	this.txtTotalDef.Text = "0";
        	// 
        	// lblTotalDef
        	// 
        	this.lblTotalDef.AutoSize = true;
        	this.lblTotalDef.Location = new System.Drawing.Point(285, 281);
        	this.lblTotalDef.Name = "lblTotalDef";
        	this.lblTotalDef.Size = new System.Drawing.Size(43, 13);
        	this.lblTotalDef.TabIndex = 16;
        	this.lblTotalDef.Text = "Total: $";
        	// 
        	// btnAgregar
        	// 
        	this.btnAgregar.Location = new System.Drawing.Point(89, 115);
        	this.btnAgregar.Name = "btnAgregar";
        	this.btnAgregar.Size = new System.Drawing.Size(155, 22);
        	this.btnAgregar.TabIndex = 18;
        	this.btnAgregar.Text = "Mostrar datos en la tabla";
        	this.btnAgregar.UseVisualStyleBackColor = true;
        	this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
        	// 
        	// FrmTransacion
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(520, 308);
        	this.Controls.Add(this.btnAgregar);
        	this.Controls.Add(this.txtTotalDef);
        	this.Controls.Add(this.lblTotalDef);
        	this.Controls.Add(this.txtDescuento);
        	this.Controls.Add(this.lblDescuento);
        	this.Controls.Add(this.txtSubtotal);
        	this.Controls.Add(this.lblSubtotal);
        	this.Controls.Add(this.btnCancelar);
        	this.Controls.Add(this.btnGuardar);
        	this.Controls.Add(this.btnSalir);
        	this.Controls.Add(this.btnNuevo);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.DTPFecha);
        	this.Controls.Add(this.txtPedido);
        	this.Controls.Add(this.lblPedido);
        	this.Controls.Add(this.txtSucursal);
        	this.Controls.Add(this.lblSucursal);
        	this.Controls.Add(this.grpArticulo);
        	this.Controls.Add(this.grpCliente);
        	this.Name = "FrmTransacion";
        	this.Text = "Pedidos de no se donde";
        	this.Load += new System.EventHandler(this.FrmTransacion_Load);
        	this.grpCliente.ResumeLayout(false);
        	this.grpCliente.PerformLayout();
        	this.grpArticulo.ResumeLayout(false);
        	this.grpArticulo.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmArticulo;
        private System.Windows.Forms.Label lblAsterisco;
        private System.Windows.Forms.Button btnResultado;

        #endregion

        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox grpArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtTotalDef;
        private System.Windows.Forms.Label lblTotalDef;
        private System.Windows.Forms.Button btnAgregar;
    }
}

