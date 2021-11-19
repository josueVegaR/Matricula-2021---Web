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
    public partial class frmCrearEstudiante : Form
    {
        //Variables globales
        Estudiante estudiante;

        public frmCrearEstudiante()
        {
            InitializeComponent();
        }

        //Métodos

        private void LimpiarForm()
        {
            dtpFechaIngreso.Value = DateTime.Now;
            txtNombreEstudiante.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtIDEstudiante.Text = string.Empty;
            txtCorreoEstudiante.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCarne.Text = string.Empty;
            cboProvincia.SelectedIndex = -1;
            txtCanton.Text = string.Empty;
            txtDistrito.Text = string.Empty;
            rtxtOtrasSenias.Text = string.Empty;
            txtDescuento.Text = "0";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCrearEstudiante_Load(object sender, EventArgs e)
        {
            LimpiarForm();
            txtNombreEstudiante.Focus();
        }

        //No permite que se ingresen números
        private void txtNombreEstudiante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIDEstudiante_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCanton_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDistrito_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCrearEstudiante_Click(object sender, EventArgs e)
        {
            if ((txtNombreEstudiante.Text != string.Empty) && (txtPrimerApellido.Text != string.Empty) && (txtSegundoApellido.Text != string.Empty) && (txtIDEstudiante.Text != string.Empty) && (txtCorreoEstudiante.Text != string.Empty) && (txtCarne.Text != string.Empty))
            {
                //Instancia de la Lógica:
                LogicaEstudiantes logicaEstudiantes = new LogicaEstudiantes(Configuracion.getConnectionString);
                
                //Instancio al estudiante
                estudiante = new Estudiante();

                //Variable de retorno para almacenar lo que devuelve el método:
                int filasAfectadas;

                //pasar los datos al estudiante
                
                //datos requeridos:
                estudiante.CarnetEstudiante = txtCarne.Text;
                estudiante.Identificacion = txtIDEstudiante.Text;
                estudiante.Nombre = txtNombreEstudiante.Text;
                estudiante.Apellido1 = txtPrimerApellido.Text;
                estudiante.Apellido2 = txtSegundoApellido.Text;
                estudiante.Telefono = txtTelefono.Text;
                estudiante.Correo = txtCorreoEstudiante.Text;

                //datos que pueden ir vacíos (null en la BD):
                // Provincia:
                if (cboProvincia.SelectedIndex != -1)
                {
                    estudiante.Provincia = cboProvincia.Text;
                }
                else
                {
                    estudiante.Provincia = "San José";
                }
                // Cantón:
                if (txtCanton.Text != string.Empty)
                {
                    estudiante.Canton = txtCanton.Text;
                }
                else
                {
                    estudiante.Canton = "No registra";
                }
                // Distrito:
                if (txtDistrito.Text != string.Empty)
                {
                    estudiante.Distrito = txtDistrito.Text;
                }
                else
                {
                    estudiante.Distrito = "No registra";
                }
                // Otras Señas:
                if (rtxtOtrasSenias.Text != string.Empty)
                {
                    estudiante.OtrasSenias = rtxtOtrasSenias.Text;
                }
                else
                {
                    estudiante.OtrasSenias = "No registra";
                }
                // Fecha ingreso es un campo no modificable.
                estudiante.FechaIngreso = dtpFechaIngreso.Value;
                // Descuento:
                if (txtDescuento.Text != string.Empty)
                {
                    estudiante.Descuento = int.Parse(txtDescuento.Text);
                }
                else
                {
                    estudiante.Descuento = 0;
                }                
                estudiante.Estado = "ACT";
                estudiante.Borrado = false;

                //Se llama al método
                filasAfectadas = logicaEstudiantes.CrearEstudiante(estudiante);
                if (filasAfectadas < 1)
                {
                    MessageBox.Show("El estudiante no pudo ser creado.", "Atención",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(logicaEstudiantes.Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarForm();
                    txtNombreEstudiante.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos requeridos.");
            }
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            LimpiarForm();
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

        private void btnVerEstudiantes_Click(object sender, EventArgs e)
        {
            frmVerEstudiantes frmVerEstudiantes = new frmVerEstudiantes();
            frmVerEstudiantes.Show();
        }
    }
}
