using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.clases
{
    public class CuerpoTecnico
    {
        private string ? id_tecnico;
        private string ? nombre_tecnico;
        private string ? cargo;
        private int edad_tecnico;

        public string ? Nombre_tecnico { get => nombre_tecnico; set => nombre_tecnico = value; }
        public string ? Cargo { get => cargo; set => cargo = value; }
        public int Edad_tecnico { get => edad_tecnico; set => edad_tecnico = value; }
        public string? Id_tecnico { get => id_tecnico; set => id_tecnico = value; }

        public CuerpoTecnico(string id_tecnico, string nombre_tecnico, string cargo, int edad_tecnico){

            this.id_tecnico = id_tecnico;
            this.nombre_tecnico = nombre_tecnico;
            this.cargo = cargo;
            this.edad_tecnico = edad_tecnico;

        }

        public CuerpoTecnico(){

        }

    }
}