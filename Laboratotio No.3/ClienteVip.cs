using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio_No._3
{
    public class ClienteVip:Cliente
    {
        double DescuentoEspecial { get; set; }

        public ClienteVip(string nombre, string correoelectronico, string numerodetelefono, double decuentoespecial)
            :base (nombre, correoelectronico, numerodetelefono )
        {
            DescuentoEspecial = decuentoespecial;
        }
    }
}
