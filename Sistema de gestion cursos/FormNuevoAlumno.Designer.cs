namespace repasando
{
    partial class FormNuevoAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoAlumno));
            this.labelAlumnoNuevo = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellidoAlumno = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombreAlumno = new System.Windows.Forms.TextBox();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.dateTimeAlumno = new System.Windows.Forms.DateTimePicker();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDniAlumno = new System.Windows.Forms.TextBox();
            this.labelNacionalidad = new System.Windows.Forms.Label();
            this.labelNombreDelCurso = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelBarrio = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelNumeroCalle = new System.Windows.Forms.Label();
            this.textBoxCiudadAlumno = new System.Windows.Forms.TextBox();
            this.textBoxBarrioAlumno = new System.Windows.Forms.TextBox();
            this.textBoxCalleAlumno = new System.Windows.Forms.TextBox();
            this.textBoxNroCalleAlumno = new System.Windows.Forms.TextBox();
            this.comboBoxPaisAlumno = new System.Windows.Forms.ComboBox();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.botonCargarNuevoAlumno = new System.Windows.Forms.Button();
            this.comboBoxProvinciaAlumno = new System.Windows.Forms.ComboBox();
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNames = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNacionalidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDatTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPais = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProvincia = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBarrio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCalle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNroCalle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCurso = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxNacionalidadAlumno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNacionalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNroCalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlumnoNuevo
            // 
            this.labelAlumnoNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAlumnoNuevo.AutoSize = true;
            this.labelAlumnoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlumnoNuevo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelAlumnoNuevo.Location = new System.Drawing.Point(403, 30);
            this.labelAlumnoNuevo.Name = "labelAlumnoNuevo";
            this.labelAlumnoNuevo.Size = new System.Drawing.Size(124, 20);
            this.labelAlumnoNuevo.TabIndex = 0;
            this.labelAlumnoNuevo.Text = "Nuevo Alumno";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(34, 85);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(62, 17);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido:";
            // 
            // textBoxApellidoAlumno
            // 
            this.textBoxApellidoAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxApellidoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoAlumno.Location = new System.Drawing.Point(115, 84);
            this.textBoxApellidoAlumno.Name = "textBoxApellidoAlumno";
            this.textBoxApellidoAlumno.Size = new System.Drawing.Size(330, 23);
            this.textBoxApellidoAlumno.TabIndex = 0;
            this.textBoxApellidoAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxApellidoAlumno_Validating);
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(477, 87);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(73, 17);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre/s:";
            // 
            // textBoxNombreAlumno
            // 
            this.textBoxNombreAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreAlumno.Location = new System.Drawing.Point(561, 85);
            this.textBoxNombreAlumno.Name = "textBoxNombreAlumno";
            this.textBoxNombreAlumno.Size = new System.Drawing.Size(291, 23);
            this.textBoxNombreAlumno.TabIndex = 1;
            this.textBoxNombreAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNombreAlumno_Validating);
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaNacimiento.Location = new System.Drawing.Point(32, 196);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(145, 17);
            this.labelFechaNacimiento.TabIndex = 5;
            this.labelFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dateTimeAlumno
            // 
            this.dateTimeAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAlumno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAlumno.Location = new System.Drawing.Point(183, 193);
            this.dateTimeAlumno.Name = "dateTimeAlumno";
            this.dateTimeAlumno.Size = new System.Drawing.Size(105, 23);
            this.dateTimeAlumno.TabIndex = 5;
            this.dateTimeAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeAlumno_Validating);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(34, 142);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(35, 17);
            this.labelDni.TabIndex = 7;
            this.labelDni.Text = "DNI:";
            // 
            // textBoxDniAlumno
            // 
            this.textBoxDniAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDniAlumno.Location = new System.Drawing.Point(115, 138);
            this.textBoxDniAlumno.MaxLength = 11;
            this.textBoxDniAlumno.Name = "textBoxDniAlumno";
            this.textBoxDniAlumno.Size = new System.Drawing.Size(268, 23);
            this.textBoxDniAlumno.TabIndex = 2;
            this.textBoxDniAlumno.TextChanged += new System.EventHandler(this.textBoxDniAlumno_TextChanged);
            this.textBoxDniAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDniAlumno_KeyPress);
            this.textBoxDniAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDniAlumno_Validating);
            // 
            // labelNacionalidad
            // 
            this.labelNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNacionalidad.AutoSize = true;
            this.labelNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNacionalidad.Location = new System.Drawing.Point(461, 139);
            this.labelNacionalidad.Name = "labelNacionalidad";
            this.labelNacionalidad.Size = new System.Drawing.Size(94, 17);
            this.labelNacionalidad.TabIndex = 9;
            this.labelNacionalidad.Text = "Nacionalidad:";
            // 
            // labelNombreDelCurso
            // 
            this.labelNombreDelCurso.AutoSize = true;
            this.labelNombreDelCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDelCurso.Location = new System.Drawing.Point(32, 410);
            this.labelNombreDelCurso.Name = "labelNombreDelCurso";
            this.labelNombreDelCurso.Size = new System.Drawing.Size(124, 17);
            this.labelNombreDelCurso.TabIndex = 11;
            this.labelNombreDelCurso.Text = "Nombre del curso:";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPais.Location = new System.Drawing.Point(32, 252);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(35, 17);
            this.labelPais.TabIndex = 12;
            this.labelPais.Text = "País";
            // 
            // labelProvincia
            // 
            this.labelProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProvincia.Location = new System.Drawing.Point(480, 248);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(66, 17);
            this.labelProvincia.TabIndex = 13;
            this.labelProvincia.Text = "Provincia";
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudad.Location = new System.Drawing.Point(32, 303);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(56, 17);
            this.labelCiudad.TabIndex = 14;
            this.labelCiudad.Text = "Ciudad:";
            // 
            // labelBarrio
            // 
            this.labelBarrio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBarrio.AutoSize = true;
            this.labelBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarrio.Location = new System.Drawing.Point(477, 306);
            this.labelBarrio.Name = "labelBarrio";
            this.labelBarrio.Size = new System.Drawing.Size(50, 17);
            this.labelBarrio.TabIndex = 15;
            this.labelBarrio.Text = "Barrio:";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalle.Location = new System.Drawing.Point(34, 354);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(43, 17);
            this.labelCalle.TabIndex = 16;
            this.labelCalle.Text = "Calle:";
            // 
            // labelNumeroCalle
            // 
            this.labelNumeroCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumeroCalle.AutoSize = true;
            this.labelNumeroCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroCalle.Location = new System.Drawing.Point(571, 357);
            this.labelNumeroCalle.Name = "labelNumeroCalle";
            this.labelNumeroCalle.Size = new System.Drawing.Size(28, 17);
            this.labelNumeroCalle.TabIndex = 17;
            this.labelNumeroCalle.Text = "N°:";
            // 
            // textBoxCiudadAlumno
            // 
            this.textBoxCiudadAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCiudadAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiudadAlumno.Location = new System.Drawing.Point(90, 303);
            this.textBoxCiudadAlumno.Name = "textBoxCiudadAlumno";
            this.textBoxCiudadAlumno.Size = new System.Drawing.Size(355, 23);
            this.textBoxCiudadAlumno.TabIndex = 8;
            this.textBoxCiudadAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCiudadAlumno_Validating);
            // 
            // textBoxBarrioAlumno
            // 
            this.textBoxBarrioAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBarrioAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarrioAlumno.Location = new System.Drawing.Point(533, 303);
            this.textBoxBarrioAlumno.Name = "textBoxBarrioAlumno";
            this.textBoxBarrioAlumno.Size = new System.Drawing.Size(319, 23);
            this.textBoxBarrioAlumno.TabIndex = 9;
            this.textBoxBarrioAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBarrioAlumno_Validating);
            // 
            // textBoxCalleAlumno
            // 
            this.textBoxCalleAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCalleAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalleAlumno.Location = new System.Drawing.Point(90, 354);
            this.textBoxCalleAlumno.Name = "textBoxCalleAlumno";
            this.textBoxCalleAlumno.Size = new System.Drawing.Size(418, 23);
            this.textBoxCalleAlumno.TabIndex = 10;
            this.textBoxCalleAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCalleAlumno_Validating);
            // 
            // textBoxNroCalleAlumno
            // 
            this.textBoxNroCalleAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNroCalleAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNroCalleAlumno.Location = new System.Drawing.Point(605, 354);
            this.textBoxNroCalleAlumno.Name = "textBoxNroCalleAlumno";
            this.textBoxNroCalleAlumno.Size = new System.Drawing.Size(127, 23);
            this.textBoxNroCalleAlumno.TabIndex = 11;
            this.textBoxNroCalleAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNroCalleAlumno_KeyPress);
            this.textBoxNroCalleAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNroCalleAlumno_Validating);
            // 
            // comboBoxPaisAlumno
            // 
            this.comboBoxPaisAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPaisAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaisAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaisAlumno.FormattingEnabled = true;
            this.comboBoxPaisAlumno.Location = new System.Drawing.Point(73, 248);
            this.comboBoxPaisAlumno.Name = "comboBoxPaisAlumno";
            this.comboBoxPaisAlumno.Size = new System.Drawing.Size(223, 24);
            this.comboBoxPaisAlumno.TabIndex = 6;
            this.comboBoxPaisAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPaisAlumno_Validating);
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursos.DropDownWidth = 250;
            this.comboBoxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(162, 407);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(170, 24);
            this.comboBoxCursos.TabIndex = 12;
            this.comboBoxCursos.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCursos_Validating);
            // 
            // botonCargarNuevoAlumno
            // 
            this.botonCargarNuevoAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonCargarNuevoAlumno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botonCargarNuevoAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botonCargarNuevoAlumno.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.botonCargarNuevoAlumno.FlatAppearance.BorderSize = 5;
            this.botonCargarNuevoAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonCargarNuevoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.botonCargarNuevoAlumno.ForeColor = System.Drawing.Color.White;
            this.botonCargarNuevoAlumno.Location = new System.Drawing.Point(369, 466);
            this.botonCargarNuevoAlumno.Name = "botonCargarNuevoAlumno";
            this.botonCargarNuevoAlumno.Size = new System.Drawing.Size(155, 58);
            this.botonCargarNuevoAlumno.TabIndex = 13;
            this.botonCargarNuevoAlumno.Text = "Cargar alumno";
            this.botonCargarNuevoAlumno.UseVisualStyleBackColor = false;
            this.botonCargarNuevoAlumno.Click += new System.EventHandler(this.botonCargarNuevoAlumno_Click);
            // 
            // comboBoxProvinciaAlumno
            // 
            this.comboBoxProvinciaAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProvinciaAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvinciaAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProvinciaAlumno.FormattingEnabled = true;
            this.comboBoxProvinciaAlumno.Location = new System.Drawing.Point(561, 244);
            this.comboBoxProvinciaAlumno.Name = "comboBoxProvinciaAlumno";
            this.comboBoxProvinciaAlumno.Size = new System.Drawing.Size(291, 24);
            this.comboBoxProvinciaAlumno.TabIndex = 7;
            this.comboBoxProvinciaAlumno.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxProvinciaAlumno_Validating);
            // 
            // errorProviderApellido
            // 
            this.errorProviderApellido.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderApellido.ContainerControl = this;
            // 
            // errorProviderNames
            // 
            this.errorProviderNames.ContainerControl = this;
            // 
            // errorProviderDni
            // 
            this.errorProviderDni.ContainerControl = this;
            // 
            // errorProviderNacionalidad
            // 
            this.errorProviderNacionalidad.ContainerControl = this;
            // 
            // errorProviderDatTime
            // 
            this.errorProviderDatTime.ContainerControl = this;
            // 
            // errorProviderPais
            // 
            this.errorProviderPais.ContainerControl = this;
            // 
            // errorProviderProvincia
            // 
            this.errorProviderProvincia.ContainerControl = this;
            // 
            // errorProviderCiudad
            // 
            this.errorProviderCiudad.ContainerControl = this;
            // 
            // errorProviderBarrio
            // 
            this.errorProviderBarrio.ContainerControl = this;
            // 
            // errorProviderCalle
            // 
            this.errorProviderCalle.ContainerControl = this;
            // 
            // errorProviderNroCalle
            // 
            this.errorProviderNroCalle.ContainerControl = this;
            // 
            // errorProviderCurso
            // 
            this.errorProviderCurso.ContainerControl = this;
            // 
            // textBoxNacionalidadAlumno
            // 
            this.textBoxNacionalidadAlumno.FormattingEnabled = true;
            this.textBoxNacionalidadAlumno.Location = new System.Drawing.Point(561, 139);
            this.textBoxNacionalidadAlumno.Name = "textBoxNacionalidadAlumno";
            this.textBoxNacionalidadAlumno.Size = new System.Drawing.Size(291, 21);
            this.textBoxNacionalidadAlumno.TabIndex = 3;
            // 
            // FormNuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 536);
            this.Controls.Add(this.textBoxNacionalidadAlumno);
            this.Controls.Add(this.comboBoxProvinciaAlumno);
            this.Controls.Add(this.botonCargarNuevoAlumno);
            this.Controls.Add(this.comboBoxCursos);
            this.Controls.Add(this.comboBoxPaisAlumno);
            this.Controls.Add(this.textBoxNroCalleAlumno);
            this.Controls.Add(this.textBoxCalleAlumno);
            this.Controls.Add(this.textBoxBarrioAlumno);
            this.Controls.Add(this.textBoxCiudadAlumno);
            this.Controls.Add(this.labelNumeroCalle);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelBarrio);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelNombreDelCurso);
            this.Controls.Add(this.labelNacionalidad);
            this.Controls.Add(this.textBoxDniAlumno);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.dateTimeAlumno);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.textBoxNombreAlumno);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxApellidoAlumno);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelAlumnoNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNuevoAlumno";
            this.Load += new System.EventHandler(this.FormNuevoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNacionalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNroCalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlumnoNuevo;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellidoAlumno;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombreAlumno;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dateTimeAlumno;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDniAlumno;
        private System.Windows.Forms.Label labelNacionalidad;
        private System.Windows.Forms.Label labelNombreDelCurso;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelBarrio;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelNumeroCalle;
        private System.Windows.Forms.TextBox textBoxCiudadAlumno;
        private System.Windows.Forms.TextBox textBoxBarrioAlumno;
        private System.Windows.Forms.TextBox textBoxCalleAlumno;
        private System.Windows.Forms.TextBox textBoxNroCalleAlumno;
        private System.Windows.Forms.ComboBox comboBoxPaisAlumno;
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.Button botonCargarNuevoAlumno;
        private System.Windows.Forms.ComboBox comboBoxProvinciaAlumno;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderNames;
        private System.Windows.Forms.ErrorProvider errorProviderDni;
        private System.Windows.Forms.ErrorProvider errorProviderNacionalidad;
        private System.Windows.Forms.ErrorProvider errorProviderDatTime;
        private System.Windows.Forms.ErrorProvider errorProviderPais;
        private System.Windows.Forms.ErrorProvider errorProviderProvincia;
        private System.Windows.Forms.ErrorProvider errorProviderCiudad;
        private System.Windows.Forms.ErrorProvider errorProviderBarrio;
        private System.Windows.Forms.ErrorProvider errorProviderCalle;
        private System.Windows.Forms.ErrorProvider errorProviderNroCalle;
        private System.Windows.Forms.ErrorProvider errorProviderCurso;
        private System.Windows.Forms.ComboBox textBoxNacionalidadAlumno;
    }
}