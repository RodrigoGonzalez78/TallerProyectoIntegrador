using DraggingControl;
using Microsoft.VisualBasic;
using ProyectoIntegradorTaller.logica;
using ProyectoIntegradorTaller.views.components;
//using ProyectoIntegradorTaller.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradorTaller.views.admin
{
    public partial class BedelMenu : FormPersonalisado
    {
        public BedelMenu()
        {

            InitializeComponent();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si el clic ocurrió en la columna "Informe"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Reserva")
                {
                    this.Hide();
                    VerReservas reservas = new VerReservas((int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                   
                    reservas.Show();

                }
            }
        }



        private void BedelMenu_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = LogicaClase.ListarAula();
            dataGridView1.Columns[0].Visible= false;

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.Name = "Reserva"; // Name the column
            buttonColumn2.Text = "Ver Reservas";    // Text for buttons in the column
            buttonColumn2.UseColumnTextForButtonValue = true; 
 
            dataGridView1.Columns.Add(buttonColumn2);

        }
       

        

        private void BMaterias_Click(object sender, EventArgs e)
        {
            this.Close();
            Materias materias = new Materias();
            materias.Show();
        }

        private void BProfesores_Click(object sender, EventArgs e)
        {
            this.Close();
            Profesores profesores=new Profesores();
            profesores.Show();
        }

        private void botonPersonalisado1_Click(object sender, EventArgs e)
        {
            this.Close();
            Datos datos = new Datos();
            datos.Show();
        }

        private void BPendientes_Click(object sender, EventArgs e)
        {
            this.Close();
            ReservasPendientes reservasPendientes = new ReservasPendientes();
            reservasPendientes.Show();
        }

       
        private void TBBusqueda__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TBBusqueda.Texts))
            {
                dataGridView1.DataSource = LogicaClase.ListarAula();
            }
            else
            {
                if (this.CBFiltro.Texts == "Nombre")
                {
                    dataGridView1.DataSource = LogicaClase.BusquedaAulaPorNombre(this.TBBusqueda.Texts);

                }
                else if (this.CBFiltro.Texts == "Capacidad")
                {

                    dataGridView1.DataSource = LogicaClase.BusquedaAulaPorCapacidad(this.TBBusqueda.Texts);
                }
                else if (this.CBFiltro.Texts == "Lugar")
                {
                    dataGridView1.DataSource = LogicaClase.BusquedaAulaPorLugar(this.TBBusqueda.Texts);
                }
            }
        }
    }
   
}
