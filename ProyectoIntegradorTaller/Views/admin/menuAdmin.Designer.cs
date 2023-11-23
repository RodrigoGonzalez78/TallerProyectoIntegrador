using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class menuAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.botonPersonalisado1 = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BLugares = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BMaterias = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BCrearAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BUsuarios = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TBBusqueda = new CustomControls.RJControls.RJTextBox();
            this.BBuscar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BDatabase = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BPeriodos = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBFiltro = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBMaximizar_
            // 
            this.PBMaximizar_.Location = new System.Drawing.Point(796, 11);
            // 
            // PBMinimizar_
            // 
            this.PBMinimizar_.Location = new System.Drawing.Point(796, 11);
            // 
            // PBCerrar_
            // 
            this.PBCerrar_.Location = new System.Drawing.Point(817, 11);
            // 
            // PBEsconder_
            // 
            this.PBEsconder_.Location = new System.Drawing.Point(775, 12);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aulas";
            // 
            // botonPersonalisado1
            // 
            this.botonPersonalisado1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonPersonalisado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.botonPersonalisado1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.botonPersonalisado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botonPersonalisado1.BorderRadius = 6;
            this.botonPersonalisado1.BorderSize = 0;
            this.botonPersonalisado1.FlatAppearance.BorderSize = 0;
            this.botonPersonalisado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPersonalisado1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalisado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalisado1.Image = global::ProyectoIntegradorTaller.Properties.Resources.cuenta;
            this.botonPersonalisado1.Location = new System.Drawing.Point(12, 48);
            this.botonPersonalisado1.Name = "botonPersonalisado1";
            this.botonPersonalisado1.Size = new System.Drawing.Size(118, 40);
            this.botonPersonalisado1.TabIndex = 16;
            this.botonPersonalisado1.Text = " Mi Cuenta";
            this.botonPersonalisado1.TextColor = System.Drawing.Color.White;
            this.botonPersonalisado1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonPersonalisado1.UseVisualStyleBackColor = false;
            this.botonPersonalisado1.Click += new System.EventHandler(this.botonPersonalisado1_Click);
            // 
            // BLugares
            // 
            this.BLugares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BLugares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BLugares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BLugares.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BLugares.BorderRadius = 6;
            this.BLugares.BorderSize = 0;
            this.BLugares.FlatAppearance.BorderSize = 0;
            this.BLugares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLugares.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLugares.ForeColor = System.Drawing.Color.White;
            this.BLugares.Image = global::ProyectoIntegradorTaller.Properties.Resources.map;
            this.BLugares.Location = new System.Drawing.Point(296, 48);
            this.BLugares.Name = "BLugares";
            this.BLugares.Size = new System.Drawing.Size(102, 40);
            this.BLugares.TabIndex = 17;
            this.BLugares.Text = "  Lugares";
            this.BLugares.TextColor = System.Drawing.Color.White;
            this.BLugares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BLugares.UseVisualStyleBackColor = false;
            this.BLugares.Click += new System.EventHandler(this.BLugares_Click);
            // 
            // BMaterias
            // 
            this.BMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BMaterias.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BMaterias.BorderRadius = 6;
            this.BMaterias.BorderSize = 0;
            this.BMaterias.FlatAppearance.BorderSize = 0;
            this.BMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMaterias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMaterias.ForeColor = System.Drawing.Color.White;
            this.BMaterias.Image = global::ProyectoIntegradorTaller.Properties.Resources.book;
            this.BMaterias.Location = new System.Drawing.Point(404, 48);
            this.BMaterias.Name = "BMaterias";
            this.BMaterias.Size = new System.Drawing.Size(97, 40);
            this.BMaterias.TabIndex = 18;
            this.BMaterias.Text = "  Materias";
            this.BMaterias.TextColor = System.Drawing.Color.White;
            this.BMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BMaterias.UseVisualStyleBackColor = false;
            this.BMaterias.Click += new System.EventHandler(this.BMaterias_Click);
            // 
            // BCrearAula
            // 
            this.BCrearAula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCrearAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BCrearAula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BCrearAula.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BCrearAula.BorderRadius = 6;
            this.BCrearAula.BorderSize = 0;
            this.BCrearAula.FlatAppearance.BorderSize = 0;
            this.BCrearAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCrearAula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCrearAula.ForeColor = System.Drawing.Color.White;
            this.BCrearAula.Image = global::ProyectoIntegradorTaller.Properties.Resources.room;
            this.BCrearAula.Location = new System.Drawing.Point(723, 48);
            this.BCrearAula.Name = "BCrearAula";
            this.BCrearAula.Size = new System.Drawing.Size(109, 40);
            this.BCrearAula.TabIndex = 19;
            this.BCrearAula.Text = "  Crear Aula";
            this.BCrearAula.TextColor = System.Drawing.Color.White;
            this.BCrearAula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCrearAula.UseVisualStyleBackColor = false;
            this.BCrearAula.Click += new System.EventHandler(this.BCrearAula_Click);
            // 
            // BUsuarios
            // 
            this.BUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BUsuarios.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BUsuarios.BorderRadius = 6;
            this.BUsuarios.BorderSize = 0;
            this.BUsuarios.FlatAppearance.BorderSize = 0;
            this.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUsuarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUsuarios.ForeColor = System.Drawing.Color.White;
            this.BUsuarios.Image = global::ProyectoIntegradorTaller.Properties.Resources.person_groups;
            this.BUsuarios.Location = new System.Drawing.Point(615, 48);
            this.BUsuarios.Name = "BUsuarios";
            this.BUsuarios.Size = new System.Drawing.Size(102, 40);
            this.BUsuarios.TabIndex = 20;
            this.BUsuarios.Text = "  Usuarios";
            this.BUsuarios.TextColor = System.Drawing.Color.White;
            this.BUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BUsuarios.UseVisualStyleBackColor = false;
            this.BUsuarios.Click += new System.EventHandler(this.BUsuarios_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(844, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TBBusqueda
            // 
            this.TBBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBBusqueda.BackColor = System.Drawing.SystemColors.Menu;
            this.TBBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBBusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBBusqueda.BorderRadius = 6;
            this.TBBusqueda.BorderSize = 2;
            this.TBBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBBusqueda.Location = new System.Drawing.Point(593, 41);
            this.TBBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TBBusqueda.Multiline = false;
            this.TBBusqueda.Name = "TBBusqueda";
            this.TBBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBBusqueda.PasswordChar = false;
            this.TBBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBBusqueda.PlaceholderText = "";
            this.TBBusqueda.Size = new System.Drawing.Size(186, 31);
            this.TBBusqueda.TabIndex = 39;
            this.TBBusqueda.Texts = "";
            this.TBBusqueda.UnderlinedStyle = true;
            this.TBBusqueda._TextChanged += new System.EventHandler(this.BBusqueda__TextChanged);
            // 
            // BBuscar
            // 
            this.BBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BBuscar.BorderRadius = 6;
            this.BBuscar.BorderSize = 0;
            this.BBuscar.FlatAppearance.BorderSize = 0;
            this.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscar.ForeColor = System.Drawing.Color.White;
            this.BBuscar.Image = global::ProyectoIntegradorTaller.Properties.Resources.search_white;
            this.BBuscar.Location = new System.Drawing.Point(786, 40);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(46, 32);
            this.BBuscar.TabIndex = 40;
            this.BBuscar.TextColor = System.Drawing.Color.White;
            this.BBuscar.UseVisualStyleBackColor = false;
            // 
            // BDatabase
            // 
            this.BDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BDatabase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BDatabase.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BDatabase.BorderRadius = 6;
            this.BDatabase.BorderSize = 0;
            this.BDatabase.FlatAppearance.BorderSize = 0;
            this.BDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDatabase.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDatabase.ForeColor = System.Drawing.Color.White;
            this.BDatabase.Image = global::ProyectoIntegradorTaller.Properties.Resources.database1;
            this.BDatabase.Location = new System.Drawing.Point(168, 48);
            this.BDatabase.Name = "BDatabase";
            this.BDatabase.Size = new System.Drawing.Size(122, 40);
            this.BDatabase.TabIndex = 41;
            this.BDatabase.Text = "  Database";
            this.BDatabase.TextColor = System.Drawing.Color.White;
            this.BDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BDatabase.UseVisualStyleBackColor = false;
            this.BDatabase.Click += new System.EventHandler(this.BDatabase_Click);
            // 
            // BPeriodos
            // 
            this.BPeriodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BPeriodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BPeriodos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BPeriodos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BPeriodos.BorderRadius = 6;
            this.BPeriodos.BorderSize = 0;
            this.BPeriodos.FlatAppearance.BorderSize = 0;
            this.BPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPeriodos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPeriodos.ForeColor = System.Drawing.Color.White;
            this.BPeriodos.Image = global::ProyectoIntegradorTaller.Properties.Resources.calendarWhite;
            this.BPeriodos.Location = new System.Drawing.Point(507, 48);
            this.BPeriodos.Name = "BPeriodos";
            this.BPeriodos.Size = new System.Drawing.Size(102, 40);
            this.BPeriodos.TabIndex = 42;
            this.BPeriodos.Text = "  Periodos";
            this.BPeriodos.TextColor = System.Drawing.Color.White;
            this.BPeriodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BPeriodos.UseVisualStyleBackColor = false;
            this.BPeriodos.Click += new System.EventHandler(this.BPeriodos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BCrearAula);
            this.panel1.Controls.Add(this.BDatabase);
            this.panel1.Controls.Add(this.BPeriodos);
            this.panel1.Controls.Add(this.BUsuarios);
            this.panel1.Controls.Add(this.BMaterias);
            this.panel1.Controls.Add(this.BLugares);
            this.panel1.Controls.Add(this.botonPersonalisado1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 100);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CBFiltro);
            this.panel2.Controls.Add(this.BBuscar);
            this.panel2.Controls.Add(this.TBBusqueda);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 75);
            this.panel2.TabIndex = 44;
            // 
            // CBFiltro
            // 
            this.CBFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBFiltro.BorderSize = 2;
            this.CBFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.CBFiltro.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Capacidad",
            "Lugar"});
            this.CBFiltro.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBFiltro.ListTextColor = System.Drawing.Color.DimGray;
            this.CBFiltro.Location = new System.Drawing.Point(379, 42);
            this.CBFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBFiltro.Name = "CBFiltro";
            this.CBFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.CBFiltro.Size = new System.Drawing.Size(207, 30);
            this.CBFiltro.TabIndex = 55;
            this.CBFiltro.Texts = "Nombre";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 277);
            this.panel3.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(375, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Home";
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 484);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuAdmin";
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private components.BotonPersonalisado botonPersonalisado1;
        private components.BotonPersonalisado BLugares;
        private components.BotonPersonalisado BMaterias;
        private components.BotonPersonalisado BCrearAula;
        private components.BotonPersonalisado BUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private components.BotonPersonalisado BBuscar;
        private components.BotonPersonalisado BDatabase;
        private components.BotonPersonalisado BPeriodos;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private components.ComboBoxPersonalisado CBFiltro;
    }
}