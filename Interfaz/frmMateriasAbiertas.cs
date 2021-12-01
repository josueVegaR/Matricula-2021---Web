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
    public partial class frmMateriasAbiertas : Form
    {
        public frmMateriasAbiertas()
        {
            InitializeComponent();
        }

        private void frmMateriasAbiertas_Load(object sender, EventArgs e)
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

        //Función para cargar las Materias Abiertas:
        private void CargarListaDataSet(string condicion = "")
        {

            LogicaMateriasAbiertas logicaMA = new LogicaMateriasAbiertas(Configuracion.getConnectionString);
            DataSet DSMateriasAbiertas;
            try
            {
                DSMateriasAbiertas = logicaMA.ListarMateriasAbiertas(condicion);
                if (DSMateriasAbiertas.Tables[0].Rows.Count > 0)
                {
                    dgvMateriasAbiertas.DataSource = DSMateriasAbiertas;
                    dgvMateriasAbiertas.DataMember = DSMateriasAbiertas.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
    }
}
