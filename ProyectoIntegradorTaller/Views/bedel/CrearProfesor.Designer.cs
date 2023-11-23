namespace ProyectoIntegradorTaller.views.admin
{
    partial class CrearProfesor
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
            this.label5 = new System.Windows.Forms.Label();
            this.TBCorreo = new CustomControls.RJControls.RJTextBox();
            this.BVolver = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.BInicioSesion = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.TBNombre = new CustomControls.RJControls.RJTextBox();
            this.TBDNI = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBApellido = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBCorreo);
            this.panel1.Controls.Add(this.BVolver);
            this.panel1.Controls.Add(this.BInicioSesion);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.TBDNI);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBApellido);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 358);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(232, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Correo Electronico";
            // 
            // TBCorreo
            // 
            this.TBCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBCorreo.BackColor = System.Drawing.SystemColors.Menu;
            this.TBCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBCorreo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBCorreo.BorderRadius = 6;
            this.TBCorreo.BorderSize = 2;
            this.TBCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBCorreo.Location = new System.Drawing.Point(235, 231);
            this.TBCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TBCorreo.Multiline = false;
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBCorreo.PasswordChar = false;
            this.TBCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBCorreo.PlaceholderText = "";
            this.TBCorreo.Size = new System.Drawing.Size(200, 31);
            this.TBCorreo.TabIndex = 52;
            this.TBCorreo.Texts = "";
            this.TBCorreo.UnderlinedStyle = true;
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
            this.BVolver.Location = new System.Drawing.Point(12, 306);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(100, 40);
            this.BVolver.TabIndex = 51;
            this.BVolver.Text = "  Volver";
            this.BVolver.TextColor = System.Drawing.Color.AliceBlue;
            this.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click_1);
            // 
            // BInicioSesion
            // 
            this.BInicioSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BInicioSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BInicioSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BInicioSesion.BorderRadius = 6;
            this.BInicioSesion.BorderSize = 0;
            this.BInicioSesion.FlatAppearance.BorderSize = 0;
            this.BInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInicioSesion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInicioSesion.ForeColor = System.Drawing.Color.White;
            this.BInicioSesion.Image = global::ProyectoIntegradorTaller.Properties.Resources.add;
            this.BInicioSesion.Location = new System.Drawing.Point(474, 306);
            this.BInicioSesion.Name = "BInicioSesion";
            this.BInicioSesion.Size = new System.Drawing.Size(200, 40);
            this.BInicioSesion.TabIndex = 32;
            this.BInicioSesion.Text = "  Crear Profesor";
            this.BInicioSesion.TextColor = System.Drawing.Color.White;
            this.BInicioSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BInicioSesion.UseVisualStyleBackColor = false;
            this.BInicioSesion.Click += new System.EventHandler(this.BInicioSesion_Click);
            // 
            // TBNombre
            // 
            this.TBNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.TBNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBNombre.BorderRadius = 6;
            this.TBNombre.BorderSize = 2;
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBNombre.Location = new System.Drawing.Point(235, 66);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TBNombre.Multiline = false;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBNombre.PasswordChar = false;
            this.TBNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBNombre.PlaceholderText = "";
            this.TBNombre.Size = new System.Drawing.Size(200, 31);
            this.TBNombre.TabIndex = 31;
            this.TBNombre.Texts = "";
            this.TBNombre.UnderlinedStyle = true;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTexto_KeyPress);
            // 
            // TBDNI
            // 
            this.TBDNI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBDNI.BackColor = System.Drawing.SystemColors.Menu;
            this.TBDNI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBDNI.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBDNI.BorderRadius = 6;
            this.TBDNI.BorderSize = 2;
            this.TBDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBDNI.Location = new System.Drawing.Point(235, 176);
            this.TBDNI.Margin = new System.Windows.Forms.Padding(4);
            this.TBDNI.Multiline = false;
            this.TBDNI.Name = "TBDNI";
            this.TBDNI.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBDNI.PasswordChar = false;
            this.TBDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBDNI.PlaceholderText = "";
            this.TBDNI.Size = new System.Drawing.Size(200, 31);
            this.TBDNI.TabIndex = 30;
            this.TBDNI.Texts = "";
            this.TBDNI.UnderlinedStyle = true;
            this.TBDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDNI_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(232, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(232, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Apellido";
            // 
            // TBApellido
            // 
            this.TBApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBApellido.BackColor = System.Drawing.SystemColors.Menu;
            this.TBApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TBApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TBApellido.BorderRadius = 6;
            this.TBApellido.BorderSize = 2;
            this.TBApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBApellido.Location = new System.Drawing.Point(235, 121);
            this.TBApellido.Margin = new System.Windows.Forms.Padding(4);
            this.TBApellido.Multiline = false;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBApellido.PasswordChar = false;
            this.TBApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBApellido.PlaceholderText = "";
            this.TBApellido.Size = new System.Drawing.Size(200, 31);
            this.TBApellido.TabIndex = 27;
            this.TBApellido.Texts = "";
            this.TBApellido.UnderlinedStyle = true;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTexto_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(232, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Nuevo Profesor";
            // 
            // CrearProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearProfesor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearProfesor";
            this.Controls.SetChildIndex(this.PBEsconder_, 0);
            this.Controls.SetChildIndex(this.PBMinimizar_, 0);
            this.Controls.SetChildIndex(this.PBMaximizar_, 0);
            this.Controls.SetChildIndex(this.PBCerrar_, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PBMaximizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMinimizar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCerrar_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEsconder_)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox TBDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox TBApellido;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox TBNombre;
        private components.BotonPersonalisado BInicioSesion;
        private components.BotonPersonalisado BVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox TBCorreo;
    }
}