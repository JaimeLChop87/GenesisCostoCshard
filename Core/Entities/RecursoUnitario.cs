using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Core.Entities
{
    /// <summary>
    /// Representa la unidad mínima de costo dentro de un Análisis de Precios Unitarios (APU).
    /// Gestiona datos para la creacion de insumos (unidad, tipoRecurso, Agrupador, valor unitario Bruto)
    /// Es usado por la clase APU como unidad de la estructura
    /// validación de costos y procedencia.
    /// </summary>
    public class RecursoUnitario
    {
        public int Id { get; set; }
        public string NombreRecursoUnitario { get; set; } = string.Empty;
        public string Unidad { get; set; } = string.Empty;
        public string TipoRecurso { get; set; } = string.Empty;
        public string Agrupador { get; set; } = string.Empty;

        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        private decimal _valorUnitarioBruto;
        /// <summary>
        /// Valor unitario antes de impuestos. 
        /// El sistema ajusta automáticamente a 0 si se intenta ingresar un valor negativo.
        /// </summary>
        public decimal ValorUnitarioBruto { 
            get => _valorUnitarioBruto;
            set => _valorUnitarioBruto = value < 0 ? 0 : value;
        }
        // Constructor
        public RecursoUnitario() { }
        public RecursoUnitario(string nombre, string unidad, string tipoRecurso, string agrupador, decimal valor) : this()
        {
            NombreRecursoUnitario = nombre;
            Unidad = unidad;
            TipoRecurso = tipoRecurso;
            Agrupador = agrupador;
            ValorUnitarioBruto = valor;
            Estado = true;
            FechaCreacion = DateTime.Now;

        }

    }

}
