using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalRendiciones.Models
{
    public class Rendicion
    {
        public Viatico viatico { get; set; }
        public List<Empleado> nombreEmpleado { get; set; }
    }
}