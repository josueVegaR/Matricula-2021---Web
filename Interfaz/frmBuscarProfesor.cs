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
    public partial class frmBuscarProfesor : Form
    {
        //Creación del Evento Aceptar
        public event EventHandler Aceptar3;

        //Variable global int para guardar el código del Profesor
        int codigoProfesor = 0;

        // --> Método para Seleccionar
        private void Seleccionar()
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                codigoProfesor = Convert.ToInt32(dgvProfesores.SelectedRows[0].Cells[0].Value);
                //Se llama el evento Aceptar3:
                Aceptar3(codigoProfesor, null);
                //Se cierra el formulario:
                Close();
                //El valor se va a pasar en el otro formulario.
            }
        }

        //Función para cargar los Profesores:
        private void CargarListaDataSet(string condicion = "")
        {

            LogicaProfesores logicaProfesores = new LogicaProfesores(Configuracion.getConnectionString);
            DataSet DSProfesores;
            try
            {
                DSProfesores = logicaProfesores.ListarProfesores(condicion);
                if (DSProfesores.Tables[0].Rows.Count > 0)
                {
                    dgvProfesores.DataSource = DSProfesores;
                    dgvProfesores.DataMember = DSProfesores.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public frmBuscarProfesor()
        {
            InitializeComponent();
        }

        private void frmBuscarProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar3(-1, null);
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtFiltrar.Text))
                {
                    condicion = string.Format(" NombreProfesor LIKE '%{0}%'", txtFiltrar.Text.Trim());
                }
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string condicion = string.Empty;
                try
                {
                    if (!string.IsNullOrEmpty(txtFiltrar.Text))
                    {
                        condicion = string.Format(" NombreProfesor LIKE '%{0}%'", txtFiltrar.Text.Trim());
                    }
                    CargarListaDataSet(condicion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }
    }
}
