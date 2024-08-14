using Laboratotio_No._3;
public class Program
{ 
public static List<Cliente> listaClientes = new List<Cliente>();
public static  List<Reserva> listaReserva  = new List<Reserva>();

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


}