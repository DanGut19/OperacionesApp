using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesApp
{
    public class Rectangulo
    {
        public double N1 { get; set; }
        public double N2 { get; set; }

        public double BtnCalcular() 
        {
            return N1 * N2;
        }
    }
}
