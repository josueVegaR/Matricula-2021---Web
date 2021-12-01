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
    public class ADAulas
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
        public ADAulas()
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADAulas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Métodos

        //El tipo DataSet me permite guardar una tabla o el resultado de una consulta de las tablas de la BD:

        // TODAS LAS AULAS CON DISPONIBLE EN 1:
        public DataSet ListarAulas(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // El data adapter permite para guardar los cambios en la BD:
            SqlDataAdapter adapter;

            //Sentencia:
            string sentencia = "SELECT CodigoAula, TipoAula, NumeroAula, Capacidad" +
                               " FROM	TBL_Aulas";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Aulas");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        //OBTENER 1 AULA DE LA LISTA:
        public Aulas ObtenerAula(int codigoAula)
        {
            Aulas aula = new Aulas();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            //esta clase no tiene constructor, se instancia con un execute.
            SqlDataReader dataReader;
            //Sentencia de SQL:
            string sentencia = string.Format(" SELECT CodigoAula, TipoAula, NumeroAula, Capacidad" +
                                             " FROM	TBL_Aulas" +
                                             " WHERE CodigoAula = {0}", codigoAula);

            //Peparar la conexión:
            comando.Connection = conexion;

            //Preparar el comando:
            comando.CommandText = sentencia;

            //Try catch:
            try
            {
                //         IMPORTANTE!!!!
                //Los procedimientos en SQL pueden retornar números, por lo que se convierten a 
                // enteros o a booleanos.

                // 1. Se abre la conexión: 
                conexion.Open();
                //Se ejecuta el data Reader:
                dataReader = comando.ExecuteReader();

                // Ahora hay que verificar si tiene filas:
                // se puede hacer con un While, y se agrega el valor a una lista:
                // while(dataReader.HasRows)
                if (dataReader.HasRows)
                {
                    dataReader.Read();//Lee la primera fila. Se comporta como un cursor
                    aula.CodigoAula = dataReader.GetInt16(0);
                    aula.TipoAula = dataReader.GetString(1);
                    aula.NumeroAula = dataReader.GetByte(2);
                    aula.Capacidad = dataReader.GetByte(3);
                }
                // Cierro la conexión:
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return aula;
        }
        #endregion
    }
}
