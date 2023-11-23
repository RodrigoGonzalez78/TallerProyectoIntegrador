using DraggingControl;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.models;
using ProyectoIntegradorTaller.views.components;
using System;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ProyectoIntegradorTaller.views.admin
{
   
    public partial class ImprimirReporte : FormPersonalisado
    {
        public int id_aula;
        private Bitmap memoryImage;
        public DateTime fecha_desde;
        public DateTime fecha_hasta;

        public string pperiodo;
        public ImprimirReporte(int id,string periodo)
        {
            InitializeComponent();
            id_aula = id;
            pperiodo= periodo;
        }



       
        private void Reporte_Load(object sender, EventArgs e)
        {
        
            ReporteLogica.ListarDias(chart1, id_aula, pperiodo);
         
            ReporteLogica.ListarMaterias(chart2, id_aula,pperiodo);
        
            ReporteLogica.ListarHoras(chart3, id_aula, pperiodo);

            ReporteLogica.ListarProfesores(chart4, id_aula, pperiodo);

            PBEsconder_.Location = new Point(732, 11);
            PBMaximizar_.Location = new Point(752,11);
            PBCerrar_.Location = new Point(775, 11);



        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuAdmin homeAdmin = new menuAdmin();
            homeAdmin.Show();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
        
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            printDocument1.DocumentName="informe "+ LogicaClase.NombreAula(id_aula)+"-"+DateTime.Now;
            printDocument1.Print();
            


        }
        private void PrintDocument1_PrintPage(System.Object sender,
      System.Drawing.Printing.PrintPageEventArgs e) =>
          e.Graphics.DrawImage(memoryImage, 0, 0);


       

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(memoryImage, 0, 0);

            this.Hide();
            Reporte unrepo = new Reporte(id_aula);
            unrepo.Show();
        }

        

        private void BVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Reporte unReporte = new Reporte(id_aula);
            unReporte.Show();
        }

       
    }
 
}
