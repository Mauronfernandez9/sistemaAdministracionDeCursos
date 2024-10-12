using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasando
{
    public class Alumno : Persona
    {
        public Alumno(string nombre,string apellido,string dni,string nacionalidad,DateTime fechaNacimiento) : base(nombre,apellido,dni,fechaNacimiento,nacionalidad) 
        {
        }
        public  Alumno() 
            :base("sin nombre","sin apellido", "sin dni",DateTime.MinValue,"sin nacionalidad")
        { }
        

        public string Turno { get; }

        public List<Curso> cursos = new List<Curso>();

        public int cantidadCursos 
        { get {return cursos.Count; } 
        }

        public void AgregarCursoNuevo(Curso cursoNuevo)
        {
            cursos.Add(cursoNuevo);
 
        }



    }
}
