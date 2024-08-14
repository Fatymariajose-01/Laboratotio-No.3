using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio_No._3
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroDeTelefono { get; set; }

        public Cliente(string nombre, string correoelectronico, string numerodetelefono)
        {
            Nombre = nombre;
            CorreoElectronico = correoelectronico;
            NumeroDeTelefono = numerodetelefono;
        }
    }
}
