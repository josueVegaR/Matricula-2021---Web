using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ValoresPorReferencia
    {
        #region Atributos
        
        private int id;
        private string dato;
        private decimal valor;

        #endregion

        #region Propiedades

        public int Id { get => id; set => id = value; }
        public string Dato { get => dato; set => dato = value; }
        public decimal Valor { get => valor; set => valor = value; }

        #endregion

        #region Constructores
        public ValoresPorReferencia()
        {
            id = 0;
            dato = string.Empty;
            valor = 0;
        }
        #endregion
    }
}
