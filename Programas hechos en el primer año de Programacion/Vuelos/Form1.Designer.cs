namespace Trabajo_con_bases_de_datos
{
    partial class FrnControlVuelos
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
        	this.grpDatosPiloto = new System.Windows.Forms.GroupBox();
        	this.cmbCategoria = new System.Windows.Forms.ComboBox();
        	this.lblCategoria = new System.Windows.Forms.Label();
        	this.grpSexo = new System.Windows.Forms.GroupBox();
        	this.rdtMujer = new System.Windows.Forms.RadioButton();
        	this.rbtHombre = new System.Windows.Forms.RadioButton();
        	this.txtApellido = new System.Windows.Forms.TextBox();
        	this.lblApellido = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.grpDatosVuelo = new System.Windows.Forms.GroupBox();
        	this.txtMonto = new System.Windows.Forms.TextBox();
        	this.lblMonto = new System.Windows.Forms.Label();
        	this.cmbDestino = new System.Windows.Forms.ComboBox();
        	this.lblDestino = new System.Windows.Forms.Label();
        	this.txtOrigen = new System.Windows.Forms.TextBox();
        	this.lblOrigen = new System.Windows.Forms.Label();
        	this.txtNumero = new System.Windows.Forms.TextBox();
        	this.lblNumero = new System.Windows.Forms.Label();
        	this.btnRegistrar = new System.Windows.Forms.Button();
        	this.lblVuelosBsAs = new System.Windows.Forms.Label();
        	this.lblVuelosPilotoA = new System.Windows.Forms.Label();
        	this.lblMontoPromedio = new System.Windows.Forms.Label();
        	this.lblPorcentajeBsAs = new System.Windows.Forms.Label();
        	this.lblPorcentajeSantaFe = new System.Windows.Forms.Label();
        	this.lblPorcentajeMendoza = new System.Windows.Forms.Label();
        	this.grpDatosPiloto.SuspendLayout();
        	this.grpSexo.SuspendLayout();
        	this.grpDatosVuelo.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// grpDatosPiloto
        	// 
        	this.grpDatosPiloto.Controls.Add(this.cmbCategoria);
        	this.grpDatosPiloto.Controls.Add(this.lblCategoria);
        	this.grpDatosPiloto.Controls.Add(this.grpSexo);
        	this.grpDatosPiloto.Controls.Add(this.txtApellido);
        	this.grpDatosPiloto.Controls.Add(this.lblApellido);
        	this.grpDatosPiloto.Controls.Add(this.txtNombre);
        	this.grpDatosPiloto.Controls.Add(this.lblNombre);
        	this.grpDatosPiloto.Location = new System.Drawing.Point(12, 13);
        	this.grpDatosPiloto.Name = "grpDatosPiloto";
        	this.grpDatosPiloto.Size = new System.Drawing.Size(570, 71);
        	this.grpDatosPiloto.TabIndex = 0;
        	this.grpDatosPiloto.TabStop = false;
        	this.grpDatosPiloto.Text = "Datos del piloto";
        	// 
        	// cmbCategoria
        	// 
        	this.cmbCategoria.FormattingEnabled = true;
        	this.cmbCategoria.Items.AddRange(new object[] {
        	        	        	"A",
        	        	        	"B",
        	        	        	"C"});
        	this.cmbCategoria.Location = new System.Drawing.Point(466, 15);
        	this.cmbCategoria.Name = "cmbCategoria";
        	this.cmbCategoria.Size = new System.Drawing.Size(100, 21);
        	this.cmbCategoria.TabIndex = 6;
        	// 
        	// lblCategoria
        	// 
        	this.lblCategoria.AutoSize = true;
        	this.lblCategoria.Location = new System.Drawing.Point(411, 18);
        	this.lblCategoria.Name = "lblCategoria";
        	this.lblCategoria.Size = new System.Drawing.Size(55, 13);
        	this.lblCategoria.TabIndex = 5;
        	this.lblCategoria.Text = "Categoria:";
        	// 
        	// grpSexo
        	// 
        	this.grpSexo.Controls.Add(this.rdtMujer);
        	this.grpSexo.Controls.Add(this.rbtHombre);
        	this.grpSexo.Location = new System.Drawing.Point(314, 13);
        	this.grpSexo.Name = "grpSexo";
        	this.grpSexo.Size = new System.Drawing.Size(91, 54);
        	this.grpSexo.TabIndex = 4;
        	this.grpSexo.TabStop = false;
        	this.grpSexo.Text = "Sexo";
        	// 
        	// rdtMujer
        	// 
        	this.rdtMujer.AutoSize = true;
        	this.rdtMujer.Location = new System.Drawing.Point(6, 34);
        	this.rdtMujer.Name = "rdtMujer";
        	this.rdtMujer.Size = new System.Drawing.Size(71, 17);
        	this.rdtMujer.TabIndex = 1;
        	this.rdtMujer.TabStop = true;
        	this.rdtMujer.Text = "Femenino";
        	this.rdtMujer.UseVisualStyleBackColor = true;
        	// 
        	// rbtHombre
        	// 
        	this.rbtHombre.AutoSize = true;
        	this.rbtHombre.Location = new System.Drawing.Point(6, 17);
        	this.rbtHombre.Name = "rbtHombre";
        	this.rbtHombre.Size = new System.Drawing.Size(73, 17);
        	this.rbtHombre.TabIndex = 0;
        	this.rbtHombre.TabStop = true;
        	this.rbtHombre.Text = "Masculino";
        	this.rbtHombre.UseVisualStyleBackColor = true;
        	// 
        	// txtApellido
        	// 
        	this.txtApellido.Location = new System.Drawing.Point(217, 14);
        	this.txtApellido.Name = "txtApellido";
        	this.txtApellido.Size = new System.Drawing.Size(88, 20);
        	this.txtApellido.TabIndex = 3;
        	// 
        	// lblApellido
        	// 
        	this.lblApellido.AutoSize = true;
        	this.lblApellido.Location = new System.Drawing.Point(170, 17);
        	this.lblApellido.Name = "lblApellido";
        	this.lblApellido.Size = new System.Drawing.Size(47, 13);
        	this.lblApellido.TabIndex = 2;
        	this.lblApellido.Text = "Apellido:";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(63, 15);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(94, 20);
        	this.txtNombre.TabIndex = 1;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.AutoSize = true;
        	this.lblNombre.Location = new System.Drawing.Point(17, 19);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(47, 13);
        	this.lblNombre.TabIndex = 0;
        	this.lblNombre.Text = "Nombre:";
        	// 
        	// grpDatosVuelo
        	// 
        	this.grpDatosVuelo.Controls.Add(this.txtMonto);
        	this.grpDatosVuelo.Controls.Add(this.lblMonto);
        	this.grpDatosVuelo.Controls.Add(this.cmbDestino);
        	this.grpDatosVuelo.Controls.Add(this.lblDestino);
        	this.grpDatosVuelo.Controls.Add(this.txtOrigen);
        	this.grpDatosVuelo.Controls.Add(this.lblOrigen);
        	this.grpDatosVuelo.Controls.Add(this.txtNumero);
        	this.grpDatosVuelo.Controls.Add(this.lblNumero);
        	this.grpDatosVuelo.Location = new System.Drawing.Point(12, 90);
        	this.grpDatosVuelo.Name = "grpDatosVuelo";
        	this.grpDatosVuelo.Size = new System.Drawing.Size(570, 44);
        	this.grpDatosVuelo.TabIndex = 7;
        	this.grpDatosVuelo.TabStop = false;
        	this.grpDatosVuelo.Text = "Datos del piloto";
        	// 
        	// txtMonto
        	// 
        	this.txtMonto.Location = new System.Drawing.Point(502, 13);
        	this.txtMonto.Name = "txtMonto";
        	this.txtMonto.Size = new System.Drawing.Size(63, 20);
        	this.txtMonto.TabIndex = 8;
        	// 
        	// lblMonto
        	// 
        	this.lblMonto.AutoSize = true;
        	this.lblMonto.Location = new System.Drawing.Point(454, 16);
        	this.lblMonto.Name = "lblMonto";
        	this.lblMonto.Size = new System.Drawing.Size(49, 13);
        	this.lblMonto.TabIndex = 7;
        	this.lblMonto.Text = "Monto: $";
        	// 
        	// cmbDestino
        	// 
        	this.cmbDestino.FormattingEnabled = true;
        	this.cmbDestino.Items.AddRange(new object[] {
        	        	        	"Buenos Aires",
        	        	        	"Mendoza",
        	        	        	"Santa Fe"});
        	this.cmbDestino.Location = new System.Drawing.Point(349, 12);
        	this.cmbDestino.Name = "cmbDestino";
        	this.cmbDestino.Size = new System.Drawing.Size(100, 21);
        	this.cmbDestino.TabIndex = 6;
        	// 
        	// lblDestino
        	// 
        	this.lblDestino.AutoSize = true;
        	this.lblDestino.Location = new System.Drawing.Point(302, 15);
        	this.lblDestino.Name = "lblDestino";
        	this.lblDestino.Size = new System.Drawing.Size(46, 13);
        	this.lblDestino.TabIndex = 5;
        	this.lblDestino.Text = "Destino:";
        	// 
        	// txtOrigen
        	// 
        	this.txtOrigen.Location = new System.Drawing.Point(208, 15);
        	this.txtOrigen.Name = "txtOrigen";
        	this.txtOrigen.Size = new System.Drawing.Size(88, 20);
        	this.txtOrigen.TabIndex = 3;
        	// 
        	// lblOrigen
        	// 
        	this.lblOrigen.AutoSize = true;
        	this.lblOrigen.Location = new System.Drawing.Point(167, 17);
        	this.lblOrigen.Name = "lblOrigen";
        	this.lblOrigen.Size = new System.Drawing.Size(41, 13);
        	this.lblOrigen.TabIndex = 2;
        	this.lblOrigen.Text = "Origen:";
        	// 
        	// txtNumero
        	// 
        	this.txtNumero.Location = new System.Drawing.Point(62, 15);
        	this.txtNumero.Name = "txtNumero";
        	this.txtNumero.Size = new System.Drawing.Size(94, 20);
        	this.txtNumero.TabIndex = 1;
        	// 
        	// lblNumero
        	// 
        	this.lblNumero.AutoSize = true;
        	this.lblNumero.Location = new System.Drawing.Point(17, 19);
        	this.lblNumero.Name = "lblNumero";
        	this.lblNumero.Size = new System.Drawing.Size(47, 13);
        	this.lblNumero.TabIndex = 0;
        	this.lblNumero.Text = "Numero:";
        	// 
        	// btnRegistrar
        	// 
        	this.btnRegistrar.Location = new System.Drawing.Point(268, 143);
        	this.btnRegistrar.Name = "btnRegistrar";
        	this.btnRegistrar.Size = new System.Drawing.Size(91, 20);
        	this.btnRegistrar.TabIndex = 8;
        	this.btnRegistrar.Text = "Registrar";
        	this.btnRegistrar.UseVisualStyleBackColor = true;
        	this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
        	// 
        	// lblVuelosBsAs
        	// 
        	this.lblVuelosBsAs.AutoSize = true;
        	this.lblVuelosBsAs.Location = new System.Drawing.Point(15, 172);
        	this.lblVuelosBsAs.Name = "lblVuelosBsAs";
        	this.lblVuelosBsAs.Size = new System.Drawing.Size(242, 13);
        	this.lblVuelosBsAs.TabIndex = 9;
        	this.lblVuelosBsAs.Text = "Cantidad de vuelos con destino a Buenos Aires: 0";
        	// 
        	// lblVuelosPilotoA
        	// 
        	this.lblVuelosPilotoA.AutoSize = true;
        	this.lblVuelosPilotoA.Location = new System.Drawing.Point(15, 189);
        	this.lblVuelosPilotoA.Name = "lblVuelosPilotoA";
        	this.lblVuelosPilotoA.Size = new System.Drawing.Size(236, 13);
        	this.lblVuelosPilotoA.TabIndex = 10;
        	this.lblVuelosPilotoA.Text = "Cantidad de vuelos con pilotos de categoria A: 0";
        	// 
        	// lblMontoPromedio
        	// 
        	this.lblMontoPromedio.AutoSize = true;
        	this.lblMontoPromedio.Location = new System.Drawing.Point(20, 206);
        	this.lblMontoPromedio.Name = "lblMontoPromedio";
        	this.lblMontoPromedio.Size = new System.Drawing.Size(181, 13);
        	this.lblMontoPromedio.TabIndex = 11;
        	this.lblMontoPromedio.Text = "Monto promedio de los vuelos: $0.00";
        	// 
        	// lblPorcentajeBsAs
        	// 
        	this.lblPorcentajeBsAs.AutoSize = true;
        	this.lblPorcentajeBsAs.Location = new System.Drawing.Point(272, 170);
        	this.lblPorcentajeBsAs.Name = "lblPorcentajeBsAs";
        	this.lblPorcentajeBsAs.Size = new System.Drawing.Size(239, 13);
        	this.lblPorcentajeBsAs.TabIndex = 12;
        	this.lblPorcentajeBsAs.Text = "Porcentaje de vuelos hechos a Buenos Aires: %0";
        	// 
        	// lblPorcentajeSantaFe
        	// 
        	this.lblPorcentajeSantaFe.AutoSize = true;
        	this.lblPorcentajeSantaFe.Location = new System.Drawing.Point(273, 185);
        	this.lblPorcentajeSantaFe.Name = "lblPorcentajeSantaFe";
        	this.lblPorcentajeSantaFe.Size = new System.Drawing.Size(220, 13);
        	this.lblPorcentajeSantaFe.TabIndex = 13;
        	this.lblPorcentajeSantaFe.Text = "Porcentaje de vuelos hechos a Santa Fe: %0";
        	// 
        	// lblPorcentajeMendoza
        	// 
        	this.lblPorcentajeMendoza.AutoSize = true;
        	this.lblPorcentajeMendoza.Location = new System.Drawing.Point(273, 202);
        	this.lblPorcentajeMendoza.Name = "lblPorcentajeMendoza";
        	this.lblPorcentajeMendoza.Size = new System.Drawing.Size(221, 13);
        	this.lblPorcentajeMendoza.TabIndex = 14;
        	this.lblPorcentajeMendoza.Text = "Porcentaje de vuelos hechos a Mendoza: %0";
        	// 
        	// FrnControlVuelos
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(592, 229);
        	this.Controls.Add(this.lblPorcentajeMendoza);
        	this.Controls.Add(this.lblPorcentajeSantaFe);
        	this.Controls.Add(this.lblPorcentajeBsAs);
        	this.Controls.Add(this.lblMontoPromedio);
        	this.Controls.Add(this.lblVuelosPilotoA);
        	this.Controls.Add(this.lblVuelosBsAs);
        	this.Controls.Add(this.btnRegistrar);
        	this.Controls.Add(this.grpDatosVuelo);
        	this.Controls.Add(this.grpDatosPiloto);
        	this.Name = "FrnControlVuelos";
        	this.Text = "Control de vuelos";
        	this.grpDatosPiloto.ResumeLayout(false);
        	this.grpDatosPiloto.PerformLayout();
        	this.grpSexo.ResumeLayout(false);
        	this.grpSexo.PerformLayout();
        	this.grpDatosVuelo.ResumeLayout(false);
        	this.grpDatosVuelo.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPiloto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdtMujer;
        private System.Windows.Forms.RadioButton rbtHombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox grpDatosVuelo;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblVuelosBsAs;
        private System.Windows.Forms.Label lblVuelosPilotoA;
        private System.Windows.Forms.Label lblMontoPromedio;
        private System.Windows.Forms.Label lblPorcentajeBsAs;
        private System.Windows.Forms.Label lblPorcentajeSantaFe;
        private System.Windows.Forms.Label lblPorcentajeMendoza;
    }
}

