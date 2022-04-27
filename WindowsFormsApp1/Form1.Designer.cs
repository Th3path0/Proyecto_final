namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtapellido = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtcarrera = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bdtp = new System.Windows.Forms.DateTimePicker();
            this.txtedificio = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcorreo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.bdtp1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtmotivo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtlugar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buscartxt = new Bunifu.Framework.UI.BunifuTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1640, 129);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Subrayada", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(405, 44);
            this.label7.TabIndex = 3;
            this.label7.Text = "Formulario Visita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(530, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(370, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(176, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(22, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(1276, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Hora de Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(884, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Carrera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(892, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(884, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 340);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtnombre
            // 
            this.txtnombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtnombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtnombre.BorderThickness = 3;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.isPassword = false;
            this.txtnombre.Location = new System.Drawing.Point(888, 252);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(314, 46);
            this.txtnombre.TabIndex = 39;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtapellido
            // 
            this.txtapellido.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtapellido.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtapellido.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtapellido.BorderThickness = 3;
            this.txtapellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellido.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtapellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtapellido.isPassword = false;
            this.txtapellido.Location = new System.Drawing.Point(888, 352);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(314, 46);
            this.txtapellido.TabIndex = 46;
            this.txtapellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcarrera
            // 
            this.txtcarrera.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcarrera.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcarrera.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtcarrera.BorderThickness = 3;
            this.txtcarrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcarrera.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcarrera.isPassword = false;
            this.txtcarrera.Location = new System.Drawing.Point(888, 445);
            this.txtcarrera.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(314, 46);
            this.txtcarrera.TabIndex = 47;
            this.txtcarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bdtp
            // 
            this.bdtp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.bdtp.Location = new System.Drawing.Point(1280, 371);
            this.bdtp.Name = "bdtp";
            this.bdtp.Size = new System.Drawing.Size(290, 26);
            this.bdtp.TabIndex = 49;
            this.bdtp.ValueChanged += new System.EventHandler(this.bdtp_ValueChanged);
            // 
            // txtedificio
            // 
            this.txtedificio.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtedificio.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtedificio.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtedificio.BorderThickness = 3;
            this.txtedificio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtedificio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtedificio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtedificio.isPassword = false;
            this.txtedificio.Location = new System.Drawing.Point(1280, 252);
            this.txtedificio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtedificio.Name = "txtedificio";
            this.txtedificio.Size = new System.Drawing.Size(314, 46);
            this.txtedificio.TabIndex = 51;
            this.txtedificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(1276, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 24);
            this.label10.TabIndex = 50;
            this.label10.Text = "Edificio";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtcorreo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcorreo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtcorreo.BorderThickness = 3;
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcorreo.isPassword = false;
            this.txtcorreo.Location = new System.Drawing.Point(888, 534);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(314, 46);
            this.txtcorreo.TabIndex = 53;
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(884, 506);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 52;
            this.label11.Text = "Correo";
            // 
            // bdtp1
            // 
            this.bdtp1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.bdtp1.Location = new System.Drawing.Point(1280, 455);
            this.bdtp1.Name = "bdtp1";
            this.bdtp1.Size = new System.Drawing.Size(290, 26);
            this.bdtp1.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(1276, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Hora de Entrada";
            // 
            // txtmotivo
            // 
            this.txtmotivo.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtmotivo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmotivo.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtmotivo.BorderThickness = 3;
            this.txtmotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmotivo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmotivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmotivo.isPassword = false;
            this.txtmotivo.Location = new System.Drawing.Point(1280, 534);
            this.txtmotivo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(314, 46);
            this.txtmotivo.TabIndex = 57;
            this.txtmotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label13.Location = new System.Drawing.Point(1276, 506);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "Motivo";
            // 
            // txtlugar
            // 
            this.txtlugar.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtlugar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlugar.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtlugar.BorderThickness = 3;
            this.txtlugar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlugar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtlugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlugar.isPassword = false;
            this.txtlugar.Location = new System.Drawing.Point(1126, 637);
            this.txtlugar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtlugar.Name = "txtlugar";
            this.txtlugar.Size = new System.Drawing.Size(314, 46);
            this.txtlugar.TabIndex = 59;
            this.txtlugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat Subrayada", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.Location = new System.Drawing.Point(1122, 609);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 24);
            this.label14.TabIndex = 58;
            this.label14.Text = "Lugar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 20;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 20;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.Location = new System.Drawing.Point(628, 625);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 85);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveBorderThickness = 1;
            this.btnEliminar.ActiveCornerRadius = 20;
            this.btnEliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleCornerRadius = 20;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.White;
            this.btnEliminar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.Location = new System.Drawing.Point(428, 625);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 85);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ActiveBorderThickness = 1;
            this.btnEditar.ActiveCornerRadius = 20;
            this.btnEditar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.IdleBorderThickness = 1;
            this.btnEditar.IdleCornerRadius = 20;
            this.btnEditar.IdleFillColor = System.Drawing.Color.White;
            this.btnEditar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEditar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.Location = new System.Drawing.Point(218, 625);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(166, 85);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ActiveBorderThickness = 1;
            this.btnNuevo.ActiveCornerRadius = 20;
            this.btnNuevo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.IdleBorderThickness = 1;
            this.btnNuevo.IdleCornerRadius = 20;
            this.btnNuevo.IdleFillColor = System.Drawing.Color.White;
            this.btnNuevo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.Location = new System.Drawing.Point(22, 625);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(166, 85);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // buscartxt
            // 
            this.buscartxt.BackColor = System.Drawing.Color.Silver;
            this.buscartxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscartxt.BackgroundImage")));
            this.buscartxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscartxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.buscartxt.Icon = ((System.Drawing.Image)(resources.GetObject("buscartxt.Icon")));
            this.buscartxt.Location = new System.Drawing.Point(22, 137);
            this.buscartxt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buscartxt.Name = "buscartxt";
            this.buscartxt.Size = new System.Drawing.Size(375, 65);
            this.buscartxt.TabIndex = 40;
            this.buscartxt.text = "Buscar";
            this.buscartxt.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_cancelar_40;
            this.pictureBox1.Location = new System.Drawing.Point(1017, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1640, 740);
            this.Controls.Add(this.txtlugar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bdtp1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtedificio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bdtp);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.buscartxt);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnombre;
        private Bunifu.Framework.UI.BunifuTextbox buscartxt;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtapellido;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcarrera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcorreo;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtedificio;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtmotivo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker bdtp1;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtlugar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker bdtp;
    }
}

