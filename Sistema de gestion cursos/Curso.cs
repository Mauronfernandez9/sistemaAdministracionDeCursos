using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasando
{
    public class Curso
    {
        public Curso(string nombre, string descripcion, DateTime fechaDeInicio, DateTime fechaDeFinalizacion, int cantidadMaxAlumnos)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaDeInicio = fechaDeInicio;
            FechaDeFinalizacion = fechaDeFinalizacion;
            CantidadMaxAlumnos = cantidadMaxAlumnos;
        }

        public string Nombre { get; }
        public string Descripcion { get; }
        public DateTime FechaDeInicio { get; }
        public DateTime FechaDeFinalizacion { get; }

        public int CantidadMaxAlumnos {get;}
        private int cantidadDeAlumnos;
        public int CantidadDeAlumnos { get { return cantidadDeAlumnos; } }

        public List<Alumno> alumnos = new List<Alumno>();

        public int InscribirEstudiante(Alumno estudianteNuevo)
        {
            if(CantidadDeAlumnos <= CantidadMaxAlumnos)
            {
                alumnos.Add(estudianteNuevo);
                estudianteNuevo.AgregarCursoNuevo(this);
                cantidadDeAlumnos++;
                return 1;
            }
            return -1;
        }










    }
}
