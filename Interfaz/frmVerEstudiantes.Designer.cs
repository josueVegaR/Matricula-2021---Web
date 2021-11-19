
namespace Interfaz
{
    partial class frmVerEstudiantes
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
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.Carne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Estudiantes activos.";
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.AllowUserToAddRows = false;
            this.dgvEstudiantes.AllowUserToDeleteRows = false;
            this.dgvEstudiantes.AllowUserToResizeColumns = false;
            this.dgvEstudiantes.AllowUserToResizeRows = false;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carne,
            this.Cedula,
            this.Nombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.Telefono,
            this.FechaIngreso});
            this.dgvEstudiantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEstudiantes.Location = new System.Drawing.Point(12, 60);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowTemplate.Height = 25;
            this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiantes.Size = new System.Drawing.Size(1053, 381);
            this.dgvEstudiantes.TabIndex = 0;
            // 
            // Carne
            // 
            this.Carne.DataPropertyName = "CarnetEstudiante";
            this.Carne.HeaderText = "Carné";
            this.Carne.Name = "Carne";
            this.Carne.Width = 80;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "IdEstudiante";
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 110;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreEstudiante";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "Apellido1Estudiante";
            this.PrimerApellido.HeaderText = "Primer Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.Width = 200;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "Apellido2Estudiante";
            this.SegundoApellido.HeaderText = "Segundo Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TelefonoEstudiante";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 110;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 110;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(807, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(939, 447);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 46);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmVerEstudiantes
            // 
            this.AcceptButton = this.btnActualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1079, 505);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "frmVerEstudiantes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Estudiantes";
            this.Load += new System.EventHandler(this.frmVerEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
    }
}