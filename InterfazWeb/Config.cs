using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace InterfazWeb
{
    public static class Configuracion
    {

        //esto es para sacar la cadena de conexión de la webConfig:
        public static string getConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["ConnectionString"];
            }
        }
    }
}