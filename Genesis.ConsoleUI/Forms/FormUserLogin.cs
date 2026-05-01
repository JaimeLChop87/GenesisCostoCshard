using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genesis.ConsoleUI.Menus;
using Genesis.Utils;


namespace Genesis.ConsoleUI.Forms
{
    public static class FormUserLogin
    {
        public static int Intentos = 0;
        private const int MaxIntentos = 1;

        public static void FormIniciarSecion()
        {
            while (Intentos < MaxIntentos)
            {
                Console.Clear();
                ForCabecera();

                Console.WriteLine("Nombre usuario/Email:");
                string NombreEmailUser = Console.ReadLine();
                string correoEmailVerificado = TextStandardizer.TextMayusClear(NombreEmailUser);
                Console.WriteLine("Contraseña Clave:");
                string PassWord = ConsoleHelper.LeerPasswordSeguroConsola();
                string pass = PasswordHasher.HashPassword(PassWord);

                if (string.IsNullOrEmpty(correoEmailVerificado))
                {
                    Console.WriteLine("...Valor Vacio ingrese Minimo un Caracter....");
                    Intentos = Intentos + 1;
                    ConsoleHelper.Pausa();
                    continue;
                }
                if (string.IsNullOrEmpty(TextStandardizer.ValidarEmail(correoEmailVerificado)))
                {
                    Console.WriteLine("...correo o contraseña incorecto....");
                    Intentos = Intentos + 1;
                    ConsoleHelper.Pausa();
                    continue;
                }

                if (!string.IsNullOrEmpty(TextStandardizer.ValidarEmail(correoEmailVerificado)))
                {
                    Console.WriteLine("...Correo Valido....");
                    
                    ConsoleHelper.Pausa();
                    MenuLogPpal.MenuLogAppUserLog();
                    break;
                }

            }
            Intentos = 0;
            
        }

        public static void ForCabecera()        
        {
            Console.WriteLine("==================================");
            Console.WriteLine("          Genesis Costos          ");
            Console.WriteLine("      Iniciar Secion Usuario      ");
            Console.WriteLine("==================================");
            Console.WriteLine("----------************------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese NombreUsuario o Email");
            Console.WriteLine("");

        }
    }
}
