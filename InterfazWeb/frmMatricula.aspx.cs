using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfazWeb
{
    public partial class frmMatricula : System.Web.UI.Page
    {

        //Métodos

        //Obtener periodo y año:
        //private void PeriodoYAnioActual()
        //{
        //    DataSet DS;
        //    int anio, periodo;
        //    LogicaValoresRef logicaValoresRef = new LogicaValoresRef(Configuracion.getConnectionString);
        //    DS = logicaValoresRef.PeriodoYAnioActual("", "");
        //    if (DS != null)
        //    {
        //        periodo = Convert.ToInt32(DS.Tables[0].Rows[2].Field<decimal>("VALOR"));
        //        txtPeriodo.Text = periodo.ToString();
        //        anio = Convert.ToInt32(DS.Tables[0].Rows[1].Field<decimal>("VALOR"));
        //        txtAnio.Text = anio.ToString();
        //    }
        //    else
        //    {
        //        Session["_mensaje"] = "Se produjo un error al recuperar los datos.";
        //    }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}