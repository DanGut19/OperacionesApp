using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesApp
{
    public class Circulo
    {
        public double N1 { get; set; }

        public double btnCalcular() 
        {
            return Math.PI * Math.Pow(N1, 2);
        }
    }
}
