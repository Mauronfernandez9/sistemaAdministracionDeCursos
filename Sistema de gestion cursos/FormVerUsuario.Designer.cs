namespace repasando
{
    partial class FormVerUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIngresoDni = new System.Windows.Forms.TextBox();
            this.botonBuscarAlumno = new System.Windows.Forms.Button();
            this.textBoxNombreEncontrado = new System.Windows.Forms.TextBox();
            this.textBoxApellidoEncontrado = new System.Windows.Forms.TextBox();
            this.textBoxNacionalidadEncontrada = new System.Windows.Forms.TextBox();
            this.textBoxPaisEncontrado = new System.Windows.Forms.TextBox();
            this.textBoxProvincEntonctrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFechaNacimientoEncontraa = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCiudadEncontrada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBarrioEncontrado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCalleEncontrada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNumeroCalleEncontrada = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCursos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI DEL ALUMNO:";
            // 
            // textBoxIngresoDni
            // 
            this.textBoxIngresoDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngresoDni.Location = new System.Drawing.Point(222, 53);
            this.textBoxIngresoDni.MaxLength = 11;
            this.textBoxIngresoDni.Name = "textBoxIngresoDni";
            this.textBoxIngresoDni.Size = new System.Drawing.Size(341, 23);
            this.textBoxIngresoDni.TabIndex = 1;
            this.textBoxIngresoDni.TextChanged += new System.EventHandler(this.textBoxIngresoDni_TextChanged);
            this.textBoxIngresoDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // botonBuscarAlumno
            // 
            this.botonBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarAlumno.Location = new System.Drawing.Point(578, 49);
            this.botonBuscarAlumno.Name = "botonBuscarAlumno";
            this.botonBuscarAlumno.Size = new System.Drawing.Size(92, 30);
            this.botonBuscarAlumno.TabIndex = 2;
            this.botonBuscarAlumno.Text = "Buscar";
            this.botonBuscarAlumno.UseVisualStyleBackColor = true;
            this.botonBuscarAlumno.Click += new System.EventHandler(this.botonBuscarAlumno_Click);
            // 
            // textBoxNombreEncontrado
            // 
            this.textBoxNombreEncontrado.Enabled = false;
            this.textBoxNombreEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEncontrado.Location = new System.Drawing.Point(118, 139);
            this.textBoxNombreEncontrado.Name = "textBoxNombreEncontrado";
            this.textBoxNombreEncontrado.Size = new System.Drawing.Size(320, 26);
            this.textBoxNombreEncontrado.TabIndex = 3;
            // 
            // textBoxApellidoEncontrado
            // 
            this.textBoxApellidoEncontrado.Enabled = false;
            this.textBoxApellidoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoEncontrado.Location = new System.Drawing.Point(533, 140);
            this.textBoxApellidoEncontrado.Name = "textBoxApellidoEncontrado";
            this.textBoxApellidoEncontrado.Size = new System.Drawing.Size(392, 26);
            this.textBoxApellidoEncontrado.TabIndex = 4;
            // 
            // textBoxNacionalidadEncontrada
            // 
            this.textBoxNacionalidadEncontrada.Enabled = false;
            this.textBoxNacionalidadEncontrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNacionalidadEncontrada.Location = new System.Drawing.Point(616, 217);
            this.textBoxNacionalidadEncontrada.Name = "textBoxNacionalidadEncontrada";
            this.textBoxNacionalidadEncontrada.Size = new System.Drawing.Size(309, 26);
            this.textBoxNacionalidadEncontrada.TabIndex = 6;
            // 
            // textBoxPaisEncontrado
            // 
            this.textBoxPaisEncontrado.Enabled = false;
            this.textBoxPaisEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaisEncontrado.Location = new System.Drawing.Point(83, 308);
            this.textBoxPaisEncontrado.Name = "textBoxPaisEncontrado";
            this.textBoxPaisEncontrado.Size = new System.Drawing.Size(161, 26);
            this.textBoxPaisEncontrado.TabIndex = 7;
            // 
            // textBoxProvincEntonctrada
            // 
            this.textBoxProvincEntonctrada.Enabled = false;
            this.textBoxProvincEntonctrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProvincEntonctrada.Location = new System.Drawing.Point(347, 308);
            this.textBoxProvincEntonctrada.Name = "textBoxProvincEntonctrada";
            this.textBoxProvincEntonctrada.Size = new System.Drawing.Size(234, 26);
            this.textBoxProvincEntonctrada.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "APELLIDO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "FECHA DE NACIMIENTO:";
            // 
            // dateTimeFechaNacimientoEncontraa
            // 
            this.dateTimeFechaNacimientoEncontraa.Enabled = false;
            this.dateTimeFechaNacimientoEncontraa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaNacimientoEncontraa.Location = new System.Drawing.Point(218, 216);
            this.dateTimeFechaNacimientoEncontraa.Name = "dateTimeFechaNacimientoEncontraa";
            this.dateTimeFechaNacimientoEncontraa.Size = new System.Drawing.Size(251, 23);
            this.dateTimeFechaNacimientoEncontraa.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "NACIONALIDAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "PAÍS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "PROVINCIA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(587, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "CIUDAD:";
            // 
            // textBoxCiudadEncontrada
            // 
            this.textBoxCiudadEncontrada.Enabled = false;
            this.textBoxCiudadEncontrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiudadEncontrada.Location = new System.Drawing.Point(661, 308);
            this.textBoxCiudadEncontrada.Name = "textBoxCiudadEncontrada";
            this.textBoxCiudadEncontrada.Size = new System.Drawing.Size(264, 26);
            this.textBoxCiudadEncontrada.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "BARRIO:";
            // 
            // textBoxBarrioEncontrado
            // 
            this.textBoxBarrioEncontrado.Enabled = false;
            this.textBoxBarrioEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarrioEncontrado.Location = new System.Drawing.Point(107, 391);
            this.textBoxBarrioEncontrado.Name = "textBoxBarrioEncontrado";
            this.textBoxBarrioEncontrado.Size = new System.Drawing.Size(331, 26);
            this.textBoxBarrioEncontrado.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "CALLE:";
            // 
            // textBoxCalleEncontrada
            // 
            this.textBoxCalleEncontrada.Enabled = false;
            this.textBoxCalleEncontrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalleEncontrada.Location = new System.Drawing.Point(524, 391);
            this.textBoxCalleEncontrada.Name = "textBoxCalleEncontrada";
            this.textBoxCalleEncontrada.Size = new System.Drawing.Size(296, 26);
            this.textBoxCalleEncontrada.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(826, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "N°:";
            // 
            // textBoxNumeroCalleEncontrada
            // 
            this.textBoxNumeroCalleEncontrada.Enabled = false;
            this.textBoxNumeroCalleEncontrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroCalleEncontrada.Location = new System.Drawing.Point(861, 390);
            this.textBoxNumeroCalleEncontrada.Name = "textBoxNumeroCalleEncontrada";
            this.textBoxNumeroCalleEncontrada.Size = new System.Drawing.Size(64, 26);
            this.textBoxNumeroCalleEncontrada.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 552);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "CURSOS:";
            // 
            // textBoxCursos
            // 
            this.textBoxCursos.Enabled = false;
            this.textBoxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCursos.Location = new System.Drawing.Point(138, 484);
            this.textBoxCursos.Multiline = true;
            this.textBoxCursos.Name = "textBoxCursos";
            this.textBoxCursos.Size = new System.Drawing.Size(787, 158);
            this.textBoxCursos.TabIndex = 25;
            // 
            // FormVerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 666);
            this.Controls.Add(this.textBoxCursos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxNumeroCalleEncontrada);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxCalleEncontrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxBarrioEncontrado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCiudadEncontrada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeFechaNacimientoEncontraa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProvincEntonctrada);
            this.Controls.Add(this.textBoxPaisEncontrado);
            this.Controls.Add(this.textBoxNacionalidadEncontrada);
            this.Controls.Add(this.textBoxApellidoEncontrado);
            this.Controls.Add(this.textBoxNombreEncontrado);
            this.Controls.Add(this.botonBuscarAlumno);
            this.Controls.Add(this.textBoxIngresoDni);
            this.Controls.Add(this.label1);
            this.Name = "FormVerUsuario";
            this.Text = "FormVerUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIngresoDni;
        private System.Windows.Forms.Button botonBuscarAlumno;
        private System.Windows.Forms.TextBox textBoxNombreEncontrado;
        private System.Windows.Forms.TextBox textBoxApellidoEncontrado;
        private System.Windows.Forms.TextBox textBoxNacionalidadEncontrada;
        private System.Windows.Forms.TextBox textBoxPaisEncontrado;
        private System.Windows.Forms.TextBox textBoxProvincEntonctrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimientoEncontraa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCiudadEncontrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBarrioEncontrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCalleEncontrada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNumeroCalleEncontrada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCursos;
    }
}