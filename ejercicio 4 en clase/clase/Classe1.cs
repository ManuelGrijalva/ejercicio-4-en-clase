using ejercicio_4_en_clase.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_en_clase.clase
internal class clase : Ipersona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void CumplirAños()
        {
            Console.WriteLine($"Vas a cumplir {Edad + 1} años!");
        }

        public void saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }
}
