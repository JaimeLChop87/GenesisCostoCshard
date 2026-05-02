using Genesis.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoCosto
    {
        // campo de uso para BBDD
        public int Id { get; private set; }

        // campos privados de la clase
        private string _descripcionTipoCosto=string.Empty;
        private string _abreviatura = string.Empty;

        public bool EstaActivo { get; set; }
        public DateTime FechaCreacion { get; set; }

        // metodos de validacion entrada datos
        public string DescripcionTipoCosto
        {
            get => _descripcionTipoCosto;
            set => _descripcionTipoCosto = TextStandardizer.TextMayusClear(value);
        }

        public string Abreviatura
        {
            get => _abreviatura;
            set => _abreviatura = TextStandardizer.TextMayusClear(value);
        }

        // constructor
        public TipoCosto() { }
        public TipoCosto(string descripcionTipoCosto, string Abre): this() {
            DescripcionTipoCosto = descripcionTipoCosto;
            Abreviatura = Abre;
            EstaActivo = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
