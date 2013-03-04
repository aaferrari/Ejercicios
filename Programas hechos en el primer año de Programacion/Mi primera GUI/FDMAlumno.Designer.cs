namespace Mi_primera_GUI
{
    partial class FDMAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDMAlumno));
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNDocumento = new System.Windows.Forms.Label();
            this.txtNDocumento = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblSoltero = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLegajo
            // 
            resources.ApplyResources(this.lblLegajo, "lblLegajo");
            this.lblLegajo.Name = "lblLegajo";
            // 
            // txtLegajo
            // 
            resources.ApplyResources(this.txtLegajo, "txtLegajo");
            this.txtLegajo.Name = "txtLegajo";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblApellido
            // 
            resources.ApplyResources(this.lblApellido, "lblApellido");
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // txtApellido
            // 
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblTipoDocumento
            // 
            resources.ApplyResources(this.lblTipoDocumento, "lblTipoDocumento");
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Click += new System.EventHandler(this.lblTipoDocumento_Click);
            // 
            // lblNDocumento
            // 
            resources.ApplyResources(this.lblNDocumento, "lblNDocumento");
            this.lblNDocumento.Name = "lblNDocumento";
            this.lblNDocumento.Click += new System.EventHandler(this.lblNDocumento_Click);
            // 
            // txtNDocumento
            // 
            resources.ApplyResources(this.txtNDocumento, "txtNDocumento");
            this.txtNDocumento.Name = "txtNDocumento";
            this.txtNDocumento.TextChanged += new System.EventHandler(this.txtNDocumento_TextChanged);
            // 
            // lblSexo
            // 
            resources.ApplyResources(this.lblSexo, "lblSexo");
            this.lblSexo.Name = "lblSexo";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblSoltero
            // 
            resources.ApplyResources(this.lblSoltero, "lblSoltero");
            this.lblSoltero.Name = "lblSoltero";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            resources.ApplyResources(this.btnNuevo, "btnNuevo");
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Tag = "";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboTipoDocumento, "cboTipoDocumento");
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // btnModificar
            // 
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            resources.ApplyResources(this.btnBorrar, "btnBorrar");
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            resources.ApplyResources(this.btnGrabar, "btnGrabar");
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FDMAlumno
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(85)))), ((int)(((byte)(94)))));
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSoltero);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtNDocumento);
            this.Controls.Add(this.lblNDocumento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FDMAlumno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNDocumento;
        private System.Windows.Forms.TextBox txtNDocumento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblSoltero;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
    }
}

