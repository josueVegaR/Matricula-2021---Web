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
    public partial class frmCrearProfesor : Form
    {
        //Variable global
        Profesor profesor;

        public frmCrearProfesor()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCrearProfesor_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCrearProfesor_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text != string.Empty) && (txtPrimerApellido.Text != string.Empty) && (txtSegundoApellido.Text != string.Empty) && (txtIdentificacion.Text != string.Empty) && (txtCorreo.Text != string.Empty) && (txtTelefono.Text != string.Empty))
            {
                //Instancia de la Lógica:
                LogicaProfesores logicaProfesores = new LogicaProfesores(Configuracion.getConnectionString);

                //Instancio al estudiante
                profesor = new Profesor();

                //Variable de retorno para almacenar lo que devuelve el método:
                int filasAfectadas;

                //pasar los datos al estudiante

                //datos requeridos:
                profesor.Identificacion = txtIdentificacion.Text;
                profesor.Nombre = txtNombre.Text;
                profesor.Apellido1 = txtPrimerApellido.Text;
                profesor.Apellido2 = txtSegundoApellido.Text;
                profesor.Telefono = txtTelefono.Text;
                profesor.Correo = txtCorreo.Text;
                profesor.Borrado = false;

                //Se llama al método
                filasAfectadas = logicaProfesores.CrearProfesor(profesor);
                if (filasAfectadas < 1)
                {
                    MessageBox.Show("El Profesor no pudo ser creado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(logicaProfesores.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    txtNombre.Focus();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son requeridos.");
            }
        }

        private void btnVerProfesores_Click(object sender, EventArgs e)
        {
            frmVerProfesores frmVerProfesores = new frmVerProfesores();
            frmVerProfesores.Show();
        }
    }
}
