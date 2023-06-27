using programa_FIFA_Scharp.clases;

internal class Program
{
    private static void Main(string[] args)
    {
        Jugador jugador = new Jugador();
        Equipo equipo = new Equipo();
        List<Equipo> equipos = new List<Equipo>();

        Console.WriteLine("Ingrese el nombre del pais: ");
        equipo.Nombre_pais = Console.ReadLine();

        Console.WriteLine("Ingrese el grupo al que pertenece: ");
        equipo.Grupo = Console.ReadLine();

        Console.WriteLine("Ingrese el nombre del jugador:");
        jugador.Nombre_jugador = Console.ReadLine();

        
    }
}