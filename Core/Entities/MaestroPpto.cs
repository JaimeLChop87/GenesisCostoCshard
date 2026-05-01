using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MaestroPpto
    {
        public int Id { get; set; }
        public string NombrePlantilla { get; set; } = string.Empty;
        public string AbrePlantillaPPto { get; set; } = string.Empty;
        public string VersionPlantilla { get; set; } = string.Empty;
        public int NivelEstructuraPlantilla { get; set; } = 1;
        public TipoCosto TipoCostoPlantilla { get; set; } 
     



        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }


    }
}
