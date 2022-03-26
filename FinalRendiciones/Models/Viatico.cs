using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalRendiciones.Models
{
    public class Viatico
    {
        public int IdViatico { get; set; }
        public int Legajo { get; set; }
        public string Concepto { get; set; }
        public double Importe { get; set; }

        public Viatico(int idViatico,int legajo, string concepto, double importe)
        {
            IdViatico = idViatico;
            Legajo = legajo;
            Concepto = concepto;
            Importe = importe;
        }

        public Viatico() { }

    }
}