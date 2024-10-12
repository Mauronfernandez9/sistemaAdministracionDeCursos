namespace repasando
{
    partial class FormCursosDisponibles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursosDisponibles));
            this.labelCursosDisponibles = new System.Windows.Forms.Label();
            this.comboBoxVerCursosDisponibles = new System.Windows.Forms.ComboBox();
            this.labelNombreCursoDisponible = new System.Windows.Forms.Label();
            this.labelDescripcionCursoDisponible = new System.Windows.Forms.Label();
            this.labelCantidadAlumnosDisponibles = new System.Windows.Forms.Label();
            this.labelCantidadmaximaAlumnos = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelFechaDeFinalizacion = new System.Windows.Forms.Label();
            this.textBoxNombreCursoDisponible = new System.Windows.Forms.TextBox();
            this.textBoxDescripCursoDisponible = new System.Windows.Forms.TextBox();
            this.textBoxCantidadCuposDisponibles = new System.Windows.Forms.TextBox();
            this.textBoxCantidadMaxAlumnos = new System.Windows.Forms.TextBox();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaFinaliz = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelCursosDisponibles
            // 
            this.labelCursosDisponibles.AutoSize = true;
            this.labelCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursosDisponibles.Location = new System.Drawing.Point(36, 26);
            this.labelCursosDisponibles.Name = "labelCursosDisponibles";
            this.labelCursosDisponibles.Size = new System.Drawing.Size(188, 24);
            this.labelCursosDisponibles.TabIndex = 0;
            this.labelCursosDisponibles.Text = "Cursos disponibles";
            // 
            // comboBoxVerCursosDisponibles
            // 
            this.comboBoxVerCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVerCursosDisponibles.FormattingEnabled = true;
            this.comboBoxVerCursosDisponibles.Location = new System.Drawing.Point(245, 26);
            this.comboBoxVerCursosDisponibles.Name = "comboBoxVerCursosDisponibles";
            this.comboBoxVerCursosDisponibles.Size = new System.Drawing.Size(245, 24);
            this.comboBoxVerCursosDisponibles.TabIndex = 0;
            this.comboBoxVerCursosDisponibles.SelectedValueChanged += new System.EventHandler(this.comboBoxVerCursosDisponibles_SelectedValueChanged);
            // 
            // labelNombreCursoDisponible
            // 
            this.labelNombreCursoDisponible.AutoSize = true;
            this.labelNombreCursoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreCursoDisponible.Location = new System.Drawing.Point(40, 105);
            this.labelNombreCursoDisponible.Name = "labelNombreCursoDisponible";
            this.labelNombreCursoDisponible.Size = new System.Drawing.Size(101, 17);
            this.labelNombreCursoDisponible.TabIndex = 2;
            this.labelNombreCursoDisponible.Text = "Nombre curso:";
            // 
            // labelDescripcionCursoDisponible
            // 
            this.labelDescripcionCursoDisponible.AutoSize = true;
            this.labelDescripcionCursoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionCursoDisponible.Location = new System.Drawing.Point(40, 188);
            this.labelDescripcionCursoDisponible.Name = "labelDescripcionCursoDisponible";
            this.labelDescripcionCursoDisponible.Size = new System.Drawing.Size(125, 17);
            this.labelDescripcionCursoDisponible.TabIndex = 3;
            this.labelDescripcionCursoDisponible.Text = "Descripción curso:";
            // 
            // labelCantidadAlumnosDisponibles
            // 
            this.labelCantidadAlumnosDisponibles.AutoSize = true;
            this.labelCantidadAlumnosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadAlumnosDisponibles.Location = new System.Drawing.Point(40, 289);
            this.labelCantidadAlumnosDisponibles.Name = "labelCantidadAlumnosDisponibles";
            this.labelCantidadAlumnosDisponibles.Size = new System.Drawing.Size(185, 17);
            this.labelCantidadAlumnosDisponibles.TabIndex = 4;
            this.labelCantidadAlumnosDisponibles.Text = "Cantidad cupos disponibles:";
            // 
            // labelCantidadmaximaAlumnos
            // 
            this.labelCantidadmaximaAlumnos.AutoSize = true;
            this.labelCantidadmaximaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadmaximaAlumnos.Location = new System.Drawing.Point(40, 336);
            this.labelCantidadmaximaAlumnos.Name = "labelCantidadmaximaAlumnos";
            this.labelCantidadmaximaAlumnos.Size = new System.Drawing.Size(196, 17);
            this.labelCantidadmaximaAlumnos.TabIndex = 5;
            this.labelCantidadmaximaAlumnos.Text = "Cantidad Maxima de alumnos:";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(40, 382);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(103, 17);
            this.labelFechaInicio.TabIndex = 6;
            this.labelFechaInicio.Text = "Fecha de Inicio";
            // 
            // labelFechaDeFinalizacion
            // 
            this.labelFechaDeFinalizacion.AutoSize = true;
            this.labelFechaDeFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDeFinalizacion.Location = new System.Drawing.Point(37, 434);
            this.labelFechaDeFinalizacion.Name = "labelFechaDeFinalizacion";
            this.labelFechaDeFinalizacion.Size = new System.Drawing.Size(145, 17);
            this.labelFechaDeFinalizacion.TabIndex = 7;
            this.labelFechaDeFinalizacion.Text = "Fecha de Finalización";
            // 
            // textBoxNombreCursoDisponible
            // 
            this.textBoxNombreCursoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCursoDisponible.Location = new System.Drawing.Point(147, 99);
            this.textBoxNombreCursoDisponible.Name = "textBoxNombreCursoDisponible";
            this.textBoxNombreCursoDisponible.ReadOnly = true;
            this.textBoxNombreCursoDisponible.Size = new System.Drawing.Size(381, 23);
            this.textBoxNombreCursoDisponible.TabIndex = 1;
            // 
            // textBoxDescripCursoDisponible
            // 
            this.textBoxDescripCursoDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripCursoDisponible.Location = new System.Drawing.Point(171, 145);
            this.textBoxDescripCursoDisponible.MaxLength = 400;
            this.textBoxDescripCursoDisponible.Multiline = true;
            this.textBoxDescripCursoDisponible.Name = "textBoxDescripCursoDisponible";
            this.textBoxDescripCursoDisponible.ReadOnly = true;
            this.textBoxDescripCursoDisponible.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripCursoDisponible.Size = new System.Drawing.Size(832, 121);
            this.textBoxDescripCursoDisponible.TabIndex = 2;
            // 
            // textBoxCantidadCuposDisponibles
            // 
            this.textBoxCantidadCuposDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidadCuposDisponibles.Location = new System.Drawing.Point(242, 283);
            this.textBoxCantidadCuposDisponibles.Name = "textBoxCantidadCuposDisponibles";
            this.textBoxCantidadCuposDisponibles.ReadOnly = true;
            this.textBoxCantidadCuposDisponibles.Size = new System.Drawing.Size(57, 23);
            this.textBoxCantidadCuposDisponibles.TabIndex = 3;
            // 
            // textBoxCantidadMaxAlumnos
            // 
            this.textBoxCantidadMaxAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidadMaxAlumnos.Location = new System.Drawing.Point(242, 333);
            this.textBoxCantidadMaxAlumnos.Name = "textBoxCantidadMaxAlumnos";
            this.textBoxCantidadMaxAlumnos.ReadOnly = true;
            this.textBoxCantidadMaxAlumnos.Size = new System.Drawing.Size(60, 23);
            this.textBoxCantidadMaxAlumnos.TabIndex = 4;
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.Enabled = false;
            this.dateTimeFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(188, 382);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(200, 23);
            this.dateTimeFechaInicio.TabIndex = 5;
            // 
            // dateTimeFechaFinaliz
            // 
            this.dateTimeFechaFinaliz.Enabled = false;
            this.dateTimeFechaFinaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaFinaliz.Location = new System.Drawing.Point(188, 428);
            this.dateTimeFechaFinaliz.Name = "dateTimeFechaFinaliz";
            this.dateTimeFechaFinaliz.Size = new System.Drawing.Size(200, 23);
            this.dateTimeFechaFinaliz.TabIndex = 6;
            // 
            // FormCursosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 490);
            this.Controls.Add(this.dateTimeFechaFinaliz);
            this.Controls.Add(this.dateTimeFechaInicio);
            this.Controls.Add(this.textBoxCantidadMaxAlumnos);
            this.Controls.Add(this.textBoxCantidadCuposDisponibles);
            this.Controls.Add(this.textBoxDescripCursoDisponible);
            this.Controls.Add(this.textBoxNombreCursoDisponible);
            this.Controls.Add(this.labelFechaDeFinalizacion);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelCantidadmaximaAlumnos);
            this.Controls.Add(this.labelCantidadAlumnosDisponibles);
            this.Controls.Add(this.labelDescripcionCursoDisponible);
            this.Controls.Add(this.labelNombreCursoDisponible);
            this.Controls.Add(this.comboBoxVerCursosDisponibles);
            this.Controls.Add(this.labelCursosDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 529);
            this.Name = "FormCursosDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCursosDisponibles";
            this.Load += new System.EventHandler(this.FormCursosDisponibles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCursosDisponibles;
        private System.Windows.Forms.ComboBox comboBoxVerCursosDisponibles;
        private System.Windows.Forms.Label labelNombreCursoDisponible;
        private System.Windows.Forms.Label labelDescripcionCursoDisponible;
        private System.Windows.Forms.Label labelCantidadAlumnosDisponibles;
        private System.Windows.Forms.Label labelCantidadmaximaAlumnos;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelFechaDeFinalizacion;
        private System.Windows.Forms.TextBox textBoxNombreCursoDisponible;
        private System.Windows.Forms.TextBox textBoxDescripCursoDisponible;
        private System.Windows.Forms.TextBox textBoxCantidadCuposDisponibles;
        private System.Windows.Forms.TextBox textBoxCantidadMaxAlumnos;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFinaliz;
    }
}