using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Prestamos.Models
{
    public class CalculadoraViewModel
    {

        public double Monto { get; set; }
        public int TipoPrestamos { get; set; }
        public string TasaInteres { get; set; }
        public int Meses { get; set; }

        public double Result { get; set; }

        
    }
}
