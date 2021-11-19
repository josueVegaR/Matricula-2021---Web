using Entidades;
using AccesoDatos;
using System;
using System.Data;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class LogicaProfesores
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

        public LogicaProfesores(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        #endregion

        #region Métodos

        // Método para listar en el DataSet la tabla devuelta por la consulta en el ADProfesores:
        public DataSet ListarProfesores(string condicion)
        {
            DataSet DS;
            ADProfesores AccesoDatosProfesores = new ADProfesores(_cadenaConexion);
            try
            {
                DS = AccesoDatosProfesores.ListarProfesores(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }

        public DataSet ListarProfesores2(string condicion)
        {
            DataSet DS;
            ADProfesores AccesoDatosProfesores = new ADProfesores(_cadenaConexion);
            try
            {
                DS = AccesoDatosProfesores.ListarProfesores2(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }

        // Método para devolver 1 Profesor:
        public Profesor ObtenerProfesor(int codigoProfesor)
        {
            Profesor Profesor;
            ADProfesores AccesoDatosProfesores = new ADProfesores(_cadenaConexion);
            try
            {
                Profesor = AccesoDatosProfesores.ObtenerProfesor(codigoProfesor);
            }
            catch (Exception)
            {

                throw;
            }
            return Profesor;
        }

        public int AsignarProfesor(Profesor profesor, int CodMateriaAbierta)
        {
            int filasAfectadas;
            ADProfesores ADProfesores = new ADProfesores(_cadenaConexion);
            try
            {
                filasAfectadas = ADProfesores.AsignarProfesor(profesor, CodMateriaAbierta);
            }
            catch (Exception)
            {

                throw;
            }
            return filasAfectadas;
        }

        //Método para la creación de un Profesor
        public int CrearProfesor(Profesor profesor)
        {
            //variable para guarda el retorno:
            int resultado;
            //una variable para acceso a datos:
            ADProfesores aDProfesores = new ADProfesores(_cadenaConexion);
            try
            {
                resultado = aDProfesores.CrearProfesor(profesor);
                _mensaje = aDProfesores.Mensaje;
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
