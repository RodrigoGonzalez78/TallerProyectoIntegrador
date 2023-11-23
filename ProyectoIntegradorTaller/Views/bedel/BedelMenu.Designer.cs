using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class BedelMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.botonPersonalisado1 = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BProfesores = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BMaterias = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.TBBusqueda = new CustomControls.RJControls.RJTextBox();
            this.BBuscar = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemProfesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.BPendientes = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CBFiltro = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemProfesorBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBMaximizar_
            // 
            this.PBMaximizar_.Location = new System.Drawing.Point(752, 11);
            // 
            // PBCerrar_
            // 
            this.PBCerrar_.Location = new System.Drawing.Point(773, 11);
            // 
            // PBEsconder_
            // 
            this.PBEsconder_.Location = new System.Drawing.Point(775, 12);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(352, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Home";
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBienvenido.Location = new System.Drawing.Point(12, 21);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(53, 18);
            this.LBienvenido.TabIndex = 3;
            this.LBienvenido.Text = "Aulas";
            // 
            // botonPersonalisado1
            // 
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
            this.botonPersonalisado1.Location = new System.Drawing.Point(12, 44);
            this.botonPersonalisado1.Name = "botonPersonalisado1";
            this.botonPersonalisado1.Size = new System.Drawing.Size(118, 40);
            this.botonPersonalisado1.TabIndex = 16;
            this.botonPersonalisado1.Text = " Mi Cuenta";
            this.botonPersonalisado1.TextColor = System.Drawing.Color.White;
            this.botonPersonalisado1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botonPersonalisado1.UseVisualStyleBackColor = false;
            this.botonPersonalisado1.Click += new System.EventHandler(this.botonPersonalisado1_Click);
            // 
            // BProfesores
            // 
            this.BProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BProfesores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BProfesores.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BProfesores.BorderRadius = 6;
            this.BProfesores.BorderSize = 0;
            this.BProfesores.FlatAppearance.BorderSize = 0;
            this.BProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BProfesores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BProfesores.ForeColor = System.Drawing.Color.White;
            this.BProfesores.Image = global::ProyectoIntegradorTaller.Properties.Resources.badge;
            this.BProfesores.Location = new System.Drawing.Point(482, 44);
            this.BProfesores.Name = "BProfesores";
            this.BProfesores.Size = new System.Drawing.Size(150, 40);
            this.BProfesores.TabIndex = 15;
            this.BProfesores.Text = "  Profesores";
            this.BProfesores.TextColor = System.Drawing.Color.White;
            this.BProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BProfesores.UseVisualStyleBackColor = false;
            this.BProfesores.Click += new System.EventHandler(this.BProfesores_Click);
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
            this.BMaterias.Location = new System.Drawing.Point(638, 44);
            this.BMaterias.Name = "BMaterias";
            this.BMaterias.Size = new System.Drawing.Size(150, 40);
            this.BMaterias.TabIndex = 14;
            this.BMaterias.Text = "  Materias";
            this.BMaterias.TextColor = System.Drawing.Color.White;
            this.BMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BMaterias.UseVisualStyleBackColor = false;
            this.BMaterias.Click += new System.EventHandler(this.BMaterias_Click);
            // 
            // TBBusqueda
            // 
            this.TBBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBBusqueda.BackColor = System.Drawing.SystemColors.Menu;
            this.TBBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBBusqueda.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBBusqueda.BorderRadius = 6;
            this.TBBusqueda.BorderSize = 2;
            this.TBBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBBusqueda.Location = new System.Drawing.Point(549, 14);
            this.TBBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TBBusqueda.Multiline = false;
            this.TBBusqueda.Name = "TBBusqueda";
            this.TBBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBBusqueda.PasswordChar = false;
            this.TBBusqueda.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBBusqueda.PlaceholderText = "";
            this.TBBusqueda.Size = new System.Drawing.Size(186, 31);
            this.TBBusqueda.TabIndex = 12;
            this.TBBusqueda.Texts = "";
            this.TBBusqueda.UnderlinedStyle = true;
            this.TBBusqueda._TextChanged += new System.EventHandler(this.TBBusqueda__TextChanged);
            // 
            // BBuscar
            // 
            this.BBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BBuscar.Location = new System.Drawing.Point(742, 15);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(46, 32);
            this.BBuscar.TabIndex = 11;
            this.BBuscar.TextColor = System.Drawing.Color.White;
            this.BBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BPendientes);
            this.panel3.Controls.Add(this.BProfesores);
            this.panel3.Controls.Add(this.BMaterias);
            this.panel3.Controls.Add(this.botonPersonalisado1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 354);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 96);
            this.panel3.TabIndex = 12;
            // 
            // BPendientes
            // 
            this.BPendientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BPendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BPendientes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BPendientes.BorderRadius = 6;
            this.BPendientes.BorderSize = 0;
            this.BPendientes.FlatAppearance.BorderSize = 0;
            this.BPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPendientes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPendientes.ForeColor = System.Drawing.Color.White;
            this.BPendientes.Image = global::ProyectoIntegradorTaller.Properties.Resources.alert;
            this.BPendientes.Location = new System.Drawing.Point(294, 44);
            this.BPendientes.Name = "BPendientes";
            this.BPendientes.Size = new System.Drawing.Size(182, 40);
            this.BPendientes.TabIndex = 17;
            this.BPendientes.Text = "  Reservas Pendientes";
            this.BPendientes.TextColor = System.Drawing.Color.White;
            this.BPendientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BPendientes.UseVisualStyleBackColor = false;
            this.BPendientes.Click += new System.EventHandler(this.BPendientes_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.CBFiltro);
            this.panel5.Controls.Add(this.BBuscar);
            this.panel5.Controls.Add(this.TBBusqueda);
            this.panel5.Controls.Add(this.LBienvenido);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 52);
            this.panel5.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 270);
            this.panel6.TabIndex = 14;
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
            this.CBFiltro.Location = new System.Drawing.Point(335, 14);
            this.CBFiltro.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBFiltro.Name = "CBFiltro";
            this.CBFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.CBFiltro.Size = new System.Drawing.Size(207, 30);
            this.CBFiltro.TabIndex = 56;
            this.CBFiltro.Texts = "Nombre";
            // 
            // BedelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BedelMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.BedelMenu_Load);
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemProfesorBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   
        private Label LCerrar;
        private Label LBienvenido;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private ProyectoIntegradorTaller.views.components.BotonPersonalisado BBuscar;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private BindingSource itemProfesorBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadMaxDataGridViewTextBoxColumn;
        private components.BotonPersonalisado BProfesores;
        private components.BotonPersonalisado BMaterias;
        private components.BotonPersonalisado botonPersonalisado1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private components.BotonPersonalisado BPendientes;
        private components.ComboBoxPersonalisado CBFiltro;
    }

    #endregion

}