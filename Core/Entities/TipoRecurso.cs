using Genesis.Utils;
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
        // campos de uso BBDD
        public int Id { get; private set; }
        private string _descripcionTipoRecurso = string.Empty;
        private string _abreviatura  = string.Empty;


        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        // metodos de validacion entrada datos
        public string DescripcionTipoRecurso 
        { 
            get => _descripcionTipoRecurso; 
            set => _descripcionTipoRecurso = TextStandardizer.TextMayusClear(value); 
        }

        public string Abreviatura 
        { 
            get => _abreviatura; 
            set => _abreviatura = TextStandardizer.TextMayusClear(value); 
        }

        // constructor
        public TipoRecurso() { }
        public TipoRecurso(string descrip, string abrTipoRec ):this() 
        {
            DescripcionTipoRecurso = descrip;
            Abreviatura = abrTipoRec;
            EstaActivo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
