using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalRendiciones.Models
{
    public class Empleado
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        public Empleado(int legajo, string nombre)
        {
            Legajo = legajo;
            Nombre = nombre;
        }

        public Empleado() { }
    }
}