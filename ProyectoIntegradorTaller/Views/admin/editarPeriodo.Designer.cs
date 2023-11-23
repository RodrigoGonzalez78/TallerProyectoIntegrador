using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class editarPeriodo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBPeriodo = new ProyectoIntegradorTaller.views.components.ComboBoxPersonalisado();
            this.label1 = new System.Windows.Forms.Label();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.fecha_desde = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.BReservarAula = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.fecha_hasta = new ProyectoIntegradorTaller.views.components.TimePickerPersonalisado();
            this.fecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBMaximizar_
            // 
            this.PBMaximizar_.Location = new System.Drawing.Point(646, 11);
            // 
            // PBCerrar_
            // 
            this.PBCerrar_.Location = new System.Drawing.Point(666, 11);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.CBPeriodo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BVolver);
            this.panel1.Controls.Add(this.fecha_desde);
            this.panel1.Controls.Add(this.BReservarAula);
            this.panel1.Controls.Add(this.fecha_hasta);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 388);
            this.panel1.TabIndex = 0;
            // 
            // CBPeriodo
            // 
            this.CBPeriodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBPeriodo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBPeriodo.BorderSize = 2;
            this.CBPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBPeriodo.ForeColor = System.Drawing.Color.DimGray;
            this.CBPeriodo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.CBPeriodo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.CBPeriodo.ListTextColor = System.Drawing.Color.DimGray;
            this.CBPeriodo.Location = new System.Drawing.Point(228, 64);
            this.CBPeriodo.MinimumSize = new System.Drawing.Size(200, 30);
            this.CBPeriodo.Name = "CBPeriodo";
            this.CBPeriodo.Padding = new System.Windows.Forms.Padding(2);
            this.CBPeriodo.Size = new System.Drawing.Size(244, 30);
            this.CBPeriodo.TabIndex = 54;
            this.CBPeriodo.Texts = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Fecha Hasta";
            // 
            // BVolver
            // 
            this.BVolver.BackColor = System.Drawing.Color.LimeGreen;
            this.BVolver.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.BVolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BVolver.BorderRadius = 6;
            this.BVolver.BorderSize = 0;
            this.BVolver.FlatAppearance.BorderSize = 0;
            this.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BVolver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVolver.ForeColor = System.Drawing.Color.AliceBlue;
            this.BVolver.Image = global::ProyectoIntegradorTaller.Properties.Resources.path30;
            this.BVolver.Location = new System.Drawing.Point(12, 303);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(100, 40);
            this.BVolver.TabIndex = 52;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.AliceBlue;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click_1);
            // 
            // fecha_desde
            // 
            this.fecha_desde.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fecha_desde.BorderSize = 0;
            this.fecha_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fecha_desde.Location = new System.Drawing.Point(228, 129);
            this.fecha_desde.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.fecha_desde.MinDate = new System.DateTime(2023, 1, 18, 0, 0, 0, 0);
            this.fecha_desde.MinimumSize = new System.Drawing.Size(4, 35);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(244, 35);
            this.fecha_desde.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.fecha_desde.TabIndex = 34;
            this.fecha_desde.TextColor = System.Drawing.Color.White;
            
            // 
            // BReservarAula
            // 
            this.BReservarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BReservarAula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BReservarAula.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BReservarAula.BorderRadius = 6;
            this.BReservarAula.BorderSize = 0;
            this.BReservarAula.FlatAppearance.BorderSize = 0;
            this.BReservarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReservarAula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BReservarAula.ForeColor = System.Drawing.Color.White;
            this.BReservarAula.Location = new System.Drawing.Point(511, 303);
            this.BReservarAula.Name = "BReservarAula";
            this.BReservarAula.Size = new System.Drawing.Size(150, 40);
            this.BReservarAula.TabIndex = 8;
            this.BReservarAula.Text = "Editar Periodo";
            this.BReservarAula.TextColor = System.Drawing.Color.White;
            this.BReservarAula.UseVisualStyleBackColor = false;
            this.BReservarAula.Click += new System.EventHandler(this.botonPersonalisado1_Click);
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.fecha_hasta.BorderSize = 0;
            this.fecha_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.fecha_hasta.Location = new System.Drawing.Point(228, 199);
            this.fecha_hasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(244, 35);
            this.fecha_hasta.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.fecha_hasta.TabIndex = 9;
            this.fecha_hasta.TextColor = System.Drawing.Color.White;
            
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(225, 108);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(101, 18);
            this.fecha.TabIndex = 8;
            this.fecha.Text = "Fecha Desde";
            
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 358);
            this.panel2.TabIndex = 6;
            
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(287, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Reservar Aula";
            // 
            // editarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editarPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservarAula";
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label fecha;
        private Panel panel2;
        private Label label8;
        private views.components.BotonPersonalisado BReservarAula;
        private views.components.TimePickerPersonalisado fecha_hasta;
        private components.BotonPersonalisado BVolver;
        private components.TimePickerPersonalisado fecha_desde;
        private components.ComboBoxPersonalisado CBPeriodo;
        private Label label1;
    }
}