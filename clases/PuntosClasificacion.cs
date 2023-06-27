using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.clases
{
    public class PuntosClasificacion
    {
        private string ? id_puntos;
        private int pj;
        private int pg;
        private int pe;
        private int pp;
        private int gf;
        private int gc;
        private int total_puntos;

        public string ? Id_puntos { get => id_puntos; set => id_puntos = value; }
        public int Pg { get => pg; set => pg = value; }
        public int Pe { get => pe; set => pe = value; }
        public int Pp { get => pp; set => pp = value; }
        public int Gf { get => gf; set => gf = value; }
        public int Gc { get => gc; set => gc = value; }
        public int Total_puntos { get => total_puntos; set => total_puntos = value; }

        public PuntosClasificacion(string id_puntos, int pj, int pg, int pe, int pp, int gf, int gc, int total_puntos)
        {
            this.id_puntos = id_puntos;
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
    }
}