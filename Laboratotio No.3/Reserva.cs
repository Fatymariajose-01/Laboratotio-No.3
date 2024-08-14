using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio_No._3
{
    public class Reserva
    {
        public string NumeroUnico { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int PrecioLugar { get; set; }

        public Reserva(string numerounico, string fecha, string hora, int precioLugar)
        {
            NumeroUnico = numerounico;
            Fecha = fecha;
            Hora = hora;
            PrecioLugar = precioLugar;
        }

    }
}
