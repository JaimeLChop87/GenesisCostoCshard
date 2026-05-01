using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Tipologia de recursos (materiales, mano obra, servicios, alquiler ...) 
    /// Gestion de tipologia de recursos
    /// Usado en la clase RecursosUnitario y Agrupador como campo obligado 
    /// </summary>
    public class TipoRecurso
    {
        public int Id { get; set; }
        public string DescripcionTipoRecurso { get; set; } = string.Empty;
        public string AbrTipoRecurso { get; set; } = string.Empty;
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        // constructor
        public TipoRecurso() { }
        public TipoRecurso(string descrip, string abrTipoRec ):this() 
        {
            DescripcionTipoRecurso = descrip;
            AbrTipoRecurso= abrTipoRec;
            Estado = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
