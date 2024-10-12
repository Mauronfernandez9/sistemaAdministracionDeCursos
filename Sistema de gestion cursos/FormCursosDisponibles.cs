using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repasando
{
    public partial class FormCursosDisponibles : Form
    {
        private List<Curso> cursosDisponibles; 
        public FormCursosDisponibles(List<Curso> cursito)
        {
            
            InitializeComponent();
            this.cursosDisponibles = cursito;
            foreach(Curso curso in cursosDisponibles)
            {
                comboBoxVerCursosDisponibles.Items.Add(curso.Nombre);
            }
        }

        

        private void FormCursosDisponibles_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBoxVerCursosDisponibles_SelectedValueChanged(object sender, EventArgs e)
        {
            string cursoSeleccionado = comboBoxVerCursosDisponibles.Text;
            Curso cursoHaMostrar = cursosDisponibles.Find(curs => curs.Nombre == cursoSeleccionado);
            textBoxNombreCursoDisponible.Text = cursoHaMostrar.Nombre;
            textBoxDescripCursoDisponible.Text = cursoHaMostrar.Descripcion;
            textBoxCantidadCuposDisponibles.Text = $"{cursoHaMostrar.CantidadMaxAlumnos - cursoHaMostrar.CantidadDeAlumnos}";
            textBoxCantidadMaxAlumnos.Text = $"{cursoHaMostrar.CantidadMaxAlumnos}";
            dateTimeFechaInicio.Value = cursoHaMostrar.FechaDeInicio;
            dateTimeFechaFinaliz.Value = cursoHaMostrar.FechaDeFinalizacion;




        }
    }
}
