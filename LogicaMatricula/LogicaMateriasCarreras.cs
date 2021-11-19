using Entidades;
using AccesoDatos;
using System;
using System.Data;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class LogicaMateriasCarreras
    {

        //atributos
        //Se vé mucho que los atributos privados tengan un guión bajo antes de la propiedad: _Propertie1
        private string _cadenaConexion;
        private string _mensaje;

        //propiedad
        public string Mensaje
        {
            get => _mensaje;
        }

        //constructor
        public LogicaMateriasCarreras(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public DataSet ListarMateriasCarreras(string condicion)
        {
            DataSet DS;
            ADMateriasCarreras AccesoDatos = new ADMateriasCarreras(_cadenaConexion);
            try
            {
                DS = AccesoDatos.ListarMateriasCarreras(condicion);
            }
            catch (Exception)
            {

                throw;
            }
            return DS;
        }

        public MateriasCarreras ObtenerMateriaCarrera(int codMateriaCarrera)
        {
            MateriasCarreras materiaCarrera;
            ADMateriasCarreras AccesoDatosMC = new ADMateriasCarreras(_cadenaConexion);
            try
            {
                materiaCarrera = AccesoDatosMC.ObtenerMateriaCarrera(codMateriaCarrera);
            }
            catch (Exception)
            {

                throw;
            }
            return materiaCarrera;
        }
    }
}
