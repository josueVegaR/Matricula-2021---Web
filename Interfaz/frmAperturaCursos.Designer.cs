
namespace Interfaz
{
    partial class frmAperturaCursos
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
            this.grbInfoMaterias = new System.Windows.Forms.GroupBox();
            this.txtCodMateriaCarrera = new System.Windows.Forms.TextBox();
            this.nmrPeriodo = new System.Windows.Forms.NumericUpDown();
            this.nmrCupo = new System.Windows.Forms.NumericUpDown();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.txtCodMateria = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.grbProfesor = new System.Windows.Forms.GroupBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.txtCodigoProfesor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbGrupoAula = new System.Windows.Forms.GroupBox();
            this.txtCodAula = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTipoAula = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumeroAula = new System.Windows.Forms.TextBox();
            this.btnBuscarAula = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.grbHorarios = new System.Windows.Forms.GroupBox();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboDiaHorario = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAbrirCurso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerMateriasAbiertas = new System.Windows.Forms.Button();
            this.grbInfoMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCupo)).BeginInit();
            this.grbProfesor.SuspendLayout();
            this.grbGrupoAula.SuspendLayout();
            this.grbHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoMaterias
            // 
            this.grbInfoMaterias.Controls.Add(this.txtCodMateriaCarrera);
            this.grbInfoMaterias.Controls.Add(this.nmrPeriodo);
            this.grbInfoMaterias.Controls.Add(this.nmrCupo);
            this.grbInfoMaterias.Controls.Add(this.txtCosto);
            this.grbInfoMaterias.Controls.Add(this.cboAnio);
            this.grbInfoMaterias.Controls.Add(this.btnBuscarMateria);
            this.grbInfoMaterias.Controls.Add(this.txtNombreCarrera);
            this.grbInfoMaterias.Controls.Add(this.label21);
            this.grbInfoMaterias.Controls.Add(this.txtCreditos);
            this.grbInfoMaterias.Controls.Add(this.txtCodMateria);
            this.grbInfoMaterias.Controls.Add(this.txtNombreMateria);
            this.grbInfoMaterias.Controls.Add(this.label5);
            this.grbInfoMaterias.Controls.Add(this.label11);
            this.grbInfoMaterias.Controls.Add(this.label4);
            this.grbInfoMaterias.Controls.Add(this.label3);
            this.grbInfoMaterias.Controls.Add(this.label2);
            this.grbInfoMaterias.Controls.Add(this.label10);
            this.grbInfoMaterias.Controls.Add(this.label9);
            this.grbInfoMaterias.Controls.Add(this.label12);
            this.grbInfoMaterias.Controls.Add(this.txtGrupo);
            this.grbInfoMaterias.Location = new System.Drawing.Point(12, 12);
            this.grbInfoMaterias.Name = "grbInfoMaterias";
            this.grbInfoMaterias.Size = new System.Drawing.Size(660, 310);
            this.grbInfoMaterias.TabIndex = 0;
            this.grbInfoMaterias.TabStop = false;
            this.grbInfoMaterias.Text = "Información de la Materia y el Grupo";
            // 
            // txtCodMateriaCarrera
            // 
            this.txtCodMateriaCarrera.Location = new System.Drawing.Point(409, 39);
            this.txtCodMateriaCarrera.Name = "txtCodMateriaCarrera";
            this.txtCodMateriaCarrera.ReadOnly = true;
            this.txtCodMateriaCarrera.Size = new System.Drawing.Size(100, 25);
            this.txtCodMateriaCarrera.TabIndex = 17;
            this.txtCodMateriaCarrera.Visible = false;
            // 
            // nmrPeriodo
            // 
            this.nmrPeriodo.Location = new System.Drawing.Point(427, 90);
            this.nmrPeriodo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPeriodo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrPeriodo.Name = "nmrPeriodo";
            this.nmrPeriodo.Size = new System.Drawing.Size(68, 25);
            this.nmrPeriodo.TabIndex = 2;
            this.nmrPeriodo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrCupo
            // 
            this.nmrCupo.Location = new System.Drawing.Point(264, 91);
            this.nmrCupo.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmrCupo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCupo.Name = "nmrCupo";
            this.nmrCupo.Size = new System.Drawing.Size(68, 25);
            this.nmrCupo.TabIndex = 1;
            this.nmrCupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(76, 90);
            this.txtCosto.MaxLength = 5;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(104, 25);
            this.txtCosto.TabIndex = 0;
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Items.AddRange(new object[] {
            "2022"});
            this.cboAnio.Location = new System.Drawing.Point(572, 89);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(63, 25);
            this.cboAnio.TabIndex = 3;
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Location = new System.Drawing.Point(516, 271);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(138, 33);
            this.btnBuscarMateria.TabIndex = 4;
            this.btnBuscarMateria.Text = "Buscar Materia";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            this.btnBuscarMateria.Click += new System.EventHandler(this.btnBuscarMateria_Click);
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(145, 231);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.ReadOnly = true;
            this.txtNombreCarrera.Size = new System.Drawing.Size(364, 25);
            this.txtNombreCarrera.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(515, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 19);
            this.label21.TabIndex = 16;
            this.label21.Text = "Año:";
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(441, 139);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.ReadOnly = true;
            this.txtCreditos.Size = new System.Drawing.Size(68, 25);
            this.txtCreditos.TabIndex = 7;
            // 
            // txtCodMateria
            // 
            this.txtCodMateria.Location = new System.Drawing.Point(280, 139);
            this.txtCodMateria.Name = "txtCodMateria";
            this.txtCodMateria.ReadOnly = true;
            this.txtCodMateria.Size = new System.Drawing.Size(68, 25);
            this.txtCodMateria.TabIndex = 6;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(145, 182);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.ReadOnly = true;
            this.txtNombreMateria.Size = new System.Drawing.Size(364, 25);
            this.txtNombreMateria.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Carrera:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Créditos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Materia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cupo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Grupo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Periodo:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(572, 39);
            this.txtGrupo.MaxLength = 2;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.ReadOnly = true;
            this.txtGrupo.Size = new System.Drawing.Size(63, 25);
            this.txtGrupo.TabIndex = 2;
            this.txtGrupo.Text = "1";
            this.txtGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupo_KeyPress);
            // 
            // grbProfesor
            // 
            this.grbProfesor.Controls.Add(this.txtIdentificacion);
            this.grbProfesor.Controls.Add(this.label19);
            this.grbProfesor.Controls.Add(this.txtNombreProfesor);
            this.grbProfesor.Controls.Add(this.btnBuscarProfesor);
            this.grbProfesor.Controls.Add(this.txtCodigoProfesor);
            this.grbProfesor.Controls.Add(this.label8);
            this.grbProfesor.Controls.Add(this.label7);
            this.grbProfesor.Controls.Add(this.label6);
            this.grbProfesor.Location = new System.Drawing.Point(12, 328);
            this.grbProfesor.Name = "grbProfesor";
            this.grbProfesor.Size = new System.Drawing.Size(660, 239);
            this.grbProfesor.TabIndex = 1;
            this.grbProfesor.TabStop = false;
            this.grbProfesor.Text = "Información del Profesor";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(501, 84);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(119, 25);
            this.txtIdentificacion.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(403, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 19);
            this.label19.TabIndex = 7;
            this.label19.Text = "Identificación:";
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Location = new System.Drawing.Point(240, 148);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.ReadOnly = true;
            this.txtNombreProfesor.Size = new System.Drawing.Size(268, 25);
            this.txtNombreProfesor.TabIndex = 6;
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Location = new System.Drawing.Point(520, 200);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(134, 33);
            this.btnBuscarProfesor.TabIndex = 6;
            this.btnBuscarProfesor.Text = "Buscar Profesor";
            this.btnBuscarProfesor.UseVisualStyleBackColor = true;
            this.btnBuscarProfesor.Click += new System.EventHandler(this.btnBuscarProfesor_Click);
            // 
            // txtCodigoProfesor
            // 
            this.txtCodigoProfesor.Location = new System.Drawing.Point(240, 84);
            this.txtCodigoProfesor.Name = "txtCodigoProfesor";
            this.txtCodigoProfesor.ReadOnly = true;
            this.txtCodigoProfesor.Size = new System.Drawing.Size(70, 25);
            this.txtCodigoProfesor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Código Profesor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre Profesor(a):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccione un Profesor(a) para el curso.";
            // 
            // grbGrupoAula
            // 
            this.grbGrupoAula.Controls.Add(this.txtCodAula);
            this.grbGrupoAula.Controls.Add(this.txtCapacidad);
            this.grbGrupoAula.Controls.Add(this.label18);
            this.grbGrupoAula.Controls.Add(this.txtTipoAula);
            this.grbGrupoAula.Controls.Add(this.label14);
            this.grbGrupoAula.Controls.Add(this.txtNumeroAula);
            this.grbGrupoAula.Controls.Add(this.btnBuscarAula);
            this.grbGrupoAula.Controls.Add(this.label13);
            this.grbGrupoAula.Location = new System.Drawing.Point(678, 12);
            this.grbGrupoAula.Name = "grbGrupoAula";
            this.grbGrupoAula.Size = new System.Drawing.Size(331, 187);
            this.grbGrupoAula.TabIndex = 2;
            this.grbGrupoAula.TabStop = false;
            this.grbGrupoAula.Text = "Información del Aula";
            // 
            // txtCodAula
            // 
            this.txtCodAula.Location = new System.Drawing.Point(30, 150);
            this.txtCodAula.Name = "txtCodAula";
            this.txtCodAula.ReadOnly = true;
            this.txtCodAula.Size = new System.Drawing.Size(100, 25);
            this.txtCodAula.TabIndex = 18;
            this.txtCodAula.Visible = false;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(255, 42);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.ReadOnly = true;
            this.txtCapacidad.Size = new System.Drawing.Size(63, 25);
            this.txtCapacidad.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(174, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 19);
            this.label18.TabIndex = 14;
            this.label18.Text = "Capacidad:";
            // 
            // txtTipoAula
            // 
            this.txtTipoAula.Location = new System.Drawing.Point(93, 101);
            this.txtTipoAula.Name = "txtTipoAula";
            this.txtTipoAula.ReadOnly = true;
            this.txtTipoAula.Size = new System.Drawing.Size(225, 25);
            this.txtTipoAula.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "Tipo Aula:";
            // 
            // txtNumeroAula
            // 
            this.txtNumeroAula.Location = new System.Drawing.Point(93, 42);
            this.txtNumeroAula.Name = "txtNumeroAula";
            this.txtNumeroAula.ReadOnly = true;
            this.txtNumeroAula.Size = new System.Drawing.Size(63, 25);
            this.txtNumeroAula.TabIndex = 11;
            // 
            // btnBuscarAula
            // 
            this.btnBuscarAula.Location = new System.Drawing.Point(199, 150);
            this.btnBuscarAula.Name = "btnBuscarAula";
            this.btnBuscarAula.Size = new System.Drawing.Size(126, 31);
            this.btnBuscarAula.TabIndex = 5;
            this.btnBuscarAula.Text = "Buscar Aula";
            this.btnBuscarAula.UseVisualStyleBackColor = true;
            this.btnBuscarAula.Click += new System.EventHandler(this.btnBuscarAula_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "Núm. Aula:";
            // 
            // grbHorarios
            // 
            this.grbHorarios.Controls.Add(this.dgvHorarios);
            this.grbHorarios.Controls.Add(this.dtpHoraFin);
            this.grbHorarios.Controls.Add(this.dtpHoraInicio);
            this.grbHorarios.Controls.Add(this.btnAgregarHorario);
            this.grbHorarios.Controls.Add(this.label17);
            this.grbHorarios.Controls.Add(this.label16);
            this.grbHorarios.Controls.Add(this.cboDiaHorario);
            this.grbHorarios.Controls.Add(this.label15);
            this.grbHorarios.Location = new System.Drawing.Point(678, 205);
            this.grbHorarios.Name = "grbHorarios";
            this.grbHorarios.Size = new System.Drawing.Size(331, 362);
            this.grbHorarios.TabIndex = 3;
            this.grbHorarios.TabStop = false;
            this.grbHorarios.Text = "Horarios:";
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AllowUserToResizeColumns = false;
            this.dgvHorarios.AllowUserToResizeRows = false;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.HoraInicio,
            this.HoraFin});
            this.dgvHorarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHorarios.Location = new System.Drawing.Point(6, 123);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowTemplate.Height = 25;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(318, 188);
            this.dgvHorarios.TabIndex = 9;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "Dia";
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.Width = 75;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            // 
            // HoraFin
            // 
            this.HoraFin.DataPropertyName = "HoraFin";
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(271, 74);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(53, 25);
            this.dtpHoraFin.TabIndex = 9;
            this.dtpHoraFin.Value = new System.DateTime(2021, 10, 31, 9, 0, 0, 0);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(90, 74);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(53, 25);
            this.dtpHoraInicio.TabIndex = 8;
            this.dtpHoraInicio.Value = new System.DateTime(2021, 10, 31, 7, 0, 0, 0);
            this.dtpHoraInicio.ValueChanged += new System.EventHandler(this.dtpHoraInicio_ValueChanged);
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Image = global::Interfaz.Properties.Resources.outline_add_black_24dp;
            this.btnAgregarHorario.Location = new System.Drawing.Point(285, 317);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(39, 33);
            this.btnAgregarHorario.TabIndex = 10;
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            this.btnAgregarHorario.Click += new System.EventHandler(this.btnAgregarHorario_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(202, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Hora Fin:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Hora Inicio:";
            // 
            // cboDiaHorario
            // 
            this.cboDiaHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaHorario.FormattingEnabled = true;
            this.cboDiaHorario.Items.AddRange(new object[] {
            "L",
            "K",
            "M",
            "J",
            "V",
            "S"});
            this.cboDiaHorario.Location = new System.Drawing.Point(266, 25);
            this.cboDiaHorario.Name = "cboDiaHorario";
            this.cboDiaHorario.Size = new System.Drawing.Size(59, 25);
            this.cboDiaHorario.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(136, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Día de la Semana:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(814, 591);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 41);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAbrirCurso
            // 
            this.btnAbrirCurso.Location = new System.Drawing.Point(909, 591);
            this.btnAbrirCurso.Name = "btnAbrirCurso";
            this.btnAbrirCurso.Size = new System.Drawing.Size(101, 41);
            this.btnAbrirCurso.TabIndex = 14;
            this.btnAbrirCurso.Text = "Abrir Curso";
            this.btnAbrirCurso.UseVisualStyleBackColor = true;
            this.btnAbrirCurso.Click += new System.EventHandler(this.btnAbrirCurso_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(721, 591);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 41);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVerMateriasAbiertas
            // 
            this.btnVerMateriasAbiertas.Location = new System.Drawing.Point(549, 591);
            this.btnVerMateriasAbiertas.Name = "btnVerMateriasAbiertas";
            this.btnVerMateriasAbiertas.Size = new System.Drawing.Size(166, 41);
            this.btnVerMateriasAbiertas.TabIndex = 11;
            this.btnVerMateriasAbiertas.Text = "Ver Materias Abiertas";
            this.btnVerMateriasAbiertas.UseVisualStyleBackColor = true;
            this.btnVerMateriasAbiertas.Click += new System.EventHandler(this.btnVerMateriasAbiertas_Click);
            // 
            // frmAperturaCursos
            // 
            this.AcceptButton = this.btnAbrirCurso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1022, 644);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerMateriasAbiertas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAbrirCurso);
            this.Controls.Add(this.grbHorarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbGrupoAula);
            this.Controls.Add(this.grbProfesor);
            this.Controls.Add(this.grbInfoMaterias);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmAperturaCursos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apertura de Cursos";
            this.Load += new System.EventHandler(this.frmAperturaCursos_Load);
            this.grbInfoMaterias.ResumeLayout(false);
            this.grbInfoMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCupo)).EndInit();
            this.grbProfesor.ResumeLayout(false);
            this.grbProfesor.PerformLayout();
            this.grbGrupoAula.ResumeLayout(false);
            this.grbGrupoAula.PerformLayout();
            this.grbHorarios.ResumeLayout(false);
            this.grbHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoMaterias;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.TextBox txtCodMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbProfesor;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.TextBox txtCodigoProfesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbGrupoAula;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTipoAula;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumeroAula;
        private System.Windows.Forms.Button btnBuscarAula;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grbHorarios;
        private System.Windows.Forms.ComboBox cboDiaHorario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAbrirCurso;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnVerMateriasAbiertas;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.NumericUpDown nmrPeriodo;
        private System.Windows.Forms.NumericUpDown nmrCupo;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.TextBox txtCodMateriaCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.TextBox txtCodAula;
    }
}