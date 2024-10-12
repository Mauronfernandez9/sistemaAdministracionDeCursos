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
    public partial class FormCrearCurso : Form
    {
        private List<Curso> cursosDisponibles; 

        public FormCrearCurso(List<Curso> cursitosDisponibles)
        {
            InitializeComponent();
            this.cursosDisponibles = cursitosDisponibles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreCurso = textBoxNombreCurso.Text;
            string descripCurso = textBoxDescriCurso.Text;
            int cantMaxAlumnos = (int)numericCantMaxAlumnos.Value;
            DateTime fechaInicio = dateTimeInicioCurso.Value;
            DateTime fechaFin = dateTimeFinCurso.Value;

            Curso nuevoCurso = new Curso(nombreCurso, descripCurso, fechaInicio, fechaFin, cantMaxAlumnos);
            cursosDisponibles.Add(nuevoCurso);
            MessageBox.Show("Curso creado correctamente!");
            textBoxNombreCurso.Text = "";
            textBoxDescriCurso.Text = "";
            numericCantMaxAlumnos.Value = 0;
            dateTimeInicioCurso.Value = DateTime.Now;
            dateTimeFinCurso.Value = DateTime.Now;
        }

        private void textBoxNombreCurso_Validating(object sender, CancelEventArgs e)
        {
           if(textBoxNombreCurso.Text.Length == 0)
            {
                errorProviderNameCurso.SetError(textBoxNombreCurso, "Ingresa un nombre al curso...");
                e.Cancel = true;
            }
            else
            {
                errorProviderNameCurso.SetError(textBoxNombreCurso, string.Empty);
                e.Cancel = false;
            }
        }

        private void textBoxDescriCurso_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxDescriCurso.Text.Length == 0)
            {
                errorProviderDescrpCourse.SetError(textBoxDescriCurso, "Agrega una descripción para el curso...");
                e.Cancel = true;
            }
            else
            {
                errorProviderDescrpCourse.SetError(textBoxDescriCurso, string.Empty);
                e.Cancel = false;
            }
        }

        private void numericCantMaxAlumnos_Validating(object sender, CancelEventArgs e)
        {
            if(numericCantMaxAlumnos.Value == 0)
            {
                errorProviderCantAlumnos.SetError(numericCantMaxAlumnos, "No puede haber 0 alumnos en el cursado");
                e.Cancel = true;
            }
            else
            {
                errorProviderCantAlumnos.SetError(numericCantMaxAlumnos, string.Empty);
                e.Cancel = false;
            }
        }

        private void dateTimeInicioCurso_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimeInicioCurso.Value.Date <= DateTime.Now.Date)
            {
                errorProviderFechaInicio.SetError(dateTimeInicioCurso, "Ingresa una fecha de inicio correcta");
                e.Cancel = true;
            }
            else
            {
                errorProviderFechaInicio.SetError(dateTimeInicioCurso, string.Empty);
                e.Cancel = false;
            }
        }

        private void dateTimeFinCurso_Validating(object sender, CancelEventArgs e)
        {
            if(dateTimeFinCurso.Value.Date < dateTimeInicioCurso.Value.Date)
            {
                errorProviderFechaFin.SetError(dateTimeFinCurso, "Ingresa una fecha de finalización correcta");
                e.Cancel = true;
            }
            else
            {
                errorProviderFechaFin.SetError(dateTimeFinCurso, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
