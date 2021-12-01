using Entidades;
using AccesoDatos;
using System;
using System.Data;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class LogicaMateriasAbiertas
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

        public LogicaMateriasAbiertas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Métodos

        //Método INSERT del Acceso a Datos:
        public int InsertarMateriaAbierta(MateriasAbiertas materiaAbierta)
        {
            // primero instanciar para acceder a los métodos
            ADMateriasAbiertas ADMateriasAbiertas = new ADMateriasAbiertas(_cadenaConexion);
            ADMateriasCarreras ADMateriasCarreras = new ADMateriasCarreras (_cadenaConexion);
            // se necesitan ambas instancias porque los métodos están uno en cada clase.

            //Identity generado:
            int codigoMateriaAbierta;

            try
            {
                if (ADMateriasCarreras.ObtenerMateriaCarrera(materiaAbierta.CodMateriaCarrera.CodMateriaCarrera) != null)
                {
                    codigoMateriaAbierta = ADMateriasAbiertas.InsertarMateriaAbierta(materiaAbierta);
                }
                else
                {
                    codigoMateriaAbierta = -1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return codigoMateriaAbierta;
        }

        //Método para mostrar la lista de materias abiertas en el data grid view del formulario
        public DataSet ListarMateriasAbiertas(string condicion)
        {
            DataSet DS;
            ADMateriasAbiertas AccesoDatosMA = new ADMateriasAbiertas(_cadenaConexion);
            try
            {
                DS = AccesoDatosMA.ListarMateriasAbiertas(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }

        #endregion
    }
}
