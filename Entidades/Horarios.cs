using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Horarios
    {
        #region Atributos
        private MateriasAbiertas codMateriaAbierta;
        private string dia;
        private DateTime horaInicio;
        private DateTime horaFin;
        #endregion

        #region Propiedades
        public MateriasAbiertas CodMateriaAbierta { get => codMateriaAbierta; set => codMateriaAbierta = value; }
        public string Dia { get => dia; set => dia = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        #endregion

        #region Constructor
        public Horarios()
        {
            codMateriaAbierta = new MateriasAbiertas();
            dia = string.Empty;
            horaInicio = DateTime.Now;
            horaFin = DateTime.Now;
        }
        #endregion
    }
}
