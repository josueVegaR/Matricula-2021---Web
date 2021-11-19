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
    public class ADMateriasCarreras
    {
        //Clases ADO

        //atributos
        private string _cadenaConexion;
        private string _mensaje;

        //propiedad
        public string Mensaje
        {
            get => _mensaje;
        }
        public string CadenaConexion
        {
            set => _cadenaConexion = value;
        }
        public ADMateriasCarreras()
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADMateriasCarreras(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Métodos:

        //El tipo DataSet me permite guardar una tabla o el resultado de una consulta de las tablas de la BD:
        public DataSet ListarMateriasCarreras(string condicion)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);


            // El data adapter permite para guardar los cambios en la BD:
            SqlDataAdapter adapter;

            //Sentencia:
            string sentencia = "SELECT	MC.CodMateriaCarrera, MA.NombreMateria, CreditosMateria, NombreCarrera, ca.CodigoCarrera" +
                " FROM TBL_Materias MA INNER JOIN TBL_MateriasCarreras MC" +
                " ON MA.CodigoMateria = MC.CodigoMateria" +
                " inner join TBL_Carreras ca" +
                " on mc.CodigoCarrera = ca.CodigoCarrera";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Materias");
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }

        
        public MateriasCarreras ObtenerMateriaCarrera(int codMateriaCarrera)
        {
            MateriasCarreras materiaCarrera = new MateriasCarreras();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            //esta clase no tiene constructor, se instancia con un execute.
            SqlDataReader dataReader;
            //Sentencia de SQL:
            string sentencia = string.Format("Select		Ma.CodigoMateria, Ma.CreditosMateria, Ca.NombreCarrera, Ma.NombreMateria, MC.CodMateriaCarrera" +
                                             " from		TBL_Materias Ma inner join TBL_MateriasCarreras MC" +
                                             " on			Ma.CodigoMateria = MC.CodigoMateria" +
                                             " inner join	TBL_Carreras Ca" +
                                             " on			Ca.CodigoCarrera = MC.CodigoCarrera" +
                                             " where		MC.CodMateriaCarrera = {0}", codMateriaCarrera);

            //Peparar la conexión:
            comando.Connection = conexion;

            //Preparar el comando:
            comando.CommandText = sentencia;

            materiaCarrera.Materia = new Materias();

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
                    materiaCarrera.Materia.CodigoMateria = dataReader.GetString(0);
                    materiaCarrera.Materia.CreditosMateria = dataReader.GetByte(1);
                    materiaCarrera.Carrera.NombreCarrera = dataReader.GetString(2);
                    materiaCarrera.Materia.NombreMateria = dataReader.GetString(3);
                    materiaCarrera.CodMateriaCarrera = dataReader.GetInt32(4);
                }
                // Cierro la conexión:
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return materiaCarrera;
        }

    }
}
