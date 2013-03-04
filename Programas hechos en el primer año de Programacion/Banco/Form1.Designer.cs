namespace Banco
{
    partial class Banco
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
        	this.grpCuenta = new System.Windows.Forms.GroupBox();
        	this.lblTipoCuenta = new System.Windows.Forms.Label();
        	this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
        	this.txtSaldo = new System.Windows.Forms.TextBox();
        	this.lblSaldo = new System.Windows.Forms.Label();
        	this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
        	this.lblNumeroCuenta = new System.Windows.Forms.Label();
        	this.grpCliente = new System.Windows.Forms.GroupBox();
        	this.rdoMujer = new System.Windows.Forms.RadioButton();
        	this.rdoHombre = new System.Windows.Forms.RadioButton();
        	this.lblSexo = new System.Windows.Forms.Label();
        	this.txtNumeroCliente = new System.Windows.Forms.TextBox();
        	this.lblNumeroCliente = new System.Windows.Forms.Label();
        	this.txtDNI = new System.Windows.Forms.TextBox();
        	this.lblDNI = new System.Windows.Forms.Label();
        	this.txtNombre = new System.Windows.Forms.TextBox();
        	this.lblNombre = new System.Windows.Forms.Label();
        	this.btnRegistrar = new System.Windows.Forms.Button();
        	this.lblCCuentaCorriente = new System.Windows.Forms.Label();
        	this.lblCCajaAhorro = new System.Windows.Forms.Label();
        	this.lblSaldoTotal = new System.Windows.Forms.Label();
        	this.lblSaldoPromedio = new System.Windows.Forms.Label();
        	this.lblSaldoMayor = new System.Windows.Forms.Label();
        	this.lblPromedioCuentaCorriente = new System.Windows.Forms.Label();
        	this.lblPromedioCajasAhorro = new System.Windows.Forms.Label();
        	this.lblRegistros = new System.Windows.Forms.Label();
        	this.lblPorTipoCuenta = new System.Windows.Forms.Label();
        	this.lblCSexos = new System.Windows.Forms.Label();
        	this.grpCuenta.SuspendLayout();
        	this.grpCliente.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// grpCuenta
        	// 
        	this.grpCuenta.Controls.Add(this.lblTipoCuenta);
        	this.grpCuenta.Controls.Add(this.cmbTipoCuenta);
        	this.grpCuenta.Controls.Add(this.txtSaldo);
        	this.grpCuenta.Controls.Add(this.lblSaldo);
        	this.grpCuenta.Controls.Add(this.txtNumeroCuenta);
        	this.grpCuenta.Controls.Add(this.lblNumeroCuenta);
        	this.grpCuenta.Location = new System.Drawing.Point(25, 2);
        	this.grpCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.grpCuenta.Name = "grpCuenta";
        	this.grpCuenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.grpCuenta.Size = new System.Drawing.Size(333, 121);
        	this.grpCuenta.TabIndex = 0;
        	this.grpCuenta.TabStop = false;
        	this.grpCuenta.Text = "Datos de la cuenta";
        	// 
        	// lblTipoCuenta
        	// 
        	this.lblTipoCuenta.AutoSize = true;
        	this.lblTipoCuenta.Location = new System.Drawing.Point(9, 87);
        	this.lblTipoCuenta.Name = "lblTipoCuenta";
        	this.lblTipoCuenta.Size = new System.Drawing.Size(118, 20);
        	this.lblTipoCuenta.TabIndex = 5;
        	this.lblTipoCuenta.Text = "Tipo de cuenta:";
        	// 
        	// cmbTipoCuenta
        	// 
        	this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.cmbTipoCuenta.FormattingEnabled = true;
        	this.cmbTipoCuenta.Items.AddRange(new object[] {
        	        	        	"Cuenta corriente",
        	        	        	"Caja de ahorro"});
        	this.cmbTipoCuenta.Location = new System.Drawing.Point(128, 84);
        	this.cmbTipoCuenta.Name = "cmbTipoCuenta";
        	this.cmbTipoCuenta.Size = new System.Drawing.Size(200, 28);
        	this.cmbTipoCuenta.TabIndex = 4;
        	this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
        	// 
        	// txtSaldo
        	// 
        	this.txtSaldo.Location = new System.Drawing.Point(88, 55);
        	this.txtSaldo.Name = "txtSaldo";
        	this.txtSaldo.Size = new System.Drawing.Size(241, 26);
        	this.txtSaldo.TabIndex = 3;
        	// 
        	// lblSaldo
        	// 
        	this.lblSaldo.AutoSize = true;
        	this.lblSaldo.Location = new System.Drawing.Point(26, 58);
        	this.lblSaldo.Name = "lblSaldo";
        	this.lblSaldo.Size = new System.Drawing.Size(67, 20);
        	this.lblSaldo.TabIndex = 2;
        	this.lblSaldo.Text = "Saldo: $";
        	// 
        	// txtNumeroCuenta
        	// 
        	this.txtNumeroCuenta.Location = new System.Drawing.Point(157, 26);
        	this.txtNumeroCuenta.Name = "txtNumeroCuenta";
        	this.txtNumeroCuenta.Size = new System.Drawing.Size(173, 26);
        	this.txtNumeroCuenta.TabIndex = 1;
        	// 
        	// lblNumeroCuenta
        	// 
        	this.lblNumeroCuenta.AutoSize = true;
        	this.lblNumeroCuenta.Location = new System.Drawing.Point(12, 28);
        	this.lblNumeroCuenta.Name = "lblNumeroCuenta";
        	this.lblNumeroCuenta.Size = new System.Drawing.Size(144, 20);
        	this.lblNumeroCuenta.TabIndex = 0;
        	this.lblNumeroCuenta.Text = "Numero de cuenta:";
        	// 
        	// grpCliente
        	// 
        	this.grpCliente.Controls.Add(this.rdoMujer);
        	this.grpCliente.Controls.Add(this.rdoHombre);
        	this.grpCliente.Controls.Add(this.lblSexo);
        	this.grpCliente.Controls.Add(this.txtNumeroCliente);
        	this.grpCliente.Controls.Add(this.lblNumeroCliente);
        	this.grpCliente.Controls.Add(this.txtDNI);
        	this.grpCliente.Controls.Add(this.lblDNI);
        	this.grpCliente.Controls.Add(this.txtNombre);
        	this.grpCliente.Controls.Add(this.lblNombre);
        	this.grpCliente.Location = new System.Drawing.Point(25, 131);
        	this.grpCliente.Name = "grpCliente";
        	this.grpCliente.Size = new System.Drawing.Size(333, 148);
        	this.grpCliente.TabIndex = 1;
        	this.grpCliente.TabStop = false;
        	this.grpCliente.Text = "Datos del cliente";
        	// 
        	// rdoMujer
        	// 
        	this.rdoMujer.AutoSize = true;
        	this.rdoMujer.Location = new System.Drawing.Point(167, 108);
        	this.rdoMujer.Name = "rdoMujer";
        	this.rdoMujer.Size = new System.Drawing.Size(66, 24);
        	this.rdoMujer.TabIndex = 8;
        	this.rdoMujer.TabStop = true;
        	this.rdoMujer.Text = "Mujer";
        	this.rdoMujer.UseVisualStyleBackColor = true;
        	// 
        	// rdoHombre
        	// 
        	this.rdoHombre.AutoSize = true;
        	this.rdoHombre.Location = new System.Drawing.Point(77, 108);
        	this.rdoHombre.Name = "rdoHombre";
        	this.rdoHombre.Size = new System.Drawing.Size(84, 24);
        	this.rdoHombre.TabIndex = 7;
        	this.rdoHombre.TabStop = true;
        	this.rdoHombre.Text = "Hombre";
        	this.rdoHombre.UseVisualStyleBackColor = true;
        	// 
        	// lblSexo
        	// 
        	this.lblSexo.AutoSize = true;
        	this.lblSexo.Location = new System.Drawing.Point(25, 109);
        	this.lblSexo.Name = "lblSexo";
        	this.lblSexo.Size = new System.Drawing.Size(49, 20);
        	this.lblSexo.TabIndex = 6;
        	this.lblSexo.Text = "Sexo:";
        	// 
        	// txtNumeroCliente
        	// 
        	this.txtNumeroCliente.Location = new System.Drawing.Point(77, 76);
        	this.txtNumeroCliente.Name = "txtNumeroCliente";
        	this.txtNumeroCliente.Size = new System.Drawing.Size(239, 26);
        	this.txtNumeroCliente.TabIndex = 5;
        	// 
        	// lblNumeroCliente
        	// 
        	this.lblNumeroCliente.AutoSize = true;
        	this.lblNumeroCliente.Location = new System.Drawing.Point(9, 78);
        	this.lblNumeroCliente.Name = "lblNumeroCliente";
        	this.lblNumeroCliente.Size = new System.Drawing.Size(69, 20);
        	this.lblNumeroCliente.TabIndex = 4;
        	this.lblNumeroCliente.Text = "Numero:";
        	// 
        	// txtDNI
        	// 
        	this.txtDNI.Location = new System.Drawing.Point(77, 47);
        	this.txtDNI.Name = "txtDNI";
        	this.txtDNI.Size = new System.Drawing.Size(240, 26);
        	this.txtDNI.TabIndex = 3;
        	// 
        	// lblDNI
        	// 
        	this.lblDNI.AutoSize = true;
        	this.lblDNI.Location = new System.Drawing.Point(37, 48);
        	this.lblDNI.Name = "lblDNI";
        	this.lblDNI.Size = new System.Drawing.Size(41, 20);
        	this.lblDNI.TabIndex = 2;
        	this.lblDNI.Text = "DNI:";
        	// 
        	// txtNombre
        	// 
        	this.txtNombre.Location = new System.Drawing.Point(76, 18);
        	this.txtNombre.Name = "txtNombre";
        	this.txtNombre.Size = new System.Drawing.Size(241, 26);
        	this.txtNombre.TabIndex = 1;
        	// 
        	// lblNombre
        	// 
        	this.lblNombre.AutoSize = true;
        	this.lblNombre.Location = new System.Drawing.Point(9, 21);
        	this.lblNombre.Name = "lblNombre";
        	this.lblNombre.Size = new System.Drawing.Size(69, 20);
        	this.lblNombre.TabIndex = 0;
        	this.lblNombre.Text = "Nombre:";
        	// 
        	// btnRegistrar
        	// 
        	this.btnRegistrar.Location = new System.Drawing.Point(128, 288);
        	this.btnRegistrar.Name = "btnRegistrar";
        	this.btnRegistrar.Size = new System.Drawing.Size(119, 28);
        	this.btnRegistrar.TabIndex = 2;
        	this.btnRegistrar.Text = "Registrar";
        	this.btnRegistrar.UseVisualStyleBackColor = true;
        	this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
        	// 
        	// lblCCuentaCorriente
        	// 
        	this.lblCCuentaCorriente.AutoSize = true;
        	this.lblCCuentaCorriente.Location = new System.Drawing.Point(1, 319);
        	this.lblCCuentaCorriente.Name = "lblCCuentaCorriente";
        	this.lblCCuentaCorriente.Size = new System.Drawing.Size(366, 20);
        	this.lblCCuentaCorriente.TabIndex = 3;
        	this.lblCCuentaCorriente.Text = "Cantidad y saldo de las cuentas corrientes: 0, $0    ";
        	// 
        	// lblCCajaAhorro
        	// 
        	this.lblCCajaAhorro.AutoSize = true;
        	this.lblCCajaAhorro.Location = new System.Drawing.Point(1, 339);
        	this.lblCCajaAhorro.Name = "lblCCajaAhorro";
        	this.lblCCajaAhorro.Size = new System.Drawing.Size(376, 20);
        	this.lblCCajaAhorro.TabIndex = 4;
        	this.lblCCajaAhorro.Text = "Cantidad y saldo de las cajas de ahorro: 0, $0            ";
        	// 
        	// lblSaldoTotal
        	// 
        	this.lblSaldoTotal.AutoSize = true;
        	this.lblSaldoTotal.Location = new System.Drawing.Point(7, 359);
        	this.lblSaldoTotal.Name = "lblSaldoTotal";
        	this.lblSaldoTotal.Size = new System.Drawing.Size(171, 20);
        	this.lblSaldoTotal.TabIndex = 5;
        	this.lblSaldoTotal.Text = "Saldo Total: $0              ";
        	// 
        	// lblSaldoPromedio
        	// 
        	this.lblSaldoPromedio.AutoSize = true;
        	this.lblSaldoPromedio.Location = new System.Drawing.Point(178, 359);
        	this.lblSaldoPromedio.Name = "lblSaldoPromedio";
        	this.lblSaldoPromedio.Size = new System.Drawing.Size(187, 20);
        	this.lblSaldoPromedio.TabIndex = 6;
        	this.lblSaldoPromedio.Text = "Saldo Promedio: $0          ";
        	// 
        	// lblSaldoMayor
        	// 
        	this.lblSaldoMayor.AutoSize = true;
        	this.lblSaldoMayor.Location = new System.Drawing.Point(6, 376);
        	this.lblSaldoMayor.Name = "lblSaldoMayor";
        	this.lblSaldoMayor.Size = new System.Drawing.Size(347, 40);
        	this.lblSaldoMayor.TabIndex = 7;
        	this.lblSaldoMayor.Text = "El cliente con mayor saldo es ______________ \r\ncon un saldo de $0";
        	// 
        	// lblPromedioCuentaCorriente
        	// 
        	this.lblPromedioCuentaCorriente.AutoSize = true;
        	this.lblPromedioCuentaCorriente.Location = new System.Drawing.Point(7, 437);
        	this.lblPromedioCuentaCorriente.Name = "lblPromedioCuentaCorriente";
        	this.lblPromedioCuentaCorriente.Size = new System.Drawing.Size(350, 20);
        	this.lblPromedioCuentaCorriente.TabIndex = 8;
        	this.lblPromedioCuentaCorriente.Text = "Promedio del saldo de las cuentas corrientes: $0";
        	// 
        	// lblPromedioCajasAhorro
        	// 
        	this.lblPromedioCajasAhorro.AutoSize = true;
        	this.lblPromedioCajasAhorro.Location = new System.Drawing.Point(7, 417);
        	this.lblPromedioCajasAhorro.Name = "lblPromedioCajasAhorro";
        	this.lblPromedioCajasAhorro.Size = new System.Drawing.Size(332, 20);
        	this.lblPromedioCajasAhorro.TabIndex = 9;
        	this.lblPromedioCajasAhorro.Text = "Promedio del saldo de las cajas de ahorro: $0 ";
        	// 
        	// lblRegistros
        	// 
        	this.lblRegistros.AutoSize = true;
        	this.lblRegistros.Location = new System.Drawing.Point(6, 457);
        	this.lblRegistros.Name = "lblRegistros";
        	this.lblRegistros.Size = new System.Drawing.Size(266, 20);
        	this.lblRegistros.TabIndex = 10;
        	this.lblRegistros.Text = "Cantidad de registros hasta ahora: 0";
        	// 
        	// lblPorTipoCuenta
        	// 
        	this.lblPorTipoCuenta.AutoSize = true;
        	this.lblPorTipoCuenta.Location = new System.Drawing.Point(6, 477);
        	this.lblPorTipoCuenta.Name = "lblPorTipoCuenta";
        	this.lblPorTipoCuenta.Size = new System.Drawing.Size(273, 40);
        	this.lblPorTipoCuenta.TabIndex = 11;
        	this.lblPorTipoCuenta.Text = "Porcentaje de cajas de ahorro: %0\r\nPorcentaje de cuentas corrientes: %0";
        	// 
        	// lblCSexos
        	// 
        	this.lblCSexos.Location = new System.Drawing.Point(4, 516);
        	this.lblCSexos.Name = "lblCSexos";
        	this.lblCSexos.Size = new System.Drawing.Size(365, 38);
        	this.lblCSexos.TabIndex = 13;
        	this.lblCSexos.Text = "Porcentaje y cantidad de hombres: 0, %0\r\nPorcentaje y cantidad de mujeres: 0, %0";
        	// 
        	// Banco
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(370, 561);
        	this.Controls.Add(this.lblCSexos);
        	this.Controls.Add(this.lblPorTipoCuenta);
        	this.Controls.Add(this.lblRegistros);
        	this.Controls.Add(this.lblPromedioCajasAhorro);
        	this.Controls.Add(this.lblPromedioCuentaCorriente);
        	this.Controls.Add(this.lblSaldoMayor);
        	this.Controls.Add(this.lblSaldoPromedio);
        	this.Controls.Add(this.lblSaldoTotal);
        	this.Controls.Add(this.lblCCajaAhorro);
        	this.Controls.Add(this.lblCCuentaCorriente);
        	this.Controls.Add(this.btnRegistrar);
        	this.Controls.Add(this.grpCliente);
        	this.Controls.Add(this.grpCuenta);
        	this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        	this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        	this.Name = "Banco";
        	this.Text = "Banco";
        	this.grpCuenta.ResumeLayout(false);
        	this.grpCuenta.PerformLayout();
        	this.grpCliente.ResumeLayout(false);
        	this.grpCliente.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label lblPromedioCuentaCorriente;
        private System.Windows.Forms.Label lblPromedioCajasAhorro;
        private System.Windows.Forms.Label lblPorTipoCuenta;
        private System.Windows.Forms.Label lblCSexos;

        #endregion

        private System.Windows.Forms.GroupBox grpCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.RadioButton rdoMujer;
        private System.Windows.Forms.RadioButton rdoHombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCCuentaCorriente;
        private System.Windows.Forms.Label lblCCajaAhorro;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblSaldoPromedio;
        private System.Windows.Forms.Label lblSaldoMayor;
        private System.Windows.Forms.Label lblRegistros;
    }
}

