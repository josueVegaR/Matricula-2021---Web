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
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MateriasCarreras curso;
            LogicaMateriasCarreras logicaMC = new LogicaMateriasCarreras(Configuracion.getConnectionString);

            //Evento !postback
            if (!IsPostBack)
            {
                CargarCursos();



            }

        }
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //MateriasCarreras materiaC;
        //LogicaMateriasCarreras logicaMC = new LogicaMateriasCarreras(Configuracion.getConnectionString);
        //string condicion = string.Empty;
        //try
        //{
        //    if (!IsPostBack)
        //    {
        //        CargarMateriasCarreras(condicion);
        //        Session["_mensaje"] = null;
        //        if (Session["CodMateriaCarrera"] != null)
        //        {
        //            materiaC = logicaMC.ObtenerMateriaCarrera(int.Parse($"CodMateriaCarrera = {Session["CodMateriaCarrera"]}"));
        //            txtIDMateriaSelecciada.Text = materiaC.CodMateriaCarrera.ToString();
        //            txtCodigoMateria.Text = materiaC.Materia.CodigoMateria.ToString();
        //            txtCreditos.Text = materiaC.Materia.CreditosMateria.ToString();
        //            txtNombreMateria.Text = materiaC.Materia.NombreMateria;

        //        }
        //        else
        //        {
        //            LimpiarForm();
        //        }
        //    }
        //}
        //catch (Exception)
        //{
        //    Session["_mensaje"] = "Error al cargar la Materia.";
        //    //Response.Redirect("Default.aspx");
        //    //Este campo lo tengo que cambiar por el form correcto.
        //}

        //}

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        protected void GrdLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdLista.PageIndex = e.NewPageIndex;
            CargarCursos();
            string javaScript = "AbrirModal();";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);
        }
    }
}