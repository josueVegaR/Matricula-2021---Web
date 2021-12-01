using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tlsSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlsAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto Programación Orientada a Objetos - Josué Vega - INA");
        }

        private void tlsAperturaCursos_Click(object sender, EventArgs e)
        {
            frmAperturaCursos formularioAbrirCursos = new frmAperturaCursos();
            formularioAbrirCursos.ShowDialog();
        }

        private void tlsCrearEstudiante_Click(object sender, EventArgs e)
        {
            frmCrearEstudiante frmCrearEstudiante = new frmCrearEstudiante();
            frmCrearEstudiante.ShowDialog();
        }

        private void tlsCrearProfesor_Click(object sender, EventArgs e)
        {
            frmCrearProfesor frm = new frmCrearProfesor();
            frm.ShowDialog();
        }

        private void tlsMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema de matrícula se encuentra bajo mantenimiento para ser entregado en la tercera Fase.");
        }
    }
}
