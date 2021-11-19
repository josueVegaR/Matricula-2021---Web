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
    public partial class frmVerEstudiantes : Form
    {
        public frmVerEstudiantes()
        {
            InitializeComponent();
        }

        //Función para cargar los Estudiantes:
        private void CargarListaDataSet(string condicion = "")
        {

            LogicaEstudiantes logicaEstudiantes = new LogicaEstudiantes(Configuracion.getConnectionString);
            DataSet DSEstudiantes;
            try
            {
                DSEstudiantes = logicaEstudiantes.ListarEstudiantes(condicion);
                if (DSEstudiantes.Tables[0].Rows.Count > 0)
                {
                    dgvEstudiantes.DataSource = DSEstudiantes;
                    dgvEstudiantes.DataMember = DSEstudiantes.Tables[0].TableName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmVerEstudiantes_Load(object sender, EventArgs e)
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
