using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    public class Program
    {
        static void Main(string[] args)
        {
            ValidaUsua arrayUsuarios = new ValidaUsua();
            arrayUsuarios.baseUsuarios();

            Console.WriteLine("                                 ------------------------------------------------");
            Console.WriteLine("                                 SISTEMA DE GESTIÓN ACÁDEMICA - CARRERAS DE GRADO");
            Console.WriteLine("                                 ------------------------------------------------");
            Console.WriteLine();

            bool correcto = false;

            do
            {
                bool seguir = false;

                do
                {
                    Console.WriteLine("Ingrese su número de DNI (sin puntos ni guiones): ", 1000000, 99999999);

                    var ingresoDNI = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(ingresoDNI) || !ingresoDNI.Any(c => Char.IsDigit(c)) || ingresoDNI.Contains('-'))
                    {
                        Console.WriteLine("Debe ingresar un número de DNI válido.");
                        continue;
                    }

                    if (ingresoDNI.Length != 8)
                    {
                        Console.WriteLine("Debe ingresar un número de DNI que contenga 8 dígitos.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese su contraseña:");
                        var ingresoContraseña = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(ingresoContraseña))
                        {
                            Console.WriteLine("Ingreso al sistema inválido. Por favor, inténtelo nuevamente.");
                            continue;
                        }
                        
                        bool res;
                        int a;

                        Usuario user = arrayUsuarios.Usuarios.FirstOrDefault(x => int.Parse(ingresoDNI) == x.dni && ingresoContraseña == x.contraseña);
                        
                        if (user != null)
                        {
                            correcto = true;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("                         MENÚ PRINCIPAL");
                                Console.WriteLine();
                                Console.WriteLine("1. Inscripción a cursos regulares");
                                Console.WriteLine("9. Salir");
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine();
                                Console.WriteLine("-----------------------------------------------------------------");
                                Console.WriteLine("Seleccione una opción del menú y presione [ENTER] para continuar.");
                                Console.WriteLine("-----------------------------------------------------------------");
                                string opcionMenu = Console.ReadLine();

                                res = int.TryParse(opcionMenu, out a);

                                if (res)
                                {
                                    if (a == 1 || a == 9)
                                    {
                                        switch (opcionMenu)
                                        {
                                            case "1":
                                                {
                                                    ValidaIncr h = new ValidaIncr();

                                                    h.SetearIncr();
                                                    
                                                    if (h.anotados.Any(x => x.Alumno == ingresoDNI))
                                                    {
                                                        string jj;                                                        
                                                        Console.WriteLine("Usted ya ha realizado una solicitud de incripción.");
                                                        Console.WriteLine();

                                                        
                                                        
                                                        StreamReader k = new StreamReader(@"./SolicitudInscripcion-" + ingresoDNI + ".txt");

                                                        jj = k.ReadLine();
                                                        
                                                        while (jj != null)
                                                        {
                                                            Console.WriteLine(jj);                                                            
                                                            jj = k.ReadLine();
                                                        }
                                                        
                                                        k.Close();
                                                        
                                                        Console.WriteLine("Por favor, presione un tecla para salir de la consola.");
                                                        Console.ReadKey();
                                                        correcto = true;
                                                        seguir = true;
                                                    }
                                                    else
                                                    {
                                                        bool res2;
                                                        int b;

                                                        do
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("-----------------------------------------------------------------");
                                                            Console.WriteLine("Opciones: ");
                                                            Console.WriteLine("1. Estoy en las últimas 4 materias   ");                                                            
                                                            Console.WriteLine("2. No estoy en las últimas 4 materias");
                                                            Console.WriteLine("-----------------------------------------------------------------");
                                                            Console.WriteLine();
                                                            Console.WriteLine("-----------------------------------------------------------------");
                                                            Console.WriteLine("Seleccione una opción del menú y presione [ENTER] para continuar.");
                                                            Console.WriteLine("-----------------------------------------------------------------");
                                                            string opciónSubmenu = Console.ReadLine();

                                                            res2 = int.TryParse(opciónSubmenu, out b);

                                                            if (res2)
                                                            {
                                                                if (b == 1 || b == 2)
                                                                {
                                                                    switch (opciónSubmenu)
                                                                    {
                                                                        case "1":
                                                                            {
                                                                                Inscripcion inscribir = new Inscripcion();
                                                                                inscribir.InscribirseUlt4(ingresoDNI);
                                                                                break;
                                                                            }

                                                                        case "2":
                                                                            {
                                                                                Inscripcion inscribir = new Inscripcion();
                                                                                inscribir.Inscribirse(ingresoDNI);
                                                                                break;
                                                                            }

                                                                        default:
                                                                            {
                                                                                Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                                                                Console.ReadKey();
                                                                                break;
                                                                            }
                                                                    }
                                                                }

                                                                else
                                                                {
                                                                    Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                                                    Console.ReadKey();
                                                                }
                                                            }

                                                            else
                                                            {
                                                                Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                                                Console.ReadKey();
                                                            }
                                                        }
                                                        while (!res2 || !(b == 1 || b ==2));
                                                    }
                                                    break;
                                                }

                                            case "9":
                                                {
                                                    correcto = true;
                                                    seguir = true;
                                                    break;
                                                }

                                            default:
                                                {
                                                    Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                                    Console.ReadKey();
                                                    break;
                                                }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                    Console.ReadKey();
                                }
                            }
                            while (!res || !(a == 1 || a == 9));

                            if (!correcto)
                            {
                                Console.WriteLine("Ingreso al sistema inválido. Por favor, inténtelo nuevamente.");

                                Console.WriteLine();
                            }
                        }
                    }
                } while (!seguir);
            } while (!correcto);
        }
    }
}