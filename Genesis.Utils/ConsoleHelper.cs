using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Utils
{
    /// <summary>
    /// Proporciona herramientas estandarizadas para el manejo de la interfaz de consola.
    /// </summary>
    public static class ConsoleHelper
    {
        /// <summary>
        /// Detiene la ejecución y espera a que el usuario presione una tecla.
        /// Centraliza el mensaje de espera para mantener la consistencia en toda la App.
        /// </summary>
        public static void Pausa()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(">>> Presione cualquier tecla para continuar...");
            Console.WriteLine("----------------------------------------------");
            Console.ReadKey();
        }

        /// <summary>
        /// Finalizar aplicacion
        /// Finaliza la ejecucion de la aplicacion cuando el usuario selecciona Salir.
        /// </summary>
        public static void FinalizarAplicacion()
        {
            Console.Clear();
            Console.WriteLine("Cerrando Génesis Costos...");
            Console.WriteLine("Gracias por usar nuestra aplicacion.");
            Thread.Sleep(1000); 
            Environment.Exit(0);
        }
        /// <summary>
        /// Metodo  LeerPasswordSeguro
        /// Oculata caracter digitado por usuario y muestra "*"
        /// Ingresar informacion protegida, retorna " string pass"
        /// </summary>
        /// <returns></returns>
        public static string LeerPasswordSeguroConsola()
        {
            string pass = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass = pass.Substring(0, (pass.Length - 1));
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return pass;
        }
    }
}
