using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Utils
{
    /// <summary>
    /// Proporciona métodos para transformar tipos de datos.
    /// </summary>
    public static class Conversores
    {
        /// <summary>
        /// Intenta convertir una cadena a un entero.
        /// Retorna el valor convertido o 0 si la entrada no es válida.
        /// </summary>
        /// <param name="entrada">Texto a convertir.</param>
        /// <returns>Valor entero o 0 por defecto.</returns>
        public static int ConversorInt (string? entrada)
        {
            if (string.IsNullOrWhiteSpace(entrada)) return 0;

            bool resultado = int.TryParse(entrada, out int salidaInt);

            return resultado ? salidaInt : 0;
        }
        
    }
}
