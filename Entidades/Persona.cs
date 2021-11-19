using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        protected string identificacion;
        protected string nombre;
        protected string apellido1;
        protected string apellido2;
        protected string telefono;
        protected string correo;
        protected bool borrado;
        #endregion

        #region Propiedades
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public bool Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Constructor
        protected Persona()
        {
            identificacion = string.Empty;
            nombre = string.Empty;
            apellido1 = string.Empty;
            apellido2 = string.Empty;
            correo = string.Empty;
            telefono = string.Empty;
            borrado = false;
        }
        #endregion
    }
}
