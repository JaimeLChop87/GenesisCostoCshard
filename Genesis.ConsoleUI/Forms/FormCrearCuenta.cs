using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Genesis.Utils;


namespace Genesis.ConsoleUI.Forms
{
    public static class FormCrearCuenta
    {

        public static void FormCrearCuentaUser()
        {
            Console.Clear();
            
            ForCabecera();
            InfoFormUserName();
            // 1. Nombre Usuario
            Console.WriteLine("Nombre Usuario");
            string nombreUser = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(TextStandardizer.ValidarNameUser(nombreUser)))
                {
                    nombreUser = TextStandardizer.ValidarNameUser(nombreUser);
                    Console.Clear();
                    ForCabecera();
                    InfoFormUserNick();
                    Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                    Console.WriteLine("\nNick_Name Usuario (Nombre a mostrar en app)");
                    break;
                }
                Console.Clear();
                ForCabecera();
                InfoFormUserName();
                Console.WriteLine("\nNombre Usuario");
                nombreUser = Console.ReadLine();
            }

            // 2. Solicitud NickName User
            string nickName = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(TextStandardizer.ValidarNickUser(nickName)))
                {
                    nickName = TextStandardizer.ValidarNickUser(nickName);
                    Console.Clear();
                    ForCabecera();
                    InfoFormEmail();
                    Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                    Console.WriteLine($"\nNickName Usuario: {nickName}");
                    Console.WriteLine("\nEmail User: ");
                    break;
                }
                Console.Clear();
                ForCabecera();
                InfoFormUserNick();
                Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                Console.WriteLine("\nNick_Name Usuario (Nombre a mostrar en app)");
                nickName = Console.ReadLine();
            }

            // 3. email
            string emailUser = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(TextStandardizer.ValidarEmail(emailUser)))
                {
                    emailUser = TextStandardizer.ValidarEmail(emailUser);
                    Console.Clear();
                    ForCabecera();
                    InfoFormPassword();
                    Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                    Console.WriteLine($"\nNickName Usuario: {nickName}");
                    Console.WriteLine($"\nEmail User: {emailUser}");
                    Console.WriteLine("\nConraseña: ");
                    break;
                }
                Console.Clear();
                ForCabecera();
                InfoFormEmail();
                Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                Console.WriteLine($"\nNickName Usuario: {nickName}");
                Console.WriteLine("\nEmail User:");
                emailUser = Console.ReadLine();
            }

            // 5. password App
            string password = ConsoleHelper.LeerPasswordSeguroConsola();
            while (true)
            {
                if (!string.IsNullOrEmpty(TextStandardizer.ValidarEmail(password)))
                {
                    password = TextStandardizer.ValidarEmail(password);
                    Console.Clear();
                    ForCabecera();
                    Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                    Console.WriteLine($"\nNickName Usuario: {nickName}");
                    Console.WriteLine($"\nEmail User: {emailUser}");
                    break;
                }
                Console.Clear();
                ForCabecera();
                InfoFormPassword();
                Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                Console.WriteLine($"\nNickName Usuario: {nickName}");
                Console.WriteLine($"\nEmail User: {emailUser}");
                Console.WriteLine("\nConraseña: ");
                password = ConsoleHelper.LeerPasswordSeguroConsola();
            }


        }

        public static void ForCabecera()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("          Genesis Costos          ");
            Console.WriteLine("    Crear Cuenta Nueva Usuario    ");
            Console.WriteLine("==================================");
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese los campos requeridos");
            Console.WriteLine("");

        }

        public static void InfoFormUserName()
        {
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
            Console.WriteLine("1. el nombre no puede estar limpio");
            Console.WriteLine("2. el nombre puedo contener los caracteres (0-9 A-Z -  .  _ )");
            Console.WriteLine("3. la cantidad de caracteres del nombre no debe ser menor a 5, no debe superar los 40 caracteres");
            Console.WriteLine("4.1 el nombre debe contener como minimo 3 caractes de tipo Letra");
            Console.WriteLine("4.2 el nombre debe de contener maximo 7 caracteres de tipo Num");
            Console.WriteLine("");
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
        }

        public static void InfoFormUserNick()
        {
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
            Console.WriteLine("1. el NickName no puede estar limpio");
            Console.WriteLine("2. el NickName puede contener los caracteres (0-9 A-Z -  .  _ )");
            Console.WriteLine("3. la cantidad de caracteres del NickName  no debe ser menor a 7, no debe superar los 21 caracteres");
            Console.WriteLine("4.1 el NickName debe contener como minimo 7 caractes de tipo Letra");
            Console.WriteLine("4.2 el NickName debe de contener maximo 7 caracteres de tipo Num");
            Console.WriteLine("");
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
        }

        public static void InfoFormEmail()
        {
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
            Console.WriteLine("1.0 el Email no puede estar limpio");
            Console.WriteLine("2.0 el email, debde de tener un solo @");
            Console.WriteLine("3.0 el email debe de estar compuesto por 'local@dominio.' ");
            Console.WriteLine("4.1 el email.local no debe superar los 64 caracteres");
            Console.WriteLine("4.2 el email no puede comenzar con punto o guion . o -");
            Console.WriteLine("4.3 el email no puede contener dos puntos seguidos '..'");
            Console.WriteLine("4.4 los caracteres permitidos Email.Local '!' '#' '$' '%' '&' '*' '+' '-' '/' '=' '?' '^' '_' '.' '{' '|' '}'");
            Console.WriteLine("Correos permitidos terminados en .COM", ".NET", ".ORG", ".CO", ".EDU");
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
        }

        public static void InfoFormPassword()
        {
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
            Console.WriteLine("1.0 el password no puede estar limpio o contener espacios");
            Console.WriteLine("2.0 el password debe de contener min un char MAYUSCULA");
            Console.WriteLine("3.0 el password debe de contener min un char miníscula");
            Console.WriteLine("4.0 el password debe de contener min un digito");
            Console.WriteLine("5.0 el password debe de contener min un char especial");
            Console.WriteLine("los caracteres permitidos '!' '#' '$' '%' '&' '*' '+' '-' '/' '=' '?' '^' '_' '.' '{' '|' '}'");
            Console.WriteLine("6.0 el password debe ser mayor a 8 caracterres");
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
        }
    }

        

}
