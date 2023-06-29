using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.clases
{
    public class ControlarClases
    {
        List<Equipo> equipos = new List<Equipo>();

        //metodo para listar todo hacer del equipo (juagdore, medicos, tecnicos, puntosObtenido)
        public IEnumerable<Equipo> AllEquipos(){
            return equipos;
        }

        //Metodo para registrar los equipos, jugadores, Cuerpo Tecnico y medico
        public void RegistrarEquipos(){
            
            bool opcEquipo = true;
            while (opcEquipo)
            {
                Equipo equipo = new Equipo();

                Console.WriteLine("Ingrese el Id del Equipo: ");
                equipo.Id_equipo = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del pais: ");
                equipo.Nombre_pais = Console.ReadLine();
                Console.WriteLine("Ingrese el grupo al que pertenece: ");
                equipo.Grupo = Console.ReadLine();

                Console.ReadKey();
                bool opcRegistros = true;
                while (opcRegistros)
                {
                    Console.WriteLine("Dijite la opcion que desea Registra:\n1. Registar Jugadores.\n2. Registrar Cuerpo Tecnico.\n3. Registrar Cuerpo Medico.\n4.Salir de Registros.");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.ReadKey();
                    switch (opcion)
                    {
                        case 1:
                            //colocarle un while a cada caso de registro 
                            Jugador jugador = new Jugador();
                            jugador.RegistroJugador();
                            equipo.Jugadores.Add(jugador);
                            Console.ReadKey();
                            break;
                        case 2:
                            CuerpoTecnico cuerpoTecnico = new CuerpoTecnico();
                            cuerpoTecnico.RegistraCuerpoTecnico();
                            equipo.Tecnicos.Add(cuerpoTecnico);
                            Console.ReadKey();
                            break;
                        case 3:
                            CuerpoMedico cuerpoMedico = new CuerpoMedico();
                            cuerpoMedico.RegistrarCuerpoMedico();
                            equipo.Medicos.Add(cuerpoMedico);
                            Console.ReadKey();
                            break;
                        case 4:
                            opcRegistros = false;
                            break;
                        
                        default:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR la opcion ingresada no es Valida");
                            break;
                    }
                    
                }
                
                equipos.Add(equipo);
                Console.WriteLine("Desea agregar otro Equipo mas? Precione: Enter (SI) ó Escape (NO).");
                if (Console.ReadKey().Key == ConsoleKey.Escape){
                    opcEquipo = false;
                }
            }

            foreach (Equipo item in equipos)
            {
                Console.WriteLine("{0, -15} {1, 15} {2, 30} ", item.Id_equipo, item.Nombre_pais, item.Grupo);
            }

        }
    }
}