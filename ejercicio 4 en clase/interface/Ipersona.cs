using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_en_clase.interfaz
{
    internal interface Ipersona
    { 
        string Nombre { get; }
        int edad { get; }
        void saludar();
        void cumplirAños();
    }
}


