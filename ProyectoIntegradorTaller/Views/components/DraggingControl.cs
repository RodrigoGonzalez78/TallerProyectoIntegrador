//using ProyectoIntegradorTaller.formularios;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.Properties;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DraggingControl
{
    public partial class DraggablePanelUserControl : Form
    {
        private bool isDragging = false;
        private Point originalMousePos;
        private Point originalControlPos;
        public PictureBox PBMaximizar_;
        public PictureBox PBMinimizar_;
        public PictureBox PBCerrar_;
        public PictureBox PBEsconder_;
        public DraggablePanelUserControl()
        {
            InitializeComponent();
           
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DraggablePanelUserControl));
            Panel panel1 = new Panel();
            PictureBox PBCerrar = new System.Windows.Forms.PictureBox();
            PictureBox PBMaximizar = new System.Windows.Forms.PictureBox();
            PictureBox PBRestaurar = new System.Windows.Forms.PictureBox();
            PictureBox PBEsconder = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();

            //PBCerrar.SuspendLayout();
            ((ISupportInitialize)(PBCerrar)).BeginInit();
            PBCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            PBCerrar.Name = "PBCerrar";
            PBCerrar.Size = new Size(15, 15);
            PBCerrar.TabIndex = 3;
            PBCerrar.TabStop = false;
         //   PBCerrar.Location = new Point(666, 11);
            PBCerrar.BackgroundImage = null;
            PBCerrar.BorderStyle = BorderStyle.None;
            PBCerrar.BackColor = Color.FromArgb(17, 97, 238);
            PBCerrar.Image = (Image)(Resources.BCerrar_Image);


         //   PBMaximizar.SuspendLayout();
            ((ISupportInitialize)(PBMaximizar)).BeginInit();
            PBMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            PBMaximizar.Name = "PBMaximizar";
            PBMaximizar.Size = new Size(15, 15);
            PBMaximizar.TabIndex = 3;
            PBMaximizar.TabStop = false;
          //  PBMaximizar.Location = new Point(646, 11);
            PBMaximizar.BackgroundImage = null;
            PBMaximizar.BorderStyle = BorderStyle.None;
            PBMaximizar.BackColor = Color.FromArgb(17, 97, 238);
            PBMaximizar.Image = (Image)Resources.icons8_full_screen_24__1_;

            ////
            //PBRestaurar.SuspendLayout();
            ((ISupportInitialize)(PBRestaurar)).BeginInit();
            PBRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            PBRestaurar.Name = "PBRestaurar";
            PBRestaurar.Size = new Size(15, 15);
            PBRestaurar.TabIndex = 3;
            PBRestaurar.TabStop = false;
            PBRestaurar.Location = new Point(646, 11);
            PBRestaurar.BackgroundImage = null;
            PBRestaurar.BorderStyle = BorderStyle.None;
            PBRestaurar.BackColor = Color.FromArgb(17, 97, 238);
            PBRestaurar.Image = (Image)(Resources.icons8_bursts_24__1_);
            PBRestaurar.Visible= false;



            PBEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            PBEsconder.Image = ((System.Drawing.Image)(Resources.icons8_minus_24));
            PBEsconder.Location = new System.Drawing.Point(624, 11);
            PBEsconder.Name = "BEsconder";
            PBEsconder.Size = new System.Drawing.Size(15, 15);
            PBEsconder.TabIndex = 4;
            PBEsconder.TabStop = false;
            PBEsconder.BackColor = Color.FromArgb(17, 97, 238);
            //BEsconder.Click += new System.EventHandler(this.BEsconder_Click);

            panel1.Size = new Size(686, 32);
            panel1.BackColor = Color.FromArgb(17, 97, 238); // Set the background color
            panel1.Location = new Point(0, 0); // Set the location
            panel1.Dock = DockStyle.Top;
            this.Load +=new EventHandler(this.panel1_load);
        
         // PBMaximizar.SuspendLayout();
          //  this.SuspendLayout();
            // Attach event handlers to the panel
            panel1.MouseClick += Panel_MouseClick;
            panel1.MouseDown += Panel_MouseDown;
            panel1.MouseMove += Panel_MouseMove;
            panel1.MouseUp += Panel_MouseUp;

            
            PBCerrar.Click += BCerrar_Click;
            PBMaximizar.Click += new EventHandler(BMaximizar_Click);
            PBRestaurar.Click += new EventHandler(BRestaurar_Click);
            PBEsconder.Click += new System.EventHandler(BEsconder_Click);

           PBMaximizar_ = PBMaximizar;
            PBMinimizar_ = PBRestaurar;
            PBCerrar_ = PBCerrar;
            PBEsconder_=PBEsconder;
           
            this.Controls.Add(PBCerrar);
            this.Controls.Add(PBMaximizar);
            this.Controls.Add(PBRestaurar);
            this.Controls.Add(PBEsconder);
            this.Controls.Add(panel1);
        }
        private void BMaximizar_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            PBMaximizar_.Visible = false;
            PBMinimizar_.Visible = true;
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PBMaximizar_.Visible = true;
            PBMinimizar_.Visible = false;
        }

        private void BEsconder_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BCerrar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask=(MsgBoxResult)MessageBox.Show("Seguro que quiere salir?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ask == MsgBoxResult.Yes)
            {
                Application.Exit();
            }
        

        }
        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                originalMousePos = Control.MousePosition;
                originalControlPos = Location;
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                originalMousePos = Control.MousePosition;
                originalControlPos = Location;
            }
        }
        
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point delta = Point.Subtract(Control.MousePosition, new Size(originalMousePos));
                Location = Point.Add(originalControlPos, new Size(delta));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void panel1_load(object sender, EventArgs e)
        {
            PBMaximizar_.Location = new Point(646, 11);
            PBCerrar_.Location = new Point(666, 11);
            PBEsconder_.Location = new Point(624, 11);
        }
    }
}

