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
   
    public partial class Reporte : FormPersonalisado
    {
        public int id_aula;
       // private Bitmap memoryImage;

        public Reporte(int id)
        {
            InitializeComponent();
            id_aula = id;
        }



        private void BCrearAula_Click(object sender, EventArgs e)
        {

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
          //  PBEsconder_.Location = new Point(732, 11);
           // PBMaximizar_.Location = new Point(752,11);
           // PBCerrar_.Location = new Point(775, 11);

            AulaLabel.Text=LogicaClase.NombreAula(id_aula);
            Periodo.DataSource = LogicaReserva.listarPeriodo();
            //Periodo.DataSource = items;
            Periodo.DisplayMember = "periodo_nombre";
            Periodo.ValueMember = "id_periodo";







            List<Lista> listaUso = new List<Lista>
            {
                new Lista { Id = 1, elegida = "Dias de mayor uso" },
                new Lista { Id = 2, elegida = "Uso por materia" },
                new Lista { Id = 3, elegida = "Horario de mayor uso" },
                new Lista { Id= 4, elegida="Uso por profesor"}
             
            };

            CBFiltro.DataSource = listaUso;

            CBFiltro.DisplayMember = "elegida";

            CBFiltro.ValueMember = "Id";
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuAdmin homeAdmin = new menuAdmin();
            homeAdmin.Show();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImprimirReporte unReporte =new ImprimirReporte(id_aula,this.Periodo.Texts);
            unReporte.Show();
        
        }
      

       

        private void comboBoxPersonalisado1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.CBFiltro.Texts)
            {

                case "Dias de mayor uso":
                    label2.Text = "Dias de mayor uso";
                    ReporteLogica.ListarDias(chart2, id_aula,this.Periodo.Texts);

                    break;
                case "Uso por materia":
                    label2.Text = "Uso por materia";
                    ReporteLogica.ListarMaterias(chart2, id_aula,this.Periodo.Texts);

                    break;
                case "Horario de mayor uso":
                    label2.Text = "Horario de mayor uso";
                    ReporteLogica.ListarHoras(chart2, id_aula,this.Periodo.Texts);
  
                    break;
                default:
                    label2.Text = "Frecuencia por profesor";
                    ReporteLogica.ListarProfesores(chart2, id_aula,this.Periodo.Texts);
                    break;
            }

        }

        private void Periodo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (this.CBFiltro.Texts)
            {

                case "Dias de mayor uso":
                    label2.Text = "Dias de mayor uso";
                    ReporteLogica.ListarDias(chart2, id_aula, this.Periodo.Texts);

                    break;
                case "Uso por materia":
                    label2.Text = "Uso por materia";
                    ReporteLogica.ListarMaterias(chart2, id_aula, this.Periodo.Texts);

                    break;
                case "Horario de mayor uso":
                    label2.Text = "Horario de mayor uso";
                    ReporteLogica.ListarHoras(chart2, id_aula,this.Periodo.Texts);

                    break;
                default:
                    label2.Text = "Frecuencia por profesor";
                    ReporteLogica.ListarProfesores(chart2, id_aula, this.Periodo.Texts);
                    break;
            }
        }
    }
    public class Lista
    {
        public int Id { get; set; }
        public string elegida { get; set; }


    }
    public class HorarioList
    {
            public string campo { set; get; }
            public string aula { set; get; }
            public int cantcampo { set; get; }
    }
}
