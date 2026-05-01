using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoCosto
    {
        public int Id { get; set; }
        public string DescripcionTipoCosto { get; set; }
        public string AbreTipoCosto { get; set; }

        // constructor
        public TipoCosto() { }
        public TipoCosto(string descripcionTipoCosto, string Abre): this() {
            DescripcionTipoCosto = descripcionTipoCosto;
            AbreTipoCosto = Abre;

            }
    }
}
