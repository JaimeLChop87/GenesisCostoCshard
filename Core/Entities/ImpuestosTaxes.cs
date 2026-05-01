using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// define la naturaleza y el porcentaje de un gravamen o retención
    /// gestiona calculos de impustos bases y porcentajes
    /// </summary>
    public class ImpuestosTaxes
    {
        public int Id { get; set; }
        public string DescripcionImpuesto { get; set; } = string.Empty; 
        public decimal ValorImpuesto { get; set; }

        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public NaturalezaImpuesto Naturaleza { get; set; } 

        // constructor 
        public ImpuestosTaxes() { }
        public ImpuestosTaxes(string nombre, decimal porcentaje, NaturalezaImpuesto naturaleza)
        {
            DescripcionImpuesto = nombre;
            ValorImpuesto = porcentaje;
            Naturaleza = naturaleza;
        }

        public enum NaturalezaImpuesto { Gravamen, Retencion }
    }
}
