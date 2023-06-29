using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.clases
{
    public class PuntosClasificacion
    {
        private int pj;
        private int pg;
        private int pe;
        private int pp;
        private int gf;
        private int gc;
        private int total_puntos;

        public int Pg { get => pg; set => pg = value; }
        public int Pe { get => pe; set => pe = value; }
        public int Pp { get => pp; set => pp = value; }
        public int Gf { get => gf; set => gf = value; }
        public int Gc { get => gc; set => gc = value; }
        public int Total_puntos { get => total_puntos; set => total_puntos = value; }
        public int Pj { get => pj; set => pj = value; }

        public PuntosClasificacion(int pj, int pg, int pe, int pp, int gf, int gc, int total_puntos)
        {
            this.pj = pj;
            this.pg = pg;
            this.pe = pe;
            this.pp = pp;
            this.gf = gf;
            this.gc = gc;
            this.total_puntos = total_puntos;
        }

        public PuntosClasificacion()
        {

        }

        public PuntosClasificacion RegistrarTablaPuntos(){
            PuntosClasificacion puntosClasi = new PuntosClasificacion();
            Console.WriteLine("Ingrese el numero de Partidos Jugdos (PJ):");
            puntosClasi.Pj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Partidos Ganados (PG):");
            puntosClasi.Pg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Partidos Empatados (PE):");
            puntosClasi.Pe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Partidos Perdidos (PP):");
            puntosClasi.Pp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Goles a Favor (GF)):");
            puntosClasi.Gf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de Goles en Contra (GC)):");
            puntosClasi.Gc = Convert.ToInt32(Console.ReadLine());
            
            return puntosClasi;
        }
    }
}