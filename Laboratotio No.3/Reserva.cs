using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio_No._3
{
    public class Reserva:ClienteVip
    {
        public string NumeroUnico { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public int PrecioLugar { get; set; }
        //Si es cliente normal a la hora de pedir descuento agrego un if e igualo el descuento a 0.

        public Reserva(string nombre, string correoelectronico, string numerodetelefono, double decuentoespecial, string numerounico, string fecha, string hora, int precioLugar)
             : base(nombre, correoelectronico, numerodetelefono, decuentoespecial)
        {
            NumeroUnico = numerounico;
            Fecha = fecha;
            Hora = hora;
            PrecioLugar = precioLugar;
        }

    }
}
