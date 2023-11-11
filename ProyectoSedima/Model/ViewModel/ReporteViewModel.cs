using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSedima.Model.ViewModel
{
    internal class ReporteViewModel
    {
        public int IdReporte { get; set; } 
        public string Cliente { get; set; }
        public string Caldera { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public string Ciudad { get; set; }
        public DateTime FecRegistro { get; set; }
        public string STATUS { get; set; }
    }
}
