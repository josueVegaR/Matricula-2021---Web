using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using Entidades;

namespace InterfazWeb
{
    public partial class frmPeriodoYAnio : System.Web.UI.Page
    {
        //metodos

        private void Limpiar()
        {
            cboPeriodo.SelectedIndex = -1;
            txtAnio.Text = string.Empty;
            txtIVA.Text = string.Empty;
        }

        private void ActualizarPeriodoYAnio()
        {
            LogicaValoresRef logicaValoresRef = new LogicaValoresRef(Configuracion.getConnectionString);
            decimal anio, periodo, iva;
            int retorno = 0;

            if ((cboPeriodo.SelectedIndex != -1) && (txtAnio.Text != string.Empty) && (txtIVA.Text != string.Empty))
            {
                anio = Convert.ToDecimal(txtAnio.Text);
                periodo = Convert.ToDecimal(cboPeriodo.Text);
                iva = Convert.ToDecimal(txtIVA.Text);
                retorno = logicaValoresRef.ActualizarPeriodoYAnio(anio, periodo, iva);
            }
            else
            {
                Session["_mensaje"] = "Todos los campos son requeridos.";
            }
            if (retorno == 0)
            {
                Session["_mensaje"] = "No se pudo actualizar la información.";
            }
            else
            {
                Session["_mensaje"] = "Los datos se guardaron con éxito.";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarPeriodoYAnio();
                Response.Redirect("Default.aspx");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}