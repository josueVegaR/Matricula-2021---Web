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
    public partial class frmBuscarAula : Form
    {
        //Creación del Evento Aceptar
        public event EventHandler Aceptar2;

        //Variable global int para guardar el ID materia Carrera
        int codigoAula = 0;

        // --> Método para Seleccionar
        private void Seleccionar()
        {
            if (dgvAulas.SelectedRows.Count > 0)
            {
                codigoAula = Convert.ToInt32(dgvAulas.SelectedRows[0].Cells[0].Value);
                //Se llama el evento Aceptar2:
                Aceptar2(codigoAula, null);
                //Se cierra el formulario:
                Close();
                //El valor se va a pasar en el otro formulario.
            }
        }

        //Función para cargar las Aulas:
        private void CargarListaDataSet(string condicion = "")
        {

            LogicaAulas logicaAulas = new LogicaAulas(Configuracion.getConnectionString);
            DataSet DSAulas;
            try
            {
                DSAulas = logicaAulas.ListarAulas(condicion);
                if (DSAulas.Tables[0].Rows.Count > 0)
                {
                    dgvAulas.DataSource = DSAulas;
                    dgvAulas.DataMember = DSAulas.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public frmBuscarAula()
        {
            InitializeComponent();
        }

        private void frmBuscarAula_Load(object sender, EventArgs e)
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

        private void dgvAulas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar2(-1, null);
            Close();
        }
    }
}
