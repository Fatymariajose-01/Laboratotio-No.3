using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio_No._3
{
    public class Plato:Reserva
    {
        public string NombrePlato { get; set; }
        public int PrecioPlato { get; set; }
        public Plato(string numerounico, string fecha, string hora, int precioLugar, string nombreplato, int precioplato)
            : base(numerounico, fecha, hora, precioLugar)
        {
            NombrePlato = nombreplato;
            PrecioPlato = precioplato;
        }
    }
}
