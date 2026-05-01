using Genesis.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Genesis.ConsoleUI.Forms;


namespace Genesis.ConsoleUI.Menus
{
    public static class MenuLoginUser
    {
        /// <summary>
        /// Menu Opciones de LoginUser
        /// Muestra opciones Ingreso, Crear, Recuperar(correo@), Cambiar Clave ingreso
        /// </summary>
        public static void MenuLoginUserUI()
        {
            int UserInput;
            do
            {
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("          Genesis Costos          ");
                Console.WriteLine("       Menu Ingreso Usuario       ");
                Console.WriteLine("==================================");
                Console.WriteLine("----------************------------");
                Console.WriteLine("                                  ");
                Console.WriteLine("1 - Iniciar Seción");
                Console.WriteLine("2 - No tienes cuenta? Crear una");
                Console.WriteLine("3 - Olvidaste Usuario o Clave?");
                Console.WriteLine("4 - Cambiar clave acceso");
                Console.WriteLine("5 - Regresar volver...");
                Console.WriteLine("9 - Salir de la aplicacion");
                Console.WriteLine("                                  ");
                Console.WriteLine("----------************------------");
                Console.WriteLine("Ingrese Opción Menu");

                string input = Console.ReadLine() ?? "";

                UserInput = Conversores.ConversorInt(input);

                switch (UserInput)
                {
                    case 1: Console.WriteLine("iniciar Sesion");
                        FormUserLogin.FormIniciarSecion();
                        break;

                    case 2:
                        Console.WriteLine("Direccionando creacion cuenta");
                        FormCrearCuenta.FormCrearCuentaUser();
                        break;

                    case 3:
                        Console.WriteLine("Direccionando creacion cuenta");
                        ConsoleHelper.Pausa();
                        break;

                    case 4:
                        Console.WriteLine("Cambiao de cosntraseña");
                        ConsoleHelper.Pausa();
                        break;

                    case 5:
                        Console.WriteLine("Regresando a Menu Incial");
                        return;

                    case 9:
                        ConsoleHelper.FinalizarAplicacion();
                        break;

                    default:
                        Console.WriteLine("Valor no valido");
                        ConsoleHelper.Pausa();
                        break;
                }
            } while (UserInput!=9);
        }


    }
}