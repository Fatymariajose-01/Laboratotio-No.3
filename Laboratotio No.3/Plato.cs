using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratotio_No._3
{
    public class Plato:Reserva
    {
        //Plato tiene la info del cliente y de la reserva.
        public string NombrePlato { get; set; }
        public int PrecioPlato { get; set; }
        public int CantidadPlatos { get; set; }
        public Plato(string nombre, string correoelectronico, string numerodetelefono, double decuentoespecial, string numerounico, string fecha, string hora, int precioLugar, string nombreplato, int precioplato, int cantidadplatos)
            : base(nombre, correoelectronico, numerodetelefono, decuentoespecial, numerounico, fecha, hora, precioLugar)
        { 
            NombrePlato = nombreplato;
            PrecioPlato = precioplato;
            CantidadPlatos = cantidadplatos;
            }
    }

}
