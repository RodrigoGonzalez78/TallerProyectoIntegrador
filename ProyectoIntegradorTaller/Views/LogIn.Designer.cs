using System.Drawing;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBienvenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TPass = new CustomControls.RJControls.RJTextBox();
            this.TEmail = new CustomControls.RJControls.RJTextBox();
            this.BInicioSesion = new ProyectoIntegradorTaller.views.components.BotonPersonalisado();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBienvenido
            // 
            this.LBienvenido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.LBienvenido.Location = new System.Drawing.Point(111, 70);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(97, 18);
            this.LBienvenido.TabIndex = 3;
            this.LBienvenido.Text = "Bienvenido";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 358);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel6.Location = new System.Drawing.Point(515, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 358);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.TPass);
            this.panel7.Controls.Add(this.TEmail);
            this.panel7.Controls.Add(this.BInicioSesion);
            this.panel7.Controls.Add(this.LBienvenido);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(179, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(335, 358);
            this.panel7.TabIndex = 11;
            // 
            // TPass
            // 
            this.TPass.BackColor = System.Drawing.SystemColors.Menu;
            this.TPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TPass.BorderRadius = 6;
            this.TPass.BorderSize = 2;
            this.TPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPass.Location = new System.Drawing.Point(73, 185);
            this.TPass.Margin = new System.Windows.Forms.Padding(4);
            this.TPass.Multiline = false;
            this.TPass.Name = "TPass";
            this.TPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TPass.PasswordChar = true;
            this.TPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TPass.PlaceholderText = "";
            this.TPass.Size = new System.Drawing.Size(186, 31);
            this.TPass.TabIndex = 10;
            this.TPass.Texts = "";
            this.TPass.UnderlinedStyle = true;
            // 
            // TEmail
            // 
            this.TEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.TEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.TEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TEmail.BorderRadius = 6;
            this.TEmail.BorderSize = 2;
            this.TEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TEmail.Location = new System.Drawing.Point(73, 130);
            this.TEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TEmail.Multiline = false;
            this.TEmail.Name = "TEmail";
            this.TEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TEmail.PasswordChar = false;
            this.TEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TEmail.PlaceholderText = "";
            this.TEmail.Size = new System.Drawing.Size(186, 31);
            this.TEmail.TabIndex = 9;
            this.TEmail.Texts = "";
            this.TEmail.UnderlinedStyle = true;
            // 
            // BInicioSesion
            // 
            this.BInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BInicioSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.BInicioSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BInicioSesion.BorderRadius = 6;
            this.BInicioSesion.BorderSize = 0;
            this.BInicioSesion.FlatAppearance.BorderSize = 0;
            this.BInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInicioSesion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInicioSesion.ForeColor = System.Drawing.Color.White;
            this.BInicioSesion.Image = global::ProyectoIntegradorTaller.Properties.Resources.login;
            this.BInicioSesion.Location = new System.Drawing.Point(73, 240);
            this.BInicioSesion.Name = "BInicioSesion";
            this.BInicioSesion.Size = new System.Drawing.Size(186, 40);
            this.BInicioSesion.TabIndex = 0;
            this.BInicioSesion.Text = "    Iniciar Sesión";
            this.BInicioSesion.TextColor = System.Drawing.Color.White;
            this.BInicioSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BInicioSesion.UseVisualStyleBackColor = false;
            this.BInicioSesion.Click += new System.EventHandler(this.BInicioSesion_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label LCerrar;
        private Label LBienvenido;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private views.components.BotonPersonalisado BInicioSesion;
        private CustomControls.RJControls.RJTextBox TEmail;
        private CustomControls.RJControls.RJTextBox TPass;
    }
}