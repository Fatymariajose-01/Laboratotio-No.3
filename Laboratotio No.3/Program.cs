using System.Data;
using Laboratotio_No._3;
public class Program
{ 
public static List<Cliente> listaClientes = new List<Cliente>();
public static  List<Reserva> listaReserva  = new List<Reserva>();

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Registrar Cliente Regular");
            Console.WriteLine("2. Registrar Cliente VIP");
            Console.WriteLine("3. Registrar Reserva");
            Console.WriteLine("4. Mostrar Detalles de Clientes");
            Console.WriteLine("5. Mostrar Detalles de Reservas");
            Console.WriteLine("6. Buscar Cliente por Nombre");
            Console.WriteLine("7. Buscar Reserva por Número");
            Console.WriteLine("8. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());   

            switch (opcion)
            {
                case 1:
                    RegistrarClienteRegular();
                    break;
                case 2:
                    RegistrarClienteVIP();
                    break;
                case 3:
                    RegistrarReserva();
                    break;
                case 4:
                    MostrarDetallesClientes();
                    break;
                case 5:
                    MostrarDetallesReservas();
                    break;
                case 6:
                    BuscarClientePorNombre();
                    break;
                case 7:
                    BuscarReservaPorNumero();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
    public static void RegistrarClienteRegular()
{
    Console.Write("Nombre del Cliente: ");
    string nombre = Console.ReadLine();
    Console.Write("Correo Electrónico: ");
    string correoelectronico = Console.ReadLine();
    Console.Write("Número de Teléfono: ");
    string telefono = Console.ReadLine();

    Cliente cliente = new Cliente(nombre, correoelectronico, telefono);
    listaClientes.Add(cliente);
    Console.WriteLine("Cliente Regular registrado con éxito.");
}

    public static void RegistrarClienteVIP()
    {
        Console.Write("Nombre del Cliente: ");
        string nombre = Console.ReadLine();
        Console.Write("Correo Electrónico: ");
        string correo = Console.ReadLine();
        Console.Write("Número de Teléfono: ");
        string telefono = Console.ReadLine();
        Console.Write("Descuento Especial (%): ");
        double descuento = double.Parse(Console.ReadLine());

        ClienteVip cliente = new ClienteVip(nombre, correo, telefono, descuento);
        listaClientes.Add(cliente);
        Console.WriteLine("Cliente VIP registrado con éxito.");
    }
    private static void RegistrarReserva()
    {
        int cantidadDePlatos = 0;
        Console.WriteLine("Ingrese el Número Único que se asignará: ");
        string numerounico = Console.ReadLine();
        Console.Write("Fecha de la Reserva (yyyy-mm-dd): ");
        string fecha = Console.ReadLine();
        Console.Write("Hora de la Reserva (HH:mm): ");
        string hora = Console.ReadLine();
        Console.WriteLine("Prrecio del Lugar: ");
        int PrecioLugar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nombre de Platos: ");
        int nombrePlatos = int.Parse(Console.ReadLine());
        List<string> platos = new List<string>();
        for (int i = 0; i < cantidadDePlatos; i++)
        {
            Console.Write($"Nombre del Plato {i + 1}: ");
            platos.Add(Console.ReadLine());
        }
        Console.WriteLine("Precio de cada plato: ");
        int PrecioPlato = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cantidad de platos: ");
        cantidadDePlatos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nombre del Cliente: ");
        string nombreCliente = Console.ReadLine();
        Cliente cliente = listaClientes.Find(c => c.Nombre.Equals(nombreCliente, StringComparison.OrdinalIgnoreCase));

        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado.");
            return;
        }

        Reserva reserva = new Reserva(numerounico, fecha, hora, PrecioLugar,  platos, PrecioPlato, cantidadDePlatos, cliente);
        listaReserva.Add(reserva);
        Console.WriteLine("Reserva registrada con éxito.");
    }
    public static void MostrarDetallesClientes()
    {
        Console.WriteLine("Detalles de Clientes:");
        foreach (var clientes1 in listaClientes)
        {
            Console.WriteLine(clientes1);
        }
        
    }

    private static void MostrarDetallesReservas()
    {
        Console.WriteLine("Detalles de Reservas:");
        foreach (var reserva in listaReserva)
        {
            Console.WriteLine(reserva);
        }
    }

    private static void BuscarClientePorNombre()
    {
        Console.Write("Nombre del Cliente a buscar: ");
        string nombre = Console.ReadLine();
        var cliente = listaClientes.Find(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        if (cliente != null)
        {
            Console.WriteLine(cliente);
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    private static void BuscarReservaPorNumero()
    {
        Console.Write("Número de Reserva a buscar: ");
        string numero = Console.ReadLine();
        var reserva = listaReserva.Find(r => r.NumeroUnico == numero);
        if (reserva != null)
        {
            Console.WriteLine(reserva);
        }
        else
        {
            Console.WriteLine("Reserva no encontrada.");
        }
    }
}