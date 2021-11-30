using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using LogicaNegocio;
using System.Data;

namespace InterfazWeb
{
    public partial class frmAperturaCursos : System.Web.UI.Page
    {
        // ------- METODOS:

        // Generar una entidad de Materia Abierta para hacer un insert:
        private MateriasAbiertas GenerarEntidadMA()
        {
            MateriasAbiertas Materia = new MateriasAbiertas();
            if (((cboPeriodo.SelectedIndex != -1)) && (!string.IsNullOrEmpty(txtAnio.Text)))
            {
                if ((!string.IsNullOrEmpty(txtCodigoMateria.Text)) && (!string.IsNullOrEmpty(txtCosto.Text)) && (!string.IsNullOrEmpty(txtCupo.Text)) && (!string.IsNullOrEmpty(txtGrupo.Text)))
                {
                    if ((cboDia.SelectedIndex != -1) && (!string.IsNullOrEmpty(txtHoraI.Text)) && (!string.IsNullOrEmpty(txtHoraS.Text)))
                    {
                        Materia.CodMateriaCarrera.CodMateriaCarrera = int.Parse(txtIDMateriaSelecciada.Text);
                        Materia.Grupo = int.Parse(txtGrupo.Text);
                        Materia.Cupo = int.Parse(txtCupo.Text);
                        Materia.Costo = double.Parse(txtCosto.Text);
                        Materia.Periodo = int.Parse(cboPeriodo.Text);
                        Materia.Anio = int.Parse(txtAnio.Text);
                        //No se le asigna el valor a disponible porque el constructor lo trae.
                    }
                    else
                    {
                        Session["_mensaje"] = "Debe agregar un horario para abrir la materia.";
                    }
                }
                else
                {
                    Session["_mensaje"] = "Todos los valores para la materia deben ser ingresados.";
                }
            }
            else
            {
                Session["_mensaje"] = "Los campos de Periodo y Año son requeridos.";
            }
            return Materia;
        }

        private void AbrirCurso()
        {
            LogicaMateriasAbiertas logicaMA = new LogicaMateriasAbiertas(Configuracion.getConnectionString);
            MateriasAbiertas Curso = new MateriasAbiertas();
            Curso = GenerarEntidadMA();
            try
            {
                if (Curso != null)
                {
                    //Se llama a la lógica para de ahí, invocar un método de AD que tenga un SP.
                }
            }
            catch (Exception ex)
            {
                Session["_mensaje"] = $"Se ha producido un error al abrir el curso. {ex.Message}";
            }
        }

        private void CargarCursos(string condicion = "")
        {
            DataSet DS;
            LogicaMateriasCarreras logicaMC = new LogicaMateriasCarreras(Configuracion.getConnectionString);
            try
            {
                DS = logicaMC.CargarCursos(condicion);

                //Se verifica que el DS tenga algo:
                if (DS != null)
                {
                    GrdLista.DataSource = DS;
                    GrdLista.DataMember = DS.Tables[0].TableName;
                    //Para que se muestren los datos en pantalla:
                    GrdLista.DataBind();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LimpiarForm()
        {
            txtIDMateriaSelecciada.Text = string.Empty;
            txtCodigoMateria.Text = string.Empty;
            txtCreditos.Text = string.Empty;
            txtNombreMateria.Text = string.Empty;
            txtGrupo.Text = string.Empty;
            txtCupo.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtAnio.Text = string.Empty;
            cboPeriodo.SelectedIndex = 0;
            DateTime horaI, horaFin;
            horaI = DateTime.Today.AddHours(7);
            horaFin = horaI.AddHours(1);
            txtHoraI.Text = horaI.ToString();
            txtHoraS.Text = horaFin.ToString();

            txtHoraMin.Text = DateTime.Today.AddHours(7).ToString();
            txtHoraIMax.Text = DateTime.Today.AddHours(21).ToString();
            txtHoraMax.Text = DateTime.Today.AddHours(22).ToString();
        }

        //----------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                //Evento !postback
                if (!IsPostBack)
                {
                    CargarCursos();
                    Session["_mensaje"] = null;
                }
                else
                {
                    LimpiarForm();
                }
            }
            catch (Exception ex)
            {
                Session["_mensaje"] = $"Error al cargar los datos. {ex.Message}";
            }
        }
        

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = $"NombreMateria like '%{txtNombre.Text.Trim()}%'";
                CargarCursos(condicion);

                //La clase Script Manager me permite correr un archivo/código JS que quiera ejecutar desde el servidor:
                string javaScript = "AbrirModal();";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);
            }
            catch (Exception)
            {
                Session["_mensaje"] = "Error al buscar la materia.";
            }
        }

        protected void GrdLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdLista.PageIndex = e.NewPageIndex;
            CargarCursos();
            string javaScript = "AbrirModal();";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            //Se declara una variable para recuperar el ID del command Argument
            int id = int.Parse(e.CommandArgument.ToString());
            MateriasCarreras materiaCarrera;
            LogicaMateriasCarreras logicaMC = new LogicaMateriasCarreras(Configuracion.getConnectionString);

            try
            {
                materiaCarrera = logicaMC.ObtenerMateriaCarrera(id);
                if (materiaCarrera != null)
                {
                    txtIDMateriaSelecciada.Text = materiaCarrera.CodMateriaCarrera.ToString();
                    txtCodigoMateria.Text = materiaCarrera.Materia.CodigoMateria;
                    txtCreditos.Text = materiaCarrera.Materia.CreditosMateria.ToString();
                    txtNombreMateria.Text = materiaCarrera.Materia.NombreMateria;
                }
            }
            catch (Exception)
            {
                Session["_mensaje"] = "Error al seleccionar la materia.";
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}