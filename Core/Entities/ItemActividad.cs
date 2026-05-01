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
        public int Id { get; set; }
        public string NombreItemActividad { get; set; } = string.Empty;
        public string Unidad {  get; set; } = string.Empty;
        public string DescripcionItemActividad { get; set; } = string.Empty;

        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        // Constructor 
        public ItemActividad() { }
        public ItemActividad(string nombre, string unidad, string descripcion) : this()
        {
            NombreItemActividad = nombre;
            Unidad = unidad;
            DescripcionItemActividad = descripcion;
            Estado = true;
            FechaCreacion = DateTime.Now;
        }


    }
}
