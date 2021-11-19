using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using EjemplosLinq.Domain;

namespace EjemplosLinq.ConLinq
{
    internal static class Elemplos
    {
        public static Persona PrimerRegistro(List<Persona> lista)
        {
            var item = lista.First();
            return item;
        }

        public static Persona PrimerRegistroSoltero(List<Persona> lista)
        {
            var item = lista.First(x=>x.Soltero);

            //var item = (from p in lista
            //    where p.Soltero
            //    select p).First();
            
            return item;
        }

        public static Persona UltimoRegistro(List<Persona> lista)
        {
            var item = lista.Last();
            return item;
        }

        public static Persona UltimoRegistroSoltero(List<Persona> lista)
        {
            var item = lista.Last(x => x.Soltero);

            //var item = (from p in lista
            //    where p.Soltero
            //    select p).Last();
            
            return item;
        }

        public static List<Persona> TodosLosMayoresDe(List<Persona> lista, int mayorA)
        {
            return lista.Where(persona => persona.Edad >= mayorA).ToList();

            //var items = (from p in lista
            //    where p.Edad >= mayorA
            //    select p).ToList();
            
            //return items;
        }

        public static List<Persona> TodosOrdenadosPorEdad(List<Persona> lista)
        {
            return lista.OrderBy(x => x.Edad).ToList();

            //var items = (from p in lista
            //    orderby p.Edad
            //    select p).ToList();

            //return items;
        }

        public static List<Persona> TodosLosCasadosOrdenadosPorEdad(List<Persona> lista)
        {
            return lista.Where(x => !x.Soltero).OrderBy(x => x.Edad).ToList();

            //var items = (from p in lista
            //    where !p.Soltero
            //    orderby p.Edad
            //    select p).ToList();

            //return items;
        }

        public static int PromedioDeEdad(List<Persona> lista)
        {
            var total = lista.Sum(x => x.Edad);
            var cantidad = lista.Count;
            if(cantidad == 0) return 0;

            return total / cantidad;
            //return (int)lista.Average(x => x.Edad);
        }

        public static bool SonTodosMayoresDeEdad(List<Persona> lista)
        {
            return lista.All(persona => persona.Edad >= 18);
        }

        public static List<PersonaDto> ProyectarADto(List<Persona> lista)
        {
            return lista.Select(persona => new PersonaDto {Nombre = persona.Nombre, Edad = persona.Edad}).ToList();
        }
    }
}
