
namespace Interfaz
{
    partial class frmCrearEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDEstudiante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoEstudiante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearEstudiante = new System.Windows.Forms.Button();
            this.grbInfoPersonal = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtxtOtrasSenias = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVerEstudiantes = new System.Windows.Forms.Button();
            this.btnLimpiarFormulario = new System.Windows.Forms.Button();
            this.grbInfoPersonal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la información necesaria para crear un nuevo estudiante.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(104, 35);
            this.txtNombreEstudiante.MaxLength = 25;
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(142, 25);
            this.txtNombreEstudiante.TabIndex = 0;
            this.txtNombreEstudiante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEstudiante_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Primer Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(377, 35);
            this.txtPrimerApellido.MaxLength = 20;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(142, 25);
            this.txtPrimerApellido.TabIndex = 1;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Ingreso:";
            // 
            // txtIDEstudiante
            // 
            this.txtIDEstudiante.Location = new System.Drawing.Point(104, 78);
            this.txtIDEstudiante.MaxLength = 10;
            this.txtIDEstudiante.Name = "txtIDEstudiante";
            this.txtIDEstudiante.Size = new System.Drawing.Size(111, 25);
            this.txtIDEstudiante.TabIndex = 3;
            this.txtIDEstudiante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDEstudiante_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Carné:";
            // 
            // txtCorreoEstudiante
            // 
            this.txtCorreoEstudiante.Location = new System.Drawing.Point(292, 78);
            this.txtCorreoEstudiante.MaxLength = 80;
            this.txtCorreoEstudiante.Name = "txtCorreoEstudiante";
            this.txtCorreoEstudiante.Size = new System.Drawing.Size(159, 25);
            this.txtCorreoEstudiante.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(668, 35);
            this.txtSegundoApellido.MaxLength = 20;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(142, 25);
            this.txtSegundoApellido.TabIndex = 2;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoApellido_KeyPress);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(725, 55);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(107, 25);
            this.dtpFechaIngreso.TabIndex = 24;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(214, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 39);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearEstudiante
            // 
            this.btnCrearEstudiante.Location = new System.Drawing.Point(682, 512);
            this.btnCrearEstudiante.Name = "btnCrearEstudiante";
            this.btnCrearEstudiante.Size = new System.Drawing.Size(150, 39);
            this.btnCrearEstudiante.TabIndex = 15;
            this.btnCrearEstudiante.Text = "Crear Estudiante";
            this.btnCrearEstudiante.UseVisualStyleBackColor = true;
            this.btnCrearEstudiante.Click += new System.EventHandler(this.btnCrearEstudiante_Click);
            // 
            // grbInfoPersonal
            // 
            this.grbInfoPersonal.Controls.Add(this.txtTelefono);
            this.grbInfoPersonal.Controls.Add(this.label14);
            this.grbInfoPersonal.Controls.Add(this.txtCarne);
            this.grbInfoPersonal.Controls.Add(this.label17);
            this.grbInfoPersonal.Controls.Add(this.label2);
            this.grbInfoPersonal.Controls.Add(this.txtNombreEstudiante);
            this.grbInfoPersonal.Controls.Add(this.label3);
            this.grbInfoPersonal.Controls.Add(this.label4);
            this.grbInfoPersonal.Controls.Add(this.txtPrimerApellido);
            this.grbInfoPersonal.Controls.Add(this.txtSegundoApellido);
            this.grbInfoPersonal.Controls.Add(this.label7);
            this.grbInfoPersonal.Controls.Add(this.txtIDEstudiante);
            this.grbInfoPersonal.Controls.Add(this.txtCorreoEstudiante);
            this.grbInfoPersonal.Controls.Add(this.label6);
            this.grbInfoPersonal.Location = new System.Drawing.Point(12, 83);
            this.grbInfoPersonal.Name = "grbInfoPersonal";
            this.grbInfoPersonal.Size = new System.Drawing.Size(820, 123);
            this.grbInfoPersonal.TabIndex = 31;
            this.grbInfoPersonal.TabStop = false;
            this.grbInfoPersonal.Text = "Información Personal";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(535, 78);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(111, 25);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(466, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "Teléfono:";
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(713, 78);
            this.txtCarne.MaxLength = 6;
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(97, 25);
            this.txtCarne.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(232, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 19);
            this.label17.TabIndex = 13;
            this.label17.Text = "Correo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(725, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "* Campos Requeridos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rtxtOtrasSenias);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDistrito);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCanton);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboProvincia);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 233);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección y Otras Señas";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(713, 110);
            this.txtDescuento.MaxLength = 2;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(101, 25);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(589, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Descuento:";
            // 
            // rtxtOtrasSenias
            // 
            this.rtxtOtrasSenias.Location = new System.Drawing.Point(97, 110);
            this.rtxtOtrasSenias.MaxLength = 200;
            this.rtxtOtrasSenias.Name = "rtxtOtrasSenias";
            this.rtxtOtrasSenias.Size = new System.Drawing.Size(446, 117);
            this.rtxtOtrasSenias.TabIndex = 10;
            this.rtxtOtrasSenias.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Otras Señas:";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(672, 45);
            this.txtDistrito.MaxLength = 25;
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(142, 25);
            this.txtDistrito.TabIndex = 9;
            this.txtDistrito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistrito_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Distrito:";
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(386, 45);
            this.txtCanton.MaxLength = 25;
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(142, 25);
            this.txtCanton.TabIndex = 8;
            this.txtCanton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanton_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cantón:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Items.AddRange(new object[] {
            "San José",
            "Alajuela",
            "Heredia",
            "Cartago",
            "Guanacaste",
            "Puntarenas",
            "Limón"});
            this.cboProvincia.Location = new System.Drawing.Point(97, 45);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(136, 25);
            this.cboProvincia.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Provincia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(708, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "* Campos No Requeridos";
            // 
            // btnVerEstudiantes
            // 
            this.btnVerEstudiantes.Location = new System.Drawing.Point(370, 512);
            this.btnVerEstudiantes.Name = "btnVerEstudiantes";
            this.btnVerEstudiantes.Size = new System.Drawing.Size(150, 39);
            this.btnVerEstudiantes.TabIndex = 13;
            this.btnVerEstudiantes.Text = "Ver Estudiantes";
            this.btnVerEstudiantes.UseVisualStyleBackColor = true;
            this.btnVerEstudiantes.Click += new System.EventHandler(this.btnVerEstudiantes_Click);
            // 
            // btnLimpiarFormulario
            // 
            this.btnLimpiarFormulario.Location = new System.Drawing.Point(526, 512);
            this.btnLimpiarFormulario.Name = "btnLimpiarFormulario";
            this.btnLimpiarFormulario.Size = new System.Drawing.Size(150, 39);
            this.btnLimpiarFormulario.TabIndex = 14;
            this.btnLimpiarFormulario.Text = "Limpiar Formulario";
            this.btnLimpiarFormulario.UseVisualStyleBackColor = true;
            this.btnLimpiarFormulario.Click += new System.EventHandler(this.btnLimpiarFormulario_Click);
            // 
            // frmCrearEstudiante
            // 
            this.AcceptButton = this.btnCrearEstudiante;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(842, 563);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiarFormulario);
            this.Controls.Add(this.btnVerEstudiantes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.grbInfoPersonal);
            this.Controls.Add(this.btnCrearEstudiante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmCrearEstudiante";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Estudiante";
            this.Load += new System.EventHandler(this.frmCrearEstudiante_Load);
            this.grbInfoPersonal.ResumeLayout(false);
            this.grbInfoPersonal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDEstudiante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoEstudiante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearEstudiante;
        private System.Windows.Forms.GroupBox grbInfoPersonal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtxtOtrasSenias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVerEstudiantes;
        private System.Windows.Forms.Button btnLimpiarFormulario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label14;
    }
}