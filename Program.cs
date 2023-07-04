using programa_FIFA_Scharp;

internal class Program
{
    private static void Main(string[] args)
    {

        ControlarPrograma controlarPrograma = new ControlarPrograma();
        bool opcControlador = true;
        while (opcControlador)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("-------FIFA WORLD CLUP FEMENINO 2023-------------");
            Console.WriteLine("*************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("* Dijite la Opcion que decea realizar: *\n");
            Console.WriteLine("1. Registrar Equipos.\n2. Registrar el Plantel del Equipo.\n3. Registrar Fecha de partidos jugados.\n4. Mostrar la tabla de estadistica del grupo.\n5. Ver la inforación de Equipos.\n6. Mostrar equipos clasificados a 8vos.\n7. Mostra el listado de jugadores que pertenecen a un Equipo.\n8. Mostrar el Equipo que mas Goles marco por cada Grupo.\n9. Salir\n");

            int opcReg = Convert.ToInt32(Console.ReadLine());
            switch (opcReg)
            {
                case 1:
                    controlarPrograma.RegistrarEquipos();
                    break;

                case 2:
                    bool opcPlantel = true;
                    while (opcPlantel) 
                    {
                        Console.WriteLine("Ingrese el Id del Equipo, para poder registrar su Personal:\n");
                        string Id = (Console.ReadLine() ?? string.Empty).ToUpper();
                        controlarPrograma.RegistraPlantelEquipos(Id);

                        //Console.ReadKey();
                        Console.WriteLine("Desea Ingresar el Id de otro Equipo? Para el registro de su Plantel: -> Precione: Enter para (SI) ó Escape para (NO).");
                        if (Console.ReadKey().Key == ConsoleKey.Escape){
                            opcPlantel = false;
                        }
                    }
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
                    break;

                case 9:
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