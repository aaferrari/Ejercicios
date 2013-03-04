namespace Matriz_con_productos
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardarMatriz = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstColector = new System.Windows.Forms.ListBox();
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.btnBuscaProductos = new System.Windows.Forms.Button();
            this.btnLimpiador = new System.Windows.Forms.Button();
            this.btnSumarPorCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(53, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 26);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre\rdel producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(8, 63);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(60, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Elija el tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Alimento",
            "Limpieza",
            "Bazar"});
            this.cmbTipo.Location = new System.Drawing.Point(67, 60);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(185, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(8, 88);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio: $";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(58, 85);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(70, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(134, 89);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(184, 87);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // btnGuardarMatriz
            // 
            this.btnGuardarMatriz.Location = new System.Drawing.Point(15, 112);
            this.btnGuardarMatriz.Name = "btnGuardarMatriz";
            this.btnGuardarMatriz.Size = new System.Drawing.Size(104, 35);
            this.btnGuardarMatriz.TabIndex = 10;
            this.btnGuardarMatriz.Text = "Guardar estos datos en la matriz";
            this.btnGuardarMatriz.UseVisualStyleBackColor = true;
            this.btnGuardarMatriz.Click += new System.EventHandler(this.btnGuardarMatriz_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(125, 113);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(146, 47);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Mostrar datos y totales de sucursales en la lista de abajo";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lstColector
            // 
            this.lstColector.FormattingEnabled = true;
            this.lstColector.Location = new System.Drawing.Point(17, 243);
            this.lstColector.Name = "lstColector";
            this.lstColector.Size = new System.Drawing.Size(302, 69);
            this.lstColector.TabIndex = 12;
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(19, 150);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(94, 40);
            this.btnListarProductos.TabIndex = 13;
            this.btnListarProductos.Text = "Listar los totales de los productos";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // btnBuscaProductos
            // 
            this.btnBuscaProductos.Location = new System.Drawing.Point(19, 191);
            this.btnBuscaProductos.Name = "btnBuscaProductos";
            this.btnBuscaProductos.Size = new System.Drawing.Size(276, 22);
            this.btnBuscaProductos.TabIndex = 14;
            this.btnBuscaProductos.Text = "Buscar un tipo de producto que esta en el Combobox";
            this.btnBuscaProductos.UseVisualStyleBackColor = true;
            this.btnBuscaProductos.Click += new System.EventHandler(this.btnBuscaProductos_Click);
            // 
            // btnLimpiador
            // 
            this.btnLimpiador.Location = new System.Drawing.Point(125, 164);
            this.btnLimpiador.Name = "btnLimpiador";
            this.btnLimpiador.Size = new System.Drawing.Size(138, 22);
            this.btnLimpiador.TabIndex = 15;
            this.btnLimpiador.Text = "Limpiar la matriz y la lista";
            this.btnLimpiador.UseVisualStyleBackColor = true;
            this.btnLimpiador.Click += new System.EventHandler(this.btnLimpiador_Click);
            // 
            // btnSumarPorCategoria
            // 
            this.btnSumarPorCategoria.Location = new System.Drawing.Point(26, 216);
            this.btnSumarPorCategoria.Name = "btnSumarPorCategoria";
            this.btnSumarPorCategoria.Size = new System.Drawing.Size(201, 23);
            this.btnSumarPorCategoria.TabIndex = 16;
            this.btnSumarPorCategoria.Text = "Sumar los articulos por categoria";
            this.btnSumarPorCategoria.UseVisualStyleBackColor = true;
            this.btnSumarPorCategoria.Click += new System.EventHandler(this.btnSumarPorCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 322);
            this.Controls.Add(this.btnSumarPorCategoria);
            this.Controls.Add(this.btnLimpiador);
            this.Controls.Add(this.btnBuscaProductos);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.lstColector);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGuardarMatriz);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Catalogo matricial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardarMatriz;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstColector;
        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.Button btnBuscaProductos;
        private System.Windows.Forms.Button btnLimpiador;
        private System.Windows.Forms.Button btnSumarPorCategoria;
    }
}

