using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Matriculas
    {
        #region Atributos
        private int numFactura;
        private Estudiante carnetEstudiante;
        private DateTime fechaMatricula;
        private double montoMatricula;
        private string tipoPago;
        private string comprobantePago;
        private string estadoFactura;
        private string estadoMatricula;
        #endregion

        #region Constructor
        public Matriculas()
        {
            numFactura = 0;
            carnetEstudiante = new Estudiante();
            fechaMatricula = DateTime.Today;
            montoMatricula = 0;
            tipoPago = string.Empty;
            comprobantePago = string.Empty;
            estadoFactura = string.Empty;
            estadoMatricula = string.Empty;
        }
        #endregion

        #region Propiedades
        public int NumFactura { get => numFactura; set => numFactura = value; }
        public Estudiante CarnetEstudiante { get => carnetEstudiante; set => carnetEstudiante = value; }
        public DateTime FechaMatricula { get => fechaMatricula; set => fechaMatricula = value; }
        public double MontoMatricula { get => montoMatricula; set => montoMatricula = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string ComprobantePago { get => comprobantePago; set => comprobantePago = value; }
        public string EstadoFactura { get => estadoFactura; set => estadoFactura = value; }
        public string EstadoMatricula { get => estadoMatricula; set => estadoMatricula = value; }
        #endregion
    }
}
