using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace programa_FIFA_Scharp.Entities
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

        /*public CuerpoMedico RegistrarCuerpoMedico(){
            CuerpoMedico cuerpoMedico = new CuerpoMedico();
            Console.WriteLine("Ingrese el Id del cuerpo Medico:");
            cuerpoMedico.Id_medico = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del Cuerpo Medico:");
            cuerpoMedico.Nombre_medico = Console.ReadLine();
            Console.WriteLine("Ingrese la especialidad del Cuerpo Medico:");
            cuerpoMedico.Especialidad = Console.ReadLine();
            Console.WriteLine("Dijete la edad del Cuerpo Tecnico:");
            cuerpoMedico.Edad_medico = Convert.ToInt32(Console.ReadLine());
            return cuerpoMedico;
        }*/
    }
}