namespace Prueba_en_ComboBox
{
    partial class frmPruebaComboBox
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
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.btnCargar = new System.Windows.Forms.Button();
        	this.btnCargaManual = new System.Windows.Forms.Button();
        	this.txtIngreso = new System.Windows.Forms.TextBox();
        	this.btnBuscar = new System.Windows.Forms.Button();
        	this.btnCargarPrincipio = new System.Windows.Forms.Button();
        	this.btnBorrarDeCombobox = new System.Windows.Forms.Button();
        	this.btnBorarSeleccionado = new System.Windows.Forms.Button();
        	this.lstListaNumeros = new System.Windows.Forms.ListBox();
        	this.btnCargarLista = new System.Windows.Forms.Button();
        	this.btnCargarLista50a60 = new System.Windows.Forms.Button();
        	this.btnPasarPares = new System.Windows.Forms.Button();
        	this.lstListaNumeros2 = new System.Windows.Forms.ListBox();
        	this.btnInicializar = new System.Windows.Forms.Button();
        	this.lstNumerosVectoriales = new System.Windows.Forms.ListBox();
        	this.txtIngresoNumero = new System.Windows.Forms.TextBox();
        	this.btnCargarAMatriz = new System.Windows.Forms.Button();
        	this.btnListarMatriz = new System.Windows.Forms.Button();
        	this.lstNumerosVectorialesConIVA = new System.Windows.Forms.ListBox();
        	this.btnCargarconIVA = new System.Windows.Forms.Button();
        	this.grpMatrizesBasicas = new System.Windows.Forms.GroupBox();
        	this.grpListboxs = new System.Windows.Forms.GroupBox();
        	this.grpComboboxs = new System.Windows.Forms.GroupBox();
        	this.grpMatrizesBasicas.SuspendLayout();
        	this.grpListboxs.SuspendLayout();
        	this.grpComboboxs.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Location = new System.Drawing.Point(6, 19);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(160, 21);
        	this.comboBox1.TabIndex = 0;
        	// 
        	// btnCargar
        	// 
        	this.btnCargar.Location = new System.Drawing.Point(172, 18);
        	this.btnCargar.Name = "btnCargar";
        	this.btnCargar.Size = new System.Drawing.Size(48, 21);
        	this.btnCargar.TabIndex = 1;
        	this.btnCargar.Text = "Cargar";
        	this.btnCargar.UseVisualStyleBackColor = true;
        	this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
        	// 
        	// btnCargaManual
        	// 
        	this.btnCargaManual.Location = new System.Drawing.Point(9, 99);
        	this.btnCargaManual.Name = "btnCargaManual";
        	this.btnCargaManual.Size = new System.Drawing.Size(81, 21);
        	this.btnCargaManual.TabIndex = 2;
        	this.btnCargaManual.Text = "Carga manual";
        	this.btnCargaManual.UseVisualStyleBackColor = true;
        	this.btnCargaManual.Click += new System.EventHandler(this.btnCargaManual_Click);
        	// 
        	// txtIngreso
        	// 
        	this.txtIngreso.Location = new System.Drawing.Point(6, 73);
        	this.txtIngreso.Name = "txtIngreso";
        	this.txtIngreso.Size = new System.Drawing.Size(147, 20);
        	this.txtIngreso.TabIndex = 3;
        	// 
        	// btnBuscar
        	// 
        	this.btnBuscar.Location = new System.Drawing.Point(95, 99);
        	this.btnBuscar.Name = "btnBuscar";
        	this.btnBuscar.Size = new System.Drawing.Size(49, 21);
        	this.btnBuscar.TabIndex = 4;
        	this.btnBuscar.Text = "Buscar";
        	this.btnBuscar.UseVisualStyleBackColor = true;
        	this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
        	// 
        	// btnCargarPrincipio
        	// 
        	this.btnCargarPrincipio.Location = new System.Drawing.Point(157, 69);
        	this.btnCargarPrincipio.Name = "btnCargarPrincipio";
        	this.btnCargarPrincipio.Size = new System.Drawing.Size(74, 34);
        	this.btnCargarPrincipio.TabIndex = 5;
        	this.btnCargarPrincipio.Text = "Cargar al \r\nprincipo";
        	this.btnCargarPrincipio.UseVisualStyleBackColor = true;
        	this.btnCargarPrincipio.Click += new System.EventHandler(this.btnCargarPrincipio_Click);
        	// 
        	// btnBorrarDeCombobox
        	// 
        	this.btnBorrarDeCombobox.Location = new System.Drawing.Point(28, 121);
        	this.btnBorrarDeCombobox.Name = "btnBorrarDeCombobox";
        	this.btnBorrarDeCombobox.Size = new System.Drawing.Size(103, 27);
        	this.btnBorrarDeCombobox.TabIndex = 6;
        	this.btnBorrarDeCombobox.Text = "Borrar del Combo";
        	this.btnBorrarDeCombobox.UseVisualStyleBackColor = true;
        	this.btnBorrarDeCombobox.Click += new System.EventHandler(this.btnBorrarDeCombobox_Click);
        	// 
        	// btnBorarSeleccionado
        	// 
        	this.btnBorarSeleccionado.Location = new System.Drawing.Point(6, 40);
        	this.btnBorarSeleccionado.Name = "btnBorarSeleccionado";
        	this.btnBorarSeleccionado.Size = new System.Drawing.Size(135, 21);
        	this.btnBorarSeleccionado.TabIndex = 7;
        	this.btnBorarSeleccionado.Text = "Borrar item seleccionado";
        	this.btnBorarSeleccionado.UseVisualStyleBackColor = true;
        	this.btnBorarSeleccionado.Click += new System.EventHandler(this.btnBorarSeleccionado_Click);
        	// 
        	// lstListaNumeros
        	// 
        	this.lstListaNumeros.FormattingEnabled = true;
        	this.lstListaNumeros.Location = new System.Drawing.Point(6, 25);
        	this.lstListaNumeros.Name = "lstListaNumeros";
        	this.lstListaNumeros.Size = new System.Drawing.Size(68, 134);
        	this.lstListaNumeros.TabIndex = 8;
        	// 
        	// btnCargarLista
        	// 
        	this.btnCargarLista.Location = new System.Drawing.Point(80, 23);
        	this.btnCargarLista.Name = "btnCargarLista";
        	this.btnCargarLista.Size = new System.Drawing.Size(69, 21);
        	this.btnCargarLista.TabIndex = 9;
        	this.btnCargarLista.Text = "Cargar lista";
        	this.btnCargarLista.UseVisualStyleBackColor = true;
        	this.btnCargarLista.Click += new System.EventHandler(this.btnCargarLista_Click);
        	// 
        	// btnCargarLista50a60
        	// 
        	this.btnCargarLista50a60.Location = new System.Drawing.Point(80, 65);
        	this.btnCargarLista50a60.Name = "btnCargarLista50a60";
        	this.btnCargarLista50a60.Size = new System.Drawing.Size(69, 39);
        	this.btnCargarLista50a60.TabIndex = 10;
        	this.btnCargarLista50a60.Text = "Cargar lista (50 a 60)";
        	this.btnCargarLista50a60.UseVisualStyleBackColor = true;
        	this.btnCargarLista50a60.Click += new System.EventHandler(this.btnCargarLista50a60_Click);
        	// 
        	// btnPasarPares
        	// 
        	this.btnPasarPares.Location = new System.Drawing.Point(80, 110);
        	this.btnPasarPares.Name = "btnPasarPares";
        	this.btnPasarPares.Size = new System.Drawing.Size(69, 52);
        	this.btnPasarPares.TabIndex = 11;
        	this.btnPasarPares.Text = "Pasar pares a la otra lista";
        	this.btnPasarPares.UseVisualStyleBackColor = true;
        	this.btnPasarPares.Click += new System.EventHandler(this.btnPasarPares_Click);
        	// 
        	// lstListaNumeros2
        	// 
        	this.lstListaNumeros2.FormattingEnabled = true;
        	this.lstListaNumeros2.Location = new System.Drawing.Point(155, 23);
        	this.lstListaNumeros2.Name = "lstListaNumeros2";
        	this.lstListaNumeros2.Size = new System.Drawing.Size(68, 134);
        	this.lstListaNumeros2.TabIndex = 12;
        	// 
        	// btnInicializar
        	// 
        	this.btnInicializar.Location = new System.Drawing.Point(12, 126);
        	this.btnInicializar.Name = "btnInicializar";
        	this.btnInicializar.Size = new System.Drawing.Size(118, 23);
        	this.btnInicializar.TabIndex = 14;
        	this.btnInicializar.Text = "Inicializar lista y matriz";
        	this.btnInicializar.UseVisualStyleBackColor = true;
        	this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
        	// 
        	// lstNumerosVectoriales
        	// 
        	this.lstNumerosVectoriales.FormattingEnabled = true;
        	this.lstNumerosVectoriales.Location = new System.Drawing.Point(141, 18);
        	this.lstNumerosVectoriales.Name = "lstNumerosVectoriales";
        	this.lstNumerosVectoriales.Size = new System.Drawing.Size(87, 82);
        	this.lstNumerosVectoriales.TabIndex = 13;
        	// 
        	// txtIngresoNumero
        	// 
        	this.txtIngresoNumero.Location = new System.Drawing.Point(6, 20);
        	this.txtIngresoNumero.Name = "txtIngresoNumero";
        	this.txtIngresoNumero.Size = new System.Drawing.Size(126, 20);
        	this.txtIngresoNumero.TabIndex = 15;
        	// 
        	// btnCargarAMatriz
        	// 
        	this.btnCargarAMatriz.Location = new System.Drawing.Point(9, 43);
        	this.btnCargarAMatriz.Name = "btnCargarAMatriz";
        	this.btnCargarAMatriz.Size = new System.Drawing.Size(122, 35);
        	this.btnCargarAMatriz.TabIndex = 16;
        	this.btnCargarAMatriz.Text = "Cargar numero a la matriz";
        	this.btnCargarAMatriz.UseVisualStyleBackColor = true;
        	this.btnCargarAMatriz.Click += new System.EventHandler(this.btnCargarAMatriz_Click);
        	// 
        	// btnListarMatriz
        	// 
        	this.btnListarMatriz.Location = new System.Drawing.Point(9, 85);
        	this.btnListarMatriz.Name = "btnListarMatriz";
        	this.btnListarMatriz.Size = new System.Drawing.Size(121, 35);
        	this.btnListarMatriz.TabIndex = 17;
        	this.btnListarMatriz.Text = "Mostrar matriz en la lista";
        	this.btnListarMatriz.UseVisualStyleBackColor = true;
        	this.btnListarMatriz.Click += new System.EventHandler(this.btnListarMatriz_Click);
        	// 
        	// lstNumerosVectorialesConIVA
        	// 
        	this.lstNumerosVectorialesConIVA.FormattingEnabled = true;
        	this.lstNumerosVectorialesConIVA.Location = new System.Drawing.Point(141, 108);
        	this.lstNumerosVectorialesConIVA.Name = "lstNumerosVectorialesConIVA";
        	this.lstNumerosVectorialesConIVA.Size = new System.Drawing.Size(87, 82);
        	this.lstNumerosVectorialesConIVA.TabIndex = 18;
        	// 
        	// btnCargarconIVA
        	// 
        	this.btnCargarconIVA.Location = new System.Drawing.Point(11, 151);
        	this.btnCargarconIVA.Name = "btnCargarconIVA";
        	this.btnCargarconIVA.Size = new System.Drawing.Size(118, 47);
        	this.btnCargarconIVA.TabIndex = 19;
        	this.btnCargarconIVA.Text = "Paras los datos a la lista de abajo con el IVA calculado";
        	this.btnCargarconIVA.UseVisualStyleBackColor = true;
        	this.btnCargarconIVA.Click += new System.EventHandler(this.btnCargarconIVA_Click);
        	// 
        	// grpMatrizesBasicas
        	// 
        	this.grpMatrizesBasicas.Controls.Add(this.btnCargarAMatriz);
        	this.grpMatrizesBasicas.Controls.Add(this.btnCargarconIVA);
        	this.grpMatrizesBasicas.Controls.Add(this.lstNumerosVectoriales);
        	this.grpMatrizesBasicas.Controls.Add(this.lstNumerosVectorialesConIVA);
        	this.grpMatrizesBasicas.Controls.Add(this.btnInicializar);
        	this.grpMatrizesBasicas.Controls.Add(this.btnListarMatriz);
        	this.grpMatrizesBasicas.Controls.Add(this.txtIngresoNumero);
        	this.grpMatrizesBasicas.Location = new System.Drawing.Point(5, 12);
        	this.grpMatrizesBasicas.Name = "grpMatrizesBasicas";
        	this.grpMatrizesBasicas.Size = new System.Drawing.Size(236, 204);
        	this.grpMatrizesBasicas.TabIndex = 20;
        	this.grpMatrizesBasicas.TabStop = false;
        	this.grpMatrizesBasicas.Text = "Almacenaje y calculo de numeros en matrices";
        	// 
        	// grpListboxs
        	// 
        	this.grpListboxs.Controls.Add(this.lstListaNumeros);
        	this.grpListboxs.Controls.Add(this.btnCargarLista);
        	this.grpListboxs.Controls.Add(this.lstListaNumeros2);
        	this.grpListboxs.Controls.Add(this.btnCargarLista50a60);
        	this.grpListboxs.Controls.Add(this.btnPasarPares);
        	this.grpListboxs.Location = new System.Drawing.Point(250, 11);
        	this.grpListboxs.Name = "grpListboxs";
        	this.grpListboxs.Size = new System.Drawing.Size(232, 172);
        	this.grpListboxs.TabIndex = 21;
        	this.grpListboxs.TabStop = false;
        	this.grpListboxs.Text = "Ejercicios basicos con listboxes";
        	// 
        	// grpComboboxs
        	// 
        	this.grpComboboxs.Controls.Add(this.comboBox1);
        	this.grpComboboxs.Controls.Add(this.btnCargar);
        	this.grpComboboxs.Controls.Add(this.btnCargaManual);
        	this.grpComboboxs.Controls.Add(this.btnBorarSeleccionado);
        	this.grpComboboxs.Controls.Add(this.txtIngreso);
        	this.grpComboboxs.Controls.Add(this.btnBorrarDeCombobox);
        	this.grpComboboxs.Controls.Add(this.btnBuscar);
        	this.grpComboboxs.Controls.Add(this.btnCargarPrincipio);
        	this.grpComboboxs.Location = new System.Drawing.Point(488, 11);
        	this.grpComboboxs.Name = "grpComboboxs";
        	this.grpComboboxs.Size = new System.Drawing.Size(235, 157);
        	this.grpComboboxs.TabIndex = 22;
        	this.grpComboboxs.TabStop = false;
        	this.grpComboboxs.Text = "Ejercicios basicos con Comboboxes";
        	// 
        	// frmPruebaComboBox
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(727, 228);
        	this.Controls.Add(this.grpComboboxs);
        	this.Controls.Add(this.grpListboxs);
        	this.Controls.Add(this.grpMatrizesBasicas);
        	this.Name = "frmPruebaComboBox";
        	this.Text = "Pruebas con Comboboxes, listboxes y matrices";
        	this.grpMatrizesBasicas.ResumeLayout(false);
        	this.grpMatrizesBasicas.PerformLayout();
        	this.grpListboxs.ResumeLayout(false);
        	this.grpComboboxs.ResumeLayout(false);
        	this.grpComboboxs.PerformLayout();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.GroupBox grpComboboxs;
        private System.Windows.Forms.GroupBox grpListboxs;
        private System.Windows.Forms.GroupBox grpMatrizesBasicas;

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCargaManual;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCargarPrincipio;
        private System.Windows.Forms.Button btnBorrarDeCombobox;
        private System.Windows.Forms.Button btnBorarSeleccionado;
        private System.Windows.Forms.ListBox lstListaNumeros;
        private System.Windows.Forms.Button btnCargarLista;
        private System.Windows.Forms.Button btnCargarLista50a60;
        private System.Windows.Forms.Button btnPasarPares;
        private System.Windows.Forms.ListBox lstListaNumeros2;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.ListBox lstNumerosVectoriales;
        private System.Windows.Forms.TextBox txtIngresoNumero;
        private System.Windows.Forms.Button btnCargarAMatriz;
        private System.Windows.Forms.Button btnListarMatriz;
        private System.Windows.Forms.ListBox lstNumerosVectorialesConIVA;
        private System.Windows.Forms.Button btnCargarconIVA;
    }
}

