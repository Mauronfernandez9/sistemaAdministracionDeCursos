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
    public partial class FormVerUsuario : Form
    {
        public FormVerUsuario(List<Alumno> listaDeAlumnos)
        {
            alumnosInstituc = listaDeAlumnos;
            InitializeComponent();
        }

        public List<Alumno> alumnosInstituc;

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxIngresoDni_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIngresoDni.Text.Length > 2 && textBoxIngresoDni.Text[2] != '.')
            {
                textBoxIngresoDni.Text = textBoxIngresoDni.Text.Insert(2, ".");
                textBoxIngresoDni.SelectionStart = textBoxIngresoDni.Text.Length;
            }
            if (textBoxIngresoDni.Text.Length > 6 && textBoxIngresoDni.Text[6] != '.')
            {
                textBoxIngresoDni.Text = textBoxIngresoDni.Text.Insert(6, ".");
                textBoxIngresoDni.SelectionStart = textBoxIngresoDni.Text.Length;
            }
        }

        private bool alumnoSeEncuentra(string dni)
        {
            Alumno alumnoEncontrado = alumnosInstituc.Find(alum => alum.Dni == dni);
            if (alumnoEncontrado != null)
            {
                return true;
            }

            return false;
        }


        private void botonBuscarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumnoEncontrado; //sobrecarga del constructor 
            string dni;
            bool respuestaSeEncuentra = false;
            textBoxCursos.Text = string.Empty;
            textBoxApellidoEncontrado.Text = string.Empty;
            textBoxBarrioEncontrado.Text = string.Empty;
            textBoxCalleEncontrada.Text = string.Empty;
            textBoxCiudadEncontrada.Text = string.Empty;
            textBoxNacionalidadEncontrada.Text = string.Empty;
            textBoxNombreEncontrado.Text = string.Empty;
            textBoxNumeroCalleEncontrada.Text = string.Empty;
            textBoxPaisEncontrado.Text = string.Empty;
            textBoxProvincEntonctrada.Text = string.Empty;

            if (alumnosInstituc.Count > 0)
            {
                if (textBoxIngresoDni.Text.Length != 0)
                {
                    respuestaSeEncuentra = alumnoSeEncuentra(textBoxIngresoDni.Text);
                }
                else
                {
                    textBoxIngresoDni.BackColor = Color.Red;
                    return;
                }
                if (respuestaSeEncuentra)
                {
                    textBoxIngresoDni.BackColor = SystemColors.Window;
                    dni = textBoxIngresoDni.Text;
                    alumnoEncontrado = alumnosInstituc.Find(alum => alum.Dni == dni);

                    
                    textBoxNombreEncontrado.Text = alumnoEncontrado.Nombre;
                    textBoxApellidoEncontrado.Text = alumnoEncontrado.Apellido;
                    textBoxBarrioEncontrado.Text = alumnoEncontrado.Direccion.Barrio;
                    textBoxCalleEncontrada.Text = alumnoEncontrado.Direccion.NombreCalle;
                    textBoxCiudadEncontrada.Text = alumnoEncontrado.Direccion.Ciudad;
                    textBoxNacionalidadEncontrada.Text = alumnoEncontrado.Nacionalidad;
                    textBoxNumeroCalleEncontrada.Text = $"{alumnoEncontrado.Direccion.NumeroCalle}";
                    textBoxPaisEncontrado.Text = alumnoEncontrado.Direccion.Pais;
                    textBoxProvincEntonctrada.Text = alumnoEncontrado.Direccion.Provincia;
                    foreach (Curso cursito in alumnoEncontrado.cursos)
                    {
                        textBoxCursos.Text += cursito.Nombre + Environment.NewLine;
                    }
                }
                else
                {
                    MessageBox.Show($"El alumno con el dni {textBoxIngresoDni.Text} no fue encontrado ");
                    textBoxIngresoDni.Text = string.Empty;
                    textBoxIngresoDni.Focus();
                }

            }
            else
            {
                MessageBox.Show("No hay alumnos cargados en el sistema");
                return;
            }

           

        
           



}





}
}


