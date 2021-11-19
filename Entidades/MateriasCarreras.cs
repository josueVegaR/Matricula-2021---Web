using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class MateriasCarreras
    {
        #region Atributos
        private int codMateriaCarrera;
        private Carreras carrera;
        private Materias materia;
        private Materias requisito;
        private Materias corequisito;
        private string estado;
        private bool borrado;
        #endregion

        #region Propiedades
        public int CodMateriaCarrera { get => codMateriaCarrera; set => codMateriaCarrera = value; }
        public Carreras Carrera { get => carrera; set => carrera = value; }
        public Materias Materia { get => materia; set => materia = value; }
        public Materias Requisito { get => requisito; set => requisito = value; }
        public Materias Corequisito { get => corequisito; set => corequisito = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Constructor
        public MateriasCarreras()
        {
            codMateriaCarrera = 0;
            carrera = new Carreras();
            materia = new Materias();
            requisito = new Materias();
            corequisito = new Materias();
            estado = string.Empty;
            borrado = false;
        }
        #endregion
    }
}
