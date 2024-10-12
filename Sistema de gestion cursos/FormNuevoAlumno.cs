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
    public partial class FormNuevoAlumno : Form
    {
        private List<Curso> cursosDisponiblesInscribir;
        public List<Alumno> alumnosDeLainstitucion;

        public FormNuevoAlumno(List<Curso> cursos, List<Alumno> alumnos)
        {
            this.cursosDisponiblesInscribir = cursos;
            this.alumnosDeLainstitucion = alumnos;
            InitializeComponent();

        }






        private void CargarCursos()
        {
            comboBoxCursos.Items.Clear();
            foreach (Curso item in cursosDisponiblesInscribir)
            {
                comboBoxCursos.Items.Add(item.Nombre);
            }
        }

        private void CargarProvincias()
        {
            comboBoxPaisAlumno.Items.Add("Argentina");
            string[] provincias = { "Buenos Aires", "Catamarca", "Chaco", "Cordoba", "Corrientes", "Entre Rios", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquen", "Rio Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucuman" };
            comboBoxProvinciaAlumno.Items.AddRange(provincias);
        }

        private void CargarNacionalidad()
        {
            string[] nacionalidad = { "Argentina", "Brasileña", "Boliviana", "Chilena", "Colombiana", "Paraguaya", "Peruana", "Venezolana", "Uruguaya", "Otros" };
            textBoxNacionalidadAlumno.Items.AddRange(nacionalidad);
        }


        private void FormNuevoAlumno_Load(object sender, EventArgs e)
        {
            CargarProvincias();
            CargarCursos();
            CargarNacionalidad();
        }

        private int validarCampos()
        {
            List<TextBox> camposText = new List<TextBox>() { textBoxCalleAlumno, textBoxBarrioAlumno, textBoxApellidoAlumno, textBoxCiudadAlumno, textBoxDniAlumno, textBoxNombreAlumno, textBoxNroCalleAlumno };
            List<ComboBox> camposBox = new List<ComboBox>() { comboBoxCursos, comboBoxPaisAlumno, comboBoxProvinciaAlumno, textBoxNacionalidadAlumno };


            int errores = 0;
            foreach (var item in camposText)
            {
                if (item.Text.Length == 0)
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                    errores++;

                }
                else
                {
                    item.BackColor = SystemColors.Window;
                    item.ForeColor = SystemColors.WindowText;
                }
            }

            if (comboBoxCursos.Text.Length == 0)
            {
                errorProviderCurso.SetError(comboBoxCursos, "Selecciona un curso");
                errores++;
            }
            else
            {
                errorProviderCurso.SetError(comboBoxCursos, string.Empty);
            }

            if (comboBoxPaisAlumno.Text.Length == 0)
            {
                errorProviderPais.SetError(comboBoxPaisAlumno, "Selecciona un pais");
                errores++;
            }
            else
            {
                errorProviderPais.SetError(comboBoxPaisAlumno, string.Empty);
            }

            if (comboBoxProvinciaAlumno.Text.Length == 0)
            {
                errorProviderProvincia.SetError(comboBoxProvinciaAlumno, "Selecciona una provincia");
                errores++;
            }
            else
            {
                errorProviderProvincia.SetError(comboBoxProvinciaAlumno, string.Empty);
            }

            if (textBoxNacionalidadAlumno.Text.Length == 0)
            {
                errorProviderNacionalidad.SetError(textBoxNacionalidadAlumno, "Selecciona una nacionalidad");
                errores++;
            }
            else
            {
                errorProviderNacionalidad.SetError(textBoxNacionalidadAlumno, string.Empty);
            }

            if (dateTimeAlumno.Value.Date == DateTime.Now.Date)
            {
                errorProviderDatTime.SetError(dateTimeAlumno, "Selecciona una fecha");
                errores++;
            }
            else
            {
                errorProviderDatTime.SetError(dateTimeAlumno, string.Empty);
            }

            return errores;


        }


        private void botonCargarNuevoAlumno_Click(object sender, EventArgs e)
        {

            int respuesta = validarCampos();
            if (respuesta == 0)
            {
                string apellido = textBoxApellidoAlumno.Text;
                string nombre = textBoxNombreAlumno.Text;
                string dni = textBoxDniAlumno.Text;
                string nacionalidad = textBoxNacionalidadAlumno.Text;
                DateTime fechaNacimiento = dateTimeAlumno.Value;
                string pais = comboBoxPaisAlumno.Text;
                string provincia = comboBoxProvinciaAlumno.Text;
                string ciudad = textBoxCiudadAlumno.Text;
                string calle = textBoxCalleAlumno.Text;
                int numeroCalle = int.Parse(textBoxNroCalleAlumno.Text);
                string curso = comboBoxCursos.Text;
                string barrio = textBoxBarrioAlumno.Text;


                Alumno nuevoAlumno = new Alumno(nombre, apellido, dni, nacionalidad, fechaNacimiento);
                Direccion nuevaDireccion = new Direccion(pais, provincia, ciudad, calle, numeroCalle, barrio);
                nuevoAlumno.Direccion = nuevaDireccion;

                cursosDisponiblesInscribir.Find(curs => curs.Nombre == curso).InscribirEstudiante(nuevoAlumno);
                alumnosDeLainstitucion.Add(nuevoAlumno);

                MessageBox.Show("Alumno cargado!");
                textBoxApellidoAlumno.Text = string.Empty;
                textBoxNombreAlumno.Text = string.Empty;
                textBoxDniAlumno.Text = string.Empty;
                textBoxNacionalidadAlumno.Text = string.Empty;
                dateTimeAlumno.Value = DateTime.Now;
                comboBoxPaisAlumno.SelectedIndex = -1;
                comboBoxProvinciaAlumno.SelectedIndex = -1;
                textBoxCiudadAlumno.Text = string.Empty;
                textBoxCalleAlumno.Text = string.Empty;
                textBoxNroCalleAlumno.Text = string.Empty;
                comboBoxCursos.SelectedIndex = -1;
                textBoxBarrioAlumno.Text = string.Empty;
                comboBoxCursos.SelectedIndex = -1;
                return;
            }
            MessageBox.Show("Revisa los campos para cargar el nuevo alumno correctamente!", "ERROR");

        }

        private void textBoxApellidoAlumno_Validating(object sender, CancelEventArgs e)
        {

            if (!campoLengthValido(textBoxApellidoAlumno.Text))
            {
                errorProviderApellido.SetError(textBoxApellidoAlumno, "El campo esta vacío");
                e.Cancel = true;
            }
            else if (ContieneNumerosOSignos(textBoxApellidoAlumno.Text))
            {
                errorProviderApellido.SetError(textBoxApellidoAlumno, "No puede contener números o caracteres especiales...");
                e.Cancel = true;
            }
            else
            {
                errorProviderApellido.SetError(textBoxApellidoAlumno, string.Empty);
                e.Cancel = false;
            }
        }

















        public bool campoLengthValido(string text)
        {
            if (text.Length > 0)
            {
                return true;
            }
            return false;


        }
        public bool ContieneNumerosOSignos(string textoAnalizar)
        {
            string[] valoresNoPermitidos = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "!", "#", "$", "%", "&", "/", "(", ")", "=", "-", "_", "@", "*", ",", ".", "?", "¿", "¡", "+", "{", "}", "[", "]" };
            foreach (char item in textoAnalizar)
            {

                if (valoresNoPermitidos.Contains(item.ToString()))
                {
                    return true;

                }

            }
            return false;
        }

        public bool ContieneLetrasOSignos(string textoAnalizar)
        {
            string[] valoresNoPermitidos = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "u", "v", "w", "x", "y", "z", "!", "$", "#", "%", "&", "/", "(", ")", "=", "?", "¿", "+", "{", "}", "[", "]", "-", "_", ";", ":" };

            foreach (char item in textoAnalizar)
            {
                if (valoresNoPermitidos.Contains(item.ToString()))
                    return true;
            }
            return false;
        }

        private void textBoxNombreAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (!campoLengthValido(textBoxNombreAlumno.Text))
            {
                errorProviderNames.SetError(textBoxNombreAlumno, "El campo esta vacío");

                e.Cancel = true;
            }
            else if (ContieneNumerosOSignos(textBoxNombreAlumno.Text))
            {
                errorProviderNames.SetError(textBoxNombreAlumno, "Este campo no puede contener números y/o signos especiales");

                e.Cancel = true;

            }
            else
            {
                errorProviderNames.SetError(textBoxNombreAlumno, string.Empty);

                e.Cancel = false;
            }
        }

        private void textBoxDniAlumno_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDniAlumno.Text.Length > 2 && textBoxDniAlumno.Text[2] != '.')
            {
                textBoxDniAlumno.Text = textBoxDniAlumno.Text.Insert(2, ".");
                textBoxDniAlumno.SelectionStart = textBoxDniAlumno.Text.Length;

            }
            if (textBoxDniAlumno.TextLength > 6 && textBoxDniAlumno.Text[6] != '.')
            {
                textBoxDniAlumno.Text = textBoxDniAlumno.Text.Insert(6, ".");
                textBoxDniAlumno.SelectionStart = textBoxDniAlumno.Text.Length;
            }
        }

        private void textBoxDniAlumno_Validating(object sender, CancelEventArgs e)
        {



            if (textBoxDniAlumno.Text.Length == 0)
            {

                errorProviderDni.SetError(textBoxDniAlumno, "El campo esta vacío");
            }
            else if (ContieneLetrasOSignos(textBoxDniAlumno.Text))
            {
                errorProviderDni.SetError(textBoxDniAlumno, "Ingresa un NÚMERO de dni correcto");

                e.Cancel = true;

            }

            else
            {
                errorProviderDni.SetError(textBoxDniAlumno, string.Empty);

                e.Cancel = false;
            }
        }

        private void dateTimeAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimeAlumno.Value >= DateTime.Now.Date)
            {
                errorProviderDatTime.SetError(dateTimeAlumno, "Ingrese una fecha correcta!");

                e.Cancel = true;
            }
            else
            {
                errorProviderDatTime.SetError(dateTimeAlumno, string.Empty);

                e.Cancel = false;
            }
        }

        private void comboBoxPaisAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxPaisAlumno.Text == "")
            {
                errorProviderPais.SetError(comboBoxPaisAlumno, "Selecciona un país...");

                e.Cancel = true;
            }
            else
            {
                errorProviderPais.SetError(comboBoxPaisAlumno, string.Empty);

                e.Cancel = false;
            }
        }

        private void comboBoxProvinciaAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxProvinciaAlumno.Text == "")
            {
                errorProviderProvincia.SetError(comboBoxProvinciaAlumno, "Selecciona una provincia...");

                e.Cancel = true;
            }
            else
            {
                errorProviderProvincia.SetError(comboBoxProvinciaAlumno, string.Empty);

                e.Cancel = false;
            }

        }

        private void textBoxCiudadAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCiudadAlumno.Text.Length == 0)
            {
                errorProviderCiudad.SetError(textBoxCiudadAlumno, "Escribe una ciudad");

                e.Cancel = true;
            }
            else
            {
                errorProviderCiudad.SetError(textBoxCiudadAlumno, string.Empty);

                e.Cancel = false;
            }

        }







        private void textBoxBarrioAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxBarrioAlumno.Text == "")
            {
                errorProviderBarrio.SetError(textBoxBarrioAlumno, "Este campo esta vacío...");

                e.Cancel = true;
            }
            else
            {
                errorProviderBarrio.SetError(textBoxBarrioAlumno, string.Empty);

                e.Cancel = false;
            }

        }

        private void textBoxCalleAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCalleAlumno.Text == "")
            {
                errorProviderCalle.SetError(textBoxCalleAlumno, "Este campo esta vacío...");

                e.Cancel = true;
            }
            else
            {
                errorProviderCalle.SetError(textBoxCalleAlumno, string.Empty);

                e.Cancel = false;
            }

        }

        private void comboBoxCursos_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxCursos.Text == "")
            {
                errorProviderCurso.SetError(comboBoxCursos, "Selecciona un curso...");

                e.Cancel = true;
            }
            else
            {
                errorProviderCurso.SetError(comboBoxCursos, string.Empty);

                e.Cancel = false;
            }

        }

        private void textBoxNroCalleAlumno_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNroCalleAlumno.Text.Length == 0)
            {
                errorProviderNroCalle.SetError(textBoxNroCalleAlumno, "Este campo no puede estar vacío");

                e.Cancel = true;
            }
            else if (ContieneLetrasOSignos(textBoxNroCalleAlumno.Text))
            {
                errorProviderNroCalle.SetError(textBoxNroCalleAlumno, "Ingresa un NÚMERO de calle");

                e.Cancel = true;
            }
            else
            {
                errorProviderNroCalle.SetError(textBoxNroCalleAlumno, string.Empty);

                e.Cancel = false;
            }
        }

        private void textBoxDniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxNroCalleAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


    }
}

