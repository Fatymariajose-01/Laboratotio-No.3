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
        //Si es cliente normal a la hora de pedir descuento agrego un if e igualo el descuento a 0.
        public List<string> NombrePlato { get; set; }
        public int PrecioPlato { get; set; }
        public int CantidadPlatos { get; set; }
        public Cliente Cliente { get; set; }

        public Reserva(string numerounico, string fecha, string hora, int precioLugar, List<string> nombreplato, int precioplato, int cantidadplatos, Cliente cliente)
        {
            NumeroUnico = numerounico;
            Fecha = fecha;
            Hora = hora;
            PrecioLugar = precioLugar;
            NombrePlato = nombreplato;
            PrecioPlato = precioplato;
            CantidadPlatos = cantidadplatos;
            Cliente = cliente;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Número unico de la reserva: {NumeroUnico}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Hora: {Hora}");
            Console.WriteLine($"Precio del Lugar: {PrecioLugar}");
            Console.WriteLine($"Nombre del Plato: {NombrePlato}");
            Console.WriteLine($"Precio del Plato: {PrecioPlato}");
            Console.WriteLine($"Cantidad de Platos: {CantidadPlatos}");
            Console.WriteLine($"Cliente: {Cliente}");
        }
        public virtual double CalcularTotal()
        {
            double total = PrecioPlato*CantidadPlatos ;

            if (Cliente is ClienteVip clienteVIP)
            {
                // Aplica descuento especial si el cliente es VIP
                total -= total * (clienteVIP.DescuentoEspecial / 100);
                total = total + PrecioLugar;
            }
            Console.WriteLine("El total es: ");
            return total;
        }
    }
}
