using programa_FIFA_Scharp.clases;

internal class Program
{
    private static void Main(string[] args)
    {

        ControlarClases controlarClases = new ControlarClases();

        bool opcControlador = true;
        while (opcControlador)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("-------FIFA WORLD CLUP FEMENINO 2023-------------");
            Console.WriteLine("*************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("* Dijite la Opcion que decea realizar: *");
            Console.WriteLine("\n1. Registrar Equipo.\n2. Registrar Fecha de partidos jugados.\n3. Mostrar la tabla de estadistica del grupo.\n4. Ver la inforación de Equipos.\n5. Mostrar equipos clasificados a 8vos.\n6. Mostra el listado de jugadores que pertenecen a un Equipo.\n7. Mostrar el Equipo que mas Goles marco por cada Grupo.\n8. Salir");

            int opcReg = Convert.ToInt32(Console.ReadLine());
            switch (opcReg)
            {
                case 1:
                    controlarClases.RegistrarEquipos();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 6:
                    break;

                case 7:
                    break;

                case 8:
                    Console.Clear();
                    opcControlador = false;
                    break;

                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR la opcion ingresada no es Valida");
                    break;
            }
        }




    }
}