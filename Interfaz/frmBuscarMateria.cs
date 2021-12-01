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
    public partial class frmBuscarMateria : Form
    {

        //Creación del Evento Aceptar
        public event EventHandler Aceptar;

        //Variable global int para guardar el ID materia Carrera
        int codMateriaCarrera = 0;


        public frmBuscarMateria()
        {
            InitializeComponent();
        }

        private void Seleccionar()
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                codMateriaCarrera = (int)dgvMaterias.SelectedRows[0].Cells[0].Value;
                //Se llama el evento Aceptar:
                Aceptar(codMateriaCarrera, null);
                //Se cierra el formulario:
                Close();
                //El valor se va a pasar en el otro formulario.
            }
        }

        //Función para cargar las Materias Carreras:
        private void CargarListaDataSet(string condicion = "")
        {

            LogicaMateriasCarreras logicaMC = new LogicaMateriasCarreras(Configuracion.getConnectionString);
            DataSet DSMateriasCarreras;
            try
            {
                DSMateriasCarreras = logicaMC.ListarMateriasCarreras(condicion);
                if (DSMateriasCarreras.Tables[0].Rows.Count > 0)
                {
                    dgvMaterias.DataSource = DSMateriasCarreras;
                    dgvMaterias.DataMember = DSMateriasCarreras.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmBuscarMateria_Load(object sender, EventArgs e)
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtFiltrar.Text))
                {
                    condicion = string.Format("NOMBREMATERIA LIKE '%{0}%'", txtFiltrar.Text.Trim());
                }
                CargarListaDataSet(condicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }
    }
}
