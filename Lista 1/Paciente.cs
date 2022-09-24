using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1
{
    public class Paciente
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Paciente Siguiente { get; set; }
        public Paciente Anterior { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Apellido}, {Nombre}";
        }
    }
}
