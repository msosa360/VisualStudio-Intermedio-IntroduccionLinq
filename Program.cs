using System;
using System.Collections.Generic;
using EjemplosLinq.Domain;

namespace EjemplosLinq
{
    internal class Program
    {
        private static List<Persona> _listaPersonas = new List<Persona>();

        static void Main(string[] args)
        {
            CargarDatosPrueba();

            string opcion;
            do
            {
                Console.WriteLine("1 - Primer Registro (sin Linq)");
                Console.WriteLine("2 - Primer Registro (con Linq)");
                
                Console.WriteLine("3 - Primer Registro Soltero (sin Linq)");
                Console.WriteLine("4 - Primer Registro Soltero (con Linq)");

                Console.WriteLine("5 - Todos los Registros Mayores a (sin Linq)");
                Console.WriteLine("6 - Todos los Registros Mayores a (con Linq)");

                Console.WriteLine("7 - Todos Ordenados por Edad (con Linq)");
                Console.WriteLine("8 - Todos los Casados Ordenados por Edad (con Linq)");

                Console.WriteLine("9 - Promedio de Edad (sin Linq)");
                Console.WriteLine("10 - Promedio de Edad (con Linq)");

                Console.WriteLine("11 - Son todos Mayores (sin Linq)");
                Console.WriteLine("12 - Son todos Mayores (con Linq)");

                Console.WriteLine("13 - Proyectar a Dto (sin Linq)");
                Console.WriteLine("14 - Proyectar a Dto (con Linq)");

                Console.WriteLine("------------------------------");
                Console.WriteLine("Seleccione una Opción: ");

                opcion = Console.ReadLine();

                if (!string.IsNullOrEmpty(opcion))
                {
                    switch (opcion)
                    {
                        case "1":
                        {
                            var res = SinLinq.Ejemplos.PrimerRegistro(_listaPersonas);
                            break;
                        }
                        case "2":
                        {
                            var res = ConLinq.Elemplos.PrimerRegistro(_listaPersonas);
                            break;
                        }
                        case "3":
                        {
                            var res = SinLinq.Ejemplos.PrimerRegistroSoltero(_listaPersonas);
                            break;
                        }
                        case "4":
                        {
                            var res = ConLinq.Elemplos.PrimerRegistroSoltero(_listaPersonas);
                            break;
                        }

                        case "5":
                        {
                            var res = SinLinq.Ejemplos.TodosLosMayoresDe(_listaPersonas, 25);
                            break;
                        }
                        case "6":
                        {
                            var res = ConLinq.Elemplos.TodosLosMayoresDe(_listaPersonas, 25);
                            break;
                        }
                        case "7":
                        {
                            var res = ConLinq.Elemplos.TodosOrdenadosPorEdad(_listaPersonas);
                            break;
                        }
                        case "8":
                        {
                            var res = ConLinq.Elemplos.TodosLosCasadosOrdenadosPorEdad(_listaPersonas);
                            break;
                        }
                        case "9":
                        {
                            var res = SinLinq.Ejemplos.PromedioDeEdad(_listaPersonas);
                            break;
                        }
                        case "10":
                        {
                            var res = ConLinq.Elemplos.PromedioDeEdad(_listaPersonas);
                            break;
                        }
                        case "11":
                        {
                            var res = SinLinq.Ejemplos.SonTodosMayoresDeEdad(_listaPersonas);
                            break;
                        }
                        case "12":
                        {
                            var res = ConLinq.Elemplos.SonTodosMayoresDeEdad(_listaPersonas);
                            break;
                        }
                        case "13":
                        {
                            var res = SinLinq.Ejemplos.ProyectarADto(_listaPersonas);
                            break;
                        }
                        case "14":
                        {
                            var res = ConLinq.Elemplos.ProyectarADto(_listaPersonas);
                            break;
                        }

                    }
                }

            } while (!string.IsNullOrEmpty(opcion));
        }

        static void CargarDatosPrueba()
        {
            _listaPersonas = new List<Persona>()
            {
                new Persona
                {
                    Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true, Sexo = "M", Salario = 59000
                },
                new Persona
                {
                    Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true, Sexo = "F", Salario = 87500
                },
                new Persona
                {
                    Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false, Sexo = "M", Salario = 45855
                },
                new Persona
                {
                    Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false, Sexo = "F", Salario = 65210
                },
                new Persona
                {
                    Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false, Sexo = "M", Salario = 87500
                },
            };

        }
    }
}
