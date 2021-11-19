using Entidades;
using AccesoDatos;
using System;
using System.Data;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class LogicaHorarios
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

        public LogicaHorarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion


        //Método INSERT del Acceso a Datos:
        public int InsertarHorario(Horarios Horario)
        {
            // primero instanciar para acceder a los métodos
            ADHorarios ADHorarios = new ADHorarios(_cadenaConexion);


            //Identity generado:
            //int filasAfectadas = 0;
            int filasAfectadas;

            try
            {
                filasAfectadas = ADHorarios.InsertarHorarios(Horario);

            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }

        //Método para mostrar la lista de Horarios en el data grid view del formulario
        public DataSet ListarHorarios(string condicion)
        {
            DataSet DS;
            ADHorarios AccesoDatosHorarios = new ADHorarios(_cadenaConexion);
            try
            {
                DS = AccesoDatosHorarios.ListarHorarios(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }
    }
}
