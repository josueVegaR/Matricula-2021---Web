using Entidades;
using AccesoDatos;
using System;
using System.Data;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class LogicaAulas
    {
        #region Atributos
        
        // _atributo = atributo privado
        private string _cadenaConexion;
        private string _mensaje;

        #endregion

        #region Propiedades
        
        public string Mensaje
        {
            get => _mensaje;
        }

        #endregion

        #region Constructor
        
        public LogicaAulas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        #endregion

        #region Métodos

        // Método para listar en el DataSet la tabla devuelta por la consulta en el ADAulas:
        public DataSet ListarAulas(string condicion)
        {
            DataSet DS;
            ADAulas AccesoDatosAulas = new ADAulas(_cadenaConexion);
            try
            {
                DS = AccesoDatosAulas.ListarAulas(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }

        // Método para devolver 1 Aula:
        public Aulas ObtenerAula(int codigoAula)
        {
            Aulas Aula;
            ADAulas AccesoDatosAulas = new ADAulas(_cadenaConexion);
            try
            {
                Aula = AccesoDatosAulas.ObtenerAula(codigoAula);
            }
            catch (Exception)
            {

                throw;
            }
            return Aula;
        }

        #endregion
    }
}
