using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Materias
    {
        #region Atributos
        private string codigoMateria;
        private string nombreMateria;
        private int creditosMateria;
        private bool borrado;
        #endregion

        #region Propiedades
        public string CodigoMateria { get => codigoMateria; set => codigoMateria = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public int CreditosMateria { get => creditosMateria; set => creditosMateria = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Constructor
        public Materias()
        {
            codigoMateria = string.Empty;
            nombreMateria = string.Empty;
            creditosMateria = 0;
            borrado = false;
        }
        #endregion 
    }
}
