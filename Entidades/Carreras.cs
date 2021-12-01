using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Carreras
    {
        #region Atributos
        private int codigoCarrera;
        private string nombreCarrera;
        private int totalCreditos;
        private string gradoCarrera;
        private bool borrado;
        #endregion

        #region Propiedades
        public int CodigoCarrera { get => codigoCarrera; set => codigoCarrera = value; }
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public int TotalCreditos { get => totalCreditos; set => totalCreditos = value; }
        public string GradoCarrera { get => gradoCarrera; set => gradoCarrera = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Constructor
        public Carreras()
        {
            codigoCarrera = 0;
            nombreCarrera = string.Empty;
            totalCreditos = 0;
            gradoCarrera = string.Empty;
            borrado = false;
        }
        #endregion 
    }
}
