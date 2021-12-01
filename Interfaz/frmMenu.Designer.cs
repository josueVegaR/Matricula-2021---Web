
namespace Interfaz
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tlsSistemaMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAperturaCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMantenimientoEstudiantes = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCrearEstudiante = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsMantenimientoProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCrearProfesor = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenuPrincipal
            // 
            this.mnuMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsSistemaMatricula,
            this.tlsMantenimientos,
            this.tlsAyuda});
            this.mnuMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuMenuPrincipal.Name = "mnuMenuPrincipal";
            this.mnuMenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuMenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuMenuPrincipal.TabIndex = 1;
            this.mnuMenuPrincipal.Text = "menuStrip1";
            // 
            // tlsSistemaMatricula
            // 
            this.tlsSistemaMatricula.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAperturaCursos,
            this.tlsMatricula,
            this.tlsSalir});
            this.tlsSistemaMatricula.Name = "tlsSistemaMatricula";
            this.tlsSistemaMatricula.Size = new System.Drawing.Size(129, 20);
            this.tlsSistemaMatricula.Text = "&Sistema de Matrícula";
            // 
            // tlsAperturaCursos
            // 
            this.tlsAperturaCursos.Name = "tlsAperturaCursos";
            this.tlsAperturaCursos.Size = new System.Drawing.Size(182, 22);
            this.tlsAperturaCursos.Text = "&Apertura de Cursos";
            this.tlsAperturaCursos.Click += new System.EventHandler(this.tlsAperturaCursos_Click);
            // 
            // tlsMatricula
            // 
            this.tlsMatricula.Name = "tlsMatricula";
            this.tlsMatricula.Size = new System.Drawing.Size(182, 22);
            this.tlsMatricula.Text = "Matrícula Estudiantil";
            this.tlsMatricula.Click += new System.EventHandler(this.tlsMatricula_Click);
            // 
            // tlsSalir
            // 
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(182, 22);
            this.tlsSalir.Text = "&Salir";
            this.tlsSalir.Click += new System.EventHandler(this.tlsSalir_Click);
            // 
            // tlsMantenimientos
            // 
            this.tlsMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsMantenimientoEstudiantes,
            this.tlsMantenimientoProfesores});
            this.tlsMantenimientos.Name = "tlsMantenimientos";
            this.tlsMantenimientos.Size = new System.Drawing.Size(106, 20);
            this.tlsMantenimientos.Text = "&Mantenimientos";
            // 
            // tlsMantenimientoEstudiantes
            // 
            this.tlsMantenimientoEstudiantes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCrearEstudiante});
            this.tlsMantenimientoEstudiantes.Name = "tlsMantenimientoEstudiantes";
            this.tlsMantenimientoEstudiantes.Size = new System.Drawing.Size(224, 22);
            this.tlsMantenimientoEstudiantes.Text = "Mantenimientos &Estudiantes";
            // 
            // tlsCrearEstudiante
            // 
            this.tlsCrearEstudiante.Name = "tlsCrearEstudiante";
            this.tlsCrearEstudiante.Size = new System.Drawing.Size(160, 22);
            this.tlsCrearEstudiante.Text = "Crear Estudiante";
            this.tlsCrearEstudiante.Click += new System.EventHandler(this.tlsCrearEstudiante_Click);
            // 
            // tlsMantenimientoProfesores
            // 
            this.tlsMantenimientoProfesores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCrearProfesor});
            this.tlsMantenimientoProfesores.Name = "tlsMantenimientoProfesores";
            this.tlsMantenimientoProfesores.Size = new System.Drawing.Size(224, 22);
            this.tlsMantenimientoProfesores.Text = "Mantenimientos &Profesores";
            // 
            // tlsCrearProfesor
            // 
            this.tlsCrearProfesor.Name = "tlsCrearProfesor";
            this.tlsCrearProfesor.Size = new System.Drawing.Size(149, 22);
            this.tlsCrearProfesor.Text = "Crear Profesor";
            this.tlsCrearProfesor.Click += new System.EventHandler(this.tlsCrearProfesor_Click);
            // 
            // tlsAyuda
            // 
            this.tlsAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAcercaDe});
            this.tlsAyuda.Name = "tlsAyuda";
            this.tlsAyuda.Size = new System.Drawing.Size(53, 20);
            this.tlsAyuda.Text = "&Ayuda";
            // 
            // tlsAcercaDe
            // 
            this.tlsAcercaDe.Name = "tlsAcercaDe";
            this.tlsAcercaDe.Size = new System.Drawing.Size(135, 22);
            this.tlsAcercaDe.Text = "Acerca &de...";
            this.tlsAcercaDe.Click += new System.EventHandler(this.tlsAcercaDe_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMenuPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMenuPrincipal;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Matrícula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMenuPrincipal.ResumeLayout(false);
            this.mnuMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tlsSistemaMatricula;
        private System.Windows.Forms.ToolStripMenuItem tlsAperturaCursos;
        private System.Windows.Forms.ToolStripMenuItem tlsSalir;
        private System.Windows.Forms.ToolStripMenuItem tlsAyuda;
        private System.Windows.Forms.ToolStripMenuItem tlsAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tlsMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tlsMantenimientoEstudiantes;
        private System.Windows.Forms.ToolStripMenuItem tlsCrearEstudiante;
        private System.Windows.Forms.ToolStripMenuItem tlsMantenimientoProfesores;
        private System.Windows.Forms.ToolStripMenuItem tlsCrearProfesor;
        private System.Windows.Forms.ToolStripMenuItem tlsMatricula;
    }
}

