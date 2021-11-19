using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Profesor : Persona
    {
        #region Atributos
        private int codigoProfesor;
        #endregion

        #region Propiedades
        public int CodigoProfesor { get => codigoProfesor; set => codigoProfesor = value; }
        #endregion

        #region Constructor
        public Profesor()
        {
            codigoProfesor = 0;
        }
        #endregion
    }
}
