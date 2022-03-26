using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalRendiciones.Models
{
    public class ViaticoDto
    {
        public int IdViatico { get; set; }
        public string Nombre { get; set; }
        public string Concepto { get; set; }
        public float Importe { get; set; }

        public ViaticoDto(int idViatico, string nombre, string concepto, float importe)
        {
            IdViatico = idViatico;
            Nombre = nombre;
            Concepto = concepto;
            Importe = importe;
        }

        public ViaticoDto() { }
    }
}