namespace repasando
{
    partial class FormCrearCurso
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearCurso));
            this.labelNuevoCurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescriCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericCantMaxAlumnos = new System.Windows.Forms.NumericUpDown();
            this.dateTimeInicioCurso = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFinCurso = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProviderNameCurso = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescrpCourse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCantAlumnos = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFechaInicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFechaFin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericCantMaxAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescrpCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaFin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNuevoCurso
            // 
            this.labelNuevoCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNuevoCurso.AutoSize = true;
            this.labelNuevoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoCurso.Location = new System.Drawing.Point(353, 28);
            this.labelNuevoCurso.Name = "labelNuevoCurso";
            this.labelNuevoCurso.Size = new System.Drawing.Size(108, 20);
            this.labelNuevoCurso.TabIndex = 0;
            this.labelNuevoCurso.Text = "Nuevo curso";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del curso:";
            // 
            // textBoxNombreCurso
            // 
            this.textBoxNombreCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreCurso.Location = new System.Drawing.Point(178, 90);
            this.textBoxNombreCurso.Name = "textBoxNombreCurso";
            this.textBoxNombreCurso.Size = new System.Drawing.Size(563, 23);
            this.textBoxNombreCurso.TabIndex = 0;
            this.textBoxNombreCurso.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombreCurso_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // textBoxDescriCurso
            // 
            this.textBoxDescriCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescriCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescriCurso.Location = new System.Drawing.Point(124, 155);
            this.textBoxDescriCurso.Name = "textBoxDescriCurso";
            this.textBoxDescriCurso.Size = new System.Drawing.Size(617, 23);
            this.textBoxDescriCurso.TabIndex = 1;
            this.textBoxDescriCurso.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescriCurso_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Inicio:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de finalización:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad maxima de alumnos:";
            // 
            // numericCantMaxAlumnos
            // 
            this.numericCantMaxAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCantMaxAlumnos.Location = new System.Drawing.Point(240, 222);
            this.numericCantMaxAlumnos.Name = "numericCantMaxAlumnos";
            this.numericCantMaxAlumnos.Size = new System.Drawing.Size(57, 23);
            this.numericCantMaxAlumnos.TabIndex = 2;
            this.numericCantMaxAlumnos.Validating += new System.ComponentModel.CancelEventHandler(this.numericCantMaxAlumnos_Validating);
            // 
            // dateTimeInicioCurso
            // 
            this.dateTimeInicioCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInicioCurso.Location = new System.Drawing.Point(144, 291);
            this.dateTimeInicioCurso.Name = "dateTimeInicioCurso";
            this.dateTimeInicioCurso.Size = new System.Drawing.Size(200, 23);
            this.dateTimeInicioCurso.TabIndex = 3;
            this.dateTimeInicioCurso.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeInicioCurso_Validating);
            // 
            // dateTimeFinCurso
            // 
            this.dateTimeFinCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFinCurso.Location = new System.Drawing.Point(541, 291);
            this.dateTimeFinCurso.Name = "dateTimeFinCurso";
            this.dateTimeFinCurso.Size = new System.Drawing.Size(200, 23);
            this.dateTimeFinCurso.TabIndex = 4;
            this.dateTimeFinCurso.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeFinCurso_Validating);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(338, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Curso";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProviderNameCurso
            // 
            this.errorProviderNameCurso.ContainerControl = this;
            // 
            // errorProviderDescrpCourse
            // 
            this.errorProviderDescrpCourse.ContainerControl = this;
            // 
            // errorProviderCantAlumnos
            // 
            this.errorProviderCantAlumnos.ContainerControl = this;
            // 
            // errorProviderFechaInicio
            // 
            this.errorProviderFechaInicio.ContainerControl = this;
            // 
            // errorProviderFechaFin
            // 
            this.errorProviderFechaFin.ContainerControl = this;
            // 
            // FormCrearCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeFinCurso);
            this.Controls.Add(this.dateTimeInicioCurso);
            this.Controls.Add(this.numericCantMaxAlumnos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescriCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNuevoCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 530);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormCrearCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCrearCurso";
            ((System.ComponentModel.ISupportInitialize)(this.numericCantMaxAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescrpCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCantAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFechaFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNuevoCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescriCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericCantMaxAlumnos;
        private System.Windows.Forms.DateTimePicker dateTimeInicioCurso;
        private System.Windows.Forms.DateTimePicker dateTimeFinCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProviderNameCurso;
        private System.Windows.Forms.ErrorProvider errorProviderDescrpCourse;
        private System.Windows.Forms.ErrorProvider errorProviderCantAlumnos;
        private System.Windows.Forms.ErrorProvider errorProviderFechaInicio;
        private System.Windows.Forms.ErrorProvider errorProviderFechaFin;
    }
}