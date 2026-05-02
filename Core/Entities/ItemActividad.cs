using Genesis.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ItemActividad
    {
        // campos usados BBDD
        public int Id { get; private set; }
        // campos clases foraneos BBDD
        public int UnidadMedidaId { get; set; }

        // campos privados
        private string _nombreItemActividad = string.Empty;
        private string _descripcionItemActividad = string.Empty;

        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        //objetos clases foraneas
        public UnidadMedida Unidad {  get; set; }

        // metodos de validacion informacion
        public string NombreItemActividad 
        { 
            get => _nombreItemActividad; 
            set => _nombreItemActividad = TextStandardizer.TextMayusClear(value);
        }

        public string DescripcionItemActividad
        {
            get => _descripcionItemActividad;
            set => _descripcionItemActividad = TextStandardizer.TextMayusClear(value);
        }

        // Constructor 
        public ItemActividad() { }
        public ItemActividad(string nombre, UnidadMedida unidad, string descripcion) : this()
        {
            NombreItemActividad = nombre;
            Unidad = unidad;
            DescripcionItemActividad = descripcion;
            EstaActivo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
