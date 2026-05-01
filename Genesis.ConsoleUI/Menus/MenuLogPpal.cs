using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Genesis.Utils;


namespace Genesis.ConsoleUI.Menus
{
    public static class MenuLogPpal
    {
        /// <summary>
        /// Menu inicial User NoLog
        /// Bienbenida app, logUser, mostrar informacion app y empresa
        /// UI inicial ingreso aplicativo 
        /// </summary>
        public static void MenuLogApp()
        {
            int UserInput;
            do
            {
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("       Genesis Costos 1.0.0       ");
                Console.WriteLine("==================================");
                Console.WriteLine("----------************------------");
                Console.WriteLine("                                  ");
                Console.WriteLine("1 - Menu Iniciar Seción");
                Console.WriteLine("2 - Informacion Empresa");
                Console.WriteLine("3 - Informacion App Genesis Costos");
                Console.WriteLine("9 - Salir");
                Console.WriteLine("                                  ");
                Console.WriteLine("----------************------------");
                Console.WriteLine("Ingrese Opción Menu");

                string input = Console.ReadLine() ?? "";

                UserInput = Conversores.ConversorInt(input);

                switch (UserInput)
                {
                    case 1:
                        Console.WriteLine("Iniciando sesion");
                        MenuLoginUser.MenuLoginUserUI();
                        break;

                    case 2:
                        Console.WriteLine("Mostrando Informacion de empresa");
                        ConsoleHelper.Pausa();
                        break;

                    case 3:
                        Console.WriteLine("Informacion de app");
                        ConsoleHelper.Pausa();
                        break;

                    case 9:
                        ConsoleHelper.FinalizarAplicacion();
                        break;

                    default:
                        Console.WriteLine("Valor no valido");
                        ConsoleHelper.Pausa();
                        break;

                }
            } while (UserInput != 9);
            Console.Clear();
        }
    
    
        /// <summary>
        /// Menu inicial UsuarioLoG, el usuario esta validado y logiado
        /// Bienbenida app, Ingresar aplicativo, mostrar informacion app y empresa, Gestion de cuenta
        /// UI ingreso aplicacion usuario logiado 
        /// </summary>
        public static void MenuLogAppUserLog()
        {
            int UserInput;
            do
            {
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("       Genesis Costos 1.0.0       ");
                Console.WriteLine($"                      ");
                Console.WriteLine("==================================");
                Console.WriteLine("----------************------------");
                Console.WriteLine("                                  ");
                Console.WriteLine("1 - Ingresar Genesis");
                Console.WriteLine("2 - Informacion Empresa");
                Console.WriteLine("3 - Informacion App Genesis Costos");
                Console.WriteLine("4 - Informacion Cuenta User");
                Console.WriteLine("9 - Salir");
                Console.WriteLine("                                  ");
                Console.WriteLine("----------************------------");
                Console.WriteLine("Ingrese Opción Menu");

                string input = Console.ReadLine() ?? "";

                UserInput = Conversores.ConversorInt(input);

                switch (UserInput)
                {
                    case 1:
                        Console.WriteLine("Direccionando a GENESIS");
                        ConsoleHelper.Pausa();
                        break;

                    case 2:
                        Console.WriteLine("Mostrando Informacion de empresa");
                        ConsoleHelper.Pausa();
                        break;

                    case 3:
                        Console.WriteLine("Informacion de app");
                        ConsoleHelper.Pausa();
                        break;

                    case 9:
                        ConsoleHelper.FinalizarAplicacion();
                        break;

                    default:
                        Console.WriteLine("Valor no valido");
                        ConsoleHelper.Pausa();
                        break;

                }
            } while (UserInput != 9);
            Console.Clear();
        }

    }
}