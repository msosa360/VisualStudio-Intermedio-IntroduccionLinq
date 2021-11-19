using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemplosLinq.Domain;

namespace EjemplosLinq.SinLinq
{
    internal static class Ejemplos
    {
        public static Persona PrimerRegistro(List<Persona> lista)
        {
            var item = lista[0];
            return item;
        }

        public static Persona PrimerRegistroSoltero(List<Persona> lista)
        {
            foreach (var persona in lista)
            {
                if (persona.Soltero)
                    return persona;
            }
            return null;
        }

        public static Persona UltimoRegistro(List<Persona> lista)
        {
            var item = lista[lista.Count-1];
            return item;
        }

        public static Persona UltimoRegistroSoltero(List<Persona> lista)
        {
            Persona item = null;
            foreach (var persona in lista)
            {
                if (persona.Soltero)
                    item = persona;
            }
            return item;
        }

        public static List<Persona> TodosLosMayoresDe(List<Persona> lista, int mayorA)
        {
            var items = new List<Persona>();
            foreach (var persona in lista)
            {
                if (persona.Edad >= mayorA)
                    items.Add(persona);
            }
            return items;
        }

        public static int PromedioDeEdad(List<Persona> lista)
        {
            var total = 0;
            var cantidad = 0;
            foreach (var persona in lista)
            {
                total = total + persona.Edad;
                cantidad++;
            }

            if (cantidad == 0) return 0;
            return total / cantidad;
        }

        public static bool SonTodosMayoresDeEdad(List<Persona> lista)
        {
            
            foreach (var persona in lista)
            {
                if (persona.Edad < 18)
                    return false;
            }

            return true;
        }

        public static List<PersonaDto> ProyectarADto(List<Persona> lista)
        {
            var items = new List<PersonaDto>();
            foreach (var persona in lista)
            {
                var dto = new PersonaDto {Nombre = persona.Nombre, Edad = persona.Edad};
                items.Add(dto);
            }

            return items;
        }
    }
}
