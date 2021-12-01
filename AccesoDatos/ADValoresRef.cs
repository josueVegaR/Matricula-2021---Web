using System;
// Se procede a agregar los namespaces que voy a utilizar para SQL:
using System.Data; //para clases generales.
using System.Data.SqlClient; // instalado por un NuGet
//using System.Collections.Generic; // este es para manejar listas de objetos.
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class ADValoresRef
    {
        //Clases ADO

        #region Atributos
        private string _cadenaConexion;
        private string _mensaje;
        #endregion

        #region Propiedades
        public string Mensaje
        {
            get => _mensaje;
        }
        public string CadenaConexion
        {
            set => _cadenaConexion = value;
        }
        #endregion

        #region Constructores
        public ADValoresRef()
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADValoresRef(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos
        public DataSet PeriodoYAnioActual(string condicion, string orden)
        {
            //Instancia de elementos ADO
            DataSet DSPeriodoyAnio = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;


            string sentencia = "Select	ID, DATO, VALOR "+
                               " From TBL_ValoresPorReferencia";
            //Si la condición no está vacía
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            //Si el orden no viene vacío
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} order by {1}", sentencia, orden);
            }
             

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(DSPeriodoyAnio, "ValoresReferencia");
            }
            catch (Exception)
            {
                throw;
            }
            return DSPeriodoyAnio;
        }


        

        public int ActualizarPeriodoYAnio(decimal Anio, decimal Periodo, decimal IVA)
        {
            //Variable para guardar las filas afectadas:
            int resultado = -1;

            //Elementos ADO
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;

            //Nombre del SP
            comando.CommandText = "SP_ActualizarAnioYPeriodo"; // Nombre del SP
            comando.CommandType = CommandType.StoredProcedure; //se especifica que tipo de comando es, en este caso es un procedimiento almacenado

            //Parámetros de Entrada:
            comando.Parameters.AddWithValue("@Anio", Anio);
            comando.Parameters.AddWithValue("@Periodo", Periodo);
            comando.Parameters.AddWithValue("@IVA", IVA);
            
            //Parámetro de Salida:
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 80).Direction = ParameterDirection.Output;
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue; //se declara otro parametro de retorno del SP que obtenga el retorno del SP
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();//ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);//obtengo la variable de retorno
                
                //se va a leer el parametro de salida del SP
                _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP

                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        #endregion
    }
}
