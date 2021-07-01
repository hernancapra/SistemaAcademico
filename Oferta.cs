﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico
{
    class Oferta
    {
        public string carrera { get; }
        public string codigoMateria { get; }
        public string codigoCurso { get; }
        public string nombreMateria { get; }
        public string titularCurso { get; }
        public string profesorCurso { get; }
        public string diaCurso { get; }
        public string horarioCurso { get; }

        public Oferta() { }

        public List<Oferta> Ofertas = new List<Oferta>();

        public Oferta(string codigoMateria, string carrera, string codigoCurso, string nombreMateria, string titularCurso, string profesorCurso, string diaCurso, string horarioCurso)
        {
            this.codigoMateria = codigoMateria;
            this.carrera = carrera;
            this.codigoCurso = codigoCurso;
            this.nombreMateria = nombreMateria;
            this.titularCurso = titularCurso;
            this.profesorCurso = profesorCurso;
            this.diaCurso = diaCurso;
            this.horarioCurso = horarioCurso;
        }

        public void crearOfertaCalificada()
        {
            using (FileStream texto = File.OpenRead(@"./OfertaCalificada1.txt"))

            using (var OfertaCursos = new StreamReader(texto))
            {
                string line;

                OfertaCursos.ReadLine();
                OfertaCursos.ReadLine();

                while ((line = OfertaCursos.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        string codigoMateria = line.Split(';')[1];
                        string carrera = line.Split(';')[0];
                        string codigoCurso = line.Split(';')[2];
                        string nombreMateria = line.Split(';')[3];
                        string TitularCurso = line.Split(';')[4];
                        string ProfesorCurso = line.Split(';')[5];
                        string diaCurso = line.Split(';')[6];
                        string HorarioCurso = line.Split(';')[7];

                        Oferta ofer1 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                        Oferta ofer2 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                        Oferta ofer3 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);

                        Ofertas.Add(ofer1);
                        Ofertas.Add(ofer2);
                        Ofertas.Add(ofer3);

                        Oferta alt1 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                        Oferta alt2 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                        Oferta alt3 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);

                        Ofertas.Add(alt1);
                        Ofertas.Add(alt2);
                        Ofertas.Add(alt3);
                    }
                }
            }
        }

        public Oferta SeleccionCurso(string IngresoMat1)
        {
            using (FileStream texto = File.OpenRead(@"./OfertaCalificada1.txt"))

            using (var OfertaCursos = new StreamReader(texto))
            {
                string line;

                while (!string.IsNullOrEmpty(line = OfertaCursos.ReadLine()))
                {
                    string codigoMateria = line.Split(';')[1];
                    string Carrera = line.Split(';')[0];
                    string codigoCurso = line.Split(';')[2];
                    string nombreMateria = line.Split(';')[3];
                    string TitularCurso = line.Split(';')[4];
                    string ProfesorCurso = line.Split(';')[5];
                    string diaCurso = line.Split(';')[6];
                    string HorarioCurso = line.Split(';')[7];

                    Oferta ofer1 = new Oferta(codigoMateria, Carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                    Oferta ofer2 = new Oferta(codigoMateria, Carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                    Oferta ofer3 = new Oferta(codigoMateria, Carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                    Oferta alt1 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                    Oferta alt2 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                    Oferta alt3 = new Oferta(codigoMateria, carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);

                    if (codigoMateria + "-" + codigoCurso == IngresoMat1)
                    {
                        return ofer1;
                    }
                }

                return null;
            }
        }

        public Oferta SeleccionCursoAlt(String IngresoMatalt1)
        {
            using (FileStream texto = File.OpenRead(@"./OfertaCalificada1.txt"))

            using (var OfertaCursos = new StreamReader(texto))
            {
                string line;

                while (!string.IsNullOrEmpty(line = OfertaCursos.ReadLine()))
                {
                    string codigoMateria = line.Split(';')[1];
                    string Carrera = line.Split(';')[0];
                    string codigoCurso = line.Split(';')[2];
                    string nombreMateria = line.Split(';')[3];
                    string TitularCurso = line.Split(';')[4];
                    string ProfesorCurso = line.Split(';')[5];
                    string diaCurso = line.Split(';')[6];
                    string HorarioCurso = line.Split(';')[7];

                    Oferta alt1 = new Oferta(codigoMateria, Carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                    Oferta alt2 = new Oferta(codigoMateria, Carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);
                    Oferta alt3 = new Oferta(codigoMateria, Carrera, codigoCurso, nombreMateria, TitularCurso, ProfesorCurso, diaCurso, HorarioCurso);

                    if (codigoMateria + "-" + codigoCurso == IngresoMatalt1)
                    {
                        return alt1;
                    }
                }

                return null;
            }
        }

        public void mostrarOfertaCalificadault4(string IngresadoDni)
        {
            using (FileStream texto = File.OpenRead(@"./OfertaCalificada1.txt"))

            using (var OfertaCursos = new StreamReader(texto))
            {
                bool res3;
                int c;

                do
                {
                    string line;
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Seleccione una carrera: ");
                    Console.WriteLine("1. Sistemas de Información de las Organizaciones");
                    Console.WriteLine("2. Administración de Empresas");
                    Console.WriteLine("3. Contador Público");
                    Console.WriteLine("4. Economia");
                    Console.WriteLine("5. Actuario en Administración");
                    Console.WriteLine("6. Actuario en Economía");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Seleccione una opción del menú y presione [ENTER] para continuar.");
                    Console.WriteLine("-----------------------------------------------------------------");
                    var IngCarrera = Console.ReadLine();

                    res3 = int.TryParse(IngCarrera, out c);

                    if (res3)
                    {
                        if (c == 1 || c == 2 || c == 3 || c == 4 || c == 5 || c == 6)
                        {
                            switch (IngCarrera)
                            {
                                case "1":
                                    {
                                        var aprobadas = new Materiasaprobadas();
                                        aprobadas.SetearMateriasaprobadas();
                                        
                                        var correlativas = new ValidaCorr();
                                        correlativas.SetearCorre();

                                        while ((!string.IsNullOrEmpty(line = OfertaCursos.ReadLine())))
                                        {
                                            string codigoMateria = line.Split(';')[1];
                                            string Carrera = line.Split(';')[0];
                                            string codigoCurso = line.Split(';')[2];
                                            string nombreMateria = line.Split(';')[3];
                                            string TitularCurso = line.Split(';')[4];
                                            string ProfesorCurso = line.Split(';')[5];
                                            string diaCurso = line.Split(';')[6];
                                            string HorarioCurso = line.Split(';')[7];

                                            if (!aprobadas.Aprobadas.Any(x => x.codigoCurso == codigoMateria && x.Dni == IngresadoDni) && Carrera == IngCarrera)
                                            {                               
                                                Console.WriteLine(codigoMateria + "|" + codigoCurso + "|" + nombreMateria + "|" + TitularCurso + "|" + ProfesorCurso + "|" + diaCurso + "|" + HorarioCurso + "|");
                                                Console.WriteLine("---------------------------------------------------------");
                                            }
                                        }

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
                while (!res3 || !(c == 1 || c == 2 || c == 3 || c == 4 || c == 5 || c == 6));
            }
        }

        public void mostrarOfertaCalificada(string IngresadoDni)
        {
            using (FileStream texto = File.OpenRead(@"./OfertaCalificada1.txt"))

            using (var OfertaCursos = new StreamReader(texto))
            {
                bool res4;
                int d;

                do
                {
                    string line;
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Seleccione una carrera: ");
                    Console.WriteLine("1. Sistemas de Información de las Organizaciones");
                    Console.WriteLine("2. Administración de Empresas");
                    Console.WriteLine("3. Contador Público");
                    Console.WriteLine("4. Economia");
                    Console.WriteLine("5. Actuario en Administración");
                    Console.WriteLine("6. Actuario en Economía");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Seleccione una opción del menú y presione [ENTER] para continuar.");
                    Console.WriteLine("-----------------------------------------------------------------");
                    var IngCarrera = Console.ReadLine();
                    Console.Clear();

                    res4 = int.TryParse(IngCarrera, out d);

                    if (res4)
                    {
                        if (d == 1 || d == 2 || d == 3 || d == 4 || d == 5 || d == 6)
                        {
                            switch (IngCarrera)
                            {
                                case "1":
                                    {
                                        var aprobadas = new Materiasaprobadas();
                                        aprobadas.SetearMateriasaprobadas();

                                        var correlativas = new ValidaCorr();
                                        correlativas.SetearCorre();

                                        List<Oferta> materias = new List<Oferta>();

                                        while ((!string.IsNullOrEmpty(line = OfertaCursos.ReadLine())))
                                        {
                                            string codigoMateria = line.Split(';')[1];
                                            string Carrera = line.Split(';')[0];
                                            string codigoCurso = line.Split(';')[2];
                                            string nombreMateria = line.Split(';')[3];
                                            string TitularCurso = line.Split(';')[4];
                                            string ProfesorCurso = line.Split(';')[5];
                                            string diaCurso = line.Split(';')[6];
                                            string HorarioCurso = line.Split(';')[7];

                                            if (IngCarrera == Carrera && !aprobadas.Aprobadas.Any(x => x.codigoCurso == codigoMateria))

                                                if (!correlativas.tienecorrelativas(codigoMateria, IngCarrera) || correlativas.TieneTodasLascorrelativas(codigoMateria, IngCarrera, aprobadas.Aprobadas))
                                                {
                                                    Console.WriteLine(codigoMateria + "|" + codigoCurso + "|" + nombreMateria + "|" + TitularCurso + "|" + ProfesorCurso + "|" + diaCurso + "|" + HorarioCurso + "|");
                                                    Console.WriteLine("---------------------------------------------------------");
                                                }
                                        }

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
                } while (!res4 || !(d == 1 || d == 2 || d == 3 || d == 4 || d == 5 || d == 6));
            }
        }
    }
}