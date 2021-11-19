using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class MateriasAbiertas
    {
        #region Atributos 
        private int codMateriaAbierta;
        private MateriasCarreras codMateriaCarrera;
        private Profesor codigoProfesor;
        private Aulas codigoAula;
        private int grupo;
        private int cupo;
        private double costo;
        private int periodo;
        private int anio;
        private bool disponible;
        #endregion

        #region Propiedades
        public int CodMateriaAbierta { get => codMateriaAbierta; set => codMateriaAbierta = value; }
        public MateriasCarreras CodMateriaCarrera { get => codMateriaCarrera; set => codMateriaCarrera = value; }
        public Profesor CodigoProfesor { get => codigoProfesor; set => codigoProfesor = value; }
        public Aulas CodigoAula { get => codigoAula; set => codigoAula = value; }
        public int Grupo { get => grupo; set => grupo = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public double Costo { get => costo; set => costo = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Anio { get => anio; set => anio = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        #endregion

        #region Constructores
        public MateriasAbiertas()
        {
            codMateriaAbierta = 0;
            codMateriaCarrera = new MateriasCarreras();
            CodigoProfesor = new Profesor();
            codigoAula = new Aulas();
            grupo = 0;
            cupo = 0;
            costo = 0;
            periodo = 0;
            anio = 0;
            disponible = true;
        }
        #endregion


    }
}
