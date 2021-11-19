
namespace Interfaz
{
    partial class frmBuscarMateria
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
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.CodigoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditosMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AllowUserToResizeColumns = false;
            this.dgvMaterias.AllowUserToResizeRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMateria,
            this.NombreMateria,
            this.CreditosMateria,
            this.NombreCarrera,
            this.CodigoCarrera});
            this.dgvMaterias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMaterias.Location = new System.Drawing.Point(12, 42);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.RowTemplate.Height = 25;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(868, 326);
            this.dgvMaterias.TabIndex = 0;
            this.dgvMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellDoubleClick);
            // 
            // CodigoMateria
            // 
            this.CodigoMateria.DataPropertyName = "CodMateriaCarrera";
            this.CodigoMateria.HeaderText = "Código Materia";
            this.CodigoMateria.Name = "CodigoMateria";
            this.CodigoMateria.Width = 75;
            // 
            // NombreMateria
            // 
            this.NombreMateria.DataPropertyName = "NombreMateria";
            this.NombreMateria.HeaderText = "Nombre Materia";
            this.NombreMateria.Name = "NombreMateria";
            this.NombreMateria.Width = 300;
            // 
            // CreditosMateria
            // 
            this.CreditosMateria.DataPropertyName = "CreditosMateria";
            this.CreditosMateria.HeaderText = "Créditos";
            this.CreditosMateria.Name = "CreditosMateria";
            this.CreditosMateria.Width = 75;
            // 
            // NombreCarrera
            // 
            this.NombreCarrera.DataPropertyName = "NombreCarrera";
            this.NombreCarrera.HeaderText = "Nombre Carrera";
            this.NombreCarrera.Name = "NombreCarrera";
            this.NombreCarrera.Width = 300;
            // 
            // CodigoCarrera
            // 
            this.CodigoCarrera.DataPropertyName = "CodigoCarrera";
            this.CodigoCarrera.HeaderText = "Código Carrera";
            this.CodigoCarrera.Name = "CodigoCarrera";
            this.CodigoCarrera.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione una materia o filtre por su nombre.";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(12, 375);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(176, 25);
            this.txtFiltrar.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(194, 374);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(98, 25);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(781, 373);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(99, 26);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(676, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 26);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBuscarMateria
            // 
            this.AcceptButton = this.btnSeleccionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(893, 412);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMaterias);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmBuscarMateria";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Materia";
            this.Load += new System.EventHandler(this.frmBuscarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditosMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCarrera;
    }
}