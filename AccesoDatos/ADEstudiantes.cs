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
    public class ADEstudiantes
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
        public ADEstudiantes()
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADEstudiantes(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion


        //Se crea un método para agregar un Estudiante en la BD con un Procedimiento Almacenado:
        public int CrearEstudiante(Estudiante estudiante)
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
            comando.CommandText = "SP_CrearEstudiante";

            //Se le asigna el tipo de comando a Stored Procedure:
            comando.CommandType = CommandType.StoredProcedure;
            //Ahora se le asigna el parámetro de entrada y luego el de salida:
            //Parámetro de Entrada:
            comando.Parameters.AddWithValue("@CarnetEstudiante", estudiante.CarnetEstudiante);
            comando.Parameters.AddWithValue("@IdEstudiante", estudiante.Identificacion);
            comando.Parameters.AddWithValue("@NombreEstudiante", estudiante.Nombre);
            comando.Parameters.AddWithValue("@Apellido1Estudiante", estudiante.Apellido1);
            comando.Parameters.AddWithValue("@Apellido2Estudiante", estudiante.Apellido2);
            comando.Parameters.AddWithValue("@TelefonoEstudiante", estudiante.Telefono);
            comando.Parameters.AddWithValue("@CorreoEstudiante", estudiante.Correo);
            comando.Parameters.AddWithValue("@ProvinciaEstudiante", estudiante.Provincia);
            comando.Parameters.AddWithValue("@CantonEstudiante", estudiante.Canton);
            comando.Parameters.AddWithValue("@DistritoEstudiante", estudiante.Distrito);
            comando.Parameters.AddWithValue("@OtrasSenias", estudiante.OtrasSenias);
            comando.Parameters.AddWithValue("@FechaIngreso", estudiante.FechaIngreso);
            comando.Parameters.AddWithValue("@Descuento", estudiante.Descuento);
            comando.Parameters.AddWithValue("@Estado", estudiante.Estado);
            comando.Parameters.AddWithValue("@Borrado", estudiante.Borrado);
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


        //Método para cargar la consulta de materias 
        public DataSet ListarEstudiantes(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // El data adapter permite para guardar los cambios en la BD:
            SqlDataAdapter adapter;

            //Sentencia:
            string sentencia = "Select		CarnetEstudiante, IdEstudiante, NombreEstudiante, Apellido1Estudiante, Apellido2Estudiante, TelefonoEstudiante, FechaIngreso" +
                " from		TBL_Estudiantes";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Estudiantes");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }
    }
}
