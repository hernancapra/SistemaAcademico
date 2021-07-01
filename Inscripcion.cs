using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    class Inscripcion
    {
        public void InscribirseUlt4(string dni)
        {
            bool res;
            int a;

            do
            {
                Oferta oferta = new Oferta();
                
                oferta.mostrarOfertaCalificadault4(dni);                
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Continuar con la inscripción");
                Console.WriteLine("2. Salir de la consola");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Ingrese una opción y presione [ENTER] para continuar.");
                Console.WriteLine("-----------------------------------------------------");
                var seleccion = Console.ReadLine();

                Oferta alt1 = new Oferta();
                Oferta alt2 = new Oferta();
                Oferta ofer1 = new Oferta();
                Oferta ofer2 = new Oferta();
                Oferta ofer3 = new Oferta();
                Oferta alt3 = new Oferta();
                ofer1.crearOfertaCalificada();

                res = int.TryParse(seleccion, out a);

                if (res)
                {
                    if (a == 1 || a == 2)
                    {
                        switch (seleccion)
                        {

                            case "1":
                                {
                                    bool vald = false;
                                    string IngresoMat2 = "";
                                    string IngresoMatAlt2 = "";
                                    string IngresoMat3 = "";
                                    string IngresoMatAlt3 = "";
                                    string IngresoMatAlt = "";
                                    string IngresoMat1 = "";
                                    string Tecla = "";
                        
                                    while (!vald)                        
                                    {
                                        do
                                        {
                                            Console.WriteLine("Ingrese el curso original en el que se desea inscribir para la materia 1 [formato: 'código materia-código curso']: ");
                                            IngresoMat1 = Console.ReadLine();

                                             if (IngresoMat1 != "" && (ofer1.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMat1))))
                                             {
                                                 ofer1 = oferta.SeleccionCurso(IngresoMat1);
                                                 vald = true;
                                             }
                                             else
                                             {
                                                 Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                             }
                                        }
                                        while (IngresoMat1 == "" || !vald);

                                        bool valida = false;
                                        do
                                        {
                                            Console.WriteLine("Ingrese el curso alternativo en el que se desea inscribir para la materia 1 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMatAlt = Console.ReadLine();

                                            alt1.crearOfertaCalificada();
                                            string materia = IngresoMat1.Split('-')[0];
                                            string materiaalt = IngresoMatAlt.Split('-')[0];

                                            if (IngresoMat1 != IngresoMatAlt && materia == materiaalt && (alt1.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMatAlt)))|| IngresoMatAlt == "0")
                                            {
                                                alt1 = oferta.SeleccionCurso(IngresoMatAlt);
                                                valida = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        }
                                        while (!valida);

                                        bool v1 = false;

                                        do
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Ingrese el curso original en el que se desea inscribir para la materia 2 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                               
                                            IngresoMat2 = Console.ReadLine();
                                            ofer2.crearOfertaCalificada();

                                            if (IngresoMat1 != IngresoMat2 && IngresoMat1 != IngresoMatAlt && (ofer2.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMat2)))|| IngresoMat2=="0")
                                            {
                                                ofer2 = oferta.SeleccionCurso(IngresoMat2);
                                                v1 = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        }
                                        while (!v1);
                                        
                                        bool v2 = false;
                                        
                                        do
                                        {
                                            Console.WriteLine("Ingrese el curso alternativo en el que se desea inscribir para la materia 2 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMatAlt2 = Console.ReadLine();
                                            alt2.crearOfertaCalificada();
                                            string materia2 = IngresoMat2.Split('-')[0];
                                            string materiaalt2 = IngresoMatAlt2.Split('-')[0];

                                            if (IngresoMat1 != IngresoMatAlt && materia2 == materiaalt2 && (alt2.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMatAlt2))) || IngresoMatAlt2=="0")
                                            {
                                                alt2 = oferta.SeleccionCursoAlt(IngresoMatAlt2);
                                                v2 = true; 
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        } while (!v2);

                                        bool v3 = false;
                                        
                                        do
                                        {
                                            ofer3.crearOfertaCalificada();
                                            Console.WriteLine();
                                            Console.WriteLine("Ingrese el curso original en el que se desea inscribir para la materia 3 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMat3 = Console.ReadLine();

                                            if (IngresoMat1 != IngresoMat2 && IngresoMat2 != IngresoMat3 && IngresoMat1 != IngresoMat3 && IngresoMat1 != IngresoMat2 && (ofer3.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMat3)))|| IngresoMat3=="0")
                                            {
                                                ofer3 = oferta.SeleccionCurso(IngresoMat3);
                                                v3 = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        } while (!v3);
                                        
                                        bool v4 = false;
                                        
                                        do
                                        {
                                            alt3.crearOfertaCalificada();
                                            Console.WriteLine("Ingrese el curso alternativo en el que se desea inscribir para la materia 3 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMatAlt3 = Console.ReadLine();
                              
                                            string materia3 = IngresoMat3.Split('-')[0];
                                            string materiaalt3 = IngresoMatAlt3.Split('-')[0];
                                            
                                            if (IngresoMat3 != null && IngresoMat3 != IngresoMat1 && materia3 == materiaalt3 && (alt3.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMatAlt3)))|| IngresoMatAlt3=="0")
                                            {
                                                alt3 = oferta.SeleccionCursoAlt(IngresoMatAlt3);
                                                v4 = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        } while (!v4);
                                        
                                        StreamWriter sw = File.CreateText(@"./SolicitudInscripcion-" + dni + ".txt");

                                        sw.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                        sw.WriteLine("Usuario: " + dni);
                                        sw.WriteLine("Fecha de inscripción: " + DateTime.Now);
                                        sw.WriteLine();
                                        sw.WriteLine("Materia 1: " + ofer1.nombreMateria + " con el profesor: " + ofer1.profesorCurso + ", los dias " + ofer1.diaCurso + " en el horario de: " + ofer1.horarioCurso);
                                        
                                        if (IngresoMatAlt == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso alternativo para materia 1.");
                                        }
                                        else 
                                        {
                                            sw.WriteLine("Alt.Mat.1: " + alt1.nombreMateria + " con el profesor: " + alt1.profesorCurso + ", los dias " + alt1.diaCurso + " en el horario de: " + alt1.horarioCurso);
                                        }

                                        if (IngresoMat2 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso para materia 2.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Materia 2: " + ofer2.nombreMateria + " con el profesor: " + ofer2.profesorCurso + ", los dias " + ofer2.diaCurso + " en el horario de: " + ofer2.horarioCurso);
                                        }

                                        if (IngresoMatAlt2 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso alternativo para materia 2.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Alt.Mat.2: " + alt2.nombreMateria + " con el profesor: " + alt2.profesorCurso + ", los dias " + alt2.diaCurso + " en el horario de: " + alt2.horarioCurso);
                                        }

                                        if (IngresoMat3 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso para materia 3.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Materia 3: " + ofer3.nombreMateria + " con el profesor: " + ofer3.profesorCurso + ", los dias " + ofer3.diaCurso + " en el horario de: " + ofer3.horarioCurso);
                                        }

                                        if (IngresoMatAlt3 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso alternativo para materia 3.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Alt.Mat.3: " + alt3.nombreMateria + " con el profesor: " + alt3.profesorCurso + ", los dias " + alt3.diaCurso + " en el horario de: " + alt3.horarioCurso);
                                        }
                                        
                                        sw.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                                        sw.Close();

                                        using (var mostrarCursos = new StreamReader(@"./SolicitudInscripcion-" + dni + ".txt"))
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Usted ha elegido los siguientes cursos para la solicitud de inscripción: ");

                                            while (!mostrarCursos.EndOfStream)
                                            {
                                                Console.WriteLine(mostrarCursos.ReadLine());
                                            }
                                        }

                                        Console.WriteLine();
                                        Console.WriteLine("¿Desea confirmar solicitud de inscripción? [1 - Confirmar || 2 - Repetir proceso de inscripción].");
                                        
                                        bool v5 = false;

                                        do
                                        {
                                            Tecla = Console.ReadLine();

                                            if (Tecla == "1")
                                            {
                                                StreamWriter grabar = new StreamWriter(@"./GuardarSolicitudInscripcion.txt", append: true);
                                                
                                                grabar.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                grabar.WriteLine("Usuario: " + dni);
                                                grabar.WriteLine("Fecha de inscripción: " + DateTime.Now);
                                                grabar.WriteLine();
                                                grabar.WriteLine("Materia 1: " + ofer1.nombreMateria + " con el profesor: " + ofer1.profesorCurso + ", los dias " + ofer1.diaCurso + " en el horario de: " + ofer1.horarioCurso);
                                        
                                                if (IngresoMatAlt == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso alternativo para materia 1.");
                                                }
                                                else
                                                {
                                                    grabar.WriteLine("Alt.Mat.1: " + alt1.nombreMateria + " con el profesor: " + alt1.profesorCurso + ", los dias " + alt1.diaCurso + " en el horario de: " + alt1.horarioCurso);
                                                }

                                                if (IngresoMat2 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso para materia 2.");
                                                }
                                                else
                                                {
                                                    grabar.WriteLine("Materia 2: " + ofer2.nombreMateria + " con el profesor: " + ofer2.profesorCurso + ", los dias " + ofer2.diaCurso + " en el horario de: " + ofer2.horarioCurso);
                                                }
                                                
                                                if (IngresoMatAlt2 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso alternativo para materia 2.");
                                                }
                                                else 
                                                { 
                                                    grabar.WriteLine("Alt.Mat.2: " + alt2.nombreMateria + " con el profesor: " + alt2.profesorCurso + ", los dias " + alt2.diaCurso + " en el horario de: " + alt2.horarioCurso);
                                                }

                                                if (IngresoMat3 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso para materia 3.");
                                                }
                                                else
                                                { 
                                                    grabar.WriteLine("Materia 3: " + ofer3.nombreMateria + " con el profesor: " + ofer3.profesorCurso + ", los dias " + ofer3.diaCurso + " en el horario de: " + ofer3.horarioCurso);
                                                }

                                                if (IngresoMatAlt3 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso alternativo para materia 3.");
                                                }
                                                else
                                                {
                                                    grabar.WriteLine("Alt.Mat.3: " + alt3.nombreMateria + " con el profesor: " + alt3.profesorCurso + ", los dias " + alt3.diaCurso + " en el horario de: " + alt3.horarioCurso);
                                                }
                                                
                                                grabar.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                                grabar.Close();

                                                Console.WriteLine("Su solicitud de inscripción se ha registrado correctamente en el sistema.");
                                                Console.WriteLine("Presione una tecla para salir de la consola.");

                                                StreamWriter grabar1 = new StreamWriter(@"./ValidaciónInscripción.txt", append: true);
                                                grabar1.WriteLine("Usuario|Inscripto");
                                                grabar1.WriteLine(dni + "|SI");
                                                grabar1.Close();
                                                Console.ReadKey();
                                                Environment.Exit(-1);
                                            }
                                            else if (Tecla == "2")
                                            {
                                                Inscripcion f = new Inscripcion();
                                                f.InscribirseUlt4(dni);          
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                                Console.ReadKey();
                                            }
                                            
                                            v1 = true;
                                        }
                                        while (!v5 && !(Tecla == "1"|| Tecla== "2"));
                                    }
                                    
                                    break;
                                }

                            case "2":
                                {
                                    Environment.Exit(-1);
                                    break;
                                }

                            default:
                                {
                                    Console.ReadKey();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.ReadKey();
                }
            } while (!res || !(a == 1 || a == 2));
        }

        public void Inscribirse(string dni)
        {
            bool res;
            int a;

            do
            {
                Oferta oferta = new Oferta();
                
                oferta.mostrarOfertaCalificada(dni);                
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Continuar con la inscripción");
                Console.WriteLine("2. Salir de la consola");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Ingrese una opción y presione [ENTER] para continuar.");
                Console.WriteLine("-----------------------------------------------------");
                var seleccion = Console.ReadLine();

                Oferta alt1 = new Oferta();
                Oferta alt2 = new Oferta();
                Oferta ofer1 = new Oferta();
                Oferta ofer2 = new Oferta();
                Oferta ofer3 = new Oferta();
                Oferta alt3 = new Oferta();
                ofer1.crearOfertaCalificada();

                res = int.TryParse(seleccion, out a);

                if (res)
                {
                    if (a == 1 || a == 2)
                    {
                        switch (seleccion)
                        {

                            case "1":
                                {
                                    bool vald = false;
                                    string IngresoMat2 = "";
                                    string IngresoMatAlt2 = "";
                                    string IngresoMat3 = "";
                                    string IngresoMatAlt3 = "";
                                    string IngresoMatAlt = "";
                                    string IngresoMat1 = "";
                                    string Tecla = "";
                        
                                    while (!vald)                        
                                    {
                                        do
                                        {
                                            Console.WriteLine("Ingrese el curso original en el que se desea inscribir para la materia 1 [formato: 'código materia-código curso']: ");
                                            IngresoMat1 = Console.ReadLine();

                                             if (IngresoMat1 != "" && (ofer1.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMat1))))
                                             {
                                                 ofer1 = oferta.SeleccionCurso(IngresoMat1);
                                                 vald = true;
                                             }
                                             else
                                             {
                                                 Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                             }
                                        }
                                        while (IngresoMat1 == "" || !vald);

                                        bool valida = false;
                                        do
                                        {
                                            Console.WriteLine("Ingrese el curso alternativo en el que se desea inscribir para la materia 1 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMatAlt = Console.ReadLine();

                                            alt1.crearOfertaCalificada();
                                            string materia = IngresoMat1.Split('-')[0];
                                            string materiaalt = IngresoMatAlt.Split('-')[0];

                                            if (IngresoMat1 != IngresoMatAlt && materia == materiaalt && (alt1.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMatAlt)))|| IngresoMatAlt == "0")
                                            {
                                                alt1 = oferta.SeleccionCurso(IngresoMatAlt);
                                                valida = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        }
                                        while (!valida);

                                        bool v1 = false;

                                        do
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Ingrese el curso original en el que se desea inscribir para la materia 2 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                               
                                            IngresoMat2 = Console.ReadLine();
                                            ofer2.crearOfertaCalificada();

                                            if (IngresoMat1 != IngresoMat2 && IngresoMat1 != IngresoMatAlt && (ofer2.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMat2)))|| IngresoMat2=="0")
                                            {
                                                ofer2 = oferta.SeleccionCurso(IngresoMat2);
                                                v1 = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        }
                                        while (!v1);
                                        
                                        bool v2 = false;
                                        
                                        do
                                        {
                                            Console.WriteLine("Ingrese el curso alternativo en el que se desea inscribir para la materia 2 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMatAlt2 = Console.ReadLine();
                                            alt2.crearOfertaCalificada();
                                            string materia2 = IngresoMat2.Split('-')[0];
                                            string materiaalt2 = IngresoMatAlt2.Split('-')[0];

                                            if (IngresoMat1 != IngresoMatAlt && materia2 == materiaalt2 && (alt2.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMatAlt2))) || IngresoMatAlt2=="0")
                                            {
                                                alt2 = oferta.SeleccionCursoAlt(IngresoMatAlt2);
                                                v2 = true; 
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        } while (!v2);

                                        bool v3 = false;
                                        
                                        do
                                        {
                                            ofer3.crearOfertaCalificada();
                                            Console.WriteLine();
                                            Console.WriteLine("Ingrese el curso original en el que se desea inscribir para la materia 3 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMat3 = Console.ReadLine();

                                            if (IngresoMat1 != IngresoMat2 && IngresoMat2 != IngresoMat3 && IngresoMat1 != IngresoMat3 && IngresoMat1 != IngresoMat2 && (ofer3.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMat3)))|| IngresoMat3=="0")
                                            {
                                                ofer3 = oferta.SeleccionCurso(IngresoMat3);
                                                v3 = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        } while (!v3);
                                        
                                        bool v4 = false;
                                        
                                        do
                                        {
                                            alt3.crearOfertaCalificada();
                                            Console.WriteLine("Ingrese el curso alternativo en el que se desea inscribir para la materia 3 [formato: 'código materia-código curso']. Si no desea ingresar un curso, presione 0: ");
                                            IngresoMatAlt3 = Console.ReadLine();
                              
                                            string materia3 = IngresoMat3.Split('-')[0];
                                            string materiaalt3 = IngresoMatAlt3.Split('-')[0];
                                            
                                            if (IngresoMat3 != null && IngresoMat3 != IngresoMat1 && materia3 == materiaalt3 && (alt3.Ofertas.Any(x => (x.codigoMateria + "-" + x.codigoCurso == IngresoMatAlt3)))|| IngresoMatAlt3=="0")
                                            {
                                                alt3 = oferta.SeleccionCursoAlt(IngresoMatAlt3);
                                                v4 = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Curso inexistente. Por favor, vuelva a ingresar el dato.");
                                            }
                                        } while (!v4);
                                        
                                        StreamWriter sw = File.CreateText(@"./SolicitudInscripcion-" + dni + ".txt");

                                        sw.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                        sw.WriteLine("Usuario: " + dni);
                                        sw.WriteLine("Fecha de inscripción: " + DateTime.Now);
                                        sw.WriteLine();
                                        sw.WriteLine("Materia 1: " + ofer1.nombreMateria + " con el profesor: " + ofer1.profesorCurso + ", los dias " + ofer1.diaCurso + " en el horario de: " + ofer1.horarioCurso);
                                        
                                        if (IngresoMatAlt == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso alternativo para materia 1.");
                                        }
                                        else 
                                        {
                                            sw.WriteLine("Alt.Mat.1: " + alt1.nombreMateria + " con el profesor: " + alt1.profesorCurso + ", los dias " + alt1.diaCurso + " en el horario de: " + alt1.horarioCurso);
                                        }

                                        if (IngresoMat2 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso para materia 2.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Materia 2: " + ofer2.nombreMateria + " con el profesor: " + ofer2.profesorCurso + ", los dias " + ofer2.diaCurso + " en el horario de: " + ofer2.horarioCurso);
                                        }

                                        if (IngresoMatAlt2 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso alternativo para materia 2.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Alt.Mat.2: " + alt2.nombreMateria + " con el profesor: " + alt2.profesorCurso + ", los dias " + alt2.diaCurso + " en el horario de: " + alt2.horarioCurso);
                                        }

                                        if (IngresoMat3 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso para materia 3.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Materia 3: " + ofer3.nombreMateria + " con el profesor: " + ofer3.profesorCurso + ", los dias " + ofer3.diaCurso + " en el horario de: " + ofer3.horarioCurso);
                                        }

                                        if (IngresoMatAlt3 == "0")
                                        {
                                            sw.WriteLine("No ha seleccionado un curso alternativo para materia 3.");
                                        }
                                        else
                                        {
                                            sw.WriteLine("Alt.Mat.3: " + alt3.nombreMateria + " con el profesor: " + alt3.profesorCurso + ", los dias " + alt3.diaCurso + " en el horario de: " + alt3.horarioCurso);
                                        }
                                        
                                        sw.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                                        sw.Close();

                                        using (var mostrarCursos = new StreamReader(@"./SolicitudInscripcion-" + dni + ".txt"))
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Usted ha elegido los siguientes cursos para la solicitud de inscripción: ");

                                            while (!mostrarCursos.EndOfStream)
                                            {
                                                Console.WriteLine(mostrarCursos.ReadLine());
                                            }
                                        }

                                        Console.WriteLine();
                                        Console.WriteLine("¿Desea confirmar solicitud de inscripción? [1 - Confirmar || 2 - Repetir proceso de inscripción].");
                                        
                                        bool v5 = false;

                                        do
                                        {
                                            Tecla = Console.ReadLine();

                                            if (Tecla == "1")
                                            {
                                                StreamWriter grabar = new StreamWriter(@"./GuardarSolicitudInscripcion.txt", append: true);
                                                
                                                grabar.WriteLine("------------------------------------------------------------------------------------------------------------------");
                                                grabar.WriteLine("Usuario: " + dni);
                                                grabar.WriteLine("Fecha de inscripción: " + DateTime.Now);
                                                grabar.WriteLine();
                                                grabar.WriteLine("Materia 1: " + ofer1.nombreMateria + " con el profesor: " + ofer1.profesorCurso + ", los dias " + ofer1.diaCurso + " en el horario de: " + ofer1.horarioCurso);
                                        
                                                if (IngresoMatAlt == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso alternativo para materia 1.");
                                                }
                                                else
                                                {
                                                    grabar.WriteLine("Alt.Mat.1: " + alt1.nombreMateria + " con el profesor: " + alt1.profesorCurso + ", los dias " + alt1.diaCurso + " en el horario de: " + alt1.horarioCurso);
                                                }

                                                if (IngresoMat2 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso para materia 2.");
                                                }
                                                else
                                                {
                                                    grabar.WriteLine("Materia 2: " + ofer2.nombreMateria + " con el profesor: " + ofer2.profesorCurso + ", los dias " + ofer2.diaCurso + " en el horario de: " + ofer2.horarioCurso);
                                                }
                                                
                                                if (IngresoMatAlt2 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso alternativo para materia 2.");
                                                }
                                                else 
                                                { 
                                                    grabar.WriteLine("Alt.Mat.2: " + alt2.nombreMateria + " con el profesor: " + alt2.profesorCurso + ", los dias " + alt2.diaCurso + " en el horario de: " + alt2.horarioCurso);
                                                }

                                                if (IngresoMat3 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso para materia 3.");
                                                }
                                                else
                                                { 
                                                    grabar.WriteLine("Materia 3: " + ofer3.nombreMateria + " con el profesor: " + ofer3.profesorCurso + ", los dias " + ofer3.diaCurso + " en el horario de: " + ofer3.horarioCurso);
                                                }

                                                if (IngresoMatAlt3 == "0")
                                                {
                                                    grabar.WriteLine("No ha seleccionado un curso alternativo para materia 3.");
                                                }
                                                else
                                                {
                                                    grabar.WriteLine("Alt.Mat.3: " + alt3.nombreMateria + " con el profesor: " + alt3.profesorCurso + ", los dias " + alt3.diaCurso + " en el horario de: " + alt3.horarioCurso);
                                                }
                                                
                                                grabar.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                                                grabar.Close();

                                                Console.WriteLine("Su solicitud de inscripción se ha registrado correctamente en el sistema.");
                                                Console.WriteLine("Presione una tecla para salir de la consola.");

                                                StreamWriter grabar1 = new StreamWriter(@"./ValidaciónInscripción.txt", append: true);
                                                grabar1.WriteLine("Usuario|Inscripto");
                                                grabar1.WriteLine(dni + "|SI");
                                                grabar1.Close();
                                                Console.ReadKey();
                                                Environment.Exit(-1);
                                            }
                                            else if (Tecla == "2")
                                            {
                                                Inscripcion f = new Inscripcion();
                                                f.InscribirseUlt4(dni);          
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Presione una tecla y vuelva a ingresar una opción válida.");
                                                Console.ReadKey();
                                            }
                                            
                                            v1 = true;
                                        }
                                        while (!v5 && !(Tecla == "1"|| Tecla== "2"));
                                    }
                                    
                                    break;
                                }

                            case "2":
                                {
                                    Environment.Exit(-1);
                                    break;
                                }

                            default:
                                {
                                    Console.ReadKey();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.ReadKey();
                }
            } while (!res || !(a == 1 || a == 2));
        }
    }
}   