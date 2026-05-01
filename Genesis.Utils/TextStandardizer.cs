using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Utils
{
    /// <summary>
    /// limpiar una entrada potencialmente peligrosa o mal formateada para dejarla en un estado saludable para el sistema.
    /// </summary>
    public static class TextStandardizer
    {
        private static readonly char[] CharsLocalValids = { '!', '#', '$', '%', '&', '*', '+', '-', '/', '=', '?', '^', '_', '.', '{', '|', '}' };
        private static readonly string[] TLDValids = { ".COM", ".NET", ".ORG", ".CO", ".EDU" };
        
        /// <summary>
        /// Metodo validacion entrada de texto
        /// devuelve "" si es null, convierte entrada MAYUS Limpia espacios vacios
        /// Entradas de texto
        /// </summary>
        /// <param name="text"> string caracteres </param>
        public static string TextMayusClear (string text)
        {
            if (String.IsNullOrEmpty(text))
            return string.Empty;

            return text.Trim().ToUpper();
        }

        /// <summary>
        /// Metodo validacion entrada Email
        /// si es null = "", 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string ValidarEmail (string email)
        {
            // 1. Limpieza Validacion no null o empy
            string emailClear = TextMayusClear(email);
            if (string.IsNullOrEmpty(emailClear))
            {
                return string.Empty;
            }
            // 2. validacion de arrrova
            if (string.IsNullOrEmpty(ValidarEmailArrova(emailClear)))
            {
                return string.Empty;
            }

            // 3. Identificacion de partes del Email
            // Local @ Dominio
            int indArrova = emailClear.IndexOf("@");
            string localEmail = emailClear.Substring(0, indArrova);
            string dominioEmail = emailClear.Substring(indArrova + 1);

            // 4. Validacion de partes Local Dominio
            if (string.IsNullOrEmpty(ValidarLocalEmail(localEmail)))
            {
                return string.Empty;
            }
            if (string.IsNullOrEmpty(ValidarDominioEmail(dominioEmail)))
            {
                return string.Empty;
            }

            return emailClear;

        }

        /// <summary>
        /// Metodo Validacion LocalEmail
        /// Valida estructura minima de la Local del Email ingresado por el Usuario
        /// Usos en la validacion de inreso e EMAIL usuario
        /// </summary>
        private static string ValidarLocalEmail(string Emaillocal)
        {
            string local = Emaillocal.Trim().ToUpper();
            

            // 1. local no superior a 64 caracteres
            if (local.Length > 64)
                return string.Empty;

            // 2.1 local no puede comenzar con "."
            if (local.StartsWith(".") || local.EndsWith("."))
                return string.Empty;
            // 2.2 local no puede comenzar con "-"
            if (local.StartsWith("-") || local.EndsWith("-"))
                return string.Empty;

            // 3. local no puede contener puntos seguidos ".."
            if (local.Contains("..")) 
                return string.Empty;
            
            // 4. validacion de caracteres especiales
            foreach (char c in local)
            {
                if (!char.IsLetterOrDigit(c) && !CharsLocalValids.Contains(c))
                    return string.Empty;
            }
            return local;
        }

        /// <summary>
        /// Metodo Validacion DominioEmail
        /// Valida estructura minima del Dominio del Email ingresado por el Usuario
        /// Usos en la validacion de inreso e EMAIL usuario
        /// </summary>
        private static string ValidarDominioEmail(string EmailDominio)
        {
            string Dominio = EmailDominio.Trim().ToUpper();
            List<char> CharsValids = new() {'–','_','.'};

            // 1. Dominio Máximo 240 caracteres en total
            if (Dominio.Length > 240)
                return string.Empty;


            // 2.1 Dominio no puede comenzar con "."
            if (Dominio.StartsWith(".") || Dominio.EndsWith("."))
                return string.Empty;
            // 2.2 Dominio no puede comenzar con "-"
            if (Dominio.StartsWith("-") || Dominio.EndsWith("-"))
                return string.Empty;

            // 3. Dominio no puede contener puntos seguidos ".."
            if (Dominio.Contains(".."))
                return string.Empty;


            // 4. validacion de caracteres especiales
            foreach (char c in Dominio)
            {
                if (!char.IsLetterOrDigit(c) && !CharsValids.Contains(c))
                    return string.Empty;
            }

            // 5. validacion terminacion TLD validos
            foreach (string tld in TLDValids)
            {
                if (Dominio.EndsWith($"{tld}"))
                    return Dominio;
            }
            return string.Empty;
        }

        /// <summary>
        /// Metodo Validacion caracter @ en Email
        /// Valida estructura minima contenido "@" exista una unica vez
        /// Usos en la validacion de inreso e EMAIL usuario
        /// </summary>
        private static string ValidarEmailArrova(string Email)
        {
            int CountArrove = 0;

            // 1. validar la existencia de un @
            if (!Email.Contains("@"))
                return string.Empty;

            // 2. validar que el correo no comience con @
            if (Email.StartsWith("@"))
                return string.Empty;

            // 3 . validacion que solo un @ exista en el correo
            foreach(char c in Email)
            {
                if (c == '@')
                    CountArrove++;
            }
            if (CountArrove > 1)
                return string.Empty;

            return "@";
        }

    }
}
