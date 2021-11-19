
namespace Interfaz
{
    partial class frmVerProfesores
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
            this.dgvListaProfesores = new System.Windows.Forms.DataGridView();
            this.CodProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Profesores activos";
            // 
            // dgvListaProfesores
            // 
            this.dgvListaProfesores.AllowUserToAddRows = false;
            this.dgvListaProfesores.AllowUserToDeleteRows = false;
            this.dgvListaProfesores.AllowUserToResizeColumns = false;
            this.dgvListaProfesores.AllowUserToResizeRows = false;
            this.dgvListaProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProfesor,
            this.Identificacion,
            this.NombreProfesor,
            this.PrimerApellido,
            this.SegundoApellido,
            this.TelefonoProfesor,
            this.Correo});
            this.dgvListaProfesores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaProfesores.Location = new System.Drawing.Point(12, 59);
            this.dgvListaProfesores.Name = "dgvListaProfesores";
            this.dgvListaProfesores.RowTemplate.Height = 25;
            this.dgvListaProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProfesores.Size = new System.Drawing.Size(1044, 360);
            this.dgvListaProfesores.TabIndex = 0;
            // 
            // CodProfesor
            // 
            this.CodProfesor.DataPropertyName = "CodigoProfesor";
            this.CodProfesor.HeaderText = "Código Profesor";
            this.CodProfesor.Name = "CodProfesor";
            // 
            // Identificacion
            // 
            this.Identificacion.DataPropertyName = "IdProfesor";
            this.Identificacion.HeaderText = "Identificación";
            this.Identificacion.Name = "Identificacion";
            // 
            // NombreProfesor
            // 
            this.NombreProfesor.DataPropertyName = "NombreProfesor";
            this.NombreProfesor.HeaderText = "Nombre";
            this.NombreProfesor.Name = "NombreProfesor";
            this.NombreProfesor.Width = 175;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "Apellido1Profesor";
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.Width = 175;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "Apellido2Profesor";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.Width = 175;
            // 
            // TelefonoProfesor
            // 
            this.TelefonoProfesor.DataPropertyName = "TelefonoProfesor";
            this.TelefonoProfesor.HeaderText = "Teléfono";
            this.TelefonoProfesor.Name = "TelefonoProfesor";
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoProfesor";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Width = 175;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(795, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(928, 425);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(128, 44);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmVerProfesores
            // 
            this.AcceptButton = this.btnActualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1068, 481);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvListaProfesores);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "frmVerProfesores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Profesores";
            this.Load += new System.EventHandler(this.frmVerProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaProfesores;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
    }
}