using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.Entities
{
    public class Jugador
    {
        private string ? id_jugador;
        private string ? nombre_jugador;
        private int nro_dorsal;
        private string ? posicion;
        private int edad_jugador;

        //definimos el constructor
        public string ? Nombre_jugador { get => nombre_jugador; set => nombre_jugador = value; }
        public int Nro_dorsal { get => nro_dorsal; set => nro_dorsal = value; }
        public string ? Posicion { get => posicion; set => posicion = value; }
        public int Edad_jugador { get => edad_jugador; set => edad_jugador = value; }
        public string ? Id_jugador { get => id_jugador; set => id_jugador = value; }

        public Jugador(string id_jugador, string nombre_jugador, int nro_dorsal, string posicion, int edad_jugador)
        {
            this.id_jugador = id_jugador;
            this.nombre_jugador = nombre_jugador;
            this.nro_dorsal = nro_dorsal;
            this.posicion = posicion;
            this.edad_jugador = edad_jugador;
        }

        public Jugador()
        {

        }

        /*public Jugador RegistroJugador(){
            Jugador jugador = new Jugador();
            Console.WriteLine("Ingrese el Id del jugador:");
            jugador.Id_jugador = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del Jugador:");
            jugador.Nombre_jugador = Console.ReadLine();
            Console.WriteLine("Ingrese el numero del Dorsal del jugador:");
            jugador.Nro_dorsal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la posicion del jugador:");
            jugador.Posicion = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del jugador:");
            jugador.Edad_jugador = Convert.ToInt32(Console.ReadLine());
            return jugador;
        }*/
    }
}