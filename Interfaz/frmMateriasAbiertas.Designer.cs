
namespace Interfaz
{
    partial class frmMateriasAbiertas
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
            this.dgvMateriasAbiertas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.CodigoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAbiertas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Materias Abiertas disponibles para el periodo y Año actual:";
            // 
            // dgvMateriasAbiertas
            // 
            this.dgvMateriasAbiertas.AllowUserToAddRows = false;
            this.dgvMateriasAbiertas.AllowUserToDeleteRows = false;
            this.dgvMateriasAbiertas.AllowUserToResizeColumns = false;
            this.dgvMateriasAbiertas.AllowUserToResizeRows = false;
            this.dgvMateriasAbiertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriasAbiertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NombreMateria,
            this.Dia,
            this.HoraInicio,
            this.HoraFin,
            this.CodProfesor,
            this.CodAula});
            this.dgvMateriasAbiertas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMateriasAbiertas.Location = new System.Drawing.Point(12, 76);
            this.dgvMateriasAbiertas.MultiSelect = false;
            this.dgvMateriasAbiertas.Name = "dgvMateriasAbiertas";
            this.dgvMateriasAbiertas.RowTemplate.Height = 25;
            this.dgvMateriasAbiertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriasAbiertas.Size = new System.Drawing.Size(703, 380);
            this.dgvMateriasAbiertas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoMateria";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Materia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // NombreMateria
            // 
            this.NombreMateria.DataPropertyName = "NombreMateria";
            this.NombreMateria.HeaderText = "Nombre Materia";
            this.NombreMateria.Name = "NombreMateria";
            this.NombreMateria.Width = 250;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "Dia";
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.Width = 50;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 80;
            // 
            // HoraFin
            // 
            this.HoraFin.DataPropertyName = "HoraFin";
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 80;
            // 
            // CodProfesor
            // 
            this.CodProfesor.DataPropertyName = "CodigoProfesor";
            this.CodProfesor.HeaderText = "Cód. Profesor";
            this.CodProfesor.Name = "CodProfesor";
            this.CodProfesor.Width = 75;
            // 
            // CodAula
            // 
            this.CodAula.DataPropertyName = "CodigoAula";
            this.CodAula.HeaderText = "Cód. Aula";
            this.CodAula.Name = "CodAula";
            this.CodAula.Width = 50;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(496, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(609, 462);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 42);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // CodigoMateria
            // 
            this.CodigoMateria.DataPropertyName = "CodigoMateria";
            this.CodigoMateria.HeaderText = "Código Materia";
            this.CodigoMateria.Name = "CodigoMateria";
            this.CodigoMateria.Width = 75;
            // 
            // frmMateriasAbiertas
            // 
            this.AcceptButton = this.btnActualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(728, 516);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvMateriasAbiertas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "frmMateriasAbiertas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Materias Abiertas Disponibles";
            this.Load += new System.EventHandler(this.frmMateriasAbiertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriasAbiertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMateriasAbiertas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodAula;
    }
}