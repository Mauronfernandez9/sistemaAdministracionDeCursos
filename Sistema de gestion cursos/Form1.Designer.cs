namespace repasando
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCursosDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStatusLabelFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNuevoAlumno = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNuevoCurso = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVerCursosDis = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.editToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editToolStripMenuItem.CheckOnClick = true;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.cursosToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.alumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAlumnoToolStripMenuItem,
            this.buscarAlumnoToolStripMenuItem});
            this.alumnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            this.nuevoAlumnoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.nuevoAlumnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            this.nuevoAlumnoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.nuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.nuevoAlumnoToolStripMenuItem.Text = "Nuevo alumno";
            this.nuevoAlumnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlumnoToolStripMenuItem_Click);
            // 
            // buscarAlumnoToolStripMenuItem
            // 
            this.buscarAlumnoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.buscarAlumnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buscarAlumnoToolStripMenuItem.Name = "buscarAlumnoToolStripMenuItem";
            this.buscarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.buscarAlumnoToolStripMenuItem.Text = "Ver alumno";
            this.buscarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.buscarAlumnoToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDocenteToolStripMenuItem,
            this.verDocenteToolStripMenuItem});
            this.docenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // nuevoDocenteToolStripMenuItem
            // 
            this.nuevoDocenteToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.nuevoDocenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nuevoDocenteToolStripMenuItem.Name = "nuevoDocenteToolStripMenuItem";
            this.nuevoDocenteToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.nuevoDocenteToolStripMenuItem.Text = "Nuevo docente";
            // 
            // verDocenteToolStripMenuItem
            // 
            this.verDocenteToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.verDocenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verDocenteToolStripMenuItem.Name = "verDocenteToolStripMenuItem";
            this.verDocenteToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.verDocenteToolStripMenuItem.Text = "Ver docente";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCursoToolStripMenuItem,
            this.verCursosDisponiblesToolStripMenuItem});
            this.cursosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // nuevoCursoToolStripMenuItem
            // 
            this.nuevoCursoToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.nuevoCursoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nuevoCursoToolStripMenuItem.Name = "nuevoCursoToolStripMenuItem";
            this.nuevoCursoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.nuevoCursoToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.nuevoCursoToolStripMenuItem.Text = "Nuevo curso";
            this.nuevoCursoToolStripMenuItem.Click += new System.EventHandler(this.nuevoCursoToolStripMenuItem_Click);
            // 
            // verCursosDisponiblesToolStripMenuItem
            // 
            this.verCursosDisponiblesToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.verCursosDisponiblesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.verCursosDisponiblesToolStripMenuItem.Name = "verCursosDisponiblesToolStripMenuItem";
            this.verCursosDisponiblesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.verCursosDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.verCursosDisponiblesToolStripMenuItem.Text = "Ver cursos disponibles";
            this.verCursosDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.verCursosDisponiblesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.fAQToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStatusLabelFecha,
            this.toolStripStatusLabel1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 5);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStatusLabelFecha
            // 
            this.toolStatusLabelFecha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStatusLabelFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStatusLabelFecha.Name = "toolStatusLabelFecha";
            this.toolStatusLabelFecha.Size = new System.Drawing.Size(0, 0);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 0);
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBienvenida.AutoSize = true;
            this.labelBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.labelBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.ForeColor = System.Drawing.Color.Transparent;
            this.labelBienvenida.Location = new System.Drawing.Point(176, 256);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(541, 39);
            this.labelBienvenida.TabIndex = 2;
            this.labelBienvenida.Text = "Bienvenido a la Gestión de Cursos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNuevoAlumno,
            this.toolStripSeparator3,
            this.toolStripButtonNuevoCurso,
            this.toolStripButtonVerCursosDis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(836, 35);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNuevoAlumno
            // 
            this.toolStripButtonNuevoAlumno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNuevoAlumno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripButtonNuevoAlumno.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNuevoAlumno.Image")));
            this.toolStripButtonNuevoAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevoAlumno.Name = "toolStripButtonNuevoAlumno";
            this.toolStripButtonNuevoAlumno.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonNuevoAlumno.Text = "toolStripButton1";
            this.toolStripButtonNuevoAlumno.ToolTipText = "Nuevo alumno";
            this.toolStripButtonNuevoAlumno.Click += new System.EventHandler(this.toolStripButtonNuevoAlumno_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButtonNuevoCurso
            // 
            this.toolStripButtonNuevoCurso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNuevoCurso.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNuevoCurso.Image")));
            this.toolStripButtonNuevoCurso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevoCurso.Name = "toolStripButtonNuevoCurso";
            this.toolStripButtonNuevoCurso.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonNuevoCurso.Text = "toolStripButton2";
            this.toolStripButtonNuevoCurso.ToolTipText = "Nuevo curso";
            this.toolStripButtonNuevoCurso.Click += new System.EventHandler(this.toolStripButtonNuevoCurso_Click);
            // 
            // toolStripButtonVerCursosDis
            // 
            this.toolStripButtonVerCursosDis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVerCursosDis.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVerCursosDis.Image")));
            this.toolStripButtonVerCursosDis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVerCursosDis.Name = "toolStripButtonVerCursosDis";
            this.toolStripButtonVerCursosDis.Size = new System.Drawing.Size(32, 32);
            this.toolStripButtonVerCursosDis.Text = "toolStripButton3";
            this.toolStripButtonVerCursosDis.ToolTipText = "Ver cursos";
            this.toolStripButtonVerCursosDis.Click += new System.EventHandler(this.toolStripButtonVerCursosDis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(836, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCursosDisponiblesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusLabelFecha;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevoCurso;
        private System.Windows.Forms.ToolStripButton toolStripButtonVerCursosDis;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevoAlumno;
    }
}

