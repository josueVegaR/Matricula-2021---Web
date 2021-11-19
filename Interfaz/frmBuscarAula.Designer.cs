
namespace Interfaz
{
    partial class frmBuscarAula
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
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.CodigoAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un aula según su tipo.";
            // 
            // dgvAulas
            // 
            this.dgvAulas.AllowUserToAddRows = false;
            this.dgvAulas.AllowUserToDeleteRows = false;
            this.dgvAulas.AllowUserToResizeColumns = false;
            this.dgvAulas.AllowUserToResizeRows = false;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAula,
            this.TipoAula,
            this.NumeroAula,
            this.Capacidad});
            this.dgvAulas.Location = new System.Drawing.Point(12, 31);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.RowTemplate.Height = 25;
            this.dgvAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAulas.Size = new System.Drawing.Size(468, 284);
            this.dgvAulas.TabIndex = 0;
            this.dgvAulas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAulas_CellDoubleClick);
            // 
            // CodigoAula
            // 
            this.CodigoAula.DataPropertyName = "CodigoAula";
            this.CodigoAula.HeaderText = "Codigo Aula";
            this.CodigoAula.Name = "CodigoAula";
            this.CodigoAula.Width = 75;
            // 
            // TipoAula
            // 
            this.TipoAula.DataPropertyName = "TipoAula";
            this.TipoAula.HeaderText = "Tipo de Aula";
            this.TipoAula.Name = "TipoAula";
            this.TipoAula.Width = 150;
            // 
            // NumeroAula
            // 
            this.NumeroAula.DataPropertyName = "NumeroAula";
            this.NumeroAula.HeaderText = "Número de Aula";
            this.NumeroAula.Name = "NumeroAula";
            // 
            // Capacidad
            // 
            this.Capacidad.DataPropertyName = "Capacidad";
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(270, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 31);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(378, 321);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(102, 31);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarAula
            // 
            this.AcceptButton = this.btnSeleccionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(495, 364);
            this.ControlBox = false;
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvAulas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmBuscarAula";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Aula";
            this.Load += new System.EventHandler(this.frmBuscarAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}