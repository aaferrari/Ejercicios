namespace Cursado_con_profesor
{
    partial class FrmCursos
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
            this.grpDocente = new System.Windows.Forms.GroupBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.grpCurso = new System.Windows.Forms.GroupBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtNombreAula = new System.Windows.Forms.TextBox();
            this.lblNombreAula = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblProfeCobraMas = new System.Windows.Forms.Label();
            this.lblNProfeCobraMas = new System.Windows.Forms.Label();
            this.lblSueldoMayor = new System.Windows.Forms.Label();
            this.lblCRegistros = new System.Windows.Forms.Label();
            this.lblCSueldoMayor = new System.Windows.Forms.Label();
            this.lblCursoDeMayorSueldo = new System.Windows.Forms.Label();
            this.lblNCursoDeMayorSueldo = new System.Windows.Forms.Label();
            this.lblProfeM = new System.Windows.Forms.Label();
            this.lblCProfeM = new System.Windows.Forms.Label();
            this.lblCProfeF = new System.Windows.Forms.Label();
            this.lblProfeF = new System.Windows.Forms.Label();
            this.grpDocente.SuspendLayout();
            this.grpSexo.SuspendLayout();
            this.grpCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDocente
            // 
            this.grpDocente.Controls.Add(this.grpSexo);
            this.grpDocente.Controls.Add(this.txtSueldo);
            this.grpDocente.Controls.Add(this.lblSueldo);
            this.grpDocente.Controls.Add(this.txtDNI);
            this.grpDocente.Controls.Add(this.lblDNI);
            this.grpDocente.Controls.Add(this.txtNombre);
            this.grpDocente.Controls.Add(this.lblNombre);
            this.grpDocente.Controls.Add(this.txtLegajo);
            this.grpDocente.Controls.Add(this.lblLegajo);
            this.grpDocente.Location = new System.Drawing.Point(18, 17);
            this.grpDocente.Margin = new System.Windows.Forms.Padding(5);
            this.grpDocente.Name = "grpDocente";
            this.grpDocente.Padding = new System.Windows.Forms.Padding(5);
            this.grpDocente.Size = new System.Drawing.Size(468, 97);
            this.grpDocente.TabIndex = 0;
            this.grpDocente.TabStop = false;
            this.grpDocente.Text = "Datos de docente";
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbFemenino);
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Location = new System.Drawing.Point(366, 15);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(90, 74);
            this.grpSexo.TabIndex = 8;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(7, 43);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(66, 24);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Mujer";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(7, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(84, 24);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Hombre";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(257, 63);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(99, 26);
            this.txtSueldo.TabIndex = 7;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(183, 66);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(76, 20);
            this.lblSueldo.TabIndex = 6;
            this.lblSueldo.Text = "Sueldo: $";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(55, 58);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(122, 26);
            this.txtDNI.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(16, 60);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(41, 20);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(258, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(98, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(189, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(71, 23);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(106, 26);
            this.txtLegajo.TabIndex = 1;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(14, 25);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(61, 20);
            this.lblLegajo.TabIndex = 0;
            this.lblLegajo.Text = "Legajo:";
            // 
            // grpCurso
            // 
            this.grpCurso.Controls.Add(this.cmbTurno);
            this.grpCurso.Controls.Add(this.lblTurno);
            this.grpCurso.Controls.Add(this.txtNombreAula);
            this.grpCurso.Controls.Add(this.lblNombreAula);
            this.grpCurso.Controls.Add(this.txtAula);
            this.grpCurso.Controls.Add(this.lblAula);
            this.grpCurso.Location = new System.Drawing.Point(16, 127);
            this.grpCurso.Name = "grpCurso";
            this.grpCurso.Size = new System.Drawing.Size(470, 63);
            this.grpCurso.TabIndex = 1;
            this.grpCurso.TabStop = false;
            this.grpCurso.Text = "Datos del curso";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde",
            "Noche"});
            this.cmbTurno.Location = new System.Drawing.Point(336, 23);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(117, 28);
            this.cmbTurno.TabIndex = 5;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(284, 29);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(54, 20);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno:";
            // 
            // txtNombreAula
            // 
            this.txtNombreAula.Location = new System.Drawing.Point(200, 22);
            this.txtNombreAula.Name = "txtNombreAula";
            this.txtNombreAula.Size = new System.Drawing.Size(78, 26);
            this.txtNombreAula.TabIndex = 3;
            // 
            // lblNombreAula
            // 
            this.lblNombreAula.AutoSize = true;
            this.lblNombreAula.Location = new System.Drawing.Point(131, 25);
            this.lblNombreAula.Name = "lblNombreAula";
            this.lblNombreAula.Size = new System.Drawing.Size(69, 20);
            this.lblNombreAula.TabIndex = 2;
            this.lblNombreAula.Text = "Nombre:";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(57, 22);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(71, 26);
            this.txtAula.TabIndex = 1;
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Location = new System.Drawing.Point(7, 24);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(45, 20);
            this.lblAula.TabIndex = 0;
            this.lblAula.Text = "Aula:";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(507, 151);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(64, 26);
            this.txtTurno.TabIndex = 5;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(17, 230);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(341, 20);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.Text = "Cantidad de cursos y profesores despachados:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(233, 195);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 28);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblProfeCobraMas
            // 
            this.lblProfeCobraMas.AutoSize = true;
            this.lblProfeCobraMas.Location = new System.Drawing.Point(19, 261);
            this.lblProfeCobraMas.Name = "lblProfeCobraMas";
            this.lblProfeCobraMas.Size = new System.Drawing.Size(266, 20);
            this.lblProfeCobraMas.TabIndex = 5;
            this.lblProfeCobraMas.Text = "Nombre del profesor que cobra mas:";
            // 
            // lblNProfeCobraMas
            // 
            this.lblNProfeCobraMas.AutoSize = true;
            this.lblNProfeCobraMas.Location = new System.Drawing.Point(281, 261);
            this.lblNProfeCobraMas.Name = "lblNProfeCobraMas";
            this.lblNProfeCobraMas.Size = new System.Drawing.Size(117, 20);
            this.lblNProfeCobraMas.TabIndex = 6;
            this.lblNProfeCobraMas.Text = "____________";
            // 
            // lblSueldoMayor
            // 
            this.lblSueldoMayor.AutoSize = true;
            this.lblSueldoMayor.Location = new System.Drawing.Point(23, 289);
            this.lblSueldoMayor.Name = "lblSueldoMayor";
            this.lblSueldoMayor.Size = new System.Drawing.Size(123, 20);
            this.lblSueldoMayor.TabIndex = 7;
            this.lblSueldoMayor.Text = "Sueldo mayor: $";
            // 
            // lblCRegistros
            // 
            this.lblCRegistros.AutoSize = true;
            this.lblCRegistros.Location = new System.Drawing.Point(353, 231);
            this.lblCRegistros.Name = "lblCRegistros";
            this.lblCRegistros.Size = new System.Drawing.Size(18, 20);
            this.lblCRegistros.TabIndex = 3;
            this.lblCRegistros.Text = "0";
            // 
            // lblCSueldoMayor
            // 
            this.lblCSueldoMayor.AutoSize = true;
            this.lblCSueldoMayor.Location = new System.Drawing.Point(140, 289);
            this.lblCSueldoMayor.Name = "lblCSueldoMayor";
            this.lblCSueldoMayor.Size = new System.Drawing.Size(40, 20);
            this.lblCSueldoMayor.TabIndex = 8;
            this.lblCSueldoMayor.Text = "0.00";
            // 
            // lblCursoDeMayorSueldo
            // 
            this.lblCursoDeMayorSueldo.AutoSize = true;
            this.lblCursoDeMayorSueldo.Location = new System.Drawing.Point(19, 321);
            this.lblCursoDeMayorSueldo.Name = "lblCursoDeMayorSueldo";
            this.lblCursoDeMayorSueldo.Size = new System.Drawing.Size(283, 20);
            this.lblCursoDeMayorSueldo.TabIndex = 9;
            this.lblCursoDeMayorSueldo.Text = "Curso en donde el profesor cobra mas:";
            // 
            // lblNCursoDeMayorSueldo
            // 
            this.lblNCursoDeMayorSueldo.AutoSize = true;
            this.lblNCursoDeMayorSueldo.Location = new System.Drawing.Point(300, 321);
            this.lblNCursoDeMayorSueldo.Name = "lblNCursoDeMayorSueldo";
            this.lblNCursoDeMayorSueldo.Size = new System.Drawing.Size(117, 20);
            this.lblNCursoDeMayorSueldo.TabIndex = 10;
            this.lblNCursoDeMayorSueldo.Text = "____________";
            // 
            // lblProfeM
            // 
            this.lblProfeM.AutoSize = true;
            this.lblProfeM.Location = new System.Drawing.Point(404, 261);
            this.lblProfeM.Name = "lblProfeM";
            this.lblProfeM.Size = new System.Drawing.Size(163, 20);
            this.lblProfeM.TabIndex = 12;
            this.lblProfeM.Text = "Profesor@s hombres:";
            // 
            // lblCProfeM
            // 
            this.lblCProfeM.AutoSize = true;
            this.lblCProfeM.Location = new System.Drawing.Point(563, 262);
            this.lblCProfeM.Name = "lblCProfeM";
            this.lblCProfeM.Size = new System.Drawing.Size(18, 20);
            this.lblCProfeM.TabIndex = 13;
            this.lblCProfeM.Text = "0";
            // 
            // lblCProfeF
            // 
            this.lblCProfeF.AutoSize = true;
            this.lblCProfeF.Location = new System.Drawing.Point(554, 290);
            this.lblCProfeF.Name = "lblCProfeF";
            this.lblCProfeF.Size = new System.Drawing.Size(18, 20);
            this.lblCProfeF.TabIndex = 15;
            this.lblCProfeF.Text = "0";
            // 
            // lblProfeF
            // 
            this.lblProfeF.AutoSize = true;
            this.lblProfeF.Location = new System.Drawing.Point(404, 289);
            this.lblProfeF.Name = "lblProfeF";
            this.lblProfeF.Size = new System.Drawing.Size(157, 20);
            this.lblProfeF.TabIndex = 14;
            this.lblProfeF.Text = "Profesor@s mujeres:";
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 355);
            this.Controls.Add(this.lblCProfeF);
            this.Controls.Add(this.lblProfeF);
            this.Controls.Add(this.lblCProfeM);
            this.Controls.Add(this.lblProfeM);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.lblNCursoDeMayorSueldo);
            this.Controls.Add(this.lblCursoDeMayorSueldo);
            this.Controls.Add(this.lblCSueldoMayor);
            this.Controls.Add(this.lblSueldoMayor);
            this.Controls.Add(this.lblNProfeCobraMas);
            this.Controls.Add(this.lblProfeCobraMas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblCRegistros);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.grpCurso);
            this.Controls.Add(this.grpDocente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCursos";
            this.Text = "Cursos, profesores y sueldos";
            this.grpDocente.ResumeLayout(false);
            this.grpDocente.PerformLayout();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.grpCurso.ResumeLayout(false);
            this.grpCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDocente;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.GroupBox grpCurso;
        private System.Windows.Forms.Label lblNombreAula;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtNombreAula;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblProfeCobraMas;
        private System.Windows.Forms.Label lblNProfeCobraMas;
        private System.Windows.Forms.Label lblSueldoMayor;
        private System.Windows.Forms.Label lblCRegistros;
        private System.Windows.Forms.Label lblCSueldoMayor;
        private System.Windows.Forms.Label lblCursoDeMayorSueldo;
        private System.Windows.Forms.Label lblNCursoDeMayorSueldo;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblProfeM;
        private System.Windows.Forms.Label lblCProfeM;
        private System.Windows.Forms.Label lblCProfeF;
        private System.Windows.Forms.Label lblProfeF;


    }
}

