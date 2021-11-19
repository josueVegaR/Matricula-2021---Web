using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Estudiante : Persona
    {
        #region Atributos
        private string carnetEstudiante;
        private string provincia;
        private string canton;
        private string distrito;
        private string otrasSenias;
        private DateTime fechaIngreso;
        private double descuento;
        private string estado;
        #endregion

        #region Propiedades
        public string CarnetEstudiante { get => carnetEstudiante; set => carnetEstudiante = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Canton { get => canton; set => canton = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string OtrasSenias { get => otrasSenias; set => otrasSenias = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public string Estado { get => estado; set => estado = value; }
        #endregion

        #region Constructor
        public Estudiante()
        {
            carnetEstudiante = string.Empty;
            provincia = string.Empty;
            canton = string.Empty;
            distrito = string.Empty;
            otrasSenias = string.Empty;
            fechaIngreso = DateTime.Now;
            descuento = 0;
            estado = "ACT";
        }
        #endregion
    }
}
