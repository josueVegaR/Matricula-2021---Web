using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DetallesMatriculas
    {
        #region Atributos
        private int numFactura;
        private MateriasAbiertas codMateriaAbierta;
        private double porcentajeDescuento;
        private double notaFinal;
        private string estadoDetalle;
        #endregion

        #region Propiedades
        public int NumFactura { get => numFactura; set => numFactura = value; }
        public MateriasAbiertas CodMateriaAbierta { get => codMateriaAbierta; set => codMateriaAbierta = value; }
        public double PorcentajeDescuento { get => porcentajeDescuento; set => porcentajeDescuento = value; }
        public double NotaFinal { get => notaFinal; set => notaFinal = value; }
        public string EstadoDetalle { get => estadoDetalle; set => estadoDetalle = value; }
        #endregion

        #region Constructor
        public DetallesMatriculas()
        {
            numFactura = 0;
            codMateriaAbierta = new MateriasAbiertas();
            porcentajeDescuento = 0;
            notaFinal = 0;
            estadoDetalle = string.Empty;
        }
        #endregion
    }
}
