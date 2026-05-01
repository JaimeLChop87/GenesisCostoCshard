using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BCrypt.Net;

namespace Genesis.Utils
{
    public static class PasswordHasher
    {
        // Genera el Hash para guardar en la BBDD (Registro)
        public static string HashPassword(string password)
        {
            //
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Verifica si la clave coincide (Login)
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
