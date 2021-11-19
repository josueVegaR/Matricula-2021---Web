
namespace Interfaz
{
    partial class frmCrearProfesor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCrearProfesor = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerProfesores = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los valores necesarios para la creación de un profesor nuevo.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSegundoApellido);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPrimerApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 133);
            this.panel1.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(514, 81);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(101, 25);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(299, 81);
            this.txtCorreo.MaxLength = 25;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(122, 25);
            this.txtCorreo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(115, 81);
            this.txtIdentificacion.MaxLength = 15;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(101, 25);
            this.txtIdentificacion.TabIndex = 3;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Identificación:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(599, 23);
            this.txtSegundoApellido.MaxLength = 20;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(122, 25);
            this.txtSegundoApellido.TabIndex = 2;
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoApellido_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(338, 23);
            this.txtPrimerApellido.MaxLength = 20;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(122, 25);
            this.txtPrimerApellido.TabIndex = 1;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 23);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 25);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnCrearProfesor
            // 
            this.btnCrearProfesor.Location = new System.Drawing.Point(613, 196);
            this.btnCrearProfesor.Name = "btnCrearProfesor";
            this.btnCrearProfesor.Size = new System.Drawing.Size(140, 45);
            this.btnCrearProfesor.TabIndex = 9;
            this.btnCrearProfesor.Text = "Crear Profesor";
            this.btnCrearProfesor.UseVisualStyleBackColor = true;
            this.btnCrearProfesor.Click += new System.EventHandler(this.btnCrearProfesor_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(467, 196);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 45);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVerProfesores
            // 
            this.btnVerProfesores.Location = new System.Drawing.Point(321, 195);
            this.btnVerProfesores.Name = "btnVerProfesores";
            this.btnVerProfesores.Size = new System.Drawing.Size(140, 46);
            this.btnVerProfesores.TabIndex = 7;
            this.btnVerProfesores.Text = "Ver Profesores";
            this.btnVerProfesores.UseVisualStyleBackColor = true;
            this.btnVerProfesores.Click += new System.EventHandler(this.btnVerProfesores_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 46);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCrearProfesor
            // 
            this.AcceptButton = this.btnCrearProfesor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(765, 252);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVerProfesores);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrearProfesor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "frmCrearProfesor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Profesor";
            this.Load += new System.EventHandler(this.frmCrearProfesor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCrearProfesor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVerProfesores;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
    }
}