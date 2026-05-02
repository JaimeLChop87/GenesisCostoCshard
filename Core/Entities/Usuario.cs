using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Genesis.Utils;

namespace Core.Entities
{
    /// <summary>
    /// Clase Usuario
    /// Contiene reglas y parametros en la creacion de Usuario
    /// En la creacion de cuentas de usuario
    /// </summary>
    public class Usuario
    {
        // campo uso para BBDD
        public int Id { get; private set; }
        
        // campos privados
        private string _username = string.Empty;
        private string _nombrePila = string.Empty;
        private string _email = string.Empty;
        private string _passWordHash = string.Empty;

        public RolUsuario Rol { get; set; }
        public bool EstaActivo { get; set; }
        public DateTime UltimoIngreso { get; set; }


        // metodos encapsulamiento entrada de texto
        public string Username 
        { 
            get => _username;
            set => _username = TextStandardizer.TextMayusClear(value);  
        }

        public string NombrePila
        {
            get => _nombrePila;
            set => _nombrePila = TextStandardizer.TextMayusClear(value);
        }

        public string Email
        {
            get => _email;
            set => _email = TextStandardizer.ValidarEmail(value);
        }

        public string PasswordHash
        { 
            get=> _passWordHash; 
            set => _passWordHash=value;
        }

        // roles de usarios en la aplicacion
        public enum RolUsuario { Xverificar, Administrador, Usuario, Estudiante }

        // constructor
        public Usuario() { }
        public Usuario(string user, string nombre,string email, string passHash)
        {
            Username = user;
            NombrePila = nombre;
            Email = email;
            PasswordHash = PasswordHasher.HashPassword(passHash);
            
            EstaActivo = true;
            Rol = RolUsuario.Xverificar;
        }

    }
}
