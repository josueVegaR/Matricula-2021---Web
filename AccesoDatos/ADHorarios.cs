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
    public class ADHorarios
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
        public ADHorarios()
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADHorarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Métodos

        //Método para insertar un Horario:
        public int InsertarHorarios(Horarios horario)
        {
            //Se establece la conexión con la BD:
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Se crea el objeto comando para ejecutar la sentencia:
            SqlCommand comando = new SqlCommand();
            //Se inicializa el valor de retorno que es el Identity generado:
            int filasAfectadas = 0;
            //Se prepara el comando: 
            string sentencia = "INSERT INTO TBL_Horarios(CodMateriaAbierta, Dia, HoraInicio, HoraFin) values (@CodMateriaAbierta, @Dia, @HoraInicio, @HoraFin)";
            

            //Se establece la conexión:
            comando.Connection = conexion;

            //Se asignan los valores de los parámetros:
            comando.Parameters.AddWithValue("@CodMateriaAbierta", horario.CodMateriaAbierta.CodMateriaAbierta);
            comando.Parameters.AddWithValue("@Dia", horario.Dia);
            comando.Parameters.AddWithValue("@HoraInicio", horario.HoraInicio);
            comando.Parameters.AddWithValue("@HoraFin", horario.HoraFin);

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

        //Método para cargar la consulta de Horarios 
        public DataSet ListarHorarios(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // El data adapter permite para guardar los cambios en la BD:
            SqlDataAdapter adapter;

            //Sentencia:
            string sentencia = "select		m.CodigoMateria, m.NombreMateria, h.Dia, h.HoraInicio, h.HoraFin" +
                " from		TBL_Horarios H inner join TBL_MateriasAbiertas MA" +
                " on			h.CodMateriaAbierta = ma.CodMateriaAbierta" +
                " inner join	TBL_MateriasCarreras mc" +
                " on			ma.CodMateriaCarrera = mc.CodMateriaCarrera" +
                " inner join	TBL_Materias m" +
                " on			mc.CodigoMateria = m.CodigoMateria";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Horarios");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }


        #endregion
    }
}
