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
    public class ADMateriasAbiertas
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
        public ADMateriasAbiertas()
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADMateriasAbiertas(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Métodos

        //Método para insertar una Materia Abierta y generar un código Materia Abierta:
        public int InsertarMateriaAbierta(MateriasAbiertas materia)
        {
            //Se establece la conexión con la BD:
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Se crea el objeto comando para ejecutar la sentencia:
            SqlCommand comando = new SqlCommand();
            //Se inicializa el valor de retorno que es el Identity generado:
            int codigoMateriaAbierta = 0;
            //Se prepara el comando: 
            string sentencia = "INSERT INTO TBL_MateriasAbiertas(CodMateriaCarrera, CodigoAula, Grupo, Cupo, Costo, Periodo, Anio) VALUES (@CodMateriaCarrera, @CodigoAula, @Grupo, @Cupo, @Costo, @Periodo, @Anio) select @@identity";
            //Sin profesor:
            //string sentencia2 = "INSERT INTO TBL_MateriasAbiertas(CodMateriaCarrera, CodigoProfesor, CodigoAula, Grupo, Cupo, Costo, Periodo, Anio) VALUES (@CodMateriaCarrera, @CodigoProfesor, @CodigoAula, @Grupo, @Cupo, @Costo, @Periodo, @Anio) select @@identity";
            
            
            //Se establece la conexión:
            comando.Connection = conexion;

            //Se asignan los valores de los parámetros:
            comando.Parameters.AddWithValue("@CodMateriaCarrera", materia.CodMateriaCarrera.CodMateriaCarrera);
            //aquí iba el profesor
            comando.Parameters.AddWithValue("@CodigoAula", materia.CodigoAula.CodigoAula);
            comando.Parameters.AddWithValue("@Grupo", materia.Grupo);
            comando.Parameters.AddWithValue("@Cupo", materia.Cupo);
            comando.Parameters.AddWithValue("@Costo", materia.Costo);
            comando.Parameters.AddWithValue("@Periodo", materia.Periodo);
            comando.Parameters.AddWithValue("@Anio", materia.Anio);

            //Se asigna la sentencia:
            comando.CommandText = sentencia;
            try
            {
                //Se abre la conexión
                conexion.Open();
                //Se asigna el identity devuelto al código de materia abierta:
                codigoMateriaAbierta = Convert.ToInt32(comando.ExecuteScalar());
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
            //Se devuelve el identity:
            return codigoMateriaAbierta;
        }

        //Método para cargar la consulta de materias 
        public DataSet ListarMateriasAbiertas(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // El data adapter permite para guardar los cambios en la BD:
            SqlDataAdapter adapter;

            //Sentencia:
            string sentencia = "select		M.CodigoMateria, m.NombreMateria, ho.Dia, ho.HoraInicio, ho.HoraFin, ma.CodigoProfesor, ma.CodigoAula" +
                " from		TBL_Materias M inner join TBL_MateriasCarreras MC" +
                " on			M.CodigoMateria = MC.CodigoMateria inner join TBL_MateriasAbiertas MA" +
                " on			MC.CodMateriaCarrera = MA.CodMateriaCarrera inner join TBL_Horarios HO" +
                " on			MA.CodMateriaAbierta = HO.CodMateriaAbierta";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Materias Abiertas");
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
