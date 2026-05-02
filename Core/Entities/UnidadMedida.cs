using Genesis.Utils;
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
        // campo uso para BBDD
        public int Id { get; private set;}
        
        // propiedades privadas
        private string _descripcionUnidad = string.Empty;
        private string _abreviatura = string.Empty;
        private decimal _unidadConver = 0m;

        // campos publicos
        public TiposMedidas TipoMedida {get; set;}
        
        public bool EsReferencia {get; set;} = false;

        public bool EstaActivo { get; set;}
        public DateTime FechaCreacion {get; set;}

        // metodos encapsulamiento valores
        public string DescripcionUnidad 
        { 
            get => _descripcionUnidad; 
            set => _descripcionUnidad = TextStandardizer.TextMayusClear(value); 
        }

        public string Abreviatura
        {
            get => _abreviatura;
            set => _abreviatura = TextStandardizer.TextMayusClear(value);
        }

        public decimal UnidadConversion 
        { 
            get => _unidadConver; 
            set => _unidadConver = DigitStandarizer.ValidarDecimalPos(value); 
        }

        public enum TiposMedidas { Longitud, Area, Volumen, Masa, Tiempo, Temperatura, Compuesta }

        //constructor
        public UnidadMedida() { }
        public UnidadMedida(string descripcion, string abreUnidad, TiposMedidas tipoMedida, decimal conver ) : this()
        {
            DescripcionUnidad = descripcion;
            Abreviatura = abreUnidad;
            TipoMedida = tipoMedida;
            UnidadConversion = conver;
            EsReferencia = false;
            EstaActivo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
