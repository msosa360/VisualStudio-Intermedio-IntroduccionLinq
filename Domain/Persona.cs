using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosLinq.Domain
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Soltero { get; set; }
        public DateTime FechaIngresoALaEmpresa { get; set; }
        
        public decimal Salario { get; set; }
        public string Sexo { get; set; }
    }
}
