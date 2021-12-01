using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace Interfaz
{
    public partial class frmAperturaCursos : Form
    {
        //Variables globales
        MateriasCarreras materiaCarrera;
        Aulas Aula;
        Profesor Profesor;
        MateriasAbiertas MateriaAbierta;
        Horarios Horario;
        bool nuevaMateriaAbierta = false;

        //Materia que almacena los valores del form
        MateriasAbiertas materiaAbierta = new MateriasAbiertas();

        //valor para guardar el código MC
        int codMateriaCarrera;

        //Valor para guarda el código del Aula
        int codigoAula;

        //Valor para guardar el código del Profesor
        int codigoProfesor;


        //crear la lista de horarios
        List<Horarios> ListaHorarios = new List<Horarios>();




        // Se crea una instancia de la clase Materias Abiertas, para guardar los valores del formulario:
        // Se crea la entidad:
        private MateriasAbiertas GenerarMateriaAbierta(bool disponible)
        {
            MateriasAbiertas materiaAbierta;
            if (nuevaMateriaAbierta == false)
            {
                materiaAbierta = MateriaAbierta;
            }
            else
            {
                materiaAbierta = new MateriasAbiertas();
            }
            // se verifican los campos requeridos de la tabla de Materias Abiertas:
            if ((txtCodMateria.Text != string.Empty) && (txtCapacidad.Text != string.Empty) && (txtGrupo.Text != string.Empty) && (txtCosto.Text != string.Empty) && (cboAnio.SelectedIndex != -1))
            {
                if (nmrCupo.Value <= 30 && nmrCupo.Value >= 1)
                {
                    if (nmrPeriodo.Value >= 1 && nmrPeriodo.Value <= 3)
                    {
                        materiaAbierta.CodMateriaCarrera.CodMateriaCarrera = int.Parse(txtCodMateria.Text);
                        materiaAbierta.CodigoAula.CodigoAula = int.Parse(txtCapacidad.Text);
                        materiaAbierta.Grupo = int.Parse(txtGrupo.Text);
                        materiaAbierta.Cupo = int.Parse(nmrCupo.Value.ToString());
                        materiaAbierta.Costo = double.Parse(txtCosto.Text);
                        materiaAbierta.Periodo = int.Parse(nmrPeriodo.Value.ToString());
                        materiaAbierta.Anio = int.Parse(cboAnio.SelectedItem.ToString());
                        if (txtCodigoProfesor.Text != string.Empty)
                        {
                            materiaAbierta.CodigoProfesor.CodigoProfesor = int.Parse(txtCodigoProfesor.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un periodo entre 1 y 3.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un cupo entre 1 y 30 estudiantes.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese la información de Materia y Aula para abrir el Curso.");

            }
            return materiaAbierta;
        }



        //Métodos del Form:

        //Limpiar el formulario:
        private void LimpiarFormulario()
        {
            txtCodMateriaCarrera.Text = string.Empty;
            txtGrupo.Text = "1";
            txtCosto.Text = string.Empty;
            nmrCupo.Value = 1;
            nmrPeriodo.Value = 1;
            cboAnio.SelectedIndex = -1;
            txtCodMateria.Text = string.Empty;
            txtCreditos.Text = string.Empty;
            txtNombreCarrera.Text = string.Empty;
            txtNombreMateria.Text = string.Empty;
            txtNumeroAula.Text = string.Empty;
            txtCapacidad.Text = string.Empty;
            txtTipoAula.Text = string.Empty;
            cboDiaHorario.SelectedIndex = -1;
            dtpHoraInicio.Value = DateTime.Today.AddHours(7);
            dtpHoraFin.Value = DateTime.Today.AddHours(9);
            txtCodigoProfesor.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtNombreProfesor.Text = string.Empty;
            ListaHorarios.Clear();
            DataSet DSHorarios = new DataSet();
            DSHorarios = LlenarDataSet(ListaHorarios);
            dgvHorarios.DataSource = DSHorarios;
            dgvHorarios.DataMember = DSHorarios.Tables[0].TableName;
            btnAbrirCurso.Enabled = true;
        }
        

        // --> Método para cargar la materia carrera seleccionada en el formulario:
        private void CargarMateriaCarrera(int codMateriaCarrera)
        {
            MateriasCarreras materiaCarrera = new MateriasCarreras();
            
            //la clase estática de Configuración es la que contiene el conection string.
            // su única función es guardar la cadena de conexión con la BD.
            LogicaMateriasCarreras logicaMC = new LogicaMateriasCarreras(Configuracion.getConnectionString);
            
            // se llama a la Lógica
            try
            {
                materiaCarrera = logicaMC.ObtenerMateriaCarrera(codMateriaCarrera);
                if (materiaCarrera != null)
                {
                    txtCodMateria.Text = materiaCarrera.Materia.CodigoMateria;
                    txtCreditos.Text = materiaCarrera.Materia.CreditosMateria.ToString();
                    txtNombreCarrera.Text = materiaCarrera.Carrera.NombreCarrera;
                    txtNombreMateria.Text = materiaCarrera.Materia.NombreMateria;
                    txtCodMateriaCarrera.Text = materiaCarrera.CodMateriaCarrera.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // --> Método para cargar el Aula seleccionada en el Formulario:
        private void ObtenerAula(int codigoAula)
        {
            Aulas Aula = new Aulas();

            //la clase estática de Configuración es la que contiene el conection string.
            // su única función es guardar la cadena de conexión con la BD.
            LogicaAulas logicaAulas = new LogicaAulas(Configuracion.getConnectionString);

            // se llama a la Lógica
            try
            {
                Aula = logicaAulas.ObtenerAula(codigoAula);
                if (Aula != null)
                {
                    txtCodAula.Text = Aula.CodigoAula.ToString();
                    txtNumeroAula.Text = Aula.NumeroAula.ToString();
                    txtCapacidad.Text = Aula.Capacidad.ToString();
                    txtTipoAula.Text = Aula.TipoAula;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // --> Método para cargar el(la) Profesor(a) seleccionado(a) en el Formulario:
        private void ObtenerProfesor(int codigoProfesor)
        {
            Profesor Profesor = new Profesor();

            //la clase estática de Configuración es la que contiene el conection string.
            // su única función es guardar la cadena de conexión con la BD.
            LogicaProfesores logicaProfesores = new LogicaProfesores(Configuracion.getConnectionString);

            // se llama a la Lógica
            try
            {
                Profesor =  logicaProfesores.ObtenerProfesor(codigoProfesor);
                if (Profesor != null)
                {
                    txtCodigoProfesor.Text = Profesor.CodigoProfesor.ToString();
                    txtNombreProfesor.Text = Profesor.Nombre + " "+Profesor.Apellido1+" "+Profesor.Apellido2;
                    txtIdentificacion.Text = Profesor.Identificacion;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public frmAperturaCursos()
        {
            InitializeComponent();
        }

        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            frmBuscarMateria formularioBuscarMateria = new frmBuscarMateria();
            //Evento Aceptar
            formularioBuscarMateria.Aceptar += new EventHandler(Aceptar);
            formularioBuscarMateria.ShowDialog();
        }


        // --> Método Aceptar del formulario de Buscar Materias Carreras:
        private void Aceptar(object codMC, EventArgs e)
        {
            try
            {
                codMateriaCarrera = (int)codMC;
                if (codMateriaCarrera != -1)
                {
                    CargarMateriaCarrera(codMateriaCarrera);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // --> Método Aceptar2 del formulario de buscar Aulas:
        private void Aceptar2(object codAula, EventArgs e)
        {
            try
            {
                codigoAula = (int)codAula;
                if (codigoAula != -1)
                {
                    //CargarMateriaCarrera(codMateriaCarrera);
                    ObtenerAula(codigoAula);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // --> Método Aceptar3 del formulario de buscar Profesores:
        private void Aceptar3(object codProfesor, EventArgs e)
        {
            try
            {
                codigoProfesor = (int)codProfesor;
                if (codigoProfesor != -1)
                {
                    ObtenerProfesor(codigoProfesor);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarAula_Click(object sender, EventArgs e)
        {
            frmBuscarAula formularioBuscarAula = new frmBuscarAula();
            // --> Evento Aceptar
            formularioBuscarAula.Aceptar2 += new EventHandler(Aceptar2);
            formularioBuscarAula.ShowDialog();
        }

        //Cerrar el form:
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            frmBuscarProfesor formularioBuscarProfesor = new frmBuscarProfesor();
            //Evento Aceptar
            formularioBuscarProfesor.Aceptar3 += new EventHandler(Aceptar3);
            formularioBuscarProfesor.ShowDialog();
        }

        private void txtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void frmAperturaCursos_Load(object sender, EventArgs e)
        {
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraInicio.Value = DateTime.Today.AddHours(7);
            dtpHoraFin.Value = DateTime.Today.AddHours(9);
            txtGrupo.Text = "1";
        }

        //private void cboCosto_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboCosto.SelectedIndex != -1)
        //    {
        //        if (cboCosto.SelectedItem.ToString() == "0")
        //        {
        //            lblTipoCurso.Text = "Curso Libre";
        //        }
        //        else if (cboCosto.SelectedItem.ToString() == "50000")
        //        {
        //            lblTipoCurso.Text = "Curso Carrera";
        //        }
        //        else
        //        {
        //            lblTipoCurso.Text = "Laboratorio";
        //        }
        //    }
        //}

        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpHoraFin.MinDate = dtpHoraInicio.Value.AddHours(2);
            dtpHoraFin.Value = dtpHoraInicio.Value.AddHours(2);
        }

        private void btnAbrirCurso_Click(object sender, EventArgs e)
        {
             //Se instancian la entidad y la lógica:
            MateriasAbiertas materiaAbierta = new MateriasAbiertas();
            LogicaMateriasAbiertas logicaMA = new LogicaMateriasAbiertas(Configuracion.getConnectionString);

            //Se instancian los horarios y la lógica:
            Horarios horario = new Horarios();
            LogicaHorarios logicaHorarios = new LogicaHorarios(Configuracion.getConnectionString);

            //instancia de profesores y AD
            Profesor profesor = new Profesor();
            LogicaProfesores logicaProfesores = new LogicaProfesores(Configuracion.getConnectionString);

            materiaAbierta.CodMateriaCarrera = new MateriasCarreras();
            // se verifican los campos requeridos de la tabla de Materias Abiertas:
            if ((txtCodMateria.Text != string.Empty) && (txtCapacidad.Text != string.Empty) && (txtGrupo.Text != string.Empty) && (txtCosto.Text != string.Empty) && (cboAnio.SelectedIndex != -1) && (txtNumeroAula.Text != string.Empty) && (dgvHorarios.RowCount > 0))
            {
                if (dgvHorarios.RowCount > 0)
                {
                    if (nmrCupo.Value <= 30 && nmrCupo.Value >= 1)
                    {
                        if (nmrPeriodo.Value >= 1 && nmrPeriodo.Value <= 3)
                        {
                            Aula = new Aulas();
                            Aula.Capacidad = int.Parse(txtCapacidad.Text);
                            if (Aula.Capacidad >= nmrCupo.Value)
                            {
                                materiaAbierta.CodMateriaCarrera.CodMateriaCarrera = int.Parse(txtCodMateriaCarrera.Text);
                                //materiaAbierta.CodigoProfesor.CodigoProfesor = int.Parse(txtCodigoProfesor.Text);
                                materiaAbierta.CodigoAula.CodigoAula = int.Parse(txtCodAula.Text);
                                materiaAbierta.Grupo = int.Parse(txtGrupo.Text);
                                materiaAbierta.Cupo = Convert.ToInt32(nmrCupo.Value);
                                materiaAbierta.Costo = double.Parse(txtCosto.Text);
                                materiaAbierta.Periodo = Convert.ToInt32(nmrPeriodo.Value);
                                materiaAbierta.Anio = int.Parse(cboAnio.SelectedItem.ToString());
                                //Se llama al método de la lógica con los valores cargados del formulario:
                                int codigoMateriaAbierta;
                                codigoMateriaAbierta = logicaMA.InsertarMateriaAbierta(materiaAbierta);
                                if (codigoMateriaAbierta < 1)
                                {
                                    MessageBox.Show("El curso no se pudo abrir.");
                                }
                                else
                                {
                                    MessageBox.Show("La Materia fué abierta con éxito.");

                                    //Ingresar método para insertar el horario:
                                    horario.CodMateriaAbierta.CodMateriaAbierta = codigoMateriaAbierta;
                                    horario.Dia = cboDiaHorario.Text;
                                    horario.HoraInicio = dtpHoraInicio.Value;
                                    horario.HoraFin = dtpHoraFin.Value;
                                    int filasAfectadas;
                                    filasAfectadas = logicaHorarios.InsertarHorario(horario);
                                    if (filasAfectadas == 1)
                                    {
                                        MessageBox.Show("El horario se asignó correctamente.");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No fué posible agregar el horario. Agregue un horario en Mantenimientos.");
                                    }
                                }

                                //Método para asignar un profesor
                                profesor.CodigoProfesor = int.Parse(txtCodigoProfesor.Text);

                                int filas;
                                filas = logicaProfesores.AsignarProfesor(profesor, codigoMateriaAbierta);
                                if (filas == 1)
                                {
                                    MessageBox.Show("El Profesor se asignó correctamente.");
                                }
                                else
                                {
                                    MessageBox.Show("No fué posible agregar el Profesor. Agregue el Profesor en Mantenimientos.");
                                }
                                //Se deshabilita el botón de Abrir Curso:
                                btnAbrirCurso.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("La capacidad del aula no puede ser menor que el cupo del curso. Intente de nuevo.");
                                txtCapacidad.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un periodo entre 1 y 3.");
                            nmrPeriodo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un cupo entre 1 y 30 estudiantes.");
                        nmrCupo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos 1 horario para abrir el curso.");
                }
                
            }
            else
            {
                MessageBox.Show("Ingrese la información requerida para abrir el Curso.");
            }
        }

        private void btnVerMateriasAbiertas_Click(object sender, EventArgs e)
        {
            frmMateriasAbiertas frmMateriasAbiertas = new frmMateriasAbiertas();
            frmMateriasAbiertas.Show();
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {
            if (cboDiaHorario.SelectedIndex != -1)
            {
                if (dtpHoraInicio.Value >= DateTime.Today.AddHours(7))
                {
                    if (dtpHoraInicio.Value <= DateTime.Today.AddHours(20))
                    {
                        if (dtpHoraInicio.Value != dtpHoraFin.Value)
                        {
                            if (dtpHoraInicio.Value < dtpHoraFin.Value)
                            {
                                if (dtpHoraFin.Value <= DateTime.Today.AddHours(22))
                                {
                                    if (dtpHoraFin.Value >= DateTime.Today.AddHours(8))
                                    {
                                        Horario = new Horarios();
                                        Horario.Dia = cboDiaHorario.Text;
                                        Horario.HoraInicio = dtpHoraInicio.Value;
                                        Horario.HoraFin = dtpHoraFin.Value;
                                        ListaHorarios.Add(Horario);
                                        DataSet DSHorarios = new DataSet();
                                        DSHorarios = LlenarDataSet(ListaHorarios);
                                        dgvHorarios.DataSource = DSHorarios;
                                        dgvHorarios.DataMember = DSHorarios.Tables[0].TableName;
                                        btnAgregarHorario.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se puede asignar un curso con hora final menor a las 8:00 a.m.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se puede asignar una hora de salida mayor a las 10:00 p.m.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("La hora inicio no puede ser mayor a la hora fin.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las horas de inicio y fin no pueden ser iguales.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede asignar un horario inicial mayor a las 8:00 p.m.");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede asignar un horario inicial menor a las 7:00 a.m.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un día para el horario.");
            }
        }

        private DataSet LlenarDataSet(List<Horarios> listaHorarios)
        {
            DataSet DataSetHorarios = new DataSet();
            DataTable TablaHorarios = new DataTable();
            DataSetHorarios.Tables.Add(TablaHorarios);
            TablaHorarios.Columns.Add("Dia");
            TablaHorarios.Columns.Add("HoraInicio");
            TablaHorarios.Columns.Add("HoraFin");
            foreach(var item in listaHorarios)
            {
                TablaHorarios.Rows.Add(new object[] { item.Dia, item.HoraInicio, item.HoraFin });
            }
            return DataSetHorarios;
        }

    }

}
