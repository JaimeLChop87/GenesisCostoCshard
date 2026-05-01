using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Entities
{
    public class Agrupador
    {
        /// <summary>
        /// Módulo de categorización lógica y tributaria. Clasifica los recursos y aplica las reglas de impuestos (detalle impuestos IVA, Retefuente, ICA...) 
        /// Gestion de agrupador Calculos de impuestos sobre el recursoUnitario
        /// </summary>
        public int Id { get; set; }
        public string NombreAgrupador {  get; set; } = string.Empty;
        public string DescripAgrupador { get; set; } = string.Empty;
        
        public bool AplicaIVA { get; set; } = false;
        public decimal ValorIVA { get; set; } = 0.0m;
        public bool EsIVADescontable { get; set; } = true;

        public TipoRecurso Tipo { get; set; }

        // Otros Impuestos <"nombre","base"> <"reteICA","0.01">
        public List<ImpuestosTaxes> OtrosImpuestos { get; set; } = new List<ImpuestosTaxes>();


        // Constructor
        public Agrupador() { }
        public Agrupador(string nombre, string desc, TipoRecurso tipo, decimal iva): this() 
        {
            NombreAgrupador = nombre;
            DescripAgrupador = desc;
            Tipo = tipo;
            AplicaIVA = iva > 0;
            ValorIVA = iva;
        }

        public void AgregarImpuesto (ImpuestosTaxes impuestoNuevo) 
        {
            OtrosImpuestos.Add(impuestoNuevo);
        }
    }
}
