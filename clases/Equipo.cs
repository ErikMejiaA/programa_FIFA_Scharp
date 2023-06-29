using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.clases
{
    public class Equipo
    {
        private string ? id_equipo;
        private string ? nombre_pais;
        private string ? grupo;
        private List<Jugador> jugadores = new List<Jugador>();
        private List<CuerpoTecnico> tecnicos = new List<CuerpoTecnico>();
        private List<CuerpoMedico> medicos = new List<CuerpoMedico>();
        private List<PuntosClasificacion> leyendaPuntos = new List<PuntosClasificacion>();


        public string ? Nombre_pais { get => nombre_pais; set => nombre_pais = value; }
        public string ? Grupo { get => grupo; set => grupo = value; }
        public string ? Id_equipo { get => id_equipo; set => id_equipo = value; }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public List<CuerpoTecnico> Tecnicos { get => tecnicos; set => tecnicos = value; }
        public List<CuerpoMedico> Medicos { get => medicos; set => medicos = value; }
        public List<PuntosClasificacion> LeyendaPuntos { get => leyendaPuntos; set => leyendaPuntos = value; }

        public Equipo(string id_equipo, string nombre_pais, string grupo, List<Jugador> jugadores, List<CuerpoTecnico> tecnicos, List<CuerpoMedico> medicos, List<PuntosClasificacion> leyendaPuntos)
        {
            this.id_equipo = id_equipo;
            this.nombre_pais = nombre_pais;
            this.grupo = grupo;
            this.jugadores = jugadores;
            this.tecnicos = tecnicos;
            this.medicos = medicos;
            this.leyendaPuntos = leyendaPuntos;

        }

        public Equipo()
        {

        }
    }
}