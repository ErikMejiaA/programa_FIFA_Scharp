using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.clases
{
    public class CuerpoMedico
    {
        private string ? id_medico;
        private string ? nombre_medico;
        private string ? especialidad;
        private int edad_medico;

        public string ? Nombre_medico { get => nombre_medico; set => nombre_medico = value;}
        public string ? Especialidad { get => especialidad; set => especialidad = value; }
        public int Edad_medico { get => edad_medico; set => edad_medico = value; }
        public string? Id_medico { get => id_medico; set => id_medico = value; }

        public CuerpoMedico(string id_medico, string nombre_medico, string especialidad, int edad_medico){

            this.id_medico = id_medico;
            this.nombre_medico = nombre_medico;
            this.especialidad = especialidad;
            this.edad_medico = edad_medico;
        }

        public CuerpoMedico(){

        }
    }
}