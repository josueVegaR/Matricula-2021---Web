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
    public partial class frmVerProfesores : Form
    {
        public frmVerProfesores()
        {
            InitializeComponent();
        }

        //Función para cargar los Profesores
        private void CargarListaDataSet(string condicion = "")
        {

            LogicaProfesores logicaProfesores = new LogicaProfesores(Configuracion.getConnectionString);
            DataSet DSProfesores;
            try
            {
                DSProfesores = logicaProfesores.ListarProfesores2(condicion);
                if (DSProfesores.Tables[0].Rows.Count > 0)
                {
                    dgvListaProfesores.DataSource = DSProfesores;
                    dgvListaProfesores.DataMember = DSProfesores.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmVerProfesores_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
