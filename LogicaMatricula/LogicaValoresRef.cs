using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace LogicaNegocio
{
    public class LogicaValoresRef
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

        public LogicaValoresRef(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        #endregion

        #region Metodos

        public DataSet PeriodoYAnioActual(string condicion, string orden)
        {
            DataSet DS;
            ADValoresRef AccesoDatosVR = new ADValoresRef(_cadenaConexion);
            try
            {
                DS = AccesoDatosVR.PeriodoYAnioActual(condicion, orden);
            }
            catch (Exception)
            {
                throw;
            }
            return DS;
        }


        public int ActualizarPeriodoYAnio(decimal Anio, decimal Periodo, decimal IVA)
        {
            int resultadoSP;

            ADValoresRef ADValoresReferencia = new ADValoresRef(_cadenaConexion);
            try
            {
                resultadoSP = ADValoresReferencia.ActualizarPeriodoYAnio(Anio, Periodo, IVA);
                _mensaje = ADValoresReferencia.Mensaje;
            }
            catch (Exception)
            {
                throw;
            }
            return resultadoSP;
        }


        #endregion
    }
}
