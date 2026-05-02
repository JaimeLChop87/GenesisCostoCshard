using Genesis.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Entities
{
    /// <summary>
    /// Módulo de categorización lógica y tributaria. Clasifica los recursos y aplica las reglas de impuestos (detalle impuestos IVA, Retefuente, ICA...) 
    /// Gestion de agrupador Calculos de impuestos sobre el recursoUnitario
    /// </summary>
    public class Agrupador
    {
        // campos para usos de BBDD
        public int Id { get; private set; }
        // LLaves Foraneas      
        public int TipoRecursoId { get; set; }

        // campos privados
        private string _nombreAgrupador = string.Empty;
        private string _descripcionAgrupador = string.Empty;
        private decimal _valorIVA = 0m;

        // campos publicos 
        public bool AplicaIVA { get; set; } = false;

        //objetos clases foraneas
        public TipoRecurso RecursoAsignado { get; set; }

        // Bobeda Otros impuestos del agrupador <"ImpuestosTaxes">>
        public List<ImpuestosTaxes> OtrosImpuestos  = new List<ImpuestosTaxes>();

        // metodos de validacion informacion
        public string NombreAgrupador 
        { 
            get => _nombreAgrupador; 
            set => _nombreAgrupador = TextStandardizer.TextMayusClear(value); 
        }

        public string DescripcionAgrupador
        { 
            get => _descripcionAgrupador;
            set => _descripcionAgrupador = TextStandardizer.TextMayusClear(value);
        }

        public decimal ValorIVA
        { 
            get => _valorIVA; 
            set => _valorIVA = DigitStandarizer.ValidarDecimalPos(value); 
        }

        public enum ImpuestosTaxes { ReteICA, ReteIVA, Retefuente, Impoconsumo, X4xmil };

        // Constructor
        public Agrupador() { }
        public Agrupador(string nombre, string desc, TipoRecurso RcsoAsignado, decimal iva): this() 
        {
            NombreAgrupador = nombre;
            DescripcionAgrupador = desc;
            RecursoAsignado = RcsoAsignado;
            AplicaIVA = iva > 0;
            ValorIVA = iva;
            OtrosImpuestos = new List<ImpuestosTaxes>();
        }
    }
}
