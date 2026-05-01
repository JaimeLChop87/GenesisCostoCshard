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

            // 1. Nombre Usuario
            Console.WriteLine("Nombre Usuario");
            string nombreUser = Console.ReadLine();
            while (string.IsNullOrEmpty(nombreUser))
            {

                if (string.IsNullOrEmpty(TextStandardizer.TextMayusClear(nombreUser)))
                {
                    Console.Clear();
                    ForCabecera();
                    Console.WriteLine("Nombre Usuario");
                    nombreUser = Console.ReadLine();
                    continue;
                }
                if (!string.IsNullOrEmpty(TextStandardizer.TextMayusClear(nombreUser)))
                {
                    Console.Clear();
                    ForCabecera();
                    Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                    break;
                }
            }

            // 2. NickName
            Console.WriteLine("Nick_Name Usuario (Nombre a mostrar en app)");
            string nickName = Console.ReadLine();

            while (string.IsNullOrEmpty(nickName))
            {

                if (string.IsNullOrEmpty(TextStandardizer.TextMayusClear(nickName)))
                {
                    Console.Clear();
                    FormUserLogin.ForCabecera();
                    Console.WriteLine($"Nombre Usuario: {nombreUser}");
                    Console.WriteLine("Nick_Name Usuario (Nombre a mostrar en app)");
                    nickName = Console.ReadLine();
                    continue;
                }
                if (!string.IsNullOrEmpty(TextStandardizer.TextMayusClear(nickName)))
                {
                    Console.WriteLine($"\nNombre Usuario: {nombreUser}");
                    Console.WriteLine($"Nick_Name Usuario: {nickName}");
                    break;
                }
            }


            // 3. NickName
            Console.WriteLine("Email");
            string emailUser = Console.ReadLine();

            while (string.IsNullOrEmpty(emailUser))
            {

                if (string.IsNullOrEmpty(TextStandardizer.TextMayusClear(nickName)))
                {
                    Console.Clear();
                    FormUserLogin.ForCabecera();
                    Console.WriteLine($"Nombre Usuario: {nombreUser}");
                    Console.WriteLine("Nick_Name Usuario (Nombre a mostrar en app)");
                    nickName = Console.ReadLine();
                    continue;
                }
                if (!string.IsNullOrEmpty(TextStandardizer.TextMayusClear(nickName)))
                {
                    Console.WriteLine($"Nombre Usuario: {nombreUser}");
                    Console.WriteLine($"Nick_Name Usuario: {nickName}");
                    break;
                }
            }


            Console.WriteLine("Conraseña: ");


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
    }

        

}
