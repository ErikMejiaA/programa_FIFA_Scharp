using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using programa_FIFA_Scharp.Entities;
using Newtonsoft.Json;

namespace programa_FIFA_Scharp
{
    public class ControlarPrograma
    {
         List<Equipo> equipos = new List<Equipo>();

        //Metodo para crear y Utilizar el archivo de base de datos que contendra todos los equipos de la FIFA
        //se especifica en el constructor de la clase 
        public ControlarPrograma() {
            if (!ExisteFile()) {
                CrearFile();

            } else {
                using(StreamReader reader = new StreamReader("fifa_world_clud.json")){
                    string json = reader.ReadToEnd();
                    this.equipos = System.Text.Json.JsonSerializer
                        .Deserialize<List<Equipo>>(json, new System.Text.Json.JsonSerializerOptions(){PropertyNameCaseInsensitive = true}) ?? new List<Equipo>();
                }
            }
        }

        //Metodo para validar si existe el archivo json
        public bool ExisteFile() {
            bool validarArchivo = true;
            if (File.Exists("fifa_world_clud.json")) {
                validarArchivo = true;

            } else {
                validarArchivo = false;
            }
            return validarArchivo;
        }
        
        //Metodo para crar el archivo json si no existe
        public void CrearFile() {
            if (!ExisteFile()) {
                File.Create("fifa_world_clud.json");
            }
        }

        //Metodo para guardar los datos de la lista Equipos en el archivo json
        public void GuardarDatosFile() {
            string json = JsonConvert.SerializeObject(equipos, Formatting.Indented);
            File.WriteAllText("fifa_world_clud.json", json);
        }

        //Metodo para registrar los equipos
        public void RegistrarEquipos() {

            bool opcEquipos = true;
            while (opcEquipos) {

                Equipo equipo = new Equipo();
                Console.WriteLine("\n");
                bool opcIdEquipo = true;
                do
                {
                    //Verificamos que el Id del Equipo no exista y si existe crear uno nuevo.
                    Console.WriteLine("Ingrese el Id del Equipo: ");
                    equipo.Id_equipo = (Console.ReadLine() ?? string.Empty).ToUpper();
                    bool idEquipo = equipos.Any(itemEquipo => (itemEquipo.Id_equipo == equipo.Id_equipo)); 
                    if (idEquipo) {
                        opcIdEquipo = true;
                        Console.WriteLine("\n*El Id del equipo que ingreso ya existe, por favor dijite uno nuevo:\n");
                    } else {
                        opcIdEquipo = false;
                    }
                } while (opcIdEquipo);

                Console.WriteLine("Ingrese el nombre del pais: ");
                equipo.Nombre_pais = (Console.ReadLine() ?? string.Empty).ToUpper();
                Console.WriteLine("Ingrese el grupo al que pertenece: ");
                equipo.Grupo = (Console.ReadLine() ?? string.Empty).ToUpper();
                equipos.Add(equipo);

                GuardarDatosFile();
                Console.ReadKey();

                Console.WriteLine("\n*Desea agregar otro Equipo mas? Precione: Enter (SI) ó Escape (NO).");
                if (Console.ReadKey().Key == ConsoleKey.Escape){
                    opcEquipos = false;
                }
            }
        }

        //Metodo para registra el Plantel de Pesonas (Jugadores, Medicos, Tecnicos) que hacen parate de un equipo 
        public void RegistraPlantelEquipos(string Id) {

            //Verificamos que el equipo exista para porceder a registar las pesosnar que lo integran 
            //como lo son los jugadores, cuerpo tecnico, cuerpo medico.
            //se crea una nueva instacia del equipo encontrado.
            Equipo cargarEquipo = equipos.FirstOrDefault(teamEquipo => (teamEquipo.Id_equipo ?? string.Empty).Equals(Id)) ?? new Equipo();
            
            if (cargarEquipo.Id_equipo == Id) {

                Console.WriteLine("El equipo se encontro");
                bool opcRegistros = true;
                while (opcRegistros) 
                {
                    Console.WriteLine("\n* Dijite la opcion que desea Registra:*\n1. Registar Jugadores.\n2. Registrar Cuerpo Tecnico.\n3. Registrar Cuerpo Medico.\n4. Salir de Registros Plantel.\n");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    Console.ReadKey();
                    switch (opcion)
                    {
                        case 1:
                            bool opcJugador = true;
                            while (opcJugador)
                            {
                                Jugador jugador = new Jugador();
                                
                                Console.WriteLine("\n");
                                bool opcIdJugador = true;
                                do
                                {
                                    //Verificamos que el Id del Jugador no exista y si existe crear uno nuevo
                                    Console.WriteLine("Ingrese el Id del jugador:");
                                    jugador.Id_jugador = (Console.ReadLine() ?? string.Empty).ToUpper();
                                    bool idJugador = cargarEquipo.Jugadores.Any(itemJugador => (itemJugador.Id_jugador == jugador.Id_jugador));
                                    if (idJugador) {
                                        opcIdJugador = true;
                                        Console.WriteLine("\n*El Id del Jugador que ingreso ya existe, por favor dijite uno nuevo:\n");
                                    } else {
                                        opcIdJugador = false;
                                    }

                                } while (opcIdJugador);

                                bool opcDorsal = true;
                                do
                                {
                                    //Verificamos que el numero del Jugador (Dorsal) no exista en otro en otro jugador.
                                    Console.WriteLine("Ingrese el numero del Dorsal del jugador:");
                                    jugador.Nro_dorsal = Convert.ToInt32(Console.ReadLine());
                                    bool numeDorsal = cargarEquipo.Jugadores.Any(itemJugador => (itemJugador.Nro_dorsal == jugador.Nro_dorsal));

                                    //Comprobamos que el numero del Dorsal dijitado sea menor a dos dijitos (< 100)
                                    //y que el numero del Dorsal no exista.
                                    if ((numeDorsal == false) && (jugador.Nro_dorsal < 100)) {
                                        opcDorsal = false;
                                    } else {
                                        opcDorsal = true;
                                         Console.WriteLine("\n*El Numero del Dorsal del Jugador que ingreso ya existe, por favor dijite uno nuevo:\n");
                                    }

                                } while (opcDorsal);

                                Console.WriteLine("Ingrese el nombre del Jugador:");
                                jugador.Nombre_jugador = (Console.ReadLine() ?? string.Empty).ToUpper();
                                Console.WriteLine("Ingrese la posicion del jugador:");
                                jugador.Posicion = (Console.ReadLine() ?? string.Empty).ToUpper();
                                Console.WriteLine("Ingrese la edad del jugador:");
                                jugador.Edad_jugador = Convert.ToInt32(Console.ReadLine());
                                cargarEquipo.Jugadores.Add(jugador);

                                GuardarDatosFile();
                                Console.ReadKey();

                                Console.WriteLine("Desea agregar otro Jugador más? Precione: Enter (SI) ó Escape (NO).");
                                if (Console.ReadKey().Key == ConsoleKey.Escape){
                                    opcJugador = false;
                                }
                            }
                            break;
                        
                        case 2:
                            bool opcTecnico = true;
                            while (opcTecnico)
                            {
                                CuerpoTecnico cuerpoTecnico = new CuerpoTecnico();

                                Console.WriteLine("\n");
                                bool opcIdTecnico = true;
                                do
                                {
                                    //Verificamo que el Id del Cuerpo Tecnico no se repita
                                    Console.WriteLine("Ingrese el id del Cuerpo Tecnico:");
                                    cuerpoTecnico.Id_tecnico = (Console.ReadLine() ?? string.Empty).ToUpper();
                                    bool idTecnico = cargarEquipo.Tecnicos.Any(itemTecnico => (itemTecnico.Id_tecnico == cuerpoTecnico.Id_tecnico));
                                    if (idTecnico){
                                        opcIdTecnico = true;
                                         Console.WriteLine("\n*El Id del Cuerpo Tecnico que ingreso ya existe, por favor dijite uno nuevo:\n");
                                    } else {
                                        opcIdTecnico = false;
                                    }

                                } while (opcIdTecnico);

                                Console.WriteLine("Ingrese el nombre del Cuerpo Tecnico:");
                                cuerpoTecnico.Nombre_tecnico = (Console.ReadLine() ?? string.Empty).ToUpper();
                                Console.WriteLine("Ingrese el cargo del Cuerpo Tecnico:");
                                cuerpoTecnico.Cargo = (Console.ReadLine() ?? string.Empty).ToUpper();
                                Console.WriteLine("Ingrese la edad del Cuerpo Tecnico:");
                                cuerpoTecnico.Edad_tecnico = Convert.ToInt32(Console.ReadLine());
                                cargarEquipo.Tecnicos.Add(cuerpoTecnico);

                                GuardarDatosFile();
                                Console.ReadKey();

                                Console.WriteLine("Desea agregar otro miembro más del Cuerpo Tecnico? Precione: Enter para (SI) ó Escape para (NO).");
                                if (Console.ReadKey().Key == ConsoleKey.Escape){
                                    opcTecnico = false;
                                }
                            }
                            break;

                        case 3:
                            bool opcMedico = true;
                            while (opcMedico)
                            {   
                                CuerpoMedico cuerpoMedico = new CuerpoMedico();

                                Console.WriteLine("\n");
                                bool opcIdMedico = true;
                                do
                                {
                                    //Verificamos que el Id del Cuerpo Medico no exista
                                    Console.WriteLine("Ingrese el Id del cuerpo Medico:");
                                    cuerpoMedico.Id_medico = (Console.ReadLine() ?? string.Empty).ToUpper();
                                    bool idMedico = cargarEquipo.Medicos.Any(itemMedico => (itemMedico.Id_medico == cuerpoMedico.Id_medico));
                                    if (idMedico) {
                                        opcIdMedico = true;
                                    } else {
                                        opcIdMedico = false;
                                    }

                                } while (opcIdMedico);

                                Console.WriteLine("Ingrese el nombre del Cuerpo Medico:");
                                cuerpoMedico.Nombre_medico = (Console.ReadLine() ?? string.Empty).ToUpper();
                                Console.WriteLine("Ingrese la especialidad del Cuerpo Medico:");
                                cuerpoMedico.Especialidad = (Console.ReadLine() ?? string.Empty).ToUpper();
                                Console.WriteLine("Ingrese la edad del Cuerpo Tecnico:");
                                cuerpoMedico.Edad_medico = Convert.ToInt32(Console.ReadLine());
                                cargarEquipo.Medicos.Add(cuerpoMedico);

                                GuardarDatosFile();
                                Console.ReadKey();

                                Console.WriteLine("Desea agregar otro miembro más del Cuerpo Medico? Precione: Enter para (SI) ó Escape para (NO).");
                                if (Console.ReadKey().Key == ConsoleKey.Escape){
                                    opcMedico = false;
                                }
                            }
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

            } else {

                Console.WriteLine("El Equipo no se encontro, no EXISTE");
            }

            /*foreach (Equipo item in equipos)
            {
                Console.WriteLine("{0, -8} {1, 10}", item.Id_equipo, item.Nombre_pais);
                /*foreach (Jugador n in item.Jugadores)
                {
                    Console.WriteLine(" {0, -8} {1, 10} {2, 16} {3, 25} {4, 35} ", n.Id_jugador, n.Nombre_jugador, n.Nro_dorsal, n.Posicion, n.Edad_juagador);
                }
                
            }
            Console.ReadKey();*/
        }

        //metodo para listar todo hacerca de los equipos (juagdore, medicos, tecnicos, puntosObtenido)
        public IEnumerable<Equipo> AllEquipos(){
            return equipos;
        }


    }
}