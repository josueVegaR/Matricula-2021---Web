using Entidades;
using AccesoDatos;
using System;
using System.Data;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class LogicaEstudiantes
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

        public LogicaEstudiantes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion


        //Insertar con un Stored Procedure:
        public int CrearEstudiante(Estudiante estudiante)
        {
            //variable para guarda el retorno:
            int resultado;
            //una variable para acceso a datos:
            ADEstudiantes accesoDatosEstudiante = new ADEstudiantes(_cadenaConexion);
            try
            {
                resultado = accesoDatosEstudiante.CrearEstudiante(estudiante);
                _mensaje = accesoDatosEstudiante.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        //Método para mostrar la lista de estudiantes en el data grid view del formulario
        public DataSet ListarEstudiantes(string condicion)
        {
            DataSet DS;
            ADEstudiantes AccesoDatosEstudiantes = new ADEstudiantes(_cadenaConexion);
            try
            {
                DS = AccesoDatosEstudiantes.ListarEstudiantes(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }

    }
}
