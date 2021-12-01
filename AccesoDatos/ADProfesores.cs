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
    public class ADProfesores
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
        public ADProfesores()
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADProfesores(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion
        
        #region Métodos

        //El tipo DataSet me permite guardar una tabla o el resultado de una consulta de las tablas de la BD:

        // TODAS LOS PROFESORES CON BORRADO EN 0:
        public DataSet ListarProfesores(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // El data adapter permite para guardar los cambios en la BD:
            SqlDataAdapter adapter;

            //Sentencia:
            string sentencia = " Select	CodigoProfesor, NombreProfesor, Apellido1Profesor, Apellido2Profesor, IdProfesor" +
                               " from	TBL_Profesores";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Profesores");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        //DataSet 2 para mostrar los profesores en la ventana de Creación de profesores. La consulta devuelve más datos.
        public DataSet ListarProfesores2(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // El data adapter permite para guardar los cambios en la BD:
            SqlDataAdapter adapter;

            //Sentencia:
            string sentencia = " Select	CodigoProfesor, IdProfesor, NombreProfesor, Apellido1Profesor, Apellido2Profesor, TelefonoProfesor, CorreoProfesor" +
                               " from	TBL_Profesores";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Profesores");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        //OBTENER 1 PROFESOR DE LA LISTA:
        public Profesor ObtenerProfesor(int codigoProfesor)
        {
            Profesor profesor = new Profesor();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            //esta clase no tiene constructor, se instancia con un execute.
            SqlDataReader dataReader;
            //Sentencia de SQL:
            string sentencia = string.Format(" Select	CodigoProfesor, NombreProfesor, Apellido1Profesor, Apellido2Profesor, idProfesor " +
                                             " from	TBL_Profesores" +
                                             " where	CodigoProfesor = {0}", codigoProfesor);

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
                if (dataReader.HasRows)
                {
                    dataReader.Read();//Lee la primera fila. Se comporta como un cursor
                    profesor.CodigoProfesor = dataReader.GetInt32(0);
                    profesor.Nombre = dataReader.GetString(1);
                    profesor.Apellido1 = dataReader.GetString(2);
                    profesor.Apellido2 = dataReader.GetString(3);
                    profesor.Identificacion = dataReader.GetString(4);
                }
                // Cierro la conexión:
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return profesor;
        }


        public int AsignarProfesor(Profesor profesor, int CodMateriaAbierta)
        {
            //Se establece la conexión con la BD:
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Se crea el objeto comando para ejecutar la sentencia:
            SqlCommand comando = new SqlCommand();
            //Se inicializa el valor de retorno que es el Identity generado:
            int filasAfectadas = 0;
            //Se prepara el comando: 
            string sentencia = " UPDATE TBL_MateriasAbiertas set CodigoProfesor = @CodigoProfesor where CodMateriaAbierta = @CodMateriaAbierta";


            //Se establece la conexión:
            comando.Connection = conexion;

            //Se asignan los valores de los parámetros:
            comando.Parameters.AddWithValue("@CodigoProfesor", profesor.CodigoProfesor);
            comando.Parameters.AddWithValue("@CodMateriaAbierta", CodMateriaAbierta);

            //Se asigna la sentencia:
            comando.CommandText = sentencia;
            try
            {
                //Se abre la conexión
                conexion.Open();
                //Se asigna el identity devuelto al código de materia abierta:
                filasAfectadas = Convert.ToInt32(comando.ExecuteNonQuery());
                //Se cierra la conexión:
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            //Se devuelve la cantidad de filas afectadas. Si es cero, no se hizo ninguna incersión.
            // Si es == 1, se hizo la incersión.
            return filasAfectadas;
        }

        //Se crea un método para agregar un Profesor en la BD con un Procedimiento Almacenado:
        public int CrearProfesor(Profesor profesor)
        {
            //El resultado va a ser 1 si agregó o 0 sino.
            int resultado = -1;

            //La sentencia SQLConnection necesita SIEMPRE la cadena de conexión.
            SqlConnection conexion = new SqlConnection(_cadenaConexion);

            //instancia del comando:
            SqlCommand comando = new SqlCommand();
            //Relación del comando con la conexión:
            comando.Connection = conexion;

            //Se asigna el texto con el nombre del Stored Procedure:
            comando.CommandText = "SP_AgregarProfesor";

            //Se le asigna el tipo de comando a Stored Procedure:
            comando.CommandType = CommandType.StoredProcedure;
            //Ahora se le asigna el parámetro de entrada y luego el de salida:
            //Parámetro de Entrada:
            comando.Parameters.AddWithValue("@IdProfesor", profesor.Identificacion);
            comando.Parameters.AddWithValue("@NombreProfesor", profesor.Nombre);
            comando.Parameters.AddWithValue("@Apellido1Profesor", profesor.Apellido1);
            comando.Parameters.AddWithValue("@Apellido2Profesor", profesor.Apellido2);
            comando.Parameters.AddWithValue("@TelefonoProfesor", profesor.Telefono);
            comando.Parameters.AddWithValue("@CorreoProfesor", profesor.Correo);
            comando.Parameters.AddWithValue("@Borrado", profesor.Borrado);
            //Parámetro de Salida:
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            //Ahora ejecutamos:
            try
            {
                //Abrimos conexión:
                conexion.Open();
                comando.ExecuteNonQuery();
                //resultado convertido a int, con un escalar para devolver 1 valor.
                resultado = Convert.ToInt32(comando.Parameters["@retorno"].Value);

                //Leer el parámetro de salida:
                _mensaje = comando.Parameters["@msj"].Value.ToString();

                //Cierro conexion
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
