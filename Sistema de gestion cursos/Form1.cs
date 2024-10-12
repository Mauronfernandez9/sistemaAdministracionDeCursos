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
    public partial class Form1 : Form
    {

        private List<Curso> cursosDisponibles = new List<Curso>();

        private List<Alumno> alumnosInstitucion = new List<Alumno>();

        public void cargarAlumnos()
        {
            foreach (Curso cadaCurso in cursosDisponibles)
            {
                foreach(Alumno cadaAlumno in cadaCurso.alumnos)
                {
                    alumnosInstitucion.Add(cadaAlumno);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            InicializarCursos();
            cargarAlumnos();
        }

        private void InicializarCursos()
        {
            cursosDisponibles.Add(cursoBarberiaMañana);
            cursosDisponibles.Add(cursoBarberiaTarde);
            cursosDisponibles.Add(cursoBarberiaNoche);
            cursosDisponibles.Add(cursoCarpinteroMañana);
            cursosDisponibles.Add(cursoCarpinteroTarde);
            cursosDisponibles.Add(cursoCarpinteroNoche);
            cursosDisponibles.Add(cursoDiseñoGraficoMañana);
            cursosDisponibles.Add(cursoDiseñoGraficoTarde);
            cursosDisponibles.Add(cursoDiseñoGraficoNoche);
            cursosDisponibles.Add(cursoChefMañana);
            cursosDisponibles.Add(cursoChefTarde);
            cursosDisponibles.Add(cursoChefNoche);

        }

        Curso cursoBarberiaMañana = new Curso("Curso de Barbero Profesional - Mañana", "En nuestro curso de barbería, aprenderás el arte de crear cortes impecables y estilos personalizados. Con técnicas modernas y atención al detalle, te formarás en el uso de herramientas profesionales, cuidado del cabello y barba, y en brindar una experiencia única a cada cliente. ¡Conviértete en un barbero experto y lleva tu pasión por el estilo a un nuevo nivel!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoBarberiaTarde = new Curso("Curso de Barbero Profesional - Tarde", "En nuestro curso de barbería, aprenderás el arte de crear cortes impecables y estilos personalizados. Con técnicas modernas y atención al detalle, te formarás en el uso de herramientas profesionales, cuidado del cabello y barba, y en brindar una experiencia única a cada cliente. ¡Conviértete en un barbero experto y lleva tu pasión por el estilo a un nuevo nivel!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoBarberiaNoche = new Curso("Curso de Barbero Profesional - Noche", "En nuestro curso de barbería, aprenderás el arte de crear cortes impecables y estilos personalizados. Con técnicas modernas y atención al detalle, te formarás en el uso de herramientas profesionales, cuidado del cabello y barba, y en brindar una experiencia única a cada cliente. ¡Conviértete en un barbero experto y lleva tu pasión por el estilo a un nuevo nivel!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);

        Curso cursoCarpinteroMañana = new Curso("Curso de Carpinteria - Mañana", "En nuestro curso de carpintería, descubrirás el oficio de trabajar con madera, creando muebles y piezas únicas con tus propias manos. Aprenderás técnicas de corte, ensamblaje, acabados y el uso de herramientas profesionales, todo mientras desarrollas tu creatividad y precisión. ¡Conviértete en un experto carpintero y transforma ideas en obras maestras!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoCarpinteroTarde = new Curso("Curso de Carpinteria - Tarde", "En nuestro curso de carpintería, descubrirás el oficio de trabajar con madera, creando muebles y piezas únicas con tus propias manos. Aprenderás técnicas de corte, ensamblaje, acabados y el uso de herramientas profesionales, todo mientras desarrollas tu creatividad y precisión. ¡Conviértete en un experto carpintero y transforma ideas en obras maestras!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoCarpinteroNoche = new Curso("Curso de Carpinteria - Noche", "En nuestro curso de carpintería, descubrirás el oficio de trabajar con madera, creando muebles y piezas únicas con tus propias manos. Aprenderás técnicas de corte, ensamblaje, acabados y el uso de herramientas profesionales, todo mientras desarrollas tu creatividad y precisión. ¡Conviértete en un experto carpintero y transforma ideas en obras maestras!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);

        Curso cursoDiseñoGraficoMañana = new Curso("Curso de Diseño Grafico - Mañana", "En nuestro curso de diseño gráfico, explorarás el mundo visual y aprenderás a transformar ideas en impresionantes piezas creativas. Conocerás el uso de herramientas digitales, teoría del color, tipografía y composición para crear diseños impactantes y funcionales. ¡Desata tu imaginación y conviértete en un diseñador gráfico profesional capaz de comunicar visualmente con estilo y originalidad!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoDiseñoGraficoTarde = new Curso("Curso de Diseño Grafico - Tarde", "En nuestro curso de diseño gráfico, explorarás el mundo visual y aprenderás a transformar ideas en impresionantes piezas creativas. Conocerás el uso de herramientas digitales, teoría del color, tipografía y composición para crear diseños impactantes y funcionales. ¡Desata tu imaginación y conviértete en un diseñador gráfico profesional capaz de comunicar visualmente con estilo y originalidad!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoDiseñoGraficoNoche = new Curso("Curso de Diseño Grafico - Noche", "En nuestro curso de diseño gráfico, explorarás el mundo visual y aprenderás a transformar ideas en impresionantes piezas creativas. Conocerás el uso de herramientas digitales, teoría del color, tipografía y composición para crear diseños impactantes y funcionales. ¡Desata tu imaginación y conviértete en un diseñador gráfico profesional capaz de comunicar visualmente con estilo y originalidad!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);



        Curso cursoChefMañana = new Curso("Curso de cocina - Mañana", "En nuestro curso de chef, te sumergirás en el apasionante mundo de la gastronomía, donde aprenderás técnicas culinarias, manejo de ingredientes frescos y presentación de platos excepcionales. Desde la cocina tradicional hasta la innovación moderna, desarrollarás tus habilidades para crear experiencias gastronómicas inolvidables. ¡Conviértete en un chef profesional y lleva tu pasión por la cocina al siguiente nivel!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoChefTarde = new Curso("Curso de cocina - Tarde", "En nuestro curso de chef, te sumergirás en el apasionante mundo de la gastronomía, donde aprenderás técnicas culinarias, manejo de ingredientes frescos y presentación de platos excepcionales. Desde la cocina tradicional hasta la innovación moderna, desarrollarás tus habilidades para crear experiencias gastronómicas inolvidables. ¡Conviértete en un chef profesional y lleva tu pasión por la cocina al siguiente nivel!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);
        Curso cursoChefNoche = new Curso("Curso de cocina - Noche", "En nuestro curso de chef, te sumergirás en el apasionante mundo de la gastronomía, donde aprenderás técnicas culinarias, manejo de ingredientes frescos y presentación de platos excepcionales. Desde la cocina tradicional hasta la innovación moderna, desarrollarás tus habilidades para crear experiencias gastronómicas inolvidables. ¡Conviértete en un chef profesional y lleva tu pasión por la cocina al siguiente nivel!", new DateTime(2024, 11, 15), new DateTime(2025, 2, 1), 25);





        private void Form1_Load(object sender, EventArgs e)
        {
            toolStatusLabelFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");


        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormNuevoAlumno))
                {
                    MessageBox.Show("Ya existe una ventana abierta!");
                    return;
                }
            }

            FormNuevoAlumno ventanaCrearAlumno = new FormNuevoAlumno(cursosDisponibles,alumnosInstitucion);
            ventanaCrearAlumno.Show();
        }

        private void verCursosDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormCursosDisponibles))
                {
                    MessageBox.Show("Ya existe una ventana abierta...");
                    return;
                }
            }
            FormCursosDisponibles ventanaCursosDisponibles = new FormCursosDisponibles(cursosDisponibles);
            ventanaCursosDisponibles.Show();

        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //foreach (var item in Application.OpenForms)
            //{
            //    if (item.GetType() == typeof(FormCrearCurso))
            //    {
            //        MessageBox.Show("La ventana ya se encuentra abierta...");
            //        return;
            //    }
            //}

            FormCrearCurso ventanaCrearCurso = new FormCrearCurso(cursosDisponibles);
            ventanaCrearCurso.ShowDialog();
        }

        private void toolStripButtonNuevoAlumno_Click(object sender, EventArgs e)
        {
            //foreach (var item in Application.OpenForms)
            //{
            //    if (item.GetType() == typeof(FormNuevoAlumno))
            //    {
            //        MessageBox.Show("La ventana ya se encuentra abierta...");
            //        return;
            //    }
            //}

            FormNuevoAlumno ventanaCrearAlumno = new FormNuevoAlumno(cursosDisponibles,alumnosInstitucion);
            ventanaCrearAlumno.ShowDialog();
        }

        private void toolStripButtonNuevoCurso_Click(object sender, EventArgs e)
        {
            //foreach (var item in Application.OpenForms)
            //{
            //    if (item.GetType() == typeof(FormCrearCurso))
            //    {
            //        MessageBox.Show("La ventana ya se encuentra abierta...");
            //        return;
            //    }
            //}

            FormCrearCurso ventanaCrearCurso = new FormCrearCurso(cursosDisponibles);
            ventanaCrearCurso.ShowDialog();
        }

        private void toolStripButtonVerCursosDis_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormCursosDisponibles))
                {
                    MessageBox.Show("La ventana ya se encuentra abierta...");
                    return;
                }
            }

            FormCursosDisponibles ventanaCursosDisponibles = new FormCursosDisponibles(cursosDisponibles);
            ventanaCursosDisponibles.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres salir?","Aviso",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Gracias por usar el programa. Hasta pronto!");
            }
        }

        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(FormVerUsuario))
                {
                    MessageBox.Show("La ventana ya esta abierta!");
                    return;
                }
            }

            FormVerUsuario ventanaVerUsuarios = new FormVerUsuario(alumnosInstitucion);
            ventanaVerUsuarios.Show();

        }
    }
}
