using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Unidad de medida, 
    /// Gestion de unidades de medida, conversor de unidades de medida
    /// corresponde a la unidad de medida del recurso unitario, ItemActividad
    /// </summary>
    public class UnidadMedida
    {
        public int Id { get; set; }
        public string DescripcionUnidad { get; set; } = string.Empty;
        public string AbreUnidad { get; set; } = string.Empty;
        public string TipoMedida { get; set; } = string.Empty;
        public string UnidadRef {  get; set; } = string.Empty;
        public float UnidadConversion { get; set; } = float.MinValue;
        public bool Esref {  get; set; } = false;

        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        
        public UnidadMedida() { }
        public UnidadMedida(string descripcion, string abreUnidad, string tipoMedida, string uniRef, float conver ) : this()
        {
            DescripcionUnidad = descripcion;
            AbreUnidad = abreUnidad;
            TipoMedida = tipoMedida;
            UnidadRef = uniRef;
            UnidadConversion = conver;
            Esref = false;
            Estado = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
